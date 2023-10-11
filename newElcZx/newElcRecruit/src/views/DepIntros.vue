<template>
    <div class="gradient">
        <div class="gradient-content-body">
            <div class="depName">{{ depName }}</div>
            <div class="smallIntro">{{ smallIntro }} </div>
            <div class="depText">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                {{ depText }}
            </div>
        </div>
        <div class="small-explain" @click="toDepUrl"> 点击查看更多信息 </div>
    </div>
</template>

<script setup>
import { ref, onMounted, reactive } from "vue";
import { useRoute } from "vue-router"
const something = "https://mp.weixin.qq.com/s/0GDsNOfe9BNjMMGUoMiOgA";
const route = useRoute()
const depName = ref("");
const smallIntro = ref("");
const depText = ref("");
const depUrls = reactive({
    elc: "https://mp.weixin.qq.com/s/0GDsNOfe9BNjMMGUoMiOgA",
    repair: "https://mp.weixin.qq.com/s/n6Ibc3jWk7CSMsfQYTNXdQ",
    secretary: "https://mp.weixin.qq.com/s/j5JnYg5dRG9ZNWrYypKTcA",
    project: "https://mp.weixin.qq.com/s/1UeR9PY_K71ccSN3wKJyqA",
    pubilize: "https://mp.weixin.qq.com/s/Qh6-YifDojszc22CC30scw",
    outreach: "https://mp.weixin.qq.com/s/J0jlD4dCNpv1OU32HlWSvQ",
    practice: "https://mp.weixin.qq.com/s/VTp3I7Jr3o2OsNf_ZnuriA",
    coding: "https://mp.weixin.qq.com/s/9VVLQ2zdbtIY2bo_mI1Rvg",
})
const depUrl = ref("");

function setDepUrl(data) {
    depUrl.value = data;
}

function toDepUrl() {
    window.location.href = depUrl.value;
}

function showText(depId = "1") {
    switch (depId) {
        case "200":
            setFields(
                "协会荣誉",
                "一堆奖",
                "广工电协在各类学科竞赛，项目开发上均有不错的成绩。在全国大学生电子设计大赛，挑战杯，全美大学生数学建模竞赛，飞思卡尔等大赛中，广工电协取得瞩目的成绩，而在各类电子竞赛中电协成员更是独领风骚，省级奖项校级奖项不可胜数。在项目开发上，电协拥有3个国家级大创项目，省级项目若干个，其中拥有自主专利6项。电协的毕业生更是深入到华为、联发科、大疆、CVTE、bigo等著名企业中成为佼佼者。在学术领域，我们的毕业生考研或保研进入清华大学、中山大学、华南理工大学、电子科技大学、哈尔滨工业大学等大学继续深造学业。"
            );
            break;
        case "100":
            setFields(
                "协会介绍",
                "早晨的图书馆,凌晨的实验室",
                "广东工业大学电子科技协会（简称广工电协）是由在校电子技术爱好者于2002年11月组织成立的，是广东工业大学最大型的学术性社团。在近20年中的发展中，协会不断突破自我，技术水平不断沉淀，自主研发室内机器人定位导航系统、基于PID算法的高效开关电源变换器、基于卷积神经网络的自动垃圾分类系统、实时数据流人脸识别的门禁系统，自主开发STM8和STM32开发板。同时电协开设贝尔组：分别在嵌入式领域、视觉领域、硬件领域、网络领域进行深入研究与开发。电协的理念是让平凡的人成为优秀的人，让优秀的人更加优秀。爱电子，爱生活。电协欢迎广大电子爱好者的加入，我们与你们共成长！"
            );
            setDepUrl(depUrls.elc)
            break;
        case "1":
            setFields(
                "维修部",
                "维物之态，修身之技",
                "作为协会中最热闹也是最“卷”的部门之一，维修部当仁不让，在协会需要我们时挺身而出。我们维修部的工作日常是组织义修活动，维护协会元器件库以及处理学校内驿站的故障家电。义修活动的范围是在整个大学城校区，包括其他学校。"
            );
            setDepUrl(depUrls.repair)
            break;
        case "2":
            setFields(
                "秘书部",
                "秘才八斗，书气翩翩",
                "秘书部主要负责文案撰写，活动申请以及协助准备各项比赛物资等工作；我们注重干事的技术提升，积极给予干事学习上的指导帮助；同时也经常开展团建活动，部门氛围非常和谐欢乐。"
            );
            setDepUrl(depUrls.secretary)
            break;
        case "3":
            setFields(
                "项目部",
                "不远千里，项目等你",
                "项目部是要对协会申请的项目进行审核以及相关资料的整理，同时收集整理协会成员比赛的相关资料以及获奖情况，并将其进行归档上传云盘，定期上传历年来的学习资料、试卷等。欢迎各位来到快乐的小卖部！！！"
            );
            setDepUrl(depUrls.project)
            break;
        case "4":
            setFields(
                "网宣部",
                "网宣之约，相见不散",
                "作为电协对外宣传的窗口，在这里你不仅能学习如何运营公众号，制作推文，还能充分发挥你的想象力设计海报传单，剪辑视频！除了有各路硬件、嵌入式大佬带飞，让你快速脱离萌新期，成长为电协软硬件“大佬”。还有男女生节，生日庆祝等众多有趣好玩的团建活动等你来参加！在网宣，我们是队友，更是亲密无间的朋友，一网情深，宣之于口，网宣大家庭期待你的加入！"
            );
            setDepUrl(depUrls.pubilize)
            break;
        case "5":
            setFields(
                "外联部",
                "相约外联，逐梦电协",
                "咱作为电协的脸面，必须得又好学又好玩！！！作为外联人，你可以：负责协会各个活动与会议的主持工作！策划举办社团活动，如部门破冰、科技比赛、男女生节、电协团建等！与校内外其他社团及社会资源建立联系，寻找交流机会和资源支持！负责电协课的物资、团建娱乐物资、比赛奖品等协会部分物质的购买与发放，负责社团招新和活动的宣传推广工作，利用多种渠道向校内外传递信息，提高社团的知名度和影响力！！！And...你还可以：跟着师兄师姐学习技术内容和相关经验！！！和协会的小伙伴们一起学习、一起参加比赛，提升自己！！！认识不同专业的永远最可爱的外联小伙伴！！！！！"
            );
            setDepUrl(depUrls.outreach)
            break;
        case "6":

            setFields(
                "实践部",
                "躬身实践，力学笃行",
                "实践部在日常工作中主要负责协会相关项目的整理收集，构建和完善协会的资料库，以及协助电协各类活动的摆摊工作等等，同时也参与开展相关的活动和比赛，并配合相关的宣传工作"
            );
            setDepUrl(depUrls.practice)
            break;
        case "7":
            setFields(
                "软件组",
                "代码，代码，还是代码",
                "软件组衍生于贝尔组，致力于开发面向全校的项目和系统。软件组目前的方向有前端、后端、网络运维、小游戏开发，主要运用的语言有C/C++、javascript、java、go、C#、python等。已经开发的项目有gdutday、GDUTDays、电子科技协会论坛等。软件组始终坚持技术深耕，项目挖掘，致力于写出更优秀的代码以及实现更完美的业务。欢迎热爱coding的你加入我们！ (此报名网站便是由 @软件组成员yinyan && Hechu 呈献)"
            );
            setDepUrl(depUrls.coding)
            break;
    }
};

function setFields(_depName, _smallIntro, _depText,) {
    depName.value = _depName;
    smallIntro.value = _smallIntro;
    depText.value = _depText;
};

onMounted(() => {
    let depId = route.params.depId;
    if (depId == "")
        depId = "100";
    showText(depId);
})
</script>

<style scoped>
.gradient {
    height: 100%;
    background-image: url("../assets/bg0.png");
    background-size: 100% 100%;
    background-repeat: no-repeat;
    overflow: auto;
    user-select: none;
}

@media screen and (min-width: 800px) {
    .gradient {
        height: 100%;
        background-image: url("../assets/bg00.png");
        background-size: 100% 100%;
        background-repeat: no-repeat;
        user-select: none;
    }
}

.gradient-content-body {
    width: 80%;
    margin: auto;
    margin-top: 50px;
    margin-bottom: 50px;
}

@media screen and (min-width: 800px) {
    .gradient-content-body {
        width: 60%;
        margin: auto;
        margin-top: 10%;
    }
}

.depName {
    font-size: 50px;
    font-family: 楷体;
    font-weight: 700;
    color: rgb(247, 199, 110);
}

.smallIntro {
    color: rgba(124, 124, 124, 0.973);
    margin-top: 5px;
    padding-left: 5px;
}

.depText {
    padding: 10px;
    border: 1px solid #ccc;
    box-sizing: border-box;
    margin: auto;
    font-weight: 500;
    font-size: 18px;
    color: rgba(95, 40, 3, 0.87);
    border-radius: 6px;
    line-height: 30px;
    margin-top: 8%;
    background-color: rgba(250, 250, 250, 0.4);
    box-shadow: 1px 1px 3px #ccc;
}

.small-explain {
    font-family: "楷体";
    text-align: center;
    font-size: 1.3em;
    color: rgb(45, 140, 240);
    cursor: pointer;
    position: fixed;
    bottom: 10px;
    left: 0;
    right: 0;
}

.small-explain:hover {
    color: rgba(209 54 57);
}

.divider {
    background: #3838375b;
    height: 1px;
    margin-top: 10px;
}
</style>
  