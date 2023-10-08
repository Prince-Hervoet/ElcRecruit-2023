<template>
    <div class="progress-body">
        <div class="progress-title-body"><span style="font-style: italic;">Progress</span> </div>
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

        <button @click="queryStep">点我查询进度</button>
    </div>
</template>

<script setup>
import { ref, onMounted, reactive, } from 'vue';
import { IdToDepName } from "../global.js"
import { ServiceUrls } from "../requests/util.js"
import axios from 'axios';

const titles = {
    partZero: "报名阶段",
    partOne: "一面阶段",
    partTwo: "笔试阶段",
    partThree: "二面阶段",
    partFour: "招新结束",
};

const userStatusList = [
    "报名中", "一面中", "笔试中", "二面中", "已录用", "已淘汰"
];

const current = ref(0);
const userStatusStr = ref("无");
const firstDepName = ref("");
const secondDepName = ref("");

const getProcess = async () => {
    const url = ServiceUrls.getProcess;
    try {
        const res = await axios({
            method: "GET",
            url,
        });
        if (res.data) {
            const processData = res.data.data[0];
            const { processState, state } = processData;
            current.value = processState;
            if (state === 60) {
                userStatusStr.value = userStatusList[5];
            } else {
                userStatusStr.value = userStatusList[processState];
            }
        }
    } catch (e) {
        alert("请检查登录状态和网络情况");
    }
}

const getUserInfo = async () => {
    const url = ServiceUrls.getInfo;
    try {
        const res = await axios({
            method: "GET",
            url,
        });
        if (res.data) {
            const userInfo = res.data.data;
            console.log(userInfo);
            const { firstDepartment, secondDepartment } = userInfo;
            firstDepName.value = IdToDepName[firstDepartment];
            secondDepName.value = IdToDepName[secondDepartment];
        }
    } catch (e) {
        alert("请检查登录状态和网络情况");
    }
}

onMounted(() => {
    getProcess();
    getUserInfo();
})


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
    box-shadow: 1px 1px 3px 1px #e6e6e6;
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

@media screen and (min-width:800px) {
    .progress-content-group-body {
        max-width: 650px;
    }
}

.progress-content-body>div {
    width: 80%;
}
</style>