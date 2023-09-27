<template>
    <u-steps class="progressBigBox" direction="column">
        <u-steps-item :title="mainprogress.partOne" :desc="time.firstTime" current="0"></u-steps-item>
        <view class="progressSmallBox2">
            <u-steps-item :title="mainprogress.partTwo" :desc="time.secondTime" current="1"></u-steps-item>
        </view>
        <u-steps-item :title="mainprogress.partThree" :desc="time.thirdTime" current="2"></u-steps-item>
        <u-steps-item :title="mainprogress.partFour" :desc="time.forthTime" current="3"></u-steps-item>
    </u-steps>
    <button @click="goAhead">点击我查看进度
    </button>
    <view class="progressBigBox">
        <view class="progressSmallBox">
            <view class="progresssRound1"></view>
            <view class="progressSmallPart1">{{ mainprogress.partOne }}</view>
        </view>
        <view class="divider"></view>
        <view class="progressSmallBox">
            <view class="progresssRound2"></view>
            <view class="progressSmallPart2">{{ mainprogress.partTwo }}</view>
        </view>
        <view class="divider"></view>
        <view class="progressSmallBox">
            <view class="progresssRound3"></view>
            <view class="progressSmallPart3">{{ mainprogress.partThree }}</view>
        </view>
        <view class="divider"></view>
        <view class="progressSmallBox">
            <view class="progresssRound4"></view>
            <view class="progressSmallPart4">{{ mainprogress.partFour }}</view>
        </view>
    </view>
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
    mainprogress.partOne = "qweqwe";
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

<style>
.progressBigBox {
    width: 80%;
    margin: auto;
    text-align: center;
    background-color: rgb(195, 235, 235);
}

.progressSmallBox {
    display: flex;
    justify-content: center;
    margin-bottom: 2px;
}

.progresssRound1 {
    width: 20px;
    height: 20px;
    margin-right: 5px;
    background-color: brown;
    background-image: url("C:\Users\yinyan\Desktop\ToElcRecruit-2023\ElcRecruit-2023\taroapp\uni\dist\dev\mp-weixin\static\partone.png");
    background-repeat: no-repeat;
    background-position: center;
    border-radius: 100em;
}

.progresssRound2 {
    width: 20px;
    height: 20px;
    margin-right: 5px;
    background-color: brown;
    background-image: url("C:\Users\yinyan\Desktop\ToElcRecruit-2023\ElcRecruit-2023\taroapp\uni\dist\dev\mp-weixin\static\parttwo.png");
    background-repeat: no-repeat;
    background-position: center;
    border-radius: 100em;
}

.progresssRound3 {
    width: 20px;
    height: 20px;
    margin-right: 5px;
    background-color: brown;
    background-image: url("C:\Users\yinyan\Desktop\ToElcRecruit-2023\ElcRecruit-2023\taroapp\uni\dist\dev\mp-weixin\static\partthree.png");
    background-repeat: no-repeat;
    background-position: center;
    border-radius: 100em;
}

.progresssRound4 {
    width: 20px;
    height: 20px;
    margin-right: 5px;
    background-color: brown;
    background-image: url("C:\Users\yinyan\Desktop\ToElcRecruit-2023\ElcRecruit-2023\taroapp\uni\dist\dev\mp-weixin\static\partfour.png");
    background-repeat: no-repeat;
    background-position: center;
    border-radius: 100em;
}

.divider {
    background: #3838375b;
    width: 5rpx;
    margin-left: 44%;
    height: 50px;
    margin-bottom: 2px;
}
</style>