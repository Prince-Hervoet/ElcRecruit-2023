import React, { useEffect, useState } from "react";
import "./host.css";
import LeftList from "../../components/leftList/leftList";
import CardList from "../../components/cardsList/cardList";
import ColorFlag from "../../components/colorFlag/colorFlag";
import DataRequest from "../../requests/dataRequest";
import ModalChart from "../../components/modalChart/modalChart";
import rootStore from "../../store/rootStore";
import Checkin from "../../components/checkin/checkin";
import useThrottle from "../../hooks/throttle";
import { useNavigate } from "react-router-dom";
import LoginRequest from "../../requests/loginRequest";
import Bo from "./bo";
import ReactLogo from "../../components/reactLogo/reactLogo";

const { cardListStore, checkinListStore } = rootStore;

// 更新卡片列表的数据，响应式更新
async function updateCardList() {
  cardListStore.setCardList([
    {
      uid: "1",
      name: "张三",
      depId: "1",
      stuId: "3120007543",
      college: "1",
      major: "2",
      status: "10",
    },
    {
      uid: "1",
      name: "张三",
      depId: "1",
      stuId: "3120007543",
      college: "1",
      major: "2",
      status: "20",
    },
    {
      uid: "1",
      name: "张三",
      depId: "1",
      stuId: "3120007543",
      college: "1",
      major: "2",
      status: "30",
    },
    {
      uid: "1",
      name: "张三",
      depId: "1",
      stuId: "3120007543",
      college: "1",
      major: "2",
      status: "40",
    },
    {
      uid: "1",
      name: "张三",
      depId: "1",
      stuId: "3120007543",
      college: "1",
      major: "2",
      status: "50",
    },
    {
      uid: "1",
      name: "张三",
      depId: "1",
      stuId: "3120007543",
      college: "1",
      major: "2",
      status: "60",
    },
  ]);
}

// 更新签到列表的数据，响应式更新
async function updateCheckinList() {
  checkinListStore.setCheckinList([
    { userId: "123", name: "asdf", stuId: "3120003434" },
    { userId: "344", name: "asdf", stuId: "3120003434" },
    { userId: "545", name: "asdf", stuId: "3120003434" },
    { userId: "565", name: "asdf", stuId: "3120003434" },
  ]);
}

function clearData() {
  cardListStore.clear();
}

export default function Host() {
  const [isShowModalChart, setIsShowModalChart] = useState(false);

  useEffect(() => {
    // 判断是否登录了
    // (async function judge() {
    //   const res = await LoginRequest.judgeLoginStatus();
    //   if (res.code === 4000) {
    //     // 发起请求获取数据
    //   } else {
    //     clearData();
    //     goto("/login", { replace: true });
    //   }
    // })();
  }, []);

  const goto = useNavigate();
  // 点击显示图表
  const clickOnShowModalChart = () => {
    setIsShowModalChart(true);
  };

  // 点击刷新数据
  const clickOnRefresh = useThrottle(() => {
    // DataRequest.getBriefInfosByDepId();
    updateCardList();
    updateCheckinList();
    console.log("触发了");
  }, 1000);

  // 点击注销用户
  const clickOnExitMe = () => {
    localStorage.removeItem("token");
    clearData();
    goto("/login", { replace: true });
  };

  const clickOnChangeTheme = () => {
    const cl = document.getElementById("hostPage").classList;
    if (cl.contains("host-dark-theme")) {
      cl.remove("host-dark-theme");
    } else {
      cl.add("host-dark-theme");
    }
  };

  return (
    <div className="host-page" id="hostPage">
      <div className="host-header">
        <div className="colorful-egg" onClick={clickOnChangeTheme}>
          <svg
            t="1687797384911"
            className="icon"
            viewBox="0 0 1024 1024"
            version="1.1"
            xmlns="http://www.w3.org/2000/svg"
            p-id="10284"
            width="36"
            height="36"
          >
            <path
              d="M512 102.4a410.0096 410.0096 0 0 1 409.6 409.6 409.6 409.6 0 1 1-409.6-409.6zM266.8544 266.8544A346.624 346.624 0 0 0 512 858.5728 347.0336 347.0336 0 0 0 858.5728 512 346.624 346.624 0 0 0 266.8544 266.8544z m290.816 260.7616l152.9344 2.56 38.2464 0.6656 19.0976 0.3584h9.6256a34.4576 34.4576 0 0 1 9.0112 0.9216c12.032 3.2768 19.456 15.3088 17.152 27.5456-2.048 12.7488-5.0176 25.2928-8.8064 37.632a291.328 291.328 0 0 1-40.2944 85.8112c-3.072 5.376-7.0656 10.24-11.776 14.336a24.8832 24.8832 0 0 1-17.7152 4.0448 28.3136 28.3136 0 0 1-12.6464-5.632l-3.4304-3.2256-56.832-51.2512-28.3136-25.6512-1.536-1.28-1.6384-1.024-0.512-0.3072h-3.328l-0.5632 0.1536-0.512 0.2048-0.4608 0.3072-0.7168 0.512-0.4096 0.3072-0.3584 0.512-0.6144 1.024-0.256 0.512v4.352l0.1024-0.1536c0.1536 0.7168 0.3072 0.8704 0.512 1.024l0.4096 0.5632v0.3072l3.2256 3.4816 4.1472 4.7104 4.352 4.7616 51.2512 56.9856 12.8 14.2336a38.2976 38.2976 0 0 1 10.5984 15.3088 24.6272 24.6272 0 0 1-6.912 25.4976 93.184 93.184 0 0 1-7.5264 5.888 293.3248 293.3248 0 0 1-122.368 49.7664 50.176 50.176 0 0 1-9.216 0.9216 23.552 23.552 0 0 1-22.3744-18.432l-0.5632-4.4544v-9.5232l-0.6656-38.2976-1.28-76.5952-1.3824-76.6464-0.3584-19.0976a54.0672 54.0672 0 0 1 0-8.9088 29.4912 29.4912 0 0 1 29.9008-24.7296z m-90.9824 0l4.4032 0.1536a29.4912 29.4912 0 0 1 24.7296 29.696l-2.5088 152.9856-0.6656 38.2464-0.3072 19.0976v9.5744a31.488 31.488 0 0 1-0.9728 8.96 23.552 23.552 0 0 1-27.648 17.408 276.992 276.992 0 0 1-37.1712-7.9872 290.3552 290.3552 0 0 1-69.8368-30.464 327.424 327.424 0 0 1-16.0768-10.24 55.808 55.808 0 0 1-14.2848-11.776 25.088 25.088 0 0 1-4.096-17.664 28.3648 28.3648 0 0 1 8.8576-16.1792l51.3024-57.088 25.6-28.416a15.36 15.36 0 0 0 2.304-3.1744v-2.6624a3.84 3.84 0 0 0 0-1.1776 6.144 6.144 0 0 0-0.256-1.1264l-0.3584-0.3584-0.256-0.4096-0.512-0.768-0.4608-0.3584-1.024-0.6144-0.512-0.256h-4.4544v0.1024c-0.6144 0.1536-0.8192 0.3072-1.024 0.512l-0.768 0.512-3.584 3.1744c-3.072 2.56-6.1952 5.632-9.4208 8.448l-56.832 51.2-14.1824 12.8a38.7072 38.7072 0 0 1-15.3088 10.5984 24.9856 24.9856 0 0 1-25.4976-6.912c-2.2528-2.2528-3.9424-5.0176-5.888-7.5264a290.1504 290.1504 0 0 1-49.664-122.4192 50.3808 50.3808 0 0 1-1.1264-9.1136 23.552 23.552 0 0 1 22.9376-22.9376h9.5744l38.2464-0.6656 76.5952-1.28 76.6464-1.3824 19.0464-0.3584c2.9696-0.2048 5.9392-0.2048 8.8576 0zM469.504 219.136a23.552 23.552 0 0 1 22.6304 19.968l0.3072 2.9696v9.5744l0.7168 38.2464 1.28 76.5952 1.3824 76.6464v19.0464c0.2048 2.9696 0.2048 5.9392 0 8.8576a29.4912 29.4912 0 0 1-24.832 24.4224l-4.9152 0.3584-153.1904-2.56-38.2464-0.6656-19.0976-0.3072h-9.5744a31.8976 31.8976 0 0 1-9.0112-0.9728 23.9104 23.9104 0 0 1-17.2032-27.5968 276.992 276.992 0 0 1 7.8336-37.2224 292.5568 292.5568 0 0 1 40.6016-85.9136c3.2256-5.4272 7.2704-10.24 12.0832-14.2848a25.088 25.088 0 0 1 30.3616 1.536l3.4304 3.2256 56.832 51.3024 28.3648 25.6 1.536 1.2288 1.6384 1.0752h2.6624l0.6144 0.0512h0.5632l1.024-0.3072 0.8192-0.3584 0.3072-0.256 0.6656-0.512L409.6 408.5248l0.3072-0.512 0.512-1.024v-2.2016l0.0512-0.7168v-1.536h0.4096v-0.4608l-0.512-0.5632-0.4608-0.512-0.0512-0.3584-3.1744-3.5328-4.096-4.6592-4.352-4.7616-51.2-56.832-12.8512-14.1824a39.936 39.936 0 0 1-10.5984-15.36 24.9856 24.9856 0 0 1 6.9632-25.4976c2.2016-2.2016 5.0176-3.9424 7.5264-5.888a290.9184 290.9184 0 0 1 122.368-49.664c3.0208-0.6144 6.0928-0.9216 9.216-1.024z m85.504 0.2048l4.608 0.4096c12.5952 1.7408 24.9856 4.352 37.2224 7.8336a292.9664 292.9664 0 0 1 86.2208 40.5504c5.376 3.1744 10.24 7.2704 14.336 12.0832a25.088 25.088 0 0 1-1.5872 30.3616l-3.2256 3.4304-51.2512 56.832-25.6512 28.3648a15.104 15.104 0 0 0-2.304 3.1744l-0.1536 0.256-0.1536 0.3072v3.2768l0.1536 0.512 0.2048 0.512a2.56 2.56 0 0 0 0.6656 1.0752l0.2048 0.4096 0.256 0.3584 0.512 0.4096 0.512 0.3072 1.024 0.512h2.1504l0.7168 0.0512H621.0048l-0.1536-0.1536h0.512l0.512-0.4608 0.512-0.256 0.3584-0.256 3.4816-3.1744 9.472-8.448 56.832-50.944 14.2336-12.8a39.5264 39.5264 0 0 1 15.36-10.6496 25.088 25.088 0 0 1 25.4976 6.9632c2.048 2.4064 4.096 4.9152 5.888 7.5264a290.2016 290.2016 0 0 1 49.8688 122.368c0.5632 3.072 0.9216 6.144 0.9216 9.216a23.552 23.552 0 0 1-19.968 22.6304l-2.9184 0.256h-9.5232l-38.2976 0.7168-76.5952 1.3312-76.6464 1.3312h-19.0976a54.4768 54.4768 0 0 1-8.9088 0 29.4912 29.4912 0 0 1-24.4224-24.576l-0.3072-4.9152 2.56-153.1904 0.6656-38.1952 0.3584-19.1488v-9.5744a34.2016 34.2016 0 0 1 0.9216-9.0112 24.0128 24.0128 0 0 1 18.5344-17.2032l4.4544-0.4096z"
              fill="#6B57FE"
              p-id="10285"
            ></path>
          </svg>
        </div>
        <div className="host-header-flesh" onClick={clickOnExitMe}>
          <svg
            t="1688565220937"
            className="icon"
            viewBox="0 0 1024 1024"
            version="1.1"
            xmlns="http://www.w3.org/2000/svg"
            p-id="2856"
            width="32"
            height="32"
          >
            <path
              d="M833.3 856.7h-40.9 16.2c13.8-0.8 24.7-12.2 24.7-26.2v26.2zM150.6 856.7h40.9-16.2c-13.8-0.8-24.7-12.2-24.7-26.2v26.2zM833.3 175.4h-40.9 16.2c13.8 0.8 24.7 12.2 24.7 26.2v-26.2zM150.6 175.4h40.9-16.2c-13.8 0.8-24.7 12.2-24.7 26.2v-26.2zM323 512c0 22.6 18.3 41 41 41h549.6c22.6 0 41-18.3 41-41 0-22.6-18.3-41-41-41H363.9c-22.6 0-40.9 18.4-40.9 41z"
              fill="#bfbfbf"
              p-id="2857"
            ></path>
            <path
              d="M711.3 309.8c-16 16-16 41.9 0 57.9L884.5 541c16 16 41.9 16 57.9 0s16-41.9 0-57.9L769.2 309.8c-16-16-42-16-57.9 0z"
              fill="#bfbfbf"
              p-id="2858"
            ></path>
            <path
              d="M711.3 714.2c16 16 41.9 16 57.9 0L942.4 541c16-16 16-41.9 0-57.9s-41.9-16-57.9 0L711.3 656.3c-16 16-16 41.9 0 57.9z"
              fill="#bfbfbf"
              p-id="2859"
            ></path>
            <path
              d="M874 728.9c-22.6 0-41 18.3-41 41v86.2H150.8V175.5h682.3v86.2c0 22.6 18.3 41 41 41s41-18.3 41-41v-45.3h-0.4v-53.1-1.4c0-37.6-30.5-68.1-68.1-68.1h-0.5v-0.1H792v-0.1H191.3v0.1h-54.1v0.1h-0.5c-35.6 0-64.9 27.4-67.8 62.3v720.3c3.5 34.3 32.5 61.2 67.7 61.2h0.5v0.1h54.1v0.4h600.7v-0.4H846v-0.1h0.5c37.6 0 68.1-30.5 68.1-68.1V815h0.3v-45c0.1-22.7-18.3-41.1-40.9-41.1z"
              fill="#bfbfbf"
              p-id="2860"
            ></path>
          </svg>
        </div>
        <div className="host-header-flesh" onClick={clickOnRefresh}>
          <svg
            t="1688568987852"
            className="icon"
            viewBox="0 0 1024 1024"
            version="1.1"
            xmlns="http://www.w3.org/2000/svg"
            p-id="6895"
            width="32"
            height="32"
          >
            <path
              d="M512 85.333333c98.922667 0 192.554667 33.856 267.434667 94.186667l53.461333-53.482667 85.76 241.664-241.664-85.76 41.664-41.642666A339.818667 339.818667 0 0 0 512 170.666667C323.477333 170.666667 170.666667 323.477333 170.666667 512s152.810667 341.333333 341.333333 341.333333a340.053333 340.053333 0 0 0 241.365333-99.968 339.989333 339.989333 0 0 0 99.84-232.490666L853.333333 512h85.333334a425.386667 425.386667 0 0 1-124.970667 301.696A425.386667 425.386667 0 0 1 512 938.666667C276.352 938.666667 85.333333 747.648 85.333333 512S276.352 85.333333 512 85.333333z"
              fill="#bfbfbf"
              p-id="6896"
            ></path>
          </svg>
        </div>
        <div className="host-header-flesh" onClick={clickOnShowModalChart}>
          <svg
            t="1688565368148"
            className="icon"
            viewBox="0 0 1024 1024"
            version="1.1"
            xmlns="http://www.w3.org/2000/svg"
            p-id="5159"
            width="32"
            height="32"
          >
            <path
              d="M569.7 96l-0.1 81.9c185.9 14.9 332.2 170.7 332.2 360.4 0 199.6-161.8 361.3-361.3 361.3-186.1 0-339.4-140.7-359.2-321.6H99c20.1 226.2 210.1 403.5 441.5 403.5 244.8 0 443.2-198.4 443.2-443.2 0-235-182.8-427.3-414-442.3zM123.2 470c0.6-193.3 152.9-350.9 344.1-359.8v-82c-236.5 9-425.5 203.3-426 441.8h81.9z"
              fill="#bfbfbf"
              p-id="5160"
            ></path>
            <path
              d="M139.9 577.9m-40.9 0a40.9 40.9 0 1 0 81.8 0 40.9 40.9 0 1 0-81.8 0Z"
              fill="#bfbfbf"
              p-id="5161"
            ></path>
            <path
              d="M569.6 136.9m-40.9 0a40.9 40.9 0 1 0 81.8 0 40.9 40.9 0 1 0-81.8 0Z"
              fill="#bfbfbf"
              p-id="5162"
            ></path>
            <path
              d="M41.4 470c0 22.6 18.3 41 41 41H471c22.6 0 41-18.3 41-41 0-22.6-18.3-41-41-41H82.4c-22.6 0.1-41 18.4-41 41z"
              fill="#bfbfbf"
              p-id="5163"
            ></path>
            <path
              d="M471 28.2c-22.6 0-41 18.3-41 41V470c0 22.6 18.3 41 41 41 22.6 0 41-18.3 41-41V69.2c0-22.6-18.3-41-41-41z"
              fill="#bfbfbf"
              p-id="5164"
            ></path>
          </svg>
        </div>
      </div>
      <div className="host-body">
        <div className="host-body-left">
          <div className="host-left-list-div">
            <div className="host-react-logo-body">
              <ReactLogo></ReactLogo>
            </div>
            <LeftList></LeftList>
          </div>
        </div>
        <div className="host-body-middle">
          <div className="host-cards-body">
            <CardList></CardList>
          </div>
          <div className="host-color-flag">
            <div>
              <ColorFlag color={"red"} text={"已淘汰"}></ColorFlag>
            </div>
            <div>
              <ColorFlag color={"green"} text={"已通过"}></ColorFlag>
            </div>
            <div>
              <ColorFlag color={"orange"} text={"已报名"}></ColorFlag>
            </div>
            <div>
              <ColorFlag color={"blue"} text={"已签到"}></ColorFlag>
            </div>
            <div>
              <ColorFlag color={"purple"} text={"面试中"}></ColorFlag>
            </div>
            <div>
              <ColorFlag color={"cyan"} text={"待定中"}></ColorFlag>
            </div>
          </div>
        </div>
        <div className="host-body-right">
          <Checkin></Checkin>
        </div>
      </div>
      <div
        className="host-modal-chart-body"
        style={isShowModalChart ? { display: "block" } : { display: "none" }}
      >
        <ModalChart
          clickOnSpace={() => {
            setIsShowModalChart(false);
          }}
        ></ModalChart>
      </div>
    </div>
  );
}
