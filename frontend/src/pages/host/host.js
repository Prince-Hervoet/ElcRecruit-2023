import React from "react";
import "./host.css";
import LeftList from "../../components/leftList/leftList";
import Empty from "../../components/empty/empty";
import CardsList from "../../components/cardsList/cardsList";
import ColorFlag from "../../components/colorFlag/colorFlag";

const leftListArray = [
  { key: 0, value: "总览表" },
  { key: 1, value: "调剂区" },
  { key: 2, value: "维修部" },
  { key: 3, value: "秘书部" },
  { key: 4, value: "项目部" },
  { key: 5, value: "网宣部" },
  { key: 6, value: "外联部" },
  { key: 7, value: "实践部" },
  { key: 8, value: "软件组" },
];

export default function Host() {
  return (
    <div className="host-page">
      <div className="host-header">
        <div className="host-header-flesh">
          <svg
            t="1687627764833"
            class="icon"
            viewBox="0 0 1024 1024"
            version="1.1"
            xmlns="http://www.w3.org/2000/svg"
            p-id="21268"
            width="32"
            height="32"
          >
            <path
              d="M657.408 960h-460.8c-50.688 0-92.16-41.472-92.16-92.16v-711.68c0-50.688 41.472-92.16 92.16-92.16h460.8c50.688 0 92.16 41.472 92.16 92.16V271.36h-61.44V156.16c0-16.896-13.824-30.72-30.72-30.72h-460.8c-16.896 0-30.72 13.824-30.72 30.72v711.68c0 16.896 13.824 30.72 30.72 30.72h460.8c16.896 0 30.72-13.824 30.72-30.72v-101.376h61.44v101.376c0 50.688-41.472 92.16-92.16 92.16z"
              p-id="21269"
              fill="#707070"
            ></path>
            <path
              d="M888.832 542.72h-481.28c-16.896 0-30.72-13.824-30.72-30.72s13.824-30.72 30.72-30.72h481.28c16.896 0 30.72 13.824 30.72 30.72s-13.824 30.72-30.72 30.72z"
              p-id="21270"
              fill="#707070"
            ></path>
            <path
              d="M867.328 534.016l-137.728-137.728c-11.776-11.776-11.776-31.744 0-43.52s31.744-11.776 43.52 0l137.728 137.728c11.776 11.776 11.776 31.744 0 43.52-12.288 11.776-31.744 11.776-43.52 0z"
              p-id="21271"
              fill="#707070"
            ></path>
            <path
              d="M867.328 490.496l-137.728 137.728c-11.776 11.776-11.776 31.744 0 43.52s31.744 11.776 43.52 0l137.728-137.728c11.776-11.776 11.776-31.744 0-43.52-12.288-11.776-31.744-11.776-43.52 0z"
              p-id="21272"
              fill="#707070"
            ></path>
            <path
              d="M718.848 271.36m-30.72 0a30.72 30.72 0 1 0 61.44 0 30.72 30.72 0 1 0-61.44 0Z"
              p-id="21273"
              fill="#707070"
            ></path>
            <path
              d="M718.848 767.488m-30.72 0a30.72 30.72 0 1 0 61.44 0 30.72 30.72 0 1 0-61.44 0Z"
              p-id="21274"
              fill="#707070"
            ></path>
          </svg>
        </div>
        <div className="host-header-flesh">
          <svg
            t="1687627328808"
            class="icon"
            viewBox="0 0 1024 1024"
            version="1.1"
            xmlns="http://www.w3.org/2000/svg"
            p-id="19555"
            width="32"
            height="32"
          >
            <path
              d="M395.776 641.664a19.392 19.392 0 0 0-6.368-12.384l-36.672-32.416a190.496 190.496 0 0 1 87.328-70.88c47.52-19.2 99.776-18.72 146.944 1.28s83.776 57.28 103.008 104.8a31.936 31.936 0 0 0 41.632 17.696 31.936 31.936 0 0 0 17.696-41.632 254.208 254.208 0 0 0-137.312-139.776 254.56 254.56 0 0 0-195.936-1.728 253.984 253.984 0 0 0-111.552 87.616l-37.408-33.088a19.168 19.168 0 0 0-31.808 16.384l12.576 119.68a19.2 19.2 0 0 0 21.088 17.088l109.696-11.52a19.2 19.2 0 0 0 17.088-21.12zM757.92 729.088l-109.216 15.36a19.2 19.2 0 0 0-9.536 33.856l34.496 28.416a190.816 190.816 0 0 1-236.672 74.016 190.592 190.592 0 0 1-102.976-104.768 32 32 0 1 0-59.36 23.936 254.272 254.272 0 0 0 137.344 139.776 255.232 255.232 0 0 0 100 20.48 255.744 255.744 0 0 0 95.904-18.752 254.592 254.592 0 0 0 115.872-93.408l41.408 34.112a19.2 19.2 0 0 0 31.2-17.472l-16.736-119.168a19.264 19.264 0 0 0-21.728-16.384z"
              p-id="19556"
              fill="#707070"
            ></path>
            <path
              d="M808.192 262.592a320.16 320.16 0 0 0-592.352 0A238.592 238.592 0 0 0 32 496a240.32 240.32 0 0 0 130.976 213.888 32 32 0 1 0 29.12-57.024A176.192 176.192 0 0 1 96 496a175.04 175.04 0 0 1 148.48-173.888l19.04-2.976 6.24-18.24C305.248 197.472 402.592 128 512 128a256 256 0 0 1 242.208 172.896l6.272 18.24 19.04 2.976A175.04 175.04 0 0 1 928 496a176.128 176.128 0 0 1-96.128 156.896 32.064 32.064 0 0 0 29.12 57.024A240.416 240.416 0 0 0 992 496a238.592 238.592 0 0 0-183.808-233.408z"
              p-id="19557"
              fill="#707070"
            ></path>
          </svg>
        </div>
      </div>
      <div className="host-body">
        <div className="host-body-left">
          <div className="host-left-list-div">
            <LeftList values={leftListArray}></LeftList>
          </div>
        </div>
        <div className="host-body-middle">
          <div className="host-cards-body">
            <CardsList></CardsList>
          </div>
          <div className="host-color-flag">
            <div>
              <ColorFlag color={"red"} text={"已淘汰"}></ColorFlag>
            </div>
            <div>
              <ColorFlag color={"green"} text={"已通过"}></ColorFlag>
            </div>
            <div>
              <ColorFlag color={"yellow"} text={"已报名"}></ColorFlag>
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
          <div
            style={{
              height: "5%",
              fontSize: "larger",
              fontWeight: 700,
              textAlign: "center",
              borderBottom: "1px solid #ccc",
              display: "flex",
              alignItems: "center",
              justifyContent: "center",
            }}
          >
            签到列表
          </div>
          <div
            style={{
              height: "95%",
            }}
          >
            <div
              style={{
                width: "100%",
                height: "100%",
                display: "flex",
                alignItems: "center",
                justifyContent: "center",
              }}
            >
              <Empty></Empty>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}
