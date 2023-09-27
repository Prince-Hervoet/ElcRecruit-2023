<template>
    <u-steps class="progressBigBox" direction="column">
        <u-steps-item :title="mainprogress.partOne" :desc="time.firstTime" current="0"></u-steps-item>
        <view class="progressSmallBox2">
            <u-steps-item :title="mainprogress.partTwo" :desc="time.secondTime" current="1"></u-steps-item>
        </view>
        <u-steps-item :title="mainprogress.partThree" :desc="time.thirdTime" current="2"></u-steps-item>
        <u-steps-item :title="mainprogress.partFour" :desc="time.forthTime" current="3"></u-steps-item>
    </u-steps>
    <button @click="goAhead">上面是没用的组件库，点击我查看进度
    </button>
    <view class="progressBigBox">
        <view class="progressSmallBox">
            <view class="progresssRound1" :class="changeColor">1</view>
            <view class="progressSmallPart1">{{ mainprogress.partOne }}</view>
        </view>
        <view class="divider"></view>
        <view class="progressSmallBox">
            <view class="progresssRound2">2</view>
            <view class="progressSmallPart2">{{ mainprogress.partTwo }}</view>
        </view>
        <view class="divider"></view>
        <view class="progressSmallBox">
            <view class="progresssRound3">3</view>
            <view class="progressSmallPart3">{{ mainprogress.partThree }}</view>
        </view>
        <view class="divider"></view>
        <view class="progressSmallBox">
            <view class="progresssRound4">4</view>
            <view class="progressSmallPart4">{{ mainprogress.partFour }}</view>
        </view>
    </view>
</template>

<script setup>
import { ref, onMounted, withCtx, reactive, } from 'vue';
let current = 0;
// let progresssRound1 = ref('qw');
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
                // const processState = res.data.data[res.data.data.length - 1].processState;
                //循环遍历process（流程），state(新生通过与否的值)
                for (let i = 0; i < res.data.data.length; i++) {
                    const e = res.data.data[i];
                    let process = e.processState;
                    let state = e.state;
                    console.log("process: " + process + ", state: " + state);
                }

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
    background-color: #ffffff;
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
    background-color: rgb(255, 255, 255);
    border: solid 1px gray;
    border-radius: 100em;
}

.progresssRound2 {
    width: 20px;
    height: 20px;
    margin-right: 5px;
    background-color: rgb(255, 255, 255);
    border: solid 1px gray;
    border-radius: 100em;
}

.progresssRound3 {
    width: 20px;
    height: 20px;
    margin-right: 5px;
    background-color: rgb(255, 255, 255);
    border: solid 1px gray;
    border-radius: 100em;
}

.progresssRound4 {
    width: 20px;
    height: 20px;
    margin-right: 5px;
    background-color: rgb(255, 255, 255);
    border: solid 1px gray;
    border-radius: 100em;
}

.divider {
    background: #3838375b;
    width: 5rpx;
    margin-left: 44%;
    height: 50px;
    margin-bottom: 2px;
}

.changeProgressRound1 {
    width: 20px;
    height: 20px;
    margin-right: 5px;
    background-color: rgb(8, 247, 40);
    border: solid 1px gray;
    border-radius: 100em;

}
</style>