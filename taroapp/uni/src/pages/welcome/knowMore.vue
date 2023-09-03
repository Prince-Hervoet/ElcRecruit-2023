<template>
  <view class="knowMore-container">
    <view class="IntroPic">
      <img class="elcphoto" src="/static/cup.png" alt="" />
    </view>
    <br /><br /><br />
    <view class="KnowDep">
      <view class="DepBigBox" @click="clickNavDepInfo(0)">
        <img src="/static/pcb.png" alt="" />
        电协介绍
      </view>
      <view class="DepBigBox" @click="clickNavDepInfo(10)">
        <img src="/static/cup.png" alt="" />
        电协荣誉
      </view>
      <view class="ali" id="First">
        <view class="DepBox" @click="clickNavDepInfo(5)">
          <img src="/static/contact.png" alt="" />
          外联部
        </view>
        <br />
        <view class="DepBox" @click="clickNavDepInfo(1)">
          <img src="/static/repair.png" alt="" />
          维修部
        </view>
        <br />
      </view>
      <br />
      <view class="ali" id="Second">
        <view class="DepBox" @click="clickNavDepInfo(4)">
          <img src="/static/publicize.png" alt="" />
          网宣部
        </view>
        <view class="DepBox" @click="clickNavDepInfo(3)">
          <img src="/static/project.png" alt="" />
          项目部
        </view>
      </view>
      <view class="ali" id="Third">
        <view class="DepBox" @click="clickNavDepInfo(6)">
          <img src="/static/practice.png" alt="" />
          实践部
        </view>
        <view class="DepBox" @click="clickNavDepInfo(2)">
          <img src="/static/secretary.png" alt="" />
          秘书部
        </view>
      </view>

      <view class="ali" id="Third">
        <view class="DepBox" @click="clickNavDepInfo(7)">
          <img src="/static/coding.png" alt="" />
          软件组
        </view>
        <view class="DepBox" @click="clickNavDepInfo(2)" style="visibility: hidden">
          <img src="" alt="" />
          占位组
        </view>
      </view>
    </view>
  </view>
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
