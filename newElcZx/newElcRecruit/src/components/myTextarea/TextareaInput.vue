<template>
  <div class="myTextarea-container">
    <div class="myTextarea-header">
      <span>{{ headerName }}</span>
    </div>
    <textarea maxlength="1000" placeholder-style="font-size:small" class="myTextarea-textarea" :value="value"
      @input="handler" />
  </div>
</template>

<script setup>
const props = defineProps(["id", "headerName", "value"]);
const emit = defineEmits(["onChange"]);
const handler = (event) => {
  emit("onChange", { id: props.id, data: event.target.value });
};
</script>

<style scoped>
.myTextarea-container {
  height: 100%;
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
<<<<<<< HEAD
  height: 100%;
=======
  height: calc(100% - 20px);
>>>>>>> 114241a35732926f751ee5cc1fe99271ab9d10dc
  background-color: rgb(244, 244, 244);
  padding: 5px;
  box-sizing: border-box;
  resize: none;
  outline: 0;
  border: 0;
  resize: none;
  min-height: 100px;
}
</style>
