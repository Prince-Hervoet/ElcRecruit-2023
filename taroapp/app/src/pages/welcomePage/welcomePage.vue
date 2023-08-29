<template>
  <view class="input-container-body">
    <!-- <view class="input-container">
      <MyInput name="姓名"></MyInput>
      <MyInput name="电话"></MyInput>
      <MyInput name="学号"></MyInput>
    </view> -->
  </view>
</template>

<script setup>
import Taro from "@tarojs/taro";
import MyInput from "../../components/myInput/MyInput.vue";

definePageConfig({
  navigationBarTitleText: "欢迎",
});
const switchTo = () => {
  Taro.navigateTo({
    url: "/pages/infoPage/infoPage",
  });
};
</script>

<style scoped>
.input-container-body {
  border: 1px solid red;
}

.input-container {
  width: 80%;
  display: flex;
}
</style>
