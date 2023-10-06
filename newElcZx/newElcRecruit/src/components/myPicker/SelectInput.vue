<template>
    <div class="myPicker-container">
        <div class="myPicker-header">
            <span>{{ headerName }}</span>
        </div>
        <div class="myPicker-picker-container">
            <Select style="width:100%;" @on-change="onSelect" :model-value="props.value">
                <Option v-for="item in arr" :value="item.id" :key="item.id">{{ item.name }}</Option>
            </Select>
        </div>
    </div>
</template>
  
<script setup>
const props = defineProps(["id", "headerName", "arr", "value"])
const emit = defineEmits(["onChange"]);

const onSelect = (data) => {
    emit("onChange", { id: props.id, data });
};


</script>
  
<style scoped>
.myPicker-container {}

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
    height: 100%;
    font-size: 17px;
    border-radius: 6px;
    display: flex;
    line-height: 17px;
    align-items: center;
    box-sizing: border-box;
}
</style>
  