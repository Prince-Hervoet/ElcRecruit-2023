<template>
  <view class="postInfo-container">
    <view class="postInfo-header-container">
      <view style="font-size: 28px; margin-bottom: 15px">报名申请</view>
      <view style="font-size: 15px">个人信息</view>
      <span style="font-size: 12px">Personal Information</span>
    </view>
    <view class="postInfo-table-container">
      <view class="postInfo-table">
        <view
          ><MyInput header-name="学院 *" @getValue="getCollege"></MyInput
        ></view>
        <view
          ><MyInput header-name="专业班级 *" @getValue="getMajor"></MyInput
        ></view>
        <view
          ><MyInput header-name="姓名 *" @getValue="getStudentName"></MyInput
        ></view>
        <view
          ><MyInput header-name="学号 *" @getValue="getStuId"></MyInput
        ></view>
        <view
          ><MyInput header-name="电话号码 *" @getValue="getPhoneNum"></MyInput
        ></view>
        <view><MyInput header-name="qq号码" @getValue="getQq"></MyInput></view>
        <view
          ><MyInput header-name="自我介绍 *" @getValue="getIntro"></MyInput
        ></view>
        <view
          ><MyInput header-name="学的知识" @getValue="getSkills"></MyInput
        ></view>
        <view
          ><MyInput header-name="第一志愿 *" @getValue="getSkills"></MyInput
        ></view>
        <view
          ><MyInput header-name="第二志愿" @getValue="getSkills"></MyInput
        ></view>
        <view><MySelect></MySelect></view>
      </view>
    </view>
    <view
      style="color: red; text-align: center"
      :style="showErrorMessage ? '' : 'display:none;'"
      >请完整填写表格</view
    >
    <button class="postInfo-button-container" @click="submitForm">
      <span style="font-size: 15px; font-weight: 700; line-height: 15px"
        >提交</span
      >
    </button>
  </view>
</template>

<script setup>
import { ref } from "vue";
import MyInput from "../../components/myInput/MyInput.vue";

let showErrorMessage = ref(false);

let college = "";
let studentName = "";
let major = "";
let stuId = "";
let phoneNum = "";
let qq = "";
let intro = "";
let skills = "";

function hasNullFields(...fields) {
  for (let i = 0; i < fields.length; i++) {
    if (!fields[i]) return false;
  }
  return true;
}

const submitForm = () => {
  if (
    !hasNullFields(
      college,
      studentName,
      stuId,
      major,
      phoneNum,
      qq,
      intro,
      skills
    )
  ) {
    showErrorMessage.value = true;
  } else {
    showErrorMessage.value = false;
    console.log(studentName);
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

.postInfo-table-container {
}
.postInfo-table {
  display: flex;
  flex-direction: column;
}

.postInfo-table > view {
  margin-bottom: 16px;
}

.postInfo-button-container {
  background-color: rgb(21, 21, 255);
  border-radius: 6px;
  height: 40px;
  color: white;
  display: flex;
  align-items: center;
  justify-content: center;
}

.hideErrMsg {
  display: none;
}
</style>
