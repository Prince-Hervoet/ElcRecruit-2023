<template>
  <view>
    <view class="myTextarea-header">
      <span>{{ headerName }}</span>
    </view>
    <textarea
      maxlength="1000"
      placeholder-style="font-size:small"
      class="myTextarea-textarea"
      v-model="inputValue"
      @input="setValue"
    />
  </view>
</template>

<script setup>
import { ref } from "vue";

const props = defineProps(["headerName"]);
const emit = defineEmits(["getValue"]);

let inputValue = ref("");
const setValue = () => {
  emit("getValue", inputValue.value);
};
</script>

<style scoped>
.myTextarea-container {
  background-color: red;
}

.myTextarea-header {
  height: 20px;
  padding: 2px;
  box-sizing: border-box;
  font-size: 14px;
  display: flex;
  align-items: center;
  color: rgb(146, 146, 146);
  margin-bottom: 5px;
}

.myTextarea-textarea {
  width: 100%;
  background-color: rgb(244, 244, 244);
  padding: 5px;
  box-sizing: border-box;
}
</style>
