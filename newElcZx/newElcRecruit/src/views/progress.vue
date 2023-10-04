<template>
    <div class="progress-body">
        <div class="progress-title-body"><span>查看进度</span> </div>
        <div class="progress-content-body">
            <div style="margin-bottom: 10px;">
                <Card>
                    <template #title>您的申请 -- 简要信息</template>
                    <p>当前所处状态: </p>
                    <p>第一志愿部门: </p>
                    <p>第二志愿部门: </p>
                </Card>
            </div>
            <div class="progress-main-body">
                <Steps :current="current" direction="vertical">
                    <Step :title="titles.partZero" content="请在报名界面填写个人信息进行报名"></Step>
                    <Step :title="titles.partOne" content="一面阶段中，请留意我们的通知"></Step>
                    <Step :title="titles.partTwo" content="笔试面阶段中，请留意我们的通知"></Step>
                    <Step :title="titles.partThree" content="二面阶段中，请留意我们的通知"></Step>
                    <Step :title="titles.partFour" content="最终结果出炉，请做好准备"></Step>
                </Steps>
            </div>
        </div>


    </div>
</template>

<script setup>
import { ref, onMounted, reactive, } from 'vue';
//正常通过面试进度条的名称
const titles = reactive({
    partZero: "报名阶段",
    partOne: "一面阶段",
    partTwo: "笔试阶段",
    partThree: "二面阶段",
    partFour: "招新结束",
})

const userStatusList = [
    "报名中", "一面中", "笔试中", "二面中", "已录用", "已淘汰"
];

const current = ref(0);
const userStatus = ref("无");

const getUserInfo = () => {

}

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
    background-color: rgb(209, 54, 57);
    color: white;
    font-size: 1.6em;
    font-family: "楷体";
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

.progress-main-body {
    background-color: rgba(255, 255, 255, 0.9);
}

.progress-content-body>div {
    width: 80%;
}
</style>