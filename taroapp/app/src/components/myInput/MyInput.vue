<template>
  <view class="form">
    <view>
      <span for="name" class="bio">{{ name }}</span
      ><br />
      <input type="text" id="name" class="name" required />
    </view>
  </view>
</template>

<script setup>
const props = defineProps(["name"]);
</script>

<style>
.form {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  margin-bottom: 20px;
}

.bio {
  color: rgba(52, 41, 41, 0.753);
  font-size: small;
  font-weight: 600;
  margin-bottom: 8px;
}

.name {
  border: none;
  outline: none;
  height: 65px;
  width: 400px;
  background-color: rgba(240, 240, 240, 0.8);
  border-radius: 10px;
  padding-left: 10px;
}
</style>
