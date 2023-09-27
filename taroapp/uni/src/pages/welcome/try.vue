<template>
    <view :class="{ active: isActive }">aa</view>
    <button @click="goAhead">点击我查看进度
    </button>
</template>

<style>
.css1 {
    background-color: blue;
}

.css2 {
    background-color: rgb(13, 190, 42);
}
</style>

<script setup>
import { ref } from 'vue';
let isActive = ref(false);
const goAhead = () => {
    isActive.value = true;
}

</script>

