<template>
  <view class="postInfo-container">
    <view class="postInfo-header-container">
      <view style="font-size: 28px; margin-bottom: 15px">报名申请</view>
      <view style="font-size: 15px">个人信息</view>
      <span style="font-size: 12px">Personal Information</span>
    </view>
    <view class="postInfo-table-container">
      <view class="postInfo-table">
        <view>
          <MyInput header-name="您的姓名 *" @getValue="setStudentName"></MyInput>
        </view>
        <view>
          <MyInput header-name="您的学号 *" @getValue="setStuId"></MyInput>
        </view>
        <view>
          <MyInput header-name="所属学院 *" @getValue="setCollege"></MyInput>
        </view>
        <view>
          <MyInput header-name="就读专业 *" @getValue="setMajor"></MyInput>
        </view>
        <view>
          <MyInput header-name="所在班级 *" @getValue="setClazz"></MyInput>
        </view>
        <view>
          <MyInput header-name="电话号码 *" @getValue="setPhoneNum"></MyInput>
        </view>
        <view>
          <MyPicker head-name="第一志愿 *" :arr="depArr" @getValue="setFirstDepId"></MyPicker>
        </view>
        <view>
          <MyPicker head-name="第二志愿" :arr="depArr" @getValue="setSecondDepId"></MyPicker>
        </view>
        <view>
          <MyTextarea headerName="自我介绍 *" @getValue="setIntro"></MyTextarea>
        </view>
        <view>
          <MyInput header-name="QQ号码" @getValue="setQq"></MyInput>
        </view>
        <view>
          <MyInput header-name="掌握技能" @getValue="setSkills"></MyInput>
        </view>
        <view>
          <MySelect></MySelect>
        </view>
      </view>
    </view>
    <button class="postInfo-button-container" @click="clickSubmitForm">
      <span style="font-size: 15px; font-weight: 700; line-height: 15px">提交</span>
    </button>
  </view>
</template>

<script setup>
import { onMounted } from "vue";
import { sendSubmitForm } from "../../requests/postInfo"
import MyInput from "../../components/myInput/MyInput.vue";
import MyTextarea from "../../components/myTextarea/MyTextarea.vue";
import MyPicker from "../../components/myPicker/MyPicker.vue";

let college = "";
let studentName = "";
let major = "";
let clazz = "";
let stuId = "";
let phoneNum = "";
let qq = "";
let intro = "";
let skills = "";
let firstDepId = "";
let secondDepId = "";

const writeErrorTipData = {
  title: '请正确填写信息',
  icon: 'error',
  duration: 1500,
  mask: true
};

const submitSuccessTipData = {
  title: '报名成功',
  icon: 'success',
  duration: 1500,
  mask: true
};


const submitErrorTipData = {
  title: '报名失败',
  icon: 'error',
  duration: 1500,
  mask: true
};

const submitLoadingTipData = {
  title: '报名中...',
  mask: true
};



const depArr = ["维修部", "秘书部", "项目部", "网宣部", "外联部", "实践部", "软件组"];

function hasNullFields(...fields) {
  for (let i = 0; i < fields.length; i++) {
    if (!fields[i]) return true;
  }
  return false;
}

function checkPhoneNumSize(value) {
  return value.length === 11;
}

function checkStuId(value) {
  return value.length === 10;
}


const clickSubmitForm = async () => {
  if (!hasNullFields(college, studentName, stuId, major, clazz, firstDepId, phoneNum, intro)
    && (checkStuId(stuId))
    && (checkPhoneNumSize(phoneNum))
  ) {
    const sendObj = {
      studentName, stuId, college, major, clazz, phoneNum, firstDepId, secondDepId, intro, qq, skills
    };

    // todo: 发送请求
    wx.showLoading(submitLoadingTipData);
    const res = await sendSubmitForm(sendObj);
    wx.hideLoading();
    if (res.code === 4000) {
      wx.showToast(submitSuccessTipData);
    } else {
      wx.showToast(submitErrorTipData);
    }
  } else {
    wx.showToast(writeErrorTipData);
  }
};

const setCollege = (value) => {
  college = value;
};

const setStudentName = (value) => {
  studentName = value;
};

const setMajor = (value) => {
  major = value;
};

const setClazz = (value) => {
  clazz = value;
}

const setStuId = (value) => {
  stuId = value;
};

const setPhoneNum = (value) => {
  phoneNum = value;
};

const setQq = (value) => {
  qq = value;
};

const setIntro = (value) => {
  intro = value;
};

const setSkills = (value) => {
  skills = value;
};

const setFirstDepId = (value) => {
  firstDepId = value;
}

const setSecondDepId = (value) => {
  secondDepId = value;
}

onMounted(() => {
  wx.login({
    success(res) {
      if (res.code) {
        //发起网络请求
        console.log(res);
      } else {
        console.log('登录失败！' + res.errMsg)
      }
    }
  })
})
</script>



<style scoped>
.postInfo-container {
  width: 75%;
  margin: auto;
  padding: 10px;
}

.postInfo-header-container {
  margin-bottom: 20px;
}

.postInfo-table-container {}

.postInfo-table {
  display: flex;
  flex-direction: column;
}

.postInfo-table>view {
  margin-bottom: 16px;
}

.postInfo-button-container {
  background-color: rgba(209 54 57);
  border-radius: 6px;
  height: 40px;
  color: white;
  display: flex;
  align-items: center;
  justify-content: center;
  margin-bottom: 10%;
}

.postInfo-button-container:active {
  background-color: rgb(227, 227, 227);
}

.hideErrMsg {
  display: none;
}
</style>
