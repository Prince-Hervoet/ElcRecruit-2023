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
            </div>

            <div>
                <MyInput header-name="密码" id="password" :value="loginContent.password" @on-change="setLoginInfo">
                </MyInput>
            </div>
            <div>
                <MyInput header-name="验证码" id="code" v-if="alreadyLogin" :value="loginContent.code"
                    @on-change="setLoginInfo"></MyInput>
            </div>
            <button class="vcode-button" v-if="alreadyLogin" @click="getCode">获取验证码</button>
        </div>
        <!-- <button class="vcode-button" v-if="alreadyLogin" @click="getCode">获取验证码</button> -->
        <button class="login-button" @click="getRegister">注册</button>

        <div class="login-content-bottom-body">
            <div class="small-explain"> <router-link to="/Login">我已经注册 , 前往登录</router-link> </div>
            <!-- <div class="small-explain"> <router-link to="/knowElc">了解更多</router-link>

            </div> -->
            <div class="divider"></div>
            <div class="small-intro">ELC &2023 -- Software Team Presents</div>
        </div>

    </div>
</template>

<script setup>
import MyInput from '../components/myInput/Input.vue';
import axios from "axios";
import { ref, reactive } from "vue";
let token = "";
const second = 60;
const alreadyLogin = ref(true);

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

//检查手机号是否合适规范
function checkphoneNumberSize(value) {
    let phoneNumberReg = /^[1][3458][0-9]{9}$/;
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
    if (checkphoneNumberSize(loginContent.phoneNumber)) {
        console.log("正确");
        //todo发送验证码审核
        axios.get(`http://139.159.220.241:8081/elc_recruit/student/send_verification_code?phoneNumber=${loginContent.phoneNumber}`)
            .then(function (response) {
                console.log(response);
            })
            .catch(function (error) {
                console.log(error);
                // console.log(loginContent.phoneNumber);
            });
    } else {
        console.log("错");
    }
}

const getRegister = () => {
    //手机号验证码密码符合要求

    //电话错误
    if (!checkphoneNumberSize(loginContent.phoneNumber)) {
        console.log("电话号码不合规");

        //密码错误
    } else if (!checkpassword(loginContent.password)) {
        console.log("您的密码复杂度太低（密码中必须包含大小写字母、数字、特殊字符），请及时修改密码！");
    } else {
        axios.get(`http://139.159.220.241:8081/elc_recruit/interviewer/register_student?phoneNumber=${loginContent.phoneNumber}&code=${loginContent.code}&password=${loginContent.password}`,
            { headers: { Authorization: ` ${token}` } },)
            .then((res) => {
                console.log(res);
                console.log(token);
            })
            .catch(function (error) {
                console.log(error);
                // console.log(loginContent.phoneNumber);
            });

    }
}

//获取短信验证码
// async getCode() {
//     console.log(loginContent.phoneNumber);
//     let res = await http.$axios({
//         url: "/api/code",
//         method: "POST",
//         data: {
//             phoneNumber: this.phoneNumber,
//         },
//     });
// }

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

/* .login-content-body>.pho {
    margin-bottom: 100px;
} */

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
    display: block;
    margin-bottom: 10px;
    background-color: rgb(255, 255, 255);
    width: 100px;
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