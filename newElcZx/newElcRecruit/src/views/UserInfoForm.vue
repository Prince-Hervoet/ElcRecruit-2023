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
                    <MyPicker id="secondDepartment" header-name="第二志愿 *(不可与第一部门重合)" :value="studentInfo.secondDepartment"
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
        <div class="small-explain1" v-if="successCommit">报名成功</div>
    </div>
</template>

<script setup>
import { onMounted, reactive, ref } from "vue";
import MyInput from "../components/myInput/Input.vue";
import MyPicker from "../components/myPicker/SelectInput.vue";
import MyTextarea from "../components/myTextarea/TextareaInput.vue";
import { CollegeList, DepInfoList } from "../global.js"
import axios from "axios";
import { ServiceUrls } from "../requests/util.js";
import router from '../router';
let token = localStorage.getItem("token")
let successCommit = ref(false)
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

const checkLogin = async () => {
    const checkUrl = ServiceUrls.getCheck
    axios.get(checkUrl, {
    })
        .then((res) => {
            console.log(res);
            // localStorage.removeItem("token")
        })
        .catch(function (error) {
            console.log(error);
            if (error) {
                alert("请重新登录")
                router.push({ path: "/login" });
            }
        });
}

function checkSame(dep1, dep2) {
    if (dep1 === dep2) {
        alert("第一志愿部门和第二志愿部门不能相同哦");
        return false;
    } else return true
}
let setUserInfo = (data) => {
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

function closeSubmit() {
    const closeUrl = ServiceUrls.getCurrent;
    axios.get(closeUrl, {
        data: "",
    })
        .then((res) => {
            console.log(res);
            const closeData = res.data.data;
            console.log(closeData);
            localStorage.setItem("closeData", closeData)
        })
        .catch(function (error) {
            console.log(error);
        });
}

const clickSubmitForm = async () => {
    const url = ServiceUrls.getCommit;
    const closeData = localStorage.getItem("closeData")

    if (closeData === "0") {
        if (
            !hasNullContent(
                studentInfo.name,
                studentInfo.grade,
                studentInfo.college,
                studentInfo.firstDepartment,
                studentInfo.introduction,
                studentInfo.qq,
                studentInfo.secondDepartment,
                studentInfo.skills
            ) &&
            checkStuId(studentInfo.studentNumber) &&
            checkphoneSize(studentInfo.phone) &&
            checkSame(studentInfo.firstDepartment, studentInfo.secondDepartment,)
        ) {
            axios.post(url, {
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
                        authorization: token,
                    }
                }
            )
                .then((res) => {
                    console.log(res);
                    successCommit.value = !successCommit.value;
                })
                .catch(function (error) {
                    console.log(error);
                    if (error.response.status === 401) {
                        alert("登录过期,请重新登录")
                    } else {
                        alert("请检查网络")
                    }
                });
        } else {
            alert("信息不完整或信息不准确，请再次确认表单内容是否完全填写，电话号和学号是否合法等")
        }; localStorage.removeItem("closeData")
    } else {
        alert("已过提交时间，禁止修改或提交");
        localStorage.removeItem("closeData")
    }

}

const getStudentData = async () => {
    const getInfo = ServiceUrls.getInfo
    axios.get(getInfo, {
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
            let head = res.data.data
            studentInfo.name = head.name;
            studentInfo.grade = head.grade,
                studentInfo.college = head.college,
                studentInfo.firstDepartment = head.firstDepartment,
                studentInfo.introduction = head.introduction,
                studentInfo.qq = head.qq,
                studentInfo.secondDepartment = head.secondDepartment,
                studentInfo.skills = head.skills
            studentInfo.studentNumber = head.studentNumber
            studentInfo.phone = head.phone
        })
        .catch(function (error) {
            console.log(error);
        });
}
onMounted(() => {
    getStudentData();
    checkLogin();
    closeSubmit()
});
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

.small-explain1 {
    font-family: "楷体";
    text-align: center;
    font-size: 1.3em;
    color: rgba(209 54 57);
}
</style>
