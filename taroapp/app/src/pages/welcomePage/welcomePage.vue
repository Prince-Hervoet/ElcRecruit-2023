<template>
  <nut-button @click="switchTo">go</nut-button>
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
</script>

<style scoped></style>
