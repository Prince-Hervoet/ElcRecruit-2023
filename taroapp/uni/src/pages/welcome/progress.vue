<template>
    <u-steps class="progressBigBox" direction="column">
        <u-steps-item :title="mainprogress.partOne" :desc="time.firstTime" current="0">safad
        </u-steps-item>
        <u-steps-item :title="mainprogress.partTwo" :desc="time.secondTime" current="1"></u-steps-item>
        <u-steps-item :title="mainprogress.partThree" :desc="time.thirdTime" current="2"></u-steps-item>
        <u-steps-item :title="mainprogress.partFour" :desc="time.forthTime" current="3"></u-steps-item>
    </u-steps>
    <button @click="goAhead">点击我查看进度
    </button>
</template>

<script setup>
import { ref, onMounted, withCtx, reactive, } from 'vue';
let current = 0;
//获取登录信息
let loginToken = "";
wx.login({
    success(res) {
        if (res.code) {
            //发起网络请求
            wx.request({
                url: "http://139.159.220.241:8081/elc_recruit/interviewer/WeChatLogin",
                data: {
                    js_code: res.code,
                },
                method: "POST",
                header: {
                    "content-type": "application/json", // 默认值
                },
                success(res) {
                    console.log(res);
                    loginToken = res.data.accessToken;
                },
            });
            //一次性code发送
            // console.log('code:'+ res.code);
        } else {
            console.log("登录失败！" + res.errMsg);
        }
    },
});

//正常通过面试进度条的名称
let mainprogress = reactive({
    partOne: "一面",
    partTwo: "笔试",
    partThree: "二面",
    partFour: "通过",
})

let time = reactive({
    firstTime: "10:00",
    secondTime: "10:30",
    thirdTime: "10:40",
    forthTime: "11:00",
});


const goAhead = () => {
    //点击按钮请求查询后台面试进度
    wx.request({
        url: "http://139.159.220.241:8081/elc_recruit/student/get_process",
        method: "GET",
        header: {
            "content-type": "application/json", // 默认值
            "Authorization": "Bearer " + loginToken
        },
        success(res) {
            console.log(res);
            //如果请求通过了，推进下一步
            if (res.data.success) {
                const processState = res.data.data[res.data.data.length - 1].processState;
                console.log(processState);
                current = processState;
            }
        },
    });
}

</script>

<style lang="scss">
.progressBigBox {
    width: 80%;

}
</style>