<template>
    <div class="knowMore-container">
        <div class="IntroPic"></div>
        <div class="knowMore-content-body">
            <div class="KnowDep">
                <div @click="clickNavDepInfo(100)">
                    <Card style="width:320px">
                        <div style="text-align:center">
                            <img src="../assets/pcb.png">
                            <h3>电协介绍</h3>
                        </div>
                    </Card>
                </div>

                <div @click="clickNavDepInfo(200)">
                    <Card style="width:320px">
                        <div style="text-align:center">
                            <img src="../assets/medal.png">
                            <h3>电协荣誉</h3>
                        </div>
                    </Card>
                </div>
                <div @click="clickNavDepInfo(5)">
                    <Card style="width:320px">
                        <div style="text-align:center">
                            <img src="../assets/contact.png">
                            <h3>外联部</h3>
                        </div>
                    </Card>
                </div>

                <div @click="clickNavDepInfo(1)">
                    <Card style="width:320px">
                        <div style="text-align:center">
                            <img src="../assets/repair.png">
                            <h3>维修部</h3>
                        </div>
                    </Card>
                </div>

                <div @click="clickNavDepInfo(4)">
                    <Card style="width:320px">
                        <div style="text-align:center">
                            <img src="../assets/publicize.png">
                            <h3>网宣部</h3>
                        </div>
                    </Card>
                </div>
                <div @click="clickNavDepInfo(3)">
                    <Card style="width:320px">
                        <div style="text-align:center">
                            <img src="../assets/project.png">
                            <h3>项目部</h3>
                        </div>
                    </Card>
                </div>
                <div @click="clickNavDepInfo(6)">
                    <Card style="width:320px">
                        <div style="text-align:center">
                            <img src="../assets/practice.png">
                            <h3>实践部</h3>
                        </div>
                    </Card>
                </div>
                <div @click="clickNavDepInfo(2)">
                    <Card style="width:320px">
                        <div style="text-align:center">
                            <img src="../assets/secretary.png">
                            <h3>秘书部</h3>
                        </div>
                    </Card>
                </div>
                <div @click="clickNavDepInfo(7)">
                    <Card style="width:320px">
                        <div style="text-align:center">
                            <img src="../assets/coding.png">
                            <h3>软件组</h3>
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
    /* background-repeat: no-repeat; */
}

.knowMore-container {
    height: 100%;
    user-select: none;
}

.knowMore-content-body {
    /* background-color: red; */
    display: flex;
    justify-content: center;
    background-image: url("../assets/knowElcBackground.png");
    background-size: 100% 100%;
    overflow: auto
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
  