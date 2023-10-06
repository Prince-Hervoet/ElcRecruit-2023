
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
                <MyInput header-name="手机号码"></MyInput>
            </div>
            <div>
                <MyInput header-name="验证码"></MyInput>
            </div>
        </div>
        <button class="vcode-button" @click="CheckLoginButton">发送验证码</button>
        <router-link to="/NewWelcome"><button class="login-button">登录</button></router-link>
        <div class="login-content-bottom-body">
            <div class="small-explain"> <router-link to="/knowElc">了解更多</router-link>
            </div>
            <div class="divider"></div>
            <div class="small-intro">ELC &2023 -- Software Team Presents</div>
        </div>

    </div>
</template>

<script setup>
import MyInput from '../components/myInput/Input.vue';
import axios from "axios";

let loginToken = "";
// const studentLogin = reactive({
//     phone: "",
//     check: "",
// });
const CheckLoginButton = () => {
    // axios({
    //     method: 'post',
    //     url: 'url',
    //     data: {
    //         phone: "string",
    //         check: "string",
    //     }
    // }).then;
    axios.post('/user', {
        phone: "string",
        check: "string",
    })
        .then(function (response) {
            console.log(response);
            loginToken = response.data.accessToken;
        })
        .catch(function (error) {
            console.log(error);
        });
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
    outline: 0;
    border: 0;
    transition: all 0.2s;
    cursor: pointer;
}

.vcode-button {
    background-color: rgb(54, 62, 209);
    border-radius: 6px;
    width: 100%;
    height: 40px;
    font-weight: bold;
    color: white;
    display: flex;
    align-items: center;
    justify-content: center;
    margin-top: 1.5em;
    outline: 0;
    border: 0;
    transition: all 0.2s;
    cursor: pointer;
}

.login-button:active {
    background-color: rgb(227, 227, 227);
}

.vcode-button:active {
    background-color: rgb(227, 227, 227);
}

.login-content-bottom-body {
    position: fixed;
    bottom: 0;
    left: 0;
    right: 0;
    margin: auto;
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
</style>