<template>
  <view class="try">
    <view class="depBigBox">
      <view class="depName">软件组</view>
      <view class="divider" />
      <view class="smallIntro">代码，代码，还是代码</view>
      <view class="depText">
        &nbsp&nbsp&nbsp 软件组衍生于贝尔组，致力于开发面向全校的项目和系统。
        软件组目前的方向有前端、后端、网络运维、小游戏开发，主要运用的语言有C/C++、javascript、java、go、C#、python等。
        已经开发的项目有gdutday、GDUTDays、电子科技协会论坛等。
        软件组始终坚持技术深耕，项目挖掘，致力于写出更优秀的代码以及实现更完美的业务。
        欢迎热爱coding的你加入我们！！！
      </view>
    </view>
    <view class="wave"> </view>
  </view>
</template>

<style scoped>
.divider {
  background: #3838375b;
  width: 70%;
  height: 5rpx;
  margin-top: 2px;
}
.try {
  height: 100vh;
  background-image: url("https://s1.ax1x.com/2023/08/30/pPwK0Ff.jpg");
  background-size: cover;
}
.depBigBox {
  padding-top: 80px;
  height: 350px;
}
.depName {
  margin-top: 35%;
  margin-left: 10%;
  font-size: 50px;
  font-family: 楷体;
}

.smallIntro {
  color: rgba(83, 81, 78, 0.767);
  margin-top: 5px;
  margin-left: 10%;
}
.depText {
  width: 70%;
  height: 200px;
  padding-left: 5%;
  padding-right: 5%;
  padding-top: 10px;
  padding-bottom: 10px;
  margin: auto;
  border: dotted 1px grey;
  font-family: 楷体;
  background-color: #fff;
  margin-top: 10%;
}

/* .wave {
  width: 100%;
  height: 200px;
  position: fixed;
  z-index: -1;
  bottom: 0;
  right: 0;
  pointer-events: none;
  --c: blue;
  --w1: radial-gradient(100% 57% at top, #0000 100%, var(--c) 100.5%) no-repeat;
  --w2: radial-gradient(100% 57% at bottom, var(--c) 100%, #0000 100.5%)  
    no-repeat;
  background: var(--w1), var(--w2), var(--w1), var(--w2);
  background-position-x: -200%, -100%, 0%, 100%;
  background-position-y: 100%;
  background-size: 50.5% 100%;
  animation: m 3s infinite linear;
  opacity: 0.6;
}

@keyframes m {
  0% {
    background-position-x: -200%, -100%, 0%, 100%;
  }
  100% {
    background-position-x: 0%, 100%, 200%, 300%;
  }
} */
</style>
