<template>
  <view class="gradient">
    <!-- <span>&nbsp;</span> -->
    <view>
      <view class="depName">{{ depName }}</view>
      <view class="divider" />
      <view class="smallIntro">{{ smallIntro }}</view>
      <view class="depText">
        {{ depText }}
      </view>
    </view>

    <!-- <view class="water">
      <view class="water-c">
        <view class="water-1"> </view>
        <view class="water-2"> </view>
      </view>
    </view> -->
  </view>
</template>

<script>
export default {
  data() {
    return {
      depName: "",
      smallIntro: "",
      depText: "",
    };
  },
  onLoad(option) {
    this.showText(option.depId);
  },

  methods: {
    showText(depId = "1") {
      switch (depId) {
        case "1":
          this.setFields(
            "维修部",
            "代码，代码，还是代码",
            "作为协会中最热闹也是最“卷”的部门之一，维修部当仁不让，在协会需要我们时挺身而出。我们维修部的工作日常是组织义修活动，维护协会元器件库以及处理学校内驿站的故障家电。义修活动的范围是在整个大学城校区，包括其他学校。"
          );
          break;
        case "2":
          this.setFields(
            "秘书部",
            "代码，代码，还是代码",
            "&nbsp&nbsp&nbsp 软件组衍生于贝尔组，致力于开发面向全校的项目和系统。软件组目前的方向有前端、后端、网络运维、小游戏开发，主要运用的语言有C/C++、javascript、java、go、C#、python等。已经开发的项目有gdutday、GDUTDays、电子科技协会论坛等。软件组始终坚持技术深耕，项目挖掘，致力于写出更优秀的代码以及实现更完美的业务。欢迎热爱coding的你加入我们！！！"
          );
          break;
        case "3":
          this.setFields(
            "项目部",
            "代码，代码，还是代码",
            "项目部是要对协会申请的项目进行审核以及相关资料的整理，同时收集整理协会成员比赛的相关资料以及获奖情况，并将其进行归档上传云盘，定期上传历年来的学习资料、试卷等。欢迎各位来到快乐的小卖部！！！"
          );
          break;
        case "4":
          this.setFields(
            "网宣部",
            "代码，代码，还是代码",
            "作为电协对外宣传的窗口，在这里你不仅能学习如何运营公众号，制作推文，还能充分发挥你的想象力设计海报传单，剪辑视频！除了有各路硬件、嵌入式大佬带飞，让你快速脱离萌新期，成长为电协软硬件“大佬”。还有男女生节，生日庆祝等众多有趣好玩的团建活动等你来参加！在网宣，我们是队友，更是亲密无间的朋友，一网情深，宣之于口，网宣大家庭期待你的加入！"
          );
          break;
        case "5":
          this.setFields(
            "外联部",
            "代码，代码，还是代码",
            "咱作为电协的脸面，必须得又好学又好玩！！！作为外联人，你可以：负责协会各个活动与会议的主持工作！策划举办社团活动，如部门破冰、科技比赛、男女生节、电协团建等！与校内外其他社团及社会资源建立联系，寻找交流机会和资源支持！负责电协课的物资、团建娱乐物资、比赛奖品等协会部分物质的购买与发放，负责社团招新和活动的宣传推广工作，利用多种渠道向校内外传递信息，提高社团的知名度和影响力！！！And...你还可以：跟着师兄师姐学习技术内容和相关经验！！！和协会的小伙伴们一起学习、一起参加比赛，提升自己！！！认识不同专业的永远最可爱的外联小伙伴！！！！！"
          );
          break;
        case "6":
          this.setFields(
            "实践部",
            "代码，代码，还是代码",
            "实践部在日常工作中主要负责协会相关项目的整理收集，构建和完善协会的资料库，以及协助电协各类活动的摆摊工作等等，同时也参与开展相关的活动和比赛，并配合相关的宣传工作"
          );
          break;
        case "7":
          this.setFields(
            "软件组",
            "代码，代码，还是代码",
            "&nbsp&nbsp&nbsp 软件组衍生于贝尔组，致力于开发面向全校的项目和系统。软件组目前的方向有前端、后端、网络运维、小游戏开发，主要运用的语言有C/C++、javascript、java、go、C#、python等。已经开发的项目有gdutday、GDUTDays、电子科技协会论坛等。软件组始终坚持技术深耕，项目挖掘，致力于写出更优秀的代码以及实现更完美的业务。欢迎热爱coding的你加入我们！！！"
          );
          break;
      }
    },

    setFields(depName, smallIntro, depText) {
      this.depName = depName;
      this.smallIntro = smallIntro;
      this.depText = depText;
    },
  },
};
</script>

<style scoped>
.try {
  height: 100vh;
  background-image: url("https://s1.ax1x.com/2023/08/30/pPwK0Ff.jpg");
  background-size: cover;
  background-repeat: repeat;
  display: flex;
  flex-direction: column;
}

.gradient {
  height: 100vh;
  background: linear-gradient(-45deg, #d4a197, #c8829d, #5e2cf5, #23d5ab);
  background-size: 600% 600%;
  display: flex;
  flex-direction: column;
  animation: gradientBG 6s ease infinite;
  overflow: auto;
}

@keyframes gradientBG {
  0% {
    background-position: 0% 50%;
  }
  50% {
    background-position: 100% 50%;
  }
  100% {
    background-position: 0% 50%;
  }
}

.water {
  position: absolute;
  margin-top: 100px;
  left: 0;
  height: 100px;
  width: 100%;
  z-index: 2;
  background-color: #4db6d669;
}

.water-c {
  position: relative;
}

.water-1 {
  background-color: #dd1f1f;
  background: url("data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9Im5vIj8+Cjxzdmcgd2lkdGg9IjYwMHB4IiBoZWlnaHQ9IjYwcHgiIHZpZXdCb3g9IjAgMCA2MDAgNjAiIHZlcnNpb249IjEuMSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiPgogICAgPCEtLSBHZW5lcmF0b3I6IFNrZXRjaCAzLjQgKDE1NTc1KSAtIGh0dHA6Ly93d3cuYm9oZW1pYW5jb2RpbmcuY29tL3NrZXRjaCAtLT4KICAgIDx0aXRsZT53YXRlci0xPC90aXRsZT4KICAgIDxkZXNjPkNyZWF0ZWQgd2l0aCBTa2V0Y2guPC9kZXNjPgogICAgPGRlZnM+PC9kZWZzPgogICAgPGcgaWQ9IuaIkSIgc3Ryb2tlPSJub25lIiBzdHJva2Utd2lkdGg9IjEiIGZpbGw9Im5vbmUiIGZpbGwtcnVsZT0iZXZlbm9kZCIgc2tldGNoOnR5cGU9Ik1TUGFnZSI+CiAgICAgICAgPGcgaWQ9Ii0iIHNrZXRjaDp0eXBlPSJNU0FydGJvYXJkR3JvdXAiIHRyYW5zZm9ybT0idHJhbnNsYXRlKC0xMjEuMDAwMDAwLCAtMTMzLjAwMDAwMCkiIGZpbGwtb3BhY2l0eT0iMC4zIiBmaWxsPSIjRkZGRkZGIj4KICAgICAgICAgICAgPGcgaWQ9IndhdGVyLTEiIHNrZXRjaDp0eXBlPSJNU0xheWVyR3JvdXAiIHRyYW5zZm9ybT0idHJhbnNsYXRlKDEyMS4wMDAwMDAsIDEzMy4wMDAwMDApIj4KICAgICAgICAgICAgICAgIDxwYXRoIGQ9Ik0wLDcuNjk4NTczOTUgTDQuNjcwNzE5NjJlLTE1LDYwIEw2MDAsNjAgTDYwMCw3LjM1MjMwNDYxIEM2MDAsNy4zNTIzMDQ2MSA0MzIuNzIxMDUyLDI0LjEwNjUxMzggMjkwLjQ4NDA0LDcuMzU2NzQxODcgQzE0OC4yNDcwMjcsLTkuMzkzMDMwMDggMCw3LjY5ODU3Mzk1IDAsNy42OTg1NzM5NSBaIiBpZD0iUGF0aC0xIiBza2V0Y2g6dHlwZT0iTVNTaGFwZUdyb3VwIj48L3BhdGg+CiAgICAgICAgICAgIDwvZz4KICAgICAgICA8L2c+CiAgICA8L2c+Cjwvc3ZnPg==")
    repeat-x;
  background-size: 300px;
  animation: wave-animation-1 4s infinite linear;
}

.water-2 {
  top: 70px;
  background: url("data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9Im5vIj8+Cjxzdmcgd2lkdGg9IjYwMHB4IiBoZWlnaHQ9IjYwcHgiIHZpZXdCb3g9IjAgMCA2MDAgNjAiIHZlcnNpb249IjEuMSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiPgogICAgPCEtLSBHZW5lcmF0b3I6IFNrZXRjaCAzLjQgKDE1NTc1KSAtIGh0dHA6Ly93d3cuYm9oZW1pYW5jb2RpbmcuY29tL3NrZXRjaCAtLT4KICAgIDx0aXRsZT53YXRlci0yPC90aXRsZT4KICAgIDxkZXNjPkNyZWF0ZWQgd2l0aCBTa2V0Y2guPC9kZXNjPgogICAgPGRlZnM+PC9kZWZzPgogICAgPGcgaWQ9IuaIkSIgc3Ryb2tlPSJub25lIiBzdHJva2Utd2lkdGg9IjEiIGZpbGw9Im5vbmUiIGZpbGwtcnVsZT0iZXZlbm9kZCIgc2tldGNoOnR5cGU9Ik1TUGFnZSI+CiAgICAgICAgPGcgaWQ9Ii0iIHNrZXRjaDp0eXBlPSJNU0FydGJvYXJkR3JvdXAiIHRyYW5zZm9ybT0idHJhbnNsYXRlKC0xMjEuMDAwMDAwLCAtMjQ2LjAwMDAwMCkiIGZpbGw9IiNGRkZGRkYiPgogICAgICAgICAgICA8ZyBpZD0id2F0ZXItMiIgc2tldGNoOnR5cGU9Ik1TTGF5ZXJHcm91cCIgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoMTIxLjAwMDAwMCwgMjQ2LjAwMDAwMCkiPgogICAgICAgICAgICAgICAgPHBhdGggZD0iTTAsNy42OTg1NzM5NSBMNC42NzA3MTk2MmUtMTUsNjAgTDYwMCw2MCBMNjAwLDcuMzUyMzA0NjEgQzYwMCw3LjM1MjMwNDYxIDQzMi43MjEwNTIsMjQuMTA2NTEzOCAyOTAuNDg0MDQsNy4zNTY3NDE4NyBDMTQ4LjI0NzAyNywtOS4zOTMwMzAwOCAwLDcuNjk4NTczOTUgMCw3LjY5ODU3Mzk1IFoiIGlkPSJQYXRoLTIiIHNrZXRjaDp0eXBlPSJNU1NoYXBlR3JvdXAiIHRyYW5zZm9ybT0idHJhbnNsYXRlKDMwMC4wMDAwMDAsIDMwLjAwMDAwMCkgc2NhbGUoLTEsIDEpIHRyYW5zbGF0ZSgtMzAwLjAwMDAwMCwgLTMwLjAwMDAwMCkgIj48L3BhdGg+CiAgICAgICAgICAgIDwvZz4KICAgICAgICA8L2c+CiAgICA8L2c+Cjwvc3ZnPg==")
    repeat-x;
  background-size: 500px;
  animation: wave-animation-2 5s infinite linear;
}

.water-1,
.water-2 {
  position: absolute;
  width: 100%;
  height: 60px;
}

.back-white {
  background: #faf8f8;
}

@keyframes wave-animation-1 {
  0% {
    background-position: 0 top;
  }

  100% {
    background-position: 600upx top;
  }
}

@keyframes wave-animation-2 {
  0% {
    background-position: 0 top;
  }

  100% {
    background-position: 600px top;
  }
}

.divider {
  background: rgba(255, 255, 255, 0.663);
  width: 70%;
  height: 5rpx;
  margin-top: 2px;
}

.depName {
  width: 70%;
  margin-top: 35%;
  font-size: 50px;
  text-align: center;
  font-family: 楷体;
  font-weight: 700;
  color: wheat;
}

.smallIntro {
  color: rgba(83, 81, 78, 0.767);
  width: 70%;
  margin-top: 5px;
  text-align: center;
}
.depText {
  width: 80%;
  padding: 10px;
  border: 1px solid #ccc;
  margin: auto;
  font-weight: 500;
  font-size: 18px;
  color: white;
  border-radius: 6px;
  line-height: 30px;
  margin-top: 10%;
  margin-bottom: 10%;
  background-color: rgba(250, 250, 250, 0.4);
}
</style>
