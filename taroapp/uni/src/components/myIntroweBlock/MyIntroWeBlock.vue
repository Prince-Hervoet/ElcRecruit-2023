<template>
  <view>
    <view class="myIntroWeBlock-container">
      <view class="myIntroWeBlock-image-container">
        <image
          src="https://s1.ax1x.com/2023/08/30/pPdXern.jpg"
          style="width: 100%; height: 100%; border-radius: 50%"
        ></image>
      </view>
      <view class="myIntroWeBlock-text-container">asdfasdfasdfasdfasdfdsf</view>
    </view>

    <view class="myIntroWeBlock-container">
      <view class="myIntroWeBlock-image-container">
        <image
          src="https://s1.ax1x.com/2023/08/30/pPdXlPU.jpg"
          style="width: 100%; height: 100%; border-radius: 50%"
        ></image>
      </view>
      <view></view>
    </view>

    <view class="myIntroWeBlock-container">
      <view class="myIntroWeBlock-image-container">
        <image
          src="https://s1.ax1x.com/2023/08/30/pPdXUVx.jpg"
          style="width: 100%; height: 100%; border-radius: 50%"
        ></image>
      </view>
      <view></view>
    </view>
  </view>
</template>

<script setup></script>

<style scoped>
.myIntroWeBlock-container {
  border-radius: 6px;
  height: 120px;
  display: flex;
  margin-bottom: 10px;
  box-shadow: 0.2em 0.1em 1em rgba(210, 210, 210, 0.2);
}

.myIntroWeBlock-image-container {
  width: 120px;
  height: 100%;
  box-sizing: border-box;
  padding: 5px;
  /* background-color: red; */
}

.myIntroWeBlock-text-container {
  box-sizing: border-box;
  padding: 10px;
}
</style>
