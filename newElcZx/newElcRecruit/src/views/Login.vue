
<template>
    <div class="login-body">
        <div class="perch">
            <img src="../assets/elcLogo.png" />
        </div>
        <div class="login-topic">
            <h3 style="color: #bbb;font-style: italic;">Welcome to ELC</h3>
        </div>

        <div class="login-content-body">
            <div>
                <MyInput header-name="手机号码" id="phoneNumber" :value="loginContent.phoneNumber" @on-change="setLoginInfo">
                </MyInput>
            </div>
            <div>
                <MyInput header-name="密码" id="password" showType="password" :value="loginContent.password"
                    @on-change="setLoginInfo">
                </MyInput>
            </div>

            <button class="login-button" @click="getLogin">登录</button>
        </div>

        <div class="login-content-bottom-body">
            <div class="small">
                <router-link to="/Register">
                    <div class="small-explain"> <button class="toCode">我要注册</button></div>
                </router-link>
                <p style="font-size: larger;">|</p>
                <router-link to="/ForgetPassword">
                    <div class="small-explain"> <button @click="getCode" class="toCode">忘记密码</button></div>
                </router-link>
                <p style="font-size: larger;">|</p>
                <router-link to="/KnowElc">
                    <div class="small-explain"> <button class="toCode">了解我们</button></div>
                </router-link>
            </div>

            <div class="divider"></div>
            <div class="small-intro">ELC &2023 -- Software Team Presents</div>
        </div>

    </div>
</template>

<script setup>
import MyInput from '../components/myInput/Input.vue';
import axios from "axios";
import { ref, reactive } from "vue";
import router from '../router';
import { ServiceUrls } from "../requests/util.js";
let token = "";
const second = 60;
const alreadyLogin = ref(false);

const loginContent = reactive({
    phoneNumber: "",
    password: "",
    code: "",
});

const setLoginInfo = (data) => {
    if (data && data.id) {
        loginContent[data.id] = data.data;
    }
};

// const getLogin = () =>{

// }
function getLogin() {
    const url = ServiceUrls.getLogin;
    axios.post(url, {
        phoneNumber: loginContent.phoneNumber,
        password: loginContent.password
    })
        .then((res) => {
            console.log(res);
            let errorMsg = res.data.errorMessages
            if (errorMsg) {
                alert(errorMsg);
            } else {
                let token = res.data.access_token
                localStorage.setItem("token", `Bearer ${token}`)
                console.log(token);
                router.push({ path: 'Welcome' });
            }
        })
        .catch(function (error) {
            console.log(error);
        });

}

//检查手机号是否合适规范
function checkphoneNumberSize(value) {
    let phoneNumberReg = /^(13[0-9]|14[01456879]|15[0-35-9]|16[2567]|17[0-8]|18[0-9]|19[0-35-9])\d{8}$/;
    if (phoneNumberReg.test(value)) {
        return true;
    } else {
        return false;
    }
}
</script>

<style scoped>
.login-body {
    width: 75%;
    height: 100%;
    margin: auto;
    user-select: none;
    display: block;
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
    display: block;
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

.myInput-header {
    height: 20px;
    padding: 2px;
    box-sizing: border-box;
    font-size: 14px;
    display: flex;
    align-items: center;
    color: rgb(146, 146, 146);
    margin-bottom: 5px;
    margin-top: 20px;
}

.myInput-input-container {
    height: 40px;
}

.myInput-input {
    width: 100%;
    height: 30px;
    margin: auto;
    border-radius: 6px;
    background-color: rgb(244, 244, 244);
    box-sizing: border-box;
    padding-left: 10px;
    border: 0;
    outline: none;
}

.myInput-input:active {
    border: 1px solid #dfdfdf;
    background-color: #eee;
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
    margin-bottom: 50px;
    outline: 0;
    border: 0;
    transition: all 0.2s;
    cursor: pointer;
}

.login-button:active {
    background-color: rgb(227, 227, 227);
}


.login-content-bottom-body {
    /* position: fixed;
    bottom: 0;
    left: 0;
    right: 0;
    margin: auto;
    display: block; */
    margin-top: 50%;

}

.small-explain {
    font-family: "楷体";
    text-align: center;
    font-size: 1.3em;
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

.toCode {
    border: none;
    outline: none;
    background-color: #ffffff;
    cursor: pointer;
    color: rgb(45, 140, 240);
}

.toCode:hover {
    color: rgba(209 54 57);
}

.small {
    display: flex;
    justify-content: center;
}
</style>