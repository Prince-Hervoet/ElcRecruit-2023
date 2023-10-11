<template>
    <div class="login-body">
        <div class="perch">
            <img src="../assets/elcLogo.png" />
        </div>
        <div class="login-topic">
            <h3 style="color: #bbb;font-style: italic;">Welcome to ELC</h3>
        </div>

        <div class="login-content-body">
            <div class="pho">
                <MyInput header-name="手机号码" id="phoneNumber" :value="loginContent.phoneNumber" @on-change="setLoginInfo">
                </MyInput>
                <i class="icon1" v-if="showPassword" @click="eyeopen">&nbsp&nbsp&nbsp&nbsp&nbsp</i>
                <i class="icon2" v-if="showPassword" @click="eyeopen">&nbsp&nbsp&nbsp&nbsp&nbsp</i>
            </div>

            <div>
                <MyInput header-name="密码" id="password" showType="password" :value="loginContent.password"
                    @on-change="setLoginInfo">
                </MyInput>

            </div>
            <div>
                <MyInput header-name="验证码" id="code" :value="loginContent.code" @on-change="setLoginInfo"></MyInput>
            </div>
        </div>
        <div class="login-getCode-container">
            <button class="vcode-button" v-if="!timing" @click="getCode">{{ code }}</button>
            <div class="time" v-if="timing">
                <div class="small-explain">
                    验证码发送成功
                </div>
                <div style="text-align: center;">
                    <Row style="color: rgb(45, 140, 240); margin: auto;">
                        <Col span="12">
                        <CountDown :target="new Date().getTime() + 60000" @on-end="handleEnd" v-font="20" />
                        </Col>
                        <span style="font-family: '楷体'; font-size: larger; color: rgb(45, 140, 240);">之后可再次发送</span>
                    </Row>
                </div>

            </div>
        </div>
        <button class="login-button" @click="getRegister">注册</button>
        <div class="small-explain1" v-if="successRegister">注册成功，请点击下方蓝字前往登录</div>
        <div class="login-content-bottom-body">
            <div class="small-explain"> <router-link to="/Login">我已经注册 , 前往登录</router-link> </div>

            <div class="divider"></div>
            <div class="small-intro">ELC &2023 -- Software Team Presents</div>
        </div>
    </div>
</template>

<script setup>

import MyInput from '../components/myInput/Input.vue';
import axios from "axios";
import { ref, reactive } from "vue";
import { ServiceUrls } from "../requests/util.js";
let passwordVisiable = ref(false)
let token = "";
const second = 60;
const requestCode = ref(true);
const timing = ref(false);
const successRegister = ref(false)
let code = "发送验证码"

const loginContent = reactive({
    phoneNumber: "",
    password: "",
    code: "",
    type: "password"
});

const eye = () => {
    passwordVisiable.value = !passwordVisiable
}

function handleEnd() {
    console.log("重新发送验证码");
    timing.value = !timing.value;
    code = "重新发送验证码"
}

const setLoginInfo = (data) => {
    if (data && data.id) {
        loginContent[data.id] = data.data;
    }
};

//检查手机号是否合适规范
function checkphoneNumberSize(value) {
    let phoneNumberReg = /^(13[0-9]|14[01456879]|15[0-35-9]|16[2567]|17[0-8]|18[0-9]|19[0-35-9])\d{8}$/;
    if (phoneNumberReg.test(value)) {
        return true;
    } else {
        return false;
    }
}

//检查密码是否符合规范
function checkpassword(value) {
    let passwordReg = /(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[\W_]).{6,}/
    if (passwordReg.test(value)) {
        return true;
    } else {
        return false;
    }
}

const getCode = () => {
    const codeUrl = ServiceUrls.getCode;
    if (checkphoneNumberSize(loginContent.phoneNumber)) {
        console.log("正确");
        requestCode.value = !requestCode.value;
        timing.value = !timing.value;
        //todo发送验证码审核
        axios.get(codeUrl + `phoneNumber=${loginContent.phoneNumber}`)
            .then((res) => {
                console.log(res);
                if (res.status === 200) {
                    console.log("验证码发送成功");
                } else {
                    handleEnd
                }
            })
            .catch(function (error) {
                console.log(error);
                // console.log(loginContent.phoneNumber);
            });
    } else {
        alert("请输入符合规范的手机号")
    }
}

const getRegister = () => {
    const registerUrl = ServiceUrls.getRegister;
    //手机号验证码密码符合要求

    //电话错误
    if (!checkphoneNumberSize(loginContent.phoneNumber)) {
        alert("电话号码不合规");

        //密码错误
    } else if (!checkpassword(loginContent.password)) {
        alert("您的密码复杂度太低（密码中必须包含大小写字母、数字、特殊字符）");
    } else {
        axios.get(registerUrl + `phoneNumber=${loginContent.phoneNumber}&code=${loginContent.code}&password=${loginContent.password}`,
            { headers: { Authorization: ` ${token}` } },)
            .then((res) => {
                console.log(res);
                let token = res.data.accessToken
                localStorage.setItem("token", `Bearer ${token}`)
                if (res.data.errorMessages) {
                    alert(res.data.errorMessages)
                } else {
                    successRegister.value = !successRegister.value;
                }
            })
            .catch(function (error) {
                console.log(error);
            });

    }
}
</script>


<style scoped>
.login-body {
    width: 75%;
    height: 100%;
    margin: auto;
    user-select: none;
}

.perch {
    height: 130px;
}

.perch>img {
    width: 100%;
    height: 100%;
}

@media screen and (min-width: 800px) {
    .login-body {
        width: 75%;
        height: 100%;
        margin: auto;
        max-width: 500px;
    }

    .perch {
        height: 180px;
    }
}


.login-topic {
    color: rgb(70, 69, 69);
    font-family: "楷体";
    position: relative;
    bottom: 20px;
}

.login-content-body {
    display: flex;
    flex-direction: column;
    width: 100%;
}

.login-content-body>div {
    height: 55px;
    margin-bottom: 20px;
}

.login-button {
    background-color: rgba(209 54 57);
    border-radius: 6px;
    width: 100%;
    height: 40px;
    font-weight: bold;
    color: white;
    display: flex;
    align-items: center;
    justify-content: center;
    margin-top: 30px;
    outline: 0;
    border: 0;
    transition: all 0.2s;
    cursor: pointer;
}

.vcode-button {
    display: block;
    margin-bottom: 10px;
    background-color: rgb(255, 255, 255);
    width: 200px;
    outline: 0;
    border: 0;
    transition: all 0.2s;
    cursor: pointer;
    font-family: "楷体";
    text-align: center;
    font-size: 1.3em;
    color: rgb(45, 140, 240);
    margin: auto;
}

.vcode-button:hover {
    color: rgba(209 54 57);
}

.login-button:active {
    background-color: rgb(227, 227, 227);
}

.vcode-button:active {
    background-color: rgb(227, 227, 227);
}

.login-content-bottom-body {
    margin-top: 50%;
}

.small-explain {
    font-family: "楷体";
    text-align: center;
    font-size: 1.3em;
    color: rgb(45, 140, 240);
}

.small-explain1 {
    font-family: "楷体";
    text-align: center;
    font-size: 1.3em;
    color: rgba(209 54 57);
}

.divider {
    background: #3838375b;
    height: 1px;
    margin-top: 10px;
}

.small-intro {
    font-family: "楷体";
    text-align: center;
}

.login-getCode-container {
    display: flex;
    justify-content: center;
    align-items: center;
}

.time {
    width: 50%;
}

.icon1 {
    background-image: url("../assets/eyeopen.png");
    display: inline-block;
    background-size: cover;
    background-repeat: no-repeat;
    position: relative;
    top: 50px;
    left: 450px;
    z-index: 2;
}

.icon2 {
    background-image: url("../assets/eyeclose.png");
    display: inline-block;
    background-size: cover;
    background-repeat: no-repeat;
    position: relative;
    top: 50px;
    left: 450px;
    z-index: 2;
}
</style>