<template>
  <view class="postInfo-header"></view>
  <view class="postInfo-table-container"
    ><view class="postInfo-table"> <MyInput name="姓名"></MyInput></view
  ></view>
</template>

<script setup>
import MyInput from "../../components/myInput/MyInput.vue";
</script>

<style scoped>
.postInfo-table-container {
  width: 80%;
  margin: auto;
}
.postInfo-table {
  display: flex;
  flex-direction: column;
}
</style>
