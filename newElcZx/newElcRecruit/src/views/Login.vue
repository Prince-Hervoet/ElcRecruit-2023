<template>
    <div class="login-contain-box">
        <h1>Login</h1>
        <div id="login-box">
            <!-- 将两个盒子装入form -->
            <div class="form">
                <div class="input-head">
                    <span>用户名 :</span>
                </div>
                <input type="text" name="" id="">

                <div class="input-head">
                    <span>密码 :</span>
                </div>
                <input type="text" name="" id="">
                <!-- <div class="item">
                    <i class="fa fa-search" style="font-size:24px"></i>
                    密码：<input type="text" placeholder="Password">
                </div> -->
            </div>
            <button>登录</button><br>
        </div>
    </div>
</template>

<style scoped>
.login-contain-box {
    height: 100vh;
    background-position: center;
    background-size: cover;
    background-image: url("../assets/bg1.jpg");
}

#login-box {
    width: 280px;
    height: 300px;
    position: relative;
    top: 30%;
    margin: auto;
    border-radius: 1em;
    /* margin: 0 auto; */
    /* margin-top: 13%; */
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
    /* display: flex; */
    /* align-items: center; */
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

/* #login-box .form .item {
    margin-top: 10px;
    font-family: "楷体";
} */

.form {
    width: 40%;
}

/* #login-box .form .item i {
    font-size: 18px;
    color: #060606;
    font-family: "楷体";
} */

/* #login-box .form .item input {
    width: 180px;
    font-size: 18px;
    border: 0;
    border-bottom: 2px solid #050505;
    padding: 5px 10px;
    background: #ffffff00;
    color: #0c0c0c;
} */

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
}
</style>