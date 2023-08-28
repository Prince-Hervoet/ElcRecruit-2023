<template>
  <nut-button @click="switchTo">go</nut-button>
</template>

<script setup>
import Taro from "@tarojs/taro";
const switchTo = () => {
  Taro.navigateTo({
    url: "/pages/infoPage/infoPage",
  });
};
</script>

<style scoped></style>
