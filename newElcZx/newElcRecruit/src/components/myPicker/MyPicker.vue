<template>
  <div class="myPicker-container">
    <div class="myPicker-header">
      <span>{{ headerName }}</span>
    </div>
    <div class="myPicker-picker-container">
      <div class="myPicker-picker">
        <Select v-model="model" style="width:100%;">
          <Option v-for="item in arr" :value="item.id" :key="item.id">{{ item.name }}</Option>
        </Select>
      </div>
      <div class="myPicker-select-container">
        <span>{{ currentSelect }}</span>
      </div>
    </div>
  </div>
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
  width: 30%;
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
