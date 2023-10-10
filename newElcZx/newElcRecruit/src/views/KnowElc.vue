<template>
    <div class="knowMore-container">
        <div class="IntroPic"></div>
        <div class="knowMore-content-body">
            <div class="KnowDep">
                <div @click="clickNavDepInfo(100)">
                    <Card style="width:320px" :shadow="true">
                        <div style="text-align:center">
                            <img src="../assets/pcb.png">
                            <h3>电协介绍</h3>
                            <p>早晨的图书馆，凌晨的实验室</p>
                        </div>
                    </Card>
                </div>

                <div @click="clickNavDepInfo(200)">
                    <Card style="width:320px" :shadow="false">
                        <div style="text-align:center">
                            <img src="../assets/medal.png">
                            <h3>电协荣誉</h3>
                            <p>一堆奖</p>
                        </div>
                    </Card>
                </div>
                <div @click="clickNavDepInfo(5)">
                    <Card style="width:320px" :shadow="false">
                        <div style="text-align:center">
                            <img src="../assets/wailian.png" class="knowMore-card-img">
                            <h3>外联部</h3>
                            <p>相约外联，逐梦电协</p>
                        </div>
                    </Card>
                </div>

                <div @click="clickNavDepInfo(1)">
                    <Card style="width:320px" :shadow="false">
                        <div style="text-align:center">
                            <img src="../assets/weixiu.png" class="knowMore-card-img">
                            <h3>维修部</h3>
                            <p>维物之态，修身之技</p>
                        </div>
                    </Card>
                </div>

                <div @click="clickNavDepInfo(4)">
                    <Card style="width:320px" :shadow="false">
                        <div style="text-align:center">
                            <img src="../assets/wangxuan.png" class="knowMore-card-img">
                            <h3>网宣部</h3>
                            <p>网宣之约，相见不散</p>
                        </div>
                    </Card>
                </div>
                <div @click="clickNavDepInfo(3)">
                    <Card style="width:320px" :shadow="false">
                        <div style="text-align:center">
                            <img src="../assets/xiangmu.png" class="knowMore-card-img">
                            <h3>项目部</h3>
                            <p>不远千里，项目等你</p>
                        </div>
                    </Card>
                </div>
                <div @click="clickNavDepInfo(6)">
                    <Card style="width:320px" :shadow="false">
                        <div style="text-align:center">
                            <img src="../assets/shijian.png" class="knowMore-card-img">
                            <h3>实践部</h3>
                            <p>躬身实践，力学笃行</p>
                        </div>
                    </Card>
                </div>
                <div @click="clickNavDepInfo(2)">
                    <Card style="width:320px" :shadow="false">
                        <div style="text-align:center">
                            <img src="../assets/mishu.png" class="knowMore-card-img">
                            <h3>秘书部</h3>
                            <p>秘才八斗，书气翩翩</p>
                        </div>
                    </Card>
                </div>
                <div @click="clickNavDepInfo(7)">
                    <Card style="width:320px" :shadow="false">
                        <div style="text-align:center">
                            <img src="../assets/ruanjian.png" class="knowMore-card-img">
                            <h3>软件组</h3>
                            <p>代码，代码，还是代码</p>
                        </div>
                    </Card>
                </div>
            </div>
        </div>

    </div>
</template>
  
<script setup>
import router from '../router';

const clickNavDepInfo = (depId) => {
    router.push({ name: "depIntros", params: { depId } });
};
</script>
<style scoped>
.IntroPic {
    background-image: url("../assets/cup.png");
    height: 300px;
    background-size: contain;
    box-shadow: 0px 5px 1px 7px #ccc;
}

.knowMore-container {
    height: 100%;
    user-select: none;
}

.knowMore-content-body {
    display: flex;
    justify-content: center;
    background-color: rgb(253, 253, 253);
    overflow: auto
}

.knowMore-card-img {
    width: 180px;
    height: 160px;
    border: 1px solid #e1e1e1;
    border-radius: 8px;
    box-shadow: 1px 1px 3px 1px #ececec;
}

.KnowDep {
    display: flex;
    flex-direction: column;
    align-items: center;
    margin-top: 20px;
}

.KnowDep>div {
    margin-bottom: 10px;
    padding: 5px;
    box-sizing: border-box;
    cursor: pointer;
}

@media screen and (min-width: 800px) {
    .KnowDep {
        display: grid;
        grid-template-columns: 1fr 1fr;
        align-items: center;
        justify-items: center;
        max-width: 650px;
        margin-top: 20px;
    }
}
</style>
  