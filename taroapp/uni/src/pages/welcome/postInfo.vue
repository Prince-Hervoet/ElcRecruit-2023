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
          <MyInput header-name="您的姓名 *" @getValue="getStudentName"></MyInput>
        </view>
        <view>
          <MyInput header-name="您的学号 *" @getValue="getStuId"></MyInput>
        </view>
        <view>
          <MyInput header-name="所属学院 *" @getValue="getCollege"></MyInput>
        </view>
        <view>
          <MyInput header-name="专业班级 *" @getValue="getMajor"></MyInput>
        </view>
        <view>
          <MyInput header-name="电话号码 *" @getValue="getPhoneNum"></MyInput>
        </view>
        <view>
          <MyPicker head-name="第一志愿 *" :arr="depArr" @getValue="getFirstDepId"></MyPicker>
        </view>
        <view>
          <MyPicker head-name="第二志愿" :arr="depArr" @getValue="getSecondDepId"></MyPicker>
        </view>
        <view>
          <MyTextarea headerName="自我介绍 *" @getValue="getIntro"></MyTextarea>
        </view>
        <view>
          <MyInput header-name="QQ号码" @getValue="getQq"></MyInput>
        </view>
        <view>
          <MyInput header-name="掌握技能" @getValue="getSkills"></MyInput>
        </view>
        <view>
          <MySelect></MySelect>
        </view>
      </view>
    </view>
    <view style="color: red; text-align: center" :style="showErrorMessage ? '' : 'display:none;'">请完整填写表格</view>
    <button class="postInfo-button-container" @click="submitForm">
      <span style="font-size: 15px; font-weight: 700; line-height: 15px">提交</span>
    </button>
  </view>
</template>

<script setup>
import { ref } from "vue";
import MyInput from "../../components/myInput/MyInput.vue";
import MyTextarea from "../../components/myTextarea/MyTextarea.vue";
import MyPicker from "../../components/myPicker/MyPicker.vue";

let showErrorMessage = ref(false);

let college = "";
let studentName = "";
let major = "";
let stuId = "";
let phoneNum = "";
let qq = "";
let intro = "";
let skills = "";
let firstDepId = "";
let secondDepId = "";

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

function checkCommonTextSize(value) {
  return value.length === 100;
}

const submitForm = () => {
  if (!hasNullFields(college, studentName, stuId, major, phoneNum, intro)
    && (checkStuId(stuId))
    && (checkPhoneNumSize(phoneNum))
  ) {
    showErrorMessage.value = false;
    // todo: 发送请求
  } else {
    showErrorMessage.value = true;
  }
};

const getCollege = (value) => {
  college = value;
};

const getStudentName = (value) => {
  studentName = value;
};

const getMajor = (value) => {
  major = value;
};

const getStuId = (value) => {
  stuId = value;
};

const getPhoneNum = (value) => {
  phoneNum = value;
};

const getQq = (value) => {
  qq = value;
};

const getIntro = (value) => {
  intro = value;
};

const getSkills = (value) => {
  skills = value;
};

const getFirstDepId = (value) => {
  firstDepId = value;
}

const getSecondDepId = (value) => {
  secondDepId = value;
}
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

.hideErrMsg {
  display: none;
}
</style>
