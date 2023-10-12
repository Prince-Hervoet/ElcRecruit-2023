<template>
    <div class="progress-body">
        <div class="progress-title-body">
            <span style="font-style: italic">我的进度</span>
            <div class="progress-title-refresh" @click="clickReFresh"><Button><svg t="1696940923711" class="icon"
                        viewBox="0 0 1024 1024" version="1.1" xmlns="http://www.w3.org/2000/svg" p-id="1658" width="30"
                        height="30">
                        <path
                            d="M506.966868 131.167389c-228.252541 0-413.287791 185.03525-413.28779 413.28779s185.03525 413.287791 413.28779 413.287791 413.287791-185.03525 413.287791-413.287791c0-228.253564-185.03525-413.287791-413.287791-413.28779z m218.625277 321.171813c0 11.763928-9.56075 21.333888-21.324678 21.333888h-88.446402c-11.763928 0-21.324678-9.56996-21.324678-21.333888s9.56075-21.324678 21.324678-21.324678h33.71794c-33.070186-45.74281-86.234013-73.003687-142.571113-73.003687-97.03501 0-175.974897 78.939887-175.974897 175.974897 0 97.025801 78.939887 175.965687 175.974897 175.965687s175.974897-78.939887 175.974897-175.965687c0-11.763928 9.56075-21.333888 21.324678-21.333888s21.324678 9.56996 21.324678 21.333888c0 120.55468-98.069573 218.624253-218.624253 218.624252s-218.632439-98.069573-218.632439-218.624252 98.078783-218.632439 218.632439-218.63244c69.270666 0 134.827755 33.277918 175.974897 89.183182v-33.834596c0-11.763928 9.56075-21.333888 21.324678-21.333887s21.324678 9.56996 21.324678 21.333887v81.637322z"
                            fill="#44CFC5" p-id="1659"></path>
                    </svg></Button></div>
        </div>
        <div class="progress-content-body">
            <div class="progress-content-group-body">
                <div class="progress-content-card-body">
                    <Card :shadow="false" :padding="20">
                        <template #title>申请(第一志愿会根据情况进行内部调整)</template>
                        <p>当前所处状态: {{ userStatusStr }}</p>
                        <p>&nbsp;</p>
                        <p>第一志愿部门: {{ firstDepName }}</p>
                        <p>&nbsp;</p>
                        <p>第二志愿部门: {{ secondDepName }}</p>
                    </Card>
                </div>
                <div class="progress-main-body">
                    <Steps :current="current" direction="vertical">
                        <Step :title="titles.partZero" content="请在报名界面填写个人信息进行报名"></Step>
                        <Step :title="titles.partOne" content="一面阶段中，请留意我们的通知"></Step>
                        <Step :title="titles.partTwo" content="笔试阶段中，请留意我们的通知"></Step>
                        <Step :title="titles.partThree" content="二面阶段中，请留意我们的通知"></Step>
                        <Step :title="titles.partFour" content="最终结果出炉，请做好准备"></Step>
                    </Steps>
                </div>
            </div>
        </div>
    </div>
</template>

<script setup>
import { ref, onMounted } from "vue";
import { IdToDepName } from "../global.js";
import { ServiceUrls } from "../requests/util.js";
import axios from "axios";
import router from '../router';

const titles = {
    partZero: "报名阶段",
    partOne: "一面阶段",
    partTwo: "笔试阶段",
    partThree: "二面阶段",
    partFour: "招新结束",
};

const userStatusList = ["报名中", "一面中", "笔试中", "二面中", "已录用"];

const current = ref(0);
const userStatusStr = ref("无");
const firstDepName = ref("");
const secondDepName = ref("");

const getProcessInfo = async () => {
    try {
        let res = await axios({
            method: "GET",
            url: ServiceUrls.getProcess,
        });
        let responseData = res.data;
        if (!responseData.success) {
            alert(`处理失败: ${responseData.errorMessages[0]}`);
            return;
        }
        const processData = responseData.data;
        console.log(processData);
        res = await axios({
            method: "GET",
            url: ServiceUrls.getInfo,
        });
        responseData = res.data;
        if (!responseData.success) {
            alert(`处理失败: ${responseData.errorMessages[0]}`);
            return;
        }
        const userInfoData = responseData.data;

        const { processState, state } = processData[0];
        if (state === 60) {
            userStatusStr.value = "已淘汰";
        } else {
            userStatusStr.value = userStatusList[processState];
            current.value = processState;
        }
        firstDepName.value = IdToDepName[userInfoData.firstDepartment];
        secondDepName.value = IdToDepName[userInfoData.secondDepartment];
    } catch (error) {
        console.log(`请求失败: ${error}`);
        if (error.response.status === 500) {
            alert("请先提交报名表再进行查看，正在为您跳转......");
            router.push({ path: "/Welcome" });
        } else {
            console.log("你没登录")
        }
        // alert("请先前往提交报名表，或检查登录是否过期以重新登录");
    }
};


const clickReFresh = () => {
    getProcessInfo();
}

onMounted(() => {
    getProcessInfo();
});
</script>

<style scoped>
.progress-body {
    width: 100%;
    height: 100%;
    background-image: url("/src/assets/progressBackground.png");
    background-size: cover;
    background-repeat: no-repeat;
}

.progress-title-body {
    width: 100%;
    height: 40px;
    color: black;
    font-size: 1.8em;
    font-weight: bold;
    font-family: "楷体";
    display: flex;
    align-items: center;
    justify-content: center;
    position: relative;
    box-shadow: 1px 1px 3px 1px #e6e6e6;
}

.progress-title-refresh {
    position: absolute;
    right: 0;
    display: flex;
    align-items: center;
    justify-content: center;

}

.progress-content-body {
    width: 100%;
    height: calc(100% - 40px);
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
}

.progress-content-card-body {
    margin-bottom: 10px;
    box-shadow: 1px 1px 3px 1px #e6e6e6;
    font-weight: bold;
}

.progress-main-body {
    border-radius: 8px;
    border: 1px solid #eee;
    padding: 10px;
    box-shadow: 1px 1px 3px 1px #e6e6e6;
    background-color: rgba(255, 255, 255, 0.9);
}

.progress-content-group-body {}

@media screen and (min-width: 800px) {
    .progress-content-group-body {
        max-width: 650px;
    }
}

.progress-content-body>div {
    width: 80%;
}
</style>
