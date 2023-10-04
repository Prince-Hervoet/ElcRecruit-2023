<template>
    <div class="postInfo-container">
        <div class="postInfo-header-container">
            <div style="font-size: 28px; margin-bottom: 15px">报名申请</div>
            <div style="font-size: 15px">个人信息</div>
            <span style="font-size: 12px">Personal Information</span>
        </div>
        <div class="postInfo-table-container">
            <div class="postInfo-table">
                <div>
                    <MyInput header-name="您的姓名 *" :value="studentInfo.name" @onChange="setname"></MyInput>
                </div>
                <div>
                    <MyInput header-name="您的学号 *" :value="studentInfo.studentNumber" @onChange="setStuId"></MyInput>
                </div>

                <div>
                    <MyInput header-name="就读专业和班级 *" :value="studentInfo.grade" @onChange="setgrade"></MyInput>
                </div>
                <div>
                    <MyInput header-name="电话号码 *" :value="studentInfo.phone" @onChange="setphone"></MyInput>
                </div>
                <div>
                    <MyInput header-name="QQ 号码" :value="studentInfo.qq" @onChange="setQq"></MyInput>
                </div>
                <div>
                    <MyPicker header-name="所属学院 *" :value="studentInfo.college" :arr="depA" @onChange="setCollege">
                    </MyPicker>
                </div>
                <div>
                    <MyPicker header-name="第一志愿 *" :value="studentInfo.firstDepartment" :arr="depInfoArr"
                        @onChange="setfirstDepartment">
                    </MyPicker>
                </div>
                <div>
                    <MyPicker header-name="第二志愿" :value="studentInfo.secondDepartment" :arr="depInfoArr"
                        @onChange="setsecondDepartment">
                    </MyPicker>
                </div>
                <div>
                    <MyTextarea header-name="自我介绍 *" :value="studentInfo.introductionn" @onChange="setintroductionn">
                    </MyTextarea>
                </div>
                <div>
                    <MyTextarea header-name="掌握技能" :value="studentInfo.skills" @onChange="setSkills"></MyTextarea>
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
import MyInput from "../components/myInput/MyInput.vue";
import MyTextarea from "../components/myTextarea/MyTextarea.vue";
import MyPicker from "../components/myPicker/MyPicker.vue";
let loginToken = "";

const studentInfo = reactive({
    name: "",
    studentNumber: "",
    college: "",
    grade: "",
    phone: "",
    firstDepartment: "",
    secondDepartment: "",
    introductionn: "",
    qq: "",
    skills: "",
});
const depArr = [
    "维修部",
    "秘书部",
    "项目部",
    "网宣部",
    "外联部",
    "实践部",
    "软件组",
];

const depInfoArr = [
    { id: 1, name: "维修部" },
    { id: 2, name: "秘书部" },
    { id: 3, name: "项目部" },
    { id: 4, name: "网宣部" },
    { id: 5, name: "外联部" },
    { id: 5, name: "实践部" },
    { id: 5, name: "软件组" },
];

const depA = [
    "机电工程学院",
    "自动化学院",
    "轻工化工学院",
    "信息工程学院",
    "计算机学院",
    "土木与交通工程学院",
    "材料与能源学院",
    "环境科学与工程学院",
    "物理与光电工程学院",
    "集成电路学院",
    "生物医药学院",
    "外国语学院",
];

// const writeErrorTipData = {
//   title: "请正确填写信息",
//   icon: "error",
//   duration: 1500,
//   mask: true,
// };

// const submitSuccessTipData = {
//   title: "报名成功",
//   icon: "success",
//   duration: 1500,
//   mask: true,
// };

// const submitErrorTipData = {
//   title: "报名失败",
//   icon: "error",
//   duration: 1500,
//   mask: true,
// };

// const submitLoadingTipData = {
//   title: "报名中...",
//   mask: true,
// };

// const clickSubmitForm = async () => {
//     const {
//         name,
//         studentNumber,
//         college,
//         grade,
//         phone,
//         firstDepartment,
//         secondDepartment,
//         introductionn,
//         qq,
//         skills,
//     } = studentInfo;
//     if (
//         !hasNullFields(
//             college,
//             name,
//             studentNumber,
//             grade,
//             firstDepartment,
//             phone,
//             introductionn
//         ) &&
//         checkStuId(studentNumber) &&
//         checkphoneSize(phone)
//     ) {
//         const sendObj = {
//             name,
//             studentNumber,
//             college,
//             grade,
//             phone,
//             firstDepartment,
//             secondDepartment,
//             introductionn,
//             qq,
//             skills,
//         };
//         // todo: 发送请求
//         wx.showLoading(submitLoadingTipData);
//         const res = await sendSubmitForm(sendObj);
//         wx.hideLoading();
//         if (res.code === 4000) {
//             //发送报名成功
//             // wx.request({
//             //   url: "http://139.159.220.241:8081/elc_recruit/student/commit",
//             //   data: {
//             //     "id": "string",
//             //     "studentNumber": "string",
//             //     "name": "string",
//             //     "college": 0,
//             //     "grade": "string",
//             //     "skills": "string",
//             //     "introduction": "string",
//             //     "phone": "string",
//             //     "qq": "string",
//             //     "weChat": "string",
//             //     "firstDepartment": 0,
//             //     "secondDepartment": 0,
//             //     "state": 10
//             //   },
//             //   method: "POST",
//             //   header: {
//             //     "content-type": "application/json", // 默认值
//             //     "Authorization": "Bearer " + loginToken
//             //   },
//             //   success(res) {
//             //     console.log(res);
//             //   },
//             // });

//             wx.showToast(submitSuccessTipData);
//         } else {
//             wx.showToast(submitErrorTipData);
//         }
//     } else {
//         wx.showToast(writeErrorTipData);
//     }
// };

const setCollege = (value) => {
    studentInfo.college = value;
};

const setname = (value) => {
    studentInfo.name = value;
};

const setgrade = (value) => {
    studentInfo.grade = value;
};

const setStuId = (value) => {
    studentInfo.studentNumber = value;
};

const setphone = (value) => {
    studentInfo.phone = value;
};

const setQq = (value) => {
    studentInfo.qq = value;
};

const setintroductionn = (value) => {
    studentInfo.introductionn = value;
};

const setSkills = (value) => {
    studentInfo.skills = value;
};

const setfirstDepartment = (value) => {
    studentInfo.firstDepartment = value;
};

const setsecondDepartment = (value) => {
    studentInfo.secondDepartment = value;
};

function hasNullFields(...fields) {
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

function getOpenId() { }
</script>

<style scoped>
.postInfo-container {
    width: 75%;
    margin: auto;
    padding: 10px;
}

@media screen and (min-width: 800px) {
    .postInfo-container {
        width: 75%;
        margin: auto;
        padding: 10px;
        max-width: 650px;
    }
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
    height: 50px;
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

.hideErrMsg {
    display: none;
}
</style>
