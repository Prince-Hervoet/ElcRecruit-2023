<template>
    <button @click="startCountdown" :disabled="isCounting">{{ countdown }}</button>
</template>
  
<script setup>
import { ref, reactive, onMounted } from "vue";

const countdown = ref(60);
const isCounting = ref(false);

// 倒计时逻辑
const startCountdown = () => {
    if (isCounting.value) return;

    isCounting.value = true;
    let timer = setInterval(() => {
        countdown.value--;
        if (countdown.value === 0) {
            clearInterval(timer);
            isCounting.value = false;
        }
    }, 1000);
};

onMounted(() => {
    // 在组件挂载后立即执行倒计时
    startCountdown();
});
</script>
  
  