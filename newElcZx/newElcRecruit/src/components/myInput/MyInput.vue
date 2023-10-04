<template>
  <div class="myInput-container">
    <div class="myInput-header">
      <span>{{ headerName }}</span>
    </div>
    <div class="myInput-input-container">
      <input id="myInput-input" class="myInput-input" :value="value" @input="handler" />
    </div>
  </div>
</template>

<script setup>
const props = defineProps(["headerName", "value"]);
const emit = defineEmits(["onChange"]);

const handler = (event) => {
  emit("onChange", event.target.value);
};
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
  /* box-shadow: 1px 1px 1px 1px #e2e2e2; */
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
</style>
