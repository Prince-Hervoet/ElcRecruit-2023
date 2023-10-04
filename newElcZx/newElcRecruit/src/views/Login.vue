
<template>
    <div class="login-body">
        <div class="perch">elc的logo</div>
        <div class="login-topic">
            <h1>ELC Recruit</h1>
        </div>

        <div class="login-content-body">
            <div>
                <MyInput header-name="手机号码"></MyInput>
            </div>
            <div>
                <MyInput header-name="验证码"></MyInput>
            </div>
        </div>
        <button class="login-button">登录</button>

        <div class="small-explain">了解更多</div>
        <!-- <div class="divider"></div>
        <div class="small-intro">ELC & 2023</div> -->
    </div>
</template>

<script setup>
import MyInput from '../components/myInput/MyInput.vue';
</script>

<style scoped>
.login-body {
    width: 75%;
    height: 100%;
    margin: auto;
}

.perch {
    height: 100px;

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
    color: white;
    display: flex;
    align-items: center;
    justify-content: center;
    margin-top: 1.5em;
    margin-bottom: 10%;
    outline: 0;
    border: 0;
    transition: all 0.2s;
}

.login-button:active {
    background-color: rgb(227, 227, 227);
}

.small-explain {
    font-family: "楷体";
    width: 100%;
    margin-top: 50px;
    text-align: center;

}

.divider {
    background: #3838375b;
    width: 100%;
    height: 1px;
    position: absolute;
    bottom: 90px;
}

.small-intro {
    width: 100%;
    font-family: "楷体";
    text-align: center;
    position: absolute;
    bottom: 50px;

}

/* .login-contain-box {
    height: 100vh;
    background-position: center;
    background-size: cover;
    background-image: url("../assets/bg1.jpg");
}

#login-box {
    width: 60%;
    height: 300px;
    position: relative;
    top: 30%;
    margin: auto;
    border-radius: 1em;
    text-align: center;
    background: #0000000e;
    padding: 20px 50px;

}

h1 {
    text-align: center;
    position: relative;
    top: 25%;
    color: #030202;
    font-size: 50px;
    font-family: "楷体";
}

.input-head {
    margin-top: 20px;
    font-size: 20px;
    color: rgb(15, 14, 14);
    margin-bottom: 5px;
    font-family: "楷体";
}



input {
    width: 180px;
    font-size: 18px;
    border: 0;
    border-bottom: 2px solid #050505;
    padding: 5px 10px;
    background: #ffffff00;
    color: #0c0c0c;
    outline: none;
}



.form {
    width: 40%;
    margin: auto;
}


#login-box button {
    margin-top: 20px;
    width: 190px;
    height: 30px;
    font-size: 20px;
    font-weight: 700;
    color: #fff;
    background-color: rgb(209, 54, 57);
    border: 0;
    border-radius: 15px;
} */
</style>