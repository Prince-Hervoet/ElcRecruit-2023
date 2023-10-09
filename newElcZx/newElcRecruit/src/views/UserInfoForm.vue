<template>
    <div class="postInfo-container">
        <div class="postInfo-header-container">
            <div style="font-size: 28px; margin-bottom: 15px">报名申请</div>
            <div style="font-size: 15px">个人信息 ( * 为必填项)</div>
            <span style="font-size: 12px">Personal Information</span>
        </div>
        <div class="postInfo-table-container">
            <div class="postInfo-table">
                <div class="space">
                    <MyInput id="name" header-name="您的姓名 *" :value="studentInfo.name" @onChange="setUserInfo"></MyInput>
                </div>
                <div class="space">
                    <MyInput id="studentNumber" header-name="您的学号 *" :value="studentInfo.studentNumber"
                        @onChange="setUserInfo">
                    </MyInput>
                </div>
                <div class="space">
                    <MyInput id="grade" header-name="专业班级 *" :value="studentInfo.grade" @onChange="setUserInfo">
                    </MyInput>
                </div>
                <div class="space">
                    <MyInput id="phone" header-name="电话号码 *" :value="studentInfo.phone" @onChange="setUserInfo"></MyInput>
                </div>
                <div class="space">
                    <MyInput id="qq" header-name="QQ 号码" :value="studentInfo.qq" @onChange="setUserInfo"></MyInput>
                </div>
                <div class="space">
                    <MyPicker id="college" header-name="所属学院 *" :value="studentInfo.college" :arr="CollegeList"
                        @onChange="setUserInfo">
                    </MyPicker>
                </div>
                <div class="space">
                    <MyPicker id="firstDepartment" header-name="第一志愿 *" :value="studentInfo.firstDepartment"
                        :arr="DepInfoList" @onChange="setUserInfo">
                    </MyPicker>
                </div>
                <div class="space">
                    <MyPicker id="secondDepartment" header-name="第二志愿" :value="studentInfo.secondDepartment"
                        :arr="DepInfoList" @onChange="setUserInfo">
                    </MyPicker>
                </div>
                <div class="myTextareaBox">
                    <MyTextarea id="introduction" header-name="自我介绍 *" :value="studentInfo.introduction"
                        @onChange="setUserInfo">
                    </MyTextarea>
                </div>
                <div class="myTextareaBox">
                    <MyTextarea id="skills" header-name="掌握技能(概述)" :value="studentInfo.skills" @onChange="setUserInfo">
                    </MyTextarea>
                </div>
            </div>
        </div>
        <button class="postInfo-button-container" @click="clickSubmitForm">
            <span style="font-size: 15px; font-weight: 700; line-height: 15px">提交</span>
        </button>
    </div>
    <div v-if="hasError" style="margin: auto;text-align: center; width: 70%; margin-bottom: 10%;">
        <Alert type="error">
            提交失败！请仔细核验信息！
        </Alert>
    </div>
</template>

<script setup>
import { onMounted, reactive, ref } from "vue";
import MyInput from "../components/myInput/Input.vue";
import MyPicker from "../components/myPicker/SelectInput.vue";
import MyTextarea from "../components/myTextarea/TextareaInput.vue";
import { CollegeList, DepInfoList } from "../global.js"
import axios from "axios";
import Login from "./Login.vue"

let token = ""
token = localStorage.getItem("token")
let hasError = ref(false);
const studentInfo = reactive({
    name: "",
    studentNumber: "",
    college: "",
    grade: "",
    phone: "",
    firstDepartment: "",
    secondDepartment: "",
    introduction: "",
    qq: "",
    skills: "",
});

const setUserInfo = (data) => {
    if (data && data.id) {
        studentInfo[data.id] = data.data;
    }
};

function hasNullContent(...fields) {
    for (let i = 0; i < fields.length; i++) {
        if (!fields[i]) return true;
    }
    return false;
}

function checkphoneSize(value) {
    return value.length === 11;
}

function checkStuId(value) {
    return value.length === 10;
}

const clickSubmitForm = async () => {
    if (true
        // !hasNullContent(
        //     studentInfo.name,
        //     studentInfo.grade,
        //     studentInfo.college,
        //     studentInfo.firstDepartment,
        //     studentInfo.introduction
        // ) &&
        // checkStuId(studentInfo.studentNumber) &&
        // checkphoneSize(studentInfo.phone)
    ) {
        console.log("成功");
        axios.post('http://139.159.220.241:8081/elc_recruit/student/commit', {
            id: '',
            name: studentInfo.name,
            studentNumber: studentInfo.studentNumber,
            college: studentInfo.college,
            grade: studentInfo.grade,
            phone: studentInfo.phone,
            firstDepartment: studentInfo.firstDepartment,
            secondDepartment: studentInfo.secondDepartment,
            introduction: studentInfo.introduction,
            qq: studentInfo.qq,
            skills: studentInfo.skills,
            state: 10,
        },
            {
                headers: {
                    accept: "text/plain",
                    "content-type": "application/json",
                    Authorization: token,
                }
            }
        )
            .then((res) => {
                console.log(res);

            })
            .catch(function (error) {
                console.log(error);
                console.log(token);
            });
    } else {
        console.log("出错啦");
        hasError.value = true;
        console.log(studentInfo.studentNumber);
    }
};
</script>

<style scoped>
.postInfo-container {
    width: 75%;
    margin: auto;
    padding: 10px;
}

.postInfo-container {
    width: 75%;
    margin: auto;
    padding: 10px;
    max-width: 650px;
}

.postInfo-header-container {
    margin-bottom: 20px;
}

.postInfo-table {
    display: flex;
    flex-direction: column;
}

.postInfo-table>.space {
    margin-bottom: 30px;
    height: 50px;
}

.postInfo-table>.myTextareaBox {
    margin-bottom: 10px;
}

.postInfo-button-container {
    background-color: rgba(209 54 57);
    border-radius: 6px;
    width: 100%;
    height: 40px;
    color: white;
    display: flex;
    align-items: center;
    justify-content: center;
    margin-top: 1.5em;
    margin-bottom: 1%;
    outline: 0;
    border: 0;
}

.postInfo-button-container:active {
    background-color: rgb(227, 227, 227);
}
</style>
