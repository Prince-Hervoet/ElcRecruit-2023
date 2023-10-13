<template>
    <div class="knowMore-container">
        <div class="IntroPic" style="display: flex; justify-content: center;width: 100%;">
            <div class="title">
                <div class="title-down" style="width: 100%;">Welcome to ELC</div>
                <div class="title-up">Welcome to ELC</div>
            </div>
            <svg t="1696779219071" class="icon" viewBox="0 0 1024 1024" version="1.1" xmlns="http://www.w3.org/2000/svg"
                p-id="9866" width="36" height="36">
                <path
                    d="M818.941862 446.600409l-358.098839-32.740465V230.206396a76.735465 76.735465 0 0 0-153.470931 0v397.489712l-64.969361-112.54535a102.313954 102.313954 0 0 0-177.00314 102.313954l204.627908 354.517851a102.313954 102.313954 0 0 0 102.313954 51.156977h454.785525a102.313954 102.313954 0 0 0 102.313954-93.105698l29.159477-316.150118A153.470931 153.470931 0 0 0 818.941862 446.600409z"
                    fill="#333333" p-id="9867"></path>
                <path
                    d="M282.305173 306.941862A126.869303 126.869303 0 0 1 256.215115 230.206396a127.892442 127.892442 0 0 1 255.784885 0A126.869303 126.869303 0 0 1 485.909942 306.941862l81.339593 61.388372A228.160117 228.160117 0 0 0 614.313954 230.206396a230.206396 230.206396 0 0 0-460.412793 0 228.160117 228.160117 0 0 0 46.552849 137.612269z"
                    fill="#333333" p-id="9868"></path>
            </svg>
        </div>
        <div style="display: flex; justify-content: center;">
            <Space size="large">
                <Spin size="small" />
                <Spin size="small" />
                <Spin size="small" />
                <Spin />
                <Spin />
                <Spin />
                <Spin size="large" />
                <Spin size="large" />
                <Spin size="large" />
            </Space>
            <Space size="large">
                <Spin size="large" />
                <Spin size="large" />
                <Spin size="large" />
                <Spin />
                <Spin />
                <Spin />

                <Spin size="small" />
                <Spin size="small" />
                <Spin size="small" />


            </Space>

        </div>
        <div class="knowMore-content-body">
            <div class="KnowDep">
                <div class="box" @click="clickNavDepInfo(100)">
                    <Card style="width:300px;height: 180px;" :shadow="false">
                        <div style="text-align:center">
                            <img src="../assets/pcb.png" style="width: 22%;">
                            <h2>电协介绍</h2>
                            <p>早晨的图书馆</p>
                            <p>凌晨的实验室</p>
                        </div>
                    </Card>
                </div>

                <div class="box" @click="clickNavDepInfo(200)">
                    <Card style="width:300px;height: 180px;" :shadow="false">
                        <div style="text-align:center">
                            <img src="../assets/medal.png" style="width: 22%;">
                            <h2>电协荣誉</h2>
                            <p>一堆奖</p>
                        </div>
                    </Card>
                </div>
                <div class="box" @click="clickNavDepInfo(5)">
                    <Card style="width:300px">
                        <div style="text-align:center">
                            <img src="../assets/wailian.png" style="width: 50%;">
                            <h2>外联部</h2>
                            <p>相约外联，逐梦电协</p>
                        </div>
                    </Card>
                </div>

                <div class="box" @click="clickNavDepInfo(1)">
                    <Card style="width:300px">
                        <div style="text-align:center">
                            <img src="../assets/weixiu.png" style="width: 50%;">
                            <h2>维修部</h2>
                            <p>维物之态，修身之技</p>
                        </div>
                    </Card>
                </div>

                <div class="box" @click="clickNavDepInfo(4)">
                    <Card style="width:300px">
                        <div style="text-align:center">
                            <img src="../assets/wangxuan.png" style="width: 50%;">
                            <h2>网宣部</h2>
                            <p>网宣之约，相见不散</p>
                        </div>
                    </Card>
                </div>
                <div class="box" @click="clickNavDepInfo(3)">
                    <Card style="width:300px">
                        <div style="text-align:center">
                            <img src="../assets/xiangmu.png" style="width: 50%;">
                            <h2>项目部</h2>
                            <p>不远千里，项目等你</p>
                        </div>
                    </Card>
                </div>
                <div class="box" @click="clickNavDepInfo(6)">
                    <Card style="width:300px">
                        <div style="text-align:center">
                            <img src="../assets/shijian.png" style="width: 50%;">
                            <h2>实践部</h2>
                            <p>躬身实践，力学笃行</p>
                        </div>
                    </Card>
                </div>
                <div class="box" @click="clickNavDepInfo(2)">
                    <Card style="width:300px">
                        <div style="text-align:center">
                            <img src="../assets/mishu.png" style="width: 50%;">
                            <h2>秘书部</h2>
                            <p>秘才八斗，书气翩翩</p>
                        </div>
                    </Card>
                </div>
                <div class="box" @click="clickNavDepInfo(7)">
                    <Card style="width:300px; ">
                        <div style="text-align:center">
                            <img src="../assets/wangl.png" style="width: 50%;">
                            <h2>软件组</h2>
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
.title {
    font-size: 45px;
    color: #444444;
    position: relative;
    font-family: "Franklin Gothic Medium", "Arial Narrow", Arial, sans-serif;
    text-shadow: 2px 2px #c6c6c6;

}

.title-up {
    position: relative;
    opacity: 1;
    clip-path: ellipse(100px 200px at 0% 50%);
    animation: lightMove 2.5s ease-in infinite;
}

.title-down {
    position: absolute;
    color: rgb(45, 140, 240);
    top: 0;
    left: 0;
}

@keyframes lightMove {
    50% {
        clip-path: ellipse(100px 200px at 100% 50%);
    }

    to {
        clip-path: ellipse(100px 200px at 0% 50%);
    }
}

.knowMore-container {
    height: 100%;
    user-select: none;
    margin-top: 50px;
}

.box:hover {
    box-shadow: #444444;
}

.knowMore-content-body {
    display: flex;
    justify-content: center;
    margin-top: 100px;
    background-color: rgb(253, 253, 253);
    overflow: auto;
    margin-top: 5%;
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
    width: 60%;
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
        max-width: 60%;
        margin-top: 20px;
    }
}

@media screen and (max-width: 400px) {
    .IntroPic {
        display: flex;
        align-items: center;
        justify-items: center;

    }

    .title-up {
        position: relative;
        opacity: 1;
        clip-path: ellipse(100px 200px at 0% 50%);
        animation: lightMove 2.5s ease-in infinite;
        width: 100%;
    }

    .title {
        width: 100%;
    }

    .title-down {
        position: absolute;
        color: rgb(45, 140, 240);
        top: 0;
        left: 0;
        width: 100%;
    }
}

h2 {
    color: rgb(45, 140, 240);
    font-family: "楷体";
}
</style>
  