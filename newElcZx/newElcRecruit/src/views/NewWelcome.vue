<template>
    <div class="welcomeBigBox">
        <router-link to="/UserInfoForm">
            <div class="joinIn">
                <div class="joinIcon"></div>
                <p class="word">我要报名</p>
                <p class="smallWord">我也要和师兄师姐们</p>
                <p class="smallWord">一起敲代码！焊板子！</p>
            </div>
        </router-link>
        <div class="bottomBox">

            <div class="bottomBoxSmall">
                <router-link to="/KnowElc">
                    <div>
                        <p class="word">了解更多</p>
                        <p class="smallWord">KnowMore</p>
                    </div>
                </router-link>
            </div>
            <div class="bottomBoxSmall">
                <router-link to="/Stepper">
                    <div>
                        <p class="word">查询进度</p>
                        <p class="smallWord">Progress</p>
                    </div>
                </router-link>

            </div>


        </div>
    </div>
</template>

<style scoped>
.welcomeBigBox {
    height: 100vh;
    background-image: url("../assets/bg.jpg");
    background-size: cover;
}

.joinIn {
    width: 40%;
    height: 150px;
    margin: auto;
    position: relative;
    top: 20%;
    background-color: rgba(239, 239, 240, 0.617);
    border-radius: 3em;
    border: 1px solid #ccc;
}

.joinIcon {
    width: 50px;
    height: 50px;
    margin: auto;
    background-image: url("../assets/join.png");
    background-position: center;
}

.word {
    color: black;
    font-size: 20px;
    font-family: "楷体";
    text-align: center;
    font-weight: 700;
    display: flex;
    justify-content: center;
    align-items: center;
    /* border: 1px solid black; */
}

.smallWord {
    color: rgb(242, 122, 3);
    font-size: 15px;
    font-family: "楷体";
    text-align: center;

}

.bottomBox {
    display: flex;
    position: relative;
    top: 55%;

    /* position: absolute; */

}

.bottomBoxSmall {
    width: 40%;
    height: 60px;
    margin: auto;
    /* margin-bottom: 20%; */
    /* top: 20px; */
    background-color: rgba(239, 239, 240, 0.617);
    border-radius: 1em;
    border: 1px solid #ccc;
}
</style>