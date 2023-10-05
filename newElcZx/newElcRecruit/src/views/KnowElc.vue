<template>
    <div class="knowMore-container">
        <div class="IntroPic">
            <img class="elcphoto" src="../assets/cup.png" alt="" />
        </div>
        <br /><br /><br />
        <div class="KnowDep">
            <div class="DepBigBox" @click="clickNavDepInfo(0)">
                <img src="../assets/pcb.png" alt="" />
                电协介绍
            </div>
            <div class="DepBigBox" @click="clickNavDepInfo(10)">
                <img src="../assets/medal.png" alt="" />
                电协荣誉
            </div>
            <div class="ali" id="First">
                <div class="DepBox" @click="clickNavDepInfo(5)">
                    <img src="../assets/contact.png" alt="" />
                    外联部
                </div>
                <br />
                <div class="DepBox" @click="clickNavDepInfo(1)">
                    <img src="../assets/repair.png" alt="" />
                    维修部
                </div>
                <br />
            </div>
            <br />
            <div class="ali" id="Second">
                <div class="DepBox" @click="clickNavDepInfo(4)">
                    <img src="../assets/publicize.png" alt="" />
                    网宣部
                </div>
                <div class="DepBox" @click="clickNavDepInfo(3)">
                    <img src="../assets/project.png" alt="" />
                    项目部
                </div>
            </div>
            <div class="ali" id="Third">
                <div class="DepBox" @click="clickNavDepInfo(6)">
                    <img src="../assets/practice.png" alt="" />
                    实践部
                </div>
                <div class="DepBox" @click="clickNavDepInfo(2)">
                    <img src="../assets/secretary.png" alt="" />
                    秘书部
                </div>
            </div>

            <div class="ali" id="Third">
                <div class="DepBox" @click="clickNavDepInfo(7)">
                    <img src="../assets/coding.png" alt="" />
                    软件组
                </div>
                <div class="DepBox" @click="clickNavDepInfo(2)" style="visibility: hidden">
                    <img src="" alt="" />
                    占位组
                </div>
            </div>
        </div>
    </div>
</template>
  
<script setup>
const clickNavDepInfo = (depId) => {
    uni.navigateTo({
        url: `depIntro?depId=${depId}`,
    });
};
</script>
<style scoped>
.knowMore-container {
    padding-bottom: 20px;
}

.elcphoto {
    width: 100%;
    height: 350px;
}

image {
    width: 20px;
    height: 20px;
}

.KnowDep {
    width: 95%;
    margin: auto;
}

.DepBox {
    width: 45%;
    height: 70px;
    text-align: center;
    margin: auto;
    background-color: rgb(255, 255, 255);
    border-radius: 1em;
    box-shadow: 1px 1px 13px 2px rgba(221, 221, 221, 0.329);
    display: flex;
    align-items: center;
    justify-content: center;
    transition: box-shadow 0.5s;
    font-size: 25px;
    font-family: 楷体;
    font-weight: 700;
    color: rgb(31, 91, 194);
}

.DepBox:active {
    transform: scale(1.2, 1.2);
}

.DepBigBox {
    width: 70%;
    height: 80px;
    text-align: center;
    margin: auto;
    background-color: rgb(255, 255, 255);
    border-radius: 1em;
    box-shadow: 1px 1px 13px 2px rgba(221, 221, 221, 0.329);
    display: flex;
    align-items: center;
    justify-content: center;
    transition: box-shadow 0.5s;
    transition: font-size 0.5s;
    font-size: 25px;
    font-family: 楷体;
    font-weight: 700;
    color: rgb(31, 91, 194);
    margin-bottom: 10%;
}

.DepZuBox {
    width: 45%;
    height: 70px;
    margin-left: 2%;
    background-color: rgb(255, 255, 255);
    border-radius: 1em;
    box-shadow: 1px 1px 13px 2px rgba(221, 221, 221, 0.329);
    display: flex;
    align-items: center;
    justify-content: center;
    font-size: 25px;
    font-family: 楷体;
    font-weight: 700;
    color: rgb(31, 91, 194);
    margin-bottom: 50px;
}

.ali {
    display: flex;
    justify-content: center;
    align-items: center;
    margin-bottom: 10%;
}
</style>
  