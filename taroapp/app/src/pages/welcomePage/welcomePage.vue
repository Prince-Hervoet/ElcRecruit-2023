<template>
  <nut-button @click="switchTo">go</nut-button>
  <button @click="form">aaa</button>
  <div>鼠鼠我呀 菜的不行啦</div>
</template>

<script setup>
import Taro from "@tarojs/taro";

definePageConfig({
  navigationBarTitleText: "欢迎",
});
const switchTo = () => {
  Taro.navigateTo({
    url: "/pages/infoPage/infoPage",
  });
};

const form = () => {};
</script>

<style scoped></style>
