<template>
  <div class="myInput-container">
    <div class="myInput-header">
      <span>{{ headerName }}</span>
    </div>
    <div class="myInput-input-container">
      <input id="myInput-input" class="myInput-input" :value="value" @input="handler" :type="inputType" />
      <div v-show="showType === 'password'" class="myInput-eye" @click="changeEye">
        <img v-show="!isOpenEye" src="../../assets/eyeclose.png">
        <img v-show="isOpenEye" src="../../assets/eyeopen.png">
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref } from "vue";
const props = defineProps(["id", "headerName", "value", "showType"]);
const emit = defineEmits(["onChange"]);

const isOpenEye = ref(false);
const inputType = ref(props.showType);

const handler = (event) => {
  emit("onChange", { id: props.id, data: event.target.value });
};

const changeEye = () => {
  if (props.showType === "password") {
    isOpenEye.value = !isOpenEye.value;
    inputType.value = (isOpenEye.value) ? "text" : "password";
  }
}
</script>

<style scoped>
.myInput-container {
  /* background-color: red; */
  height: 100%;
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
}

.myInput-input-container {
  height: calc(100% - 20px);
  position: relative;
}

.myInput-input {
  width: 100%;
  height: 100%;
  background-color: rgb(244, 244, 244);
  box-sizing: border-box;
  outline: 0;
  border: 1px solid rgb(227, 227, 227);
  border-radius: 6px;
  padding-left: 10px;
}

.myInput-input:active {
  border: 1px solid #dfdfdf;
  background-color: #eee;
}

.myInput-eye {
  position: absolute;
  right: 0;
  top: 0;
  width: 32px;
  height: 100%;
  box-sizing: border-box;
  padding: 3px;
  cursor: pointer;
}

.myInput-eye>img {
  width: 100%;
  height: 100%;
}
</style>
