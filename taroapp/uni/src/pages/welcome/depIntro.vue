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
            "·软件组衍生于贝尔组，致力于开发面向全校的项目和系统。软件组目前的方向有前端、后端、网络运维、小游戏开发，主要运用的语言有C/C++、javascript、java、go、C#、python等。已经开发的项目有gdutday、GDUTDays、电子科技协会论坛等。软件组始终坚持技术深耕，项目挖掘，致力于写出更优秀的代码以及实现更完美的业务。欢迎热爱coding的你加入我们！！！"
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
            "&nbsp&nbsp&nbsp 软件组衍生于贝尔组，致力于开发面向全校的项目和系统。软件组目前的方向有前端、后端、网络运维、小游戏开发，主要运用的语言有C/C++、javascript、java、go、C#、python等。已经开发的项目有gdutday、GDUTDays、电子科技协会论坛等。软件组始终坚持技术深耕，项目挖掘，致力于写出更优秀的代码以及实现更完美的业务。欢迎热爱coding的你加入我们！！！"
          );
          break;
        case "4":
          this.setFields(
            "网宣部",
            "代码，代码，还是代码",
            "&nbsp&nbsp&nbsp 软件组衍生于贝尔组，致力于开发面向全校的项目和系统。软件组目前的方向有前端、后端、网络运维、小游戏开发，主要运用的语言有C/C++、javascript、java、go、C#、python等。已经开发的项目有gdutday、GDUTDays、电子科技协会论坛等。软件组始终坚持技术深耕，项目挖掘，致力于写出更优秀的代码以及实现更完美的业务。欢迎热爱coding的你加入我们！！！"
          );
          break;
        case "5":
          this.setFields(
            "外联部",
            "代码，代码，还是代码",
            "&nbsp&nbsp&nbsp 软件组衍生于贝尔组，致力于开发面向全校的项目和系统。软件组目前的方向有前端、后端、网络运维、小游戏开发，主要运用的语言有C/C++、javascript、java、go、C#、python等。已经开发的项目有gdutday、GDUTDays、电子科技协会论坛等。软件组始终坚持技术深耕，项目挖掘，致力于写出更优秀的代码以及实现更完美的业务。欢迎热爱coding的你加入我们！！！"
          );
          break;
        case "6":
          this.setFields(
            "实践部",
            "代码，代码，还是代码",
            "&nbsp&nbsp&nbsp 软件组衍生于贝尔组，致力于开发面向全校的项目和系统。软件组目前的方向有前端、后端、网络运维、小游戏开发，主要运用的语言有C/C++、javascript、java、go、C#、python等。已经开发的项目有gdutday、GDUTDays、电子科技协会论坛等。软件组始终坚持技术深耕，项目挖掘，致力于写出更优秀的代码以及实现更完美的业务。欢迎热爱coding的你加入我们！！！"
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
  justify-content: center;
}

.gradient {
  height: 100vh;
  background: linear-gradient(-45deg, #ee7752, #df6493, #31aad5, #23d5ab);
  background-size: 600% 600%;
  display: flex;
  flex-direction: column;
  justify-content: center;
  animation: gradientBG 6s ease infinite;
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
  background: #3838375b;
  width: 70%;
  height: 5rpx;
  margin-top: 2px;
}

.depName {
  width: 70%;
  /* margin-top: 45%; */
  font-size: 50px;
  text-align: center;
  font-family: 楷体;
}

.smallIntro {
  color: rgba(83, 81, 78, 0.767);
  width: 70%;
  margin-top: 5px;
  text-align: center;
}
.depText {
  width: 70%;
  padding-left: 5%;
  padding-right: 5%;
  padding-top: 10px;
  padding-bottom: 10px;
  margin: auto;
  border: dotted 1px grey;
  font-family: 楷体;
  font-weight: 600;
  font-size: large;
  background-color: rgba(245, 245, 245, 0.6);
  border-radius: 6px;
  line-height: normal;
  margin-top: 10%;
}
</style>
