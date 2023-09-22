<template>
  <view class="myPicker-container">
    <view class="myPicker-header">
      <span>{{ headerName }}</span>
    </view>
    <view class="myPicker-picker-container">
      <view class="myPicker-picker">
        <picker :range="arr" style="font-size: large;" @change="handler" :value="value">
          <img src="/static/select.png" style="width: 28px; height: 28px" />
        </picker>
      </view>
      <view class="myPicker-select-container">
        <span>{{ currentSelect }}</span>
      </view>
    </view>
  </view>
</template>

<script setup>
import { ref, onUpdated } from "vue";
const props = defineProps(["headerName", "arr", "value"])
const emit = defineEmits(["onChange"]);
const currentSelect = ref(props.value ? props.arr[parseInt(props.value)] : "");

const handler = (event) => {
  const index = parseInt(event.detail.value);
  currentSelect.value = props.arr[index];
  emit("onChange", event.detail.value);
};

onUpdated(() => {
  currentSelect.value = props.value ? props.arr[parseInt(props.value)] : "";
})

</script>

<style scoped>
/* .myPicker-container {} */

.myPicker-header {
  padding: 2px;
  box-sizing: border-box;
  font-size: 14px;
  display: flex;
  align-items: center;
  color: rgb(146, 146, 146);
  margin-bottom: 5px;
}

.myPicker-picker-container {
  height: 40px;
  background-color: rgb(244, 244, 244);
  color: rgb(146, 146, 146);
  font-size: 17px;
  border-radius: 6px;
  display: flex;
  line-height: 17px;
  align-items: center;
  box-sizing: border-box;
}

.myPicker-picker {
  width: 15%;
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
}

.myPicker-select-container {
  flex: 1;
  color: black;
  display: flex;
  justify-content: center;
  align-items: center;
}
</style>
