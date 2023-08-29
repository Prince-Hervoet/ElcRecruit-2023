<template>
  <view class="myInput-container">
    <view class="myInput-header">
      <span>{{ name }}</span>
    </view>
    <view class="myInput-input-container">
      <input class="myInput-input" />
    </view>
  </view>
</template>

<script setup>
const props = defineProps(["name"]);
</script>

<style scoped>
.myInput-container {
  /* background-color: red; */
}

.myInput-header {
  height: 20px;
  padding: 2px;
  box-sizing: border-box;
  font-size: 14px;
  display: flex;
  align-items: center;
  color: rgb(146, 146, 146);
  margin-bottom: 5px;
  /* background-color: black; */
}

.myInput-input-container {
  height: 40px;
}

.myInput-input {
  width: 100%;
  height: 100%;
  border-radius: 6px;
  background-color: rgb(244, 244, 244);
  box-sizing: border-box;
  padding-left: 10px;
}

.myInput-input:active {
  border: 1px solid #dfdfdf;
  background-color: #eee;
}
</style>
