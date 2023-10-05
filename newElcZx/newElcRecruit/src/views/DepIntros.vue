<template>
    <div class="gradient">
<<<<<<< HEAD
        <div>
            <div class="depName">{{ depName }}</div>
            <div class="divider"></div>
            <div class="smallIntro">{{ smallIntro }}</div>
            <div class="depText">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                {{ depText }}
            </div>
=======
        <div class="depName">{{ depName }}</div>
        <div class="divider"></div>
        <div class="smallIntro">{{ smallIntro }}</div>
        <div class="depText">ss&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
            {{ depText }}
>>>>>>> 50e0fded3c5255061abe52536b4dc8634f8db6ad
        </div>
    </div>
</template>
  
<script setup>
import { ref, onMounted } from "vue";
import { useRoute } from "vue-router"
const route = useRoute()

const depName = ref("");
const smallIntro = ref("");
const depText = ref("");
function showText(depId = "1") {
    switch (depId) {
        case "10":
            setFields(
                "协会荣誉",
                "一堆奖",
                "广工电协在各类学科竞赛，项目开发上均有不错的成绩。在全国大学生电子设计大赛，挑战杯，全美大学生数学建模竞赛，飞思卡尔等大赛中，广工电协取得瞩目的成绩，而在各类电子竞赛中电协成员更是独领风骚，省级奖项校级奖项不可胜数。在项目开发上，电协拥有3个国家级大创项目，省级项目若干个，其中拥有自主专利6项。电协的毕业生更是深入到华为、联发科、大疆、CVTE、bigo等著名企业中成为佼佼者。在学术领域，我们的毕业生考研或保研进入清华大学、中山大学、华南理工大学、电子科技大学、哈尔滨工业大学等大学继续深造学业。"
            );
            break;
        case "0":
            setFields(
                "协会介绍",
                "早晨的图书馆,凌晨的实验室",
                "广东工业大学电子科技协会（简称广工电协）是由在校电子技术爱好者于2002年11月组织成立的，是广东工业大学最大型的学术性社团。在近20年中的发展中，协会不断突破自我，技术水平不断沉淀，自主研发室内机器人定位导航系统、基于PID算法的高效开关电源变换器、基于卷积神经网络的自动垃圾分类系统、实时数据流人脸识别的门禁系统，自主开发STM8和STM32开发板。同时电协开设贝尔组：分别在嵌入式领域、视觉领域、硬件领域、网络领域进行深入研究与开发。电协的理念是让平凡的人成为优秀的人，让优秀的人更加优秀。爱电子，爱生活。电协欢迎广大电子爱好者的加入，我们与你们共成长！"
            );
            break;
        case "1":
            setFields(
                "维修部",
                "维物之态，修身之技",
                "作为协会中最热闹也是最“卷”的部门之一，维修部当仁不让，在协会需要我们时挺身而出。我们维修部的工作日常是组织义修活动，维护协会元器件库以及处理学校内驿站的故障家电。义修活动的范围是在整个大学城校区，包括其他学校。"
            );
            break;
        case "2":
            setFields(
                "秘书部",
                "秘才八斗，书气翩翩",
                "秘书部主要负责文案撰写，活动申请以及协助准备各项比赛物资等工作；我们注重干事的技术提升，积极给予干事学习上的指导帮助；同时也经常开展团建活动，部门氛围非常和谐欢乐。"
            );
            break;
        case "3":
            setFields(
                "项目部",
                "不远千里，项目等你",
                "项目部是要对协会申请的项目进行审核以及相关资料的整理，同时收集整理协会成员比赛的相关资料以及获奖情况，并将其进行归档上传云盘，定期上传历年来的学习资料、试卷等。欢迎各位来到快乐的小卖部！！！"
            );
            break;
        case "4":
            setFields(
                "网宣部",
                "网宣之约，相见不散",
                "作为电协对外宣传的窗口，在这里你不仅能学习如何运营公众号，制作推文，还能充分发挥你的想象力设计海报传单，剪辑视频！除了有各路硬件、嵌入式大佬带飞，让你快速脱离萌新期，成长为电协软硬件“大佬”。还有男女生节，生日庆祝等众多有趣好玩的团建活动等你来参加！在网宣，我们是队友，更是亲密无间的朋友，一网情深，宣之于口，网宣大家庭期待你的加入！"
            );
            break;
        case "5":
            setFields(
                "外联部",
                "相约外联，逐梦电协",
                "咱作为电协的脸面，必须得又好学又好玩！！！作为外联人，你可以：负责协会各个活动与会议的主持工作！策划举办社团活动，如部门破冰、科技比赛、男女生节、电协团建等！与校内外其他社团及社会资源建立联系，寻找交流机会和资源支持！负责电协课的物资、团建娱乐物资、比赛奖品等协会部分物质的购买与发放，负责社团招新和活动的宣传推广工作，利用多种渠道向校内外传递信息，提高社团的知名度和影响力！！！And...你还可以：跟着师兄师姐学习技术内容和相关经验！！！和协会的小伙伴们一起学习、一起参加比赛，提升自己！！！认识不同专业的永远最可爱的外联小伙伴！！！！！"
            );
            break;
        case "6":
            setFields(
                "实践部",
                "躬身实践，力学笃行",
                "实践部在日常工作中主要负责协会相关项目的整理收集，构建和完善协会的资料库，以及协助电协各类活动的摆摊工作等等，同时也参与开展相关的活动和比赛，并配合相关的宣传工作"
            );
            break;
        case "7":
            setFields(
                "软件组",
                "代码，代码，还是代码",
                "软件组衍生于贝尔组，致力于开发面向全校的项目和系统。软件组目前的方向有前端、后端、网络运维、小游戏开发，主要运用的语言有C/C++、javascript、java、go、C#、python等。已经开发的项目有gdutday、GDUTDays、电子科技协会论坛等。软件组始终坚持技术深耕，项目挖掘，致力于写出更优秀的代码以及实现更完美的业务。欢迎热爱coding的你加入我们！ (此小程序由 @软件组成员yinyan 呈献)"
            );
            break;
    }
};

function setFields(_depName, _smallIntro, _depText) {
    depName.value = _depName;
    smallIntro.value = _smallIntro;
    depText.value = _depText;
};

onMounted(() => {
    console.log(route.params.depId);
    showText(route.params.depId);
})
</script>
  
<style scoped>
.gradient {
    height: 100%;
    background-image: url("data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAABDgAAAeABAMAAADZT/o5AAAABGdBTUEAALGPC/xhBQAAAAFzUkdCAK7OHOkAAARDaVRYdFhNTDpjb20uYWRvYmUueG1wAAAAAAA8P3hwYWNrZXQgYmVnaW49J++7vycgaWQ9J1c1TTBNcENlaGlIenJlU3pOVGN6a2M5ZCc/Pgo8eDp4bXBtZXRhIHhtbG5zOng9J2Fkb2JlOm5zOm1ldGEvJz4KPHJkZjpSREYgeG1sbnM6cmRmPSdodHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgtbnMjJz4KCiA8cmRmOkRlc2NyaXB0aW9uIHJkZjphYm91dD0nJwogIHhtbG5zOkF0dHJpYj0naHR0cDovL25zLmF0dHJpYnV0aW9uLmNvbS9hZHMvMS4wLyc+CiAgPEF0dHJpYjpBZHM+CiAgIDxyZGY6U2VxPgogICAgPHJkZjpsaSByZGY6cGFyc2VUeXBlPSdSZXNvdXJjZSc+CiAgICAgPEF0dHJpYjpDcmVhdGVkPjIwMjMtMDktMDM8L0F0dHJpYjpDcmVhdGVkPgogICAgIDxBdHRyaWI6RXh0SWQ+YTlhZmMxMWMtMzQ5MC00NjI2LWIxZWYtM2MwYjNlZTRlMmZmPC9BdHRyaWI6RXh0SWQ+CiAgICAgPEF0dHJpYjpUb3VjaFR5cGU+MjwvQXR0cmliOlRvdWNoVHlwZT4KICAgIDwvcmRmOmxpPgogICA8L3JkZjpTZXE+CiAgPC9BdHRyaWI6QWRzPgogPC9yZGY6RGVzY3JpcHRpb24+CgogPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9JycKICB4bWxuczpkYz0naHR0cDovL3B1cmwub3JnL2RjL2VsZW1lbnRzLzEuMS8nPgogIDxkYzp0aXRsZT4KICAgPHJkZjpBbHQ+CiAgICA8cmRmOmxpIHhtbDpsYW5nPSd4LWRlZmF1bHQnPuacquWRveWQjeeahOiuvuiuoSAtIDE8L3JkZjpsaT4KICAgPC9yZGY6QWx0PgogIDwvZGM6dGl0bGU+CiA8L3JkZjpEZXNjcmlwdGlvbj4KCiA8cmRmOkRlc2NyaXB0aW9uIHJkZjphYm91dD0nJwogIHhtbG5zOnBkZj0naHR0cDovL25z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");
    background-size: cover;
    display: flex;
    flex-direction: column;
    overflow: auto;
}

.divider {
    background: rgba(198, 198, 198, 0.663);
    width: 70%;
    height: 5rpx;
    margin-top: 2px;
}

.depName {
    width: 70%;
    margin-top: 10%;
    font-size: 50px;
    text-align: center;
    font-family: 楷体;
    font-weight: 700;
    color: rgb(247, 199, 110);
}

.smallIntro {
    color: rgba(124, 124, 124, 0.973);
    width: 70%;
    margin-top: 5px;
    text-align: center;
}

.depText {
    width: 70%;
    padding: 10px;
    border: 1px solid #ccc;
    margin: auto;
    font-weight: 500;
    font-size: 18px;
    color: rgba(95, 40, 3, 0.87);
    border-radius: 6px;
    line-height: 30px;
    margin-top: 8%;
    margin-bottom: 10%;
    background-color: rgba(250, 250, 250, 0.4);
    box-shadow: 1px 1px 3px #ccc;
}
</style>
  