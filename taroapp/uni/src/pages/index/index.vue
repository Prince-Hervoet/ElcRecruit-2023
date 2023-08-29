<template>
  <view class="postInfo-container">
    <view class="postInfo-header-container">
      <view style="font-size: 28px; margin-bottom: 15px">报名申请</view>
      <view style="font-size: 15px">个人信息</view>
      <span style="font-size: 12px">Personal Information</span>
    </view>
    <view class="postInfo-table-container">
      <view class="postInfo-table">
        <view><MyInput name="姓名"></MyInput></view>
        <view><MyInput name="学号"></MyInput></view>
        <view><MyInput name="电话号码"></MyInput></view>
        <view><MyInput name="qq号码"></MyInput></view>
        <view><MyInput name="专业"></MyInput></view>
        <view><MyInput name="班级"></MyInput></view>
        <view><MyInput name="学院"></MyInput></view>
        <view><MySelect></MySelect></view>
      </view>
    </view>
    <view class="postInfo-button-container" @click="clickCommit()">
      <span style="font-size: 15px; font-weight: 700; line-height: 15px"
        >提交</span
      >
    </view>
  </view>
</template>

<script setup>
import MyInput from "../../components/myInput/MyInput.vue";
import MySelect from "../../components/mySelect/MySelect.vue";

const clickCommit = () => {
  console.log("adfasdhfjksafhkh1");
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

.postInfo-button-container:active {
  background-color: rgb(220, 220, 220);
}
</style>
