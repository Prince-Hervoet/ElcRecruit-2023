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
import ReactLogo from "../../components/reactLogo/reactLogo";
import SearchFrame from "../../components/searchFrame/searchFrame";

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
        <div className="host-header-button-body">
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
              t="1689428918119"
              className="icon"
              viewBox="0 0 1024 1024"
              version="1.1"
              xmlns="http://www.w3.org/2000/svg"
              p-id="3261"
              width="32"
              height="32"
            >
              <path
                d="M679.6 958.1H127.8c-34.8 0-63-28.2-63-63V126.7c0-34.8 28.2-63 63-63h551.8c34.8 0 63 28.2 63 63v768.4c0 34.7-28.2 63-63 63z"
                fill="#01AA7A"
                p-id="3262"
              ></path>
              <path
                d="M772.8 576.7H264.4c-36.3 0-65.8-29.5-65.8-65.8s29.5-65.8 65.8-65.8h508.4c36.3 0 65.8 29.5 65.8 65.8s-29.5 65.8-65.8 65.8z"
                fill="#FFD301"
                p-id="3263"
              ></path>
              <path
                d="M933.9 460L699.7 231.5c-25.1-24.5-65.7-24.5-90.8 0-25.1 24.5-25.1 64.1 0 88.6l195.6 190.8-195.6 190.8c-25.1 24.5-25.1 64.1 0 88.6s65.7 24.5 90.8 0l234.2-228.5c14.3-13.9 20.4-32.7 18.4-50.9 2-18.2-4.1-37-18.4-50.9z"
                fill="#EA590A"
                p-id="3264"
              ></path>
            </svg>
          </div>
          <div className="host-header-flesh" onClick={clickOnRefresh}>
            <svg
              t="1689428968995"
              className="icon"
              viewBox="0 0 1024 1024"
              version="1.1"
              xmlns="http://www.w3.org/2000/svg"
              p-id="4571"
              width="32"
              height="32"
            >
              <path
                d="M512 0c282.7648 0 512 229.2352 512 512S794.7648 1024 512 1024 0 794.7648 0 512 229.2352 0 512 0z m257.3056 488.3584a38.4 38.4 0 0 0-41.024 35.5968c-8.0128 113.4208-102.6688 201.984-217.0496 201.984-59.136 0-114.368-23.6672-154.8928-64.768l-3.648-3.7888-2.9568-3.2384 28.8768-28.864 1.0624-1.2032a12.8 12.8 0 0 0-8.448-20.5312l-1.664-0.128h-109.9008l-1.4976 0.1024a12.8 12.8 0 0 0-11.2256 11.2128l-0.0768 1.4976v109.9008l0.0768 1.4848a12.8 12.8 0 0 0 20.5056 8.6784l1.2672-1.1136 26.6496-26.6624a293.6576 293.6576 0 0 0 215.872 94.2208c154.752 0 282.8032-119.808 293.6576-273.3696a38.4 38.4 0 0 0-35.584-41.0112z"
                fill="#6B57FE"
                p-id="4572"
              ></path>
              <path
                d="M510.1696 217.6c82.7904 0 160.128 34.4064 215.3728 93.6704l26.0864-26.112a12.8 12.8 0 0 1 21.76 7.5648l0.1024 1.4976v109.888a12.8 12.8 0 0 1-11.3152 12.7232l-1.4848 0.0768h-109.9008a12.8 12.8 0 0 1-10.112-20.6336l1.0624-1.216 29.4144-29.4272-2.432-2.6752A216.8576 216.8576 0 0 0 510.1696 294.4c-114.0992 0-208.6272 88.1664-216.9984 201.28a38.4 38.4 0 1 1-76.5824-5.6704C227.9168 336.8576 355.776 217.6 510.1696 217.6z"
                fill="#FFBA00"
                p-id="4573"
              ></path>
            </svg>
          </div>
          <div className="host-header-flesh" onClick={clickOnShowModalChart}>
            <svg
              t="1689429095810"
              className="icon"
              viewBox="0 0 1024 1024"
              version="1.1"
              xmlns="http://www.w3.org/2000/svg"
              p-id="7216"
              width="32"
              height="32"
            >
              <path
                d="M0 544c0 265.088 214.912 480 480 480 265.088 0 480-214.912 480-480H480V64C214.912 64 0 278.912 0 544z"
                fill="#3A5BA0"
                p-id="7217"
              ></path>
              <path
                d="M992 512H512V32c265.088 0 480 214.912 480 480z"
                fill="#FFA500"
                p-id="7218"
              ></path>
            </svg>
          </div>
        </div>
        <div className="host-header-search-frame-body">
          <SearchFrame></SearchFrame>
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
