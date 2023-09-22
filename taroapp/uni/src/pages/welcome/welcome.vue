<template>
  <view class="welcome-container">
    <view class="welcome-button-container">
      <view style="margin-right: 20px;">
        <button class="welcome-button-knowus" @click="clickGotoknow">
          <img src="/static/knowUs.png" style="width: 20px;height:20px;margin-right:5px">
          <span style="font-size: medium; font-weight: 700">了解我们</span>
        </button>
      </view>
      <view>
        <button class="welcome-button-recruit" @click="clickGotoRecruit">
          <img src="/static/recruit.png" style="width: 22px;height:22px;margin-right:5px">
          <span style="font-size: medium; font-weight: 700">报名入口</span>
        </button>
      </view>
    </view>
  </view>
</template>

<script setup>
const clickGotoRecruit = () => {
  uni.navigateTo({
    url: "postInfo",
    // url: "progress",
  });
};
const clickGotoknow = () => {
  uni.navigateTo({
    url: "knowMore",
  });
};
</script>

<style scoped>
.welcome-button-recruit {
  width: 120px;
  height: 100px;
  background-color: rgba(209 54 57);
  display: flex;
  align-items: center;
  justify-content: center;
  border-radius: 12px;
  color: #ffffff;
  transition: 0.1s all;
  box-shadow: 1px 2px 10px rgba(209, 54, 57, 0.574);
}

.welcome-button-recruit:active {
  transform: scale(1.2, 1.2);
}

.welcome-button-knowus {
  width: 120px;
  height: 100px;
  background-color: rgba(221, 220, 220, 0.87);
  display: flex;
  align-items: center;
  justify-content: center;
  border-radius: 12px;
  color: #000000;
  box-shadow: 1px 2px 10px rgba(221, 220, 220, 0.586);
}

.welcome-button-knowus:active {
  transform: scale(1.2, 1.2);
}

.welcome-button-container {
  width: 100%;
  display: flex;
  align-items: center;
  justify-content: center;
  position: fixed;
  bottom: 150px;
}


.welcome-container {
  height: 100vh;
  background-size: cover;
  background-image: url("https://pic.imgdb.cn/item/64f44559661c6c8e540ac00f.png")
}
</style>
