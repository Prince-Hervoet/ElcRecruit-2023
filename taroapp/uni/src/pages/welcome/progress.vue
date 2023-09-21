<template>
    <view class="progress-bar">
        <view class="progress-bar-inner" :style="{ width: progress + '%' }">
            <view class="progress-bar-button" @click="changeProgress">下一步</view>
        </view>
    </view>
</template>
  
<script setup>
import { ref } from 'vue'
const progress = ref(0)
const total = ref(4)
const step = ref(1)
const buttonText = ref('下一步')

const changeProgress = () => {
    if (step.value < total.value) {
        step.value++
    } else {
        step.value = 1
        buttonText.value = '笔试'
    }
}

</script>
  
<style scoped>
.progress-bar {
    width: 100%;
    height: 20px;
    background-color: #ddd;
}

.progress-bar-inner {
    height: 100%;
    background-color: #4caf50;
    /* Green */
    border-radius: 10px;
}

.progress-bar-button {
    height: 100%;
    background-color: #ff9900;
    /* Orange */
    border-radius: 10px;
    color: #fff;
    font-size: 16px;
    font-weight: bold;
}
</style>
  