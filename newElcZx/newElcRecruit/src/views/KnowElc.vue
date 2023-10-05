<template>
    <div class="knowMore-container">
        <div class="IntroPic"></div>
        <div class="knowMore-content-body">
            <div class="KnowDep">
                <div>
                    <Card style="width:320px">
                        <div style="text-align:center">
                            <img src="../assets/pcb.png">
                            <h3>电协介绍</h3>
                        </div>
                    </Card>
                </div>

                <div>
                    <Card style="width:320px">
                        <div style="text-align:center">
                            <img src="../assets/medal.png">
                            <h3>电协荣誉</h3>
                        </div>
                    </Card>
                </div>
                <div>
                    <Card style="width:320px">
                        <div style="text-align:center">
                            <img src="../assets/contact.png">
                            <h3>外联部</h3>
                        </div>
                    </Card>
                </div>

                <div>
                    <Card style="width:320px">
                        <div style="text-align:center">
                            <img src="../assets/repair.png">
                            <h3>维修部</h3>
                        </div>
                    </Card>
                </div>

                <div>
                    <Card style="width:320px">
                        <div style="text-align:center">
                            <img src="../assets/publicize.png">
                            <h3>网宣部</h3>
                        </div>
                    </Card>
                </div>
                <div>
                    <Card style="width:320px">
                        <div style="text-align:center">
                            <img src="../assets/project.png">
                            <h3>项目部</h3>
                        </div>
                    </Card>
                </div>
                <div>
                    <Card style="width:320px">
                        <div style="text-align:center">
                            <img src="../assets/practice.png">
                            <h3>实践部</h3>
                        </div>
                    </Card>
                </div>
                <div>
                    <Card style="width:320px">
                        <div style="text-align:center">
                            <img src="../assets/secretary.png">
                            <h3>秘书部</h3>
                        </div>
                    </Card>
                </div>
                <div>
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
const clickNavDepInfo = (depId) => {
    uni.navigateTo({
        url: `depIntro?depId=${depId}`,
    });
};
</script>
<style scoped>
.IntroPic {
    background-image: url("../assets/cup.png");
    height: 300px;
    background-size: cover;
}

.knowMore-container {
    padding-bottom: 20px;
    background-image: url("../assets/knowElcBackground.png");
    background-size: cover;
    background-repeat: no-repeat;
    overflow: auto
}

.elcphoto {
    width: 100%;
    height: 350px;
}

.knowMore-content-body {
    display: flex;
    align-items: center;
    justify-content: center;
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
  