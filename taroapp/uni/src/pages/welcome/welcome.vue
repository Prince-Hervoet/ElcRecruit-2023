<template>
  <view class="welcome-container">
    <view class="welcome-recruit-button-container"
      ><button class="welcome-button" @click="clickGotoRecruit">
        <span style="font-size: medium; font-weight: 700">报名入口</span>
      </button></view
    >

    <view class="welcome-introwe-button-container"
      ><button class="welcome-button">
        <span style="font-size: medium; font-weight: 700">了解我们</span>
      </button></view
    >
  </view>
</template>

<script setup>
const clickGotoRecruit = () => {
  uni.navigateTo({
    url: "postInfo",
  });
};
</script>

<style scoped>
.welcome-button {
  width: 240px;
  height: 40px;
  background-color: rgba(252, 252, 252, 0.9);
  display: flex;
  align-items: center;
  justify-content: center;
  border-radius: 6px;
}

.welcome-recruit-button-container {
  position: fixed;
  bottom: 100px;
  left: 50%;
  transform: translate(-50%, -50%);
}

.welcome-introwe-button-container {
  position: fixed;
  bottom: 150px;
  left: 50%;
  transform: translate(-50%, -50%);
}

.welcome-container {
  height: 100vh;
  background-size: 100% 100%;
}
</style>
