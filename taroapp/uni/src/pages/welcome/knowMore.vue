<template>
  <view class="IntroPic"
    ><img class="elcphoto" src="C:\Users\86139\Desktop\elcphoto.jpg" alt=""
  /></view>
  <br /><br /><br />
  <view class="KnowDep">
    <view class="DepBigBox">
      <img src="C:\Users\86139\Downloads\pcb.png" alt="" />
      电协介绍</view
    >
    <view class="ali" id="First">
      <view class="DepBox" @click="gotoCoding(5)">
        <img src="C:\Users\86139\Downloads\contact.png" alt="" />
        外联部</view
      >
      <br />
      <view class="DepBox" @click="gotoCoding(1)">
        <img src="C:\Users\86139\Downloads\repair.png" alt="" />
        维修部</view
      >
      <br />
    </view>
    <br />
    <view class="ali" id="Second">
      <view class="DepBox" @click="gotoCoding(4)">
        <img src="C:\Users\86139\Downloads\publicize.png" alt="" />
        网宣部</view
      >
      <view class="DepBox" @click="gotoCoding(3)">
        <img src="C:\Users\86139\Downloads\project.png" alt="" />
        项目部</view
      >
    </view>
    <view class="ali" id="Third">
      <view class="DepBox" @click="gotoCoding(6)">
        <img src="C:\Users\86139\Downloads\practice.png" alt="" />
        实践部</view
      >
      <view class="DepBox" @click="gotoCoding(2)">
        <img src="C:\Users\86139\Downloads\secretary.png" alt="" />
        秘书部</view
      >
    </view>

    <button class="DepZuBox" @click="gotoCoding(7)">
      <img src="C:\Users\86139\Downloads\coding.png" alt="" />
      软件组
    </button>
  </view>
</template>

<script setup>
const gotoCoding = (depId) => {
  uni.navigateTo({
    url: `depIntro?depId=${depId}`,
  });
};
</script>
<style>
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
  box-shadow: 1px 1px 13px 3px rgba(176, 179, 179, 0.329);
  display: flex;
  align-items: center;
  justify-content: center;
  transition: box-shadow 0.5s;
  font-size: 25px;
  font-family: 楷体;
  font-weight: 700;
  color: rgb(31, 91, 194);
}
.DepBigBox {
  width: 70%;
  height: 80px;
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
  width: 45%;
  height: 70px;
  text-align: center;
  margin-left: 2%;
  background-color: rgb(255, 255, 255);
  border-radius: 1em;
  box-shadow: 1px 1px 13px 3px rgba(176, 179, 179, 0.329);
  display: flex;
  align-items: center;
  justify-content: center;
  transition: font-size 0.5s;
  font-size: 25px;
  font-family: 楷体;
  font-weight: 700;
  color: rgb(31, 91, 194);
  margin-bottom: 50px;
}
.ali {
  /* display: grid; */
  display: flex;
  justify-content: center;
  align-items: center;
  margin-bottom: 10%;
}
</style>
