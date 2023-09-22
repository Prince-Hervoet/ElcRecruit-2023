<template>
    <u-steps current="0">
        <u-steps-item title="一面" desc="time1">
        </u-steps-item>
        <u-steps-item ref="push" title="笔试" desc="time2"></u-steps-item>
        <u-steps-item title="二面" desc="time3"></u-steps-item>
        <u-steps-item title="通过" desc="time4"></u-steps-item>
    </u-steps>
    <button @click="goAhead">zc</button>
</template>

<script setup>
import { ref, onMounted } from 'vue'

const push = ref(true)
onMounted(() => {
    // if () {
    //     push.value.textContent = 'mounted!'
    // }
})
wx.request({
    url: "http://192.168.123.184:8081/elc_recruit/student/",
    data: {

    },
    method: "POST",
    header: {
        "content-type": "application/json", // 默认值
        "Authorization": "Bearer " + loginToken
    },
    success(res) {
        console.log(res);
    },
});


</script>