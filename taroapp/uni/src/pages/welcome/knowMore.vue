<template>
  <view class="IntroPic">这是一个介绍图</view>
  <br /><br /><br />
  <view class="KnowDep">
    <view class="DepBigBox">电协介绍</view>
    <view class="ali" id="First">
      <view class="DepBox">外联部</view>
      <br />
      <view class="DepBox">维修部</view>
      <br />
    </view>
    <br />
    <view class="ali" id="Second">
      <view class="DepBox">网宣部</view>
      <view class="DepBox">项目部</view>
    </view>
    <view class="ali" id="Third">
      <view class="DepBox">实践部</view>
      <view class="DepBox">秘书部</view>
    </view>

    <button class="DepZuBox" @click="GotoCoding">软件组</button>
  </view>
</template>

<script setup>
const GotoCoding = () => {
  uni.navigateTo({
    url: "depIntro?depId=1",
  });
};
</script>
<style>
.KnowDep {
  width: 90%;
  margin: auto;
}
.DepBox {
  width: 40%;
  height: 100px;
  text-align: center;
  margin: auto;
  background-color: rgb(255, 255, 255);
  border-radius: 1em;
  box-shadow: 1px 1px 13px 3px rgba(176, 179, 179, 0.329);
  display: flex;
  align-items: center;
  justify-content: center;
  transition: box-shadow 0.5s;
  transition: font-size 0.5s;
  font-size: 25px;
  font-family: 楷体;
  font-weight: 700;
  color: rgb(31, 91, 194);
}
.DepBigBox {
  width: 70%;
  height: 100px;
  text-align: center;
  margin: auto;
  background-color: rgb(255, 255, 255);
  border-radius: 1em;
  box-shadow: 1px 1px 13px 3px rgba(176, 179, 179, 0.329);
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
  width: 40%;
  height: 100px;
  text-align: center;
  margin-left: 5%;
  background-color: rgb(255, 255, 255);
  border-radius: 1em;
  box-shadow: 1px 1px 13px 3px rgba(176, 179, 179, 0.329);
  display: flex;
  align-items: center;
  justify-content: center;
  transition: box-shadow 0.5s;
  transition: font-size 0.5s;
  font-size: 25px;
  font-family: 楷体;
  font-weight: 700;
  color: rgb(31, 91, 194);
}
.ali {
  /* display: grid; */
  display: flex;
  justify-content: center;
  align-items: center;
  margin-bottom: 10%;
}
</style>
