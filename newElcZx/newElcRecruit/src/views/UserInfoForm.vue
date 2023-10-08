<template>
    <div class="postInfo-container">
        <div class="postInfo-header-container">
            <div style="font-size: 28px; margin-bottom: 15px">报名申请</div>
            <div style="font-size: 15px">个人信息 ( * 为必填项)</div>
            <span style="font-size: 12px">Personal Information</span>
        </div>
        <div class="postInfo-table-container">
            <div class="postInfo-table">
                <div>
                    <MyInput id="name" header-name="您的姓名 *" :value="studentInfo.name" @onChange="setUserInfo"></MyInput>
                </div>
                <div>
                    <MyInput id="studentNumber" header-name="您的学号 *" :value="studentInfo.studentNumber"
                        @onChange="setUserInfo">
                    </MyInput>
                </div>
                <div>
                    <MyInput id="grade" header-name="专业班级 *" :value="studentInfo.grade" @onChange="setUserInfo">
                    </MyInput>
                </div>
                <div>
                    <MyInput id="phone" header-name="电话号码 *" :value="studentInfo.phone" @onChange="setUserInfo"></MyInput>
                </div>
                <div>
                    <MyInput id="qq" header-name="QQ 号码" :value="studentInfo.qq" @onChange="setUserInfo"></MyInput>
                </div>
                <div>
                    <MyPicker id="college" header-name="所属学院 *" :value="studentInfo.college" :arr="collegeList"
                        @onChange="setUserInfo">
                    </MyPicker>
                </div>
                <div>
                    <MyPicker id="firstDepartment" header-name="第一志愿 *" :value="studentInfo.firstDepartment"
                        :arr="depInfoList" @onChange="setUserInfo">
                    </MyPicker>
                </div>
                <div>
                    <MyPicker id="secondDepartment" header-name="第二志愿" :value="studentInfo.secondDepartment"
                        :arr="depInfoList" @onChange="setUserInfo">
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
</template>

<script setup>
import { onMounted, reactive } from "vue";
import MyInput from "../components/myInput/Input.vue";
import MyPicker from "../components/myPicker/SelectInput.vue";
import MyTextarea from "../components/myTextarea/TextareaInput.vue";
import axios from "axios";
import Register from "./Register.vue";
let token = localStorage.getItem("token");
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

const depInfoList = [
    { id: 1, name: "维修部" },
    { id: 2, name: "秘书部" },
    { id: 3, name: "项目部" },
    { id: 4, name: "网宣部" },
    { id: 5, name: "外联部" },
    { id: 6, name: "实践部" },
    { id: 7, name: "软件组" },
];

const collegeList = [
    { id: 0, name: "机电工程学院" },
    { id: 1, name: "自动化学院" },
    { id: 2, name: "轻工化工学院" },
    { id: 3, name: "信息工程学院" },
    { id: 6, name: "计算机学院" },
    { id: 4, name: "土木与交通工程学院" },
    { id: 7, name: "材料与能源学院" },
    { id: 11, name: "物理与光电工程学院" },
    { id: 8, name: "环境科学与工程学院" },
    { id: 21, name: "集成电路学院" },
    { id: 18, name: "生物医药学院" },
    { id: 9, name: "外国语学院" },
];

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
        axios.post('http://139.159.220.241:8081/elc_recruit/student/commit',
            {
                headers: {
                    "content-type": "application/json",
                    "Authorization": "Bearer" + token
                }
            },
            {
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
            })
            .then((res) => {
                console.log(res);
                console.log(res.headers);
            })
            .catch(function (error) {
                console.log(error);
                console.log(token);
            });
    } else {
        console.log("出错啦");
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

.postInfo-table>div {
    margin-bottom: 30px;
    height: 55px;
}

.postInfo-table>.myTextareaBox {
    margin-bottom: 100px;
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
    margin-bottom: 10%;
    outline: 0;
    border: 0;
}

.postInfo-button-container:active {
    background-color: rgb(227, 227, 227);
}
</style>
