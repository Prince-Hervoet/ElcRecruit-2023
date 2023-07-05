import React, { useCallback, useState } from "react";
import "./leftList.css";
import DataRequest from "../../requests/dataRequest";
import rootStore from "../../store/rootStore";

const { cardListStore } = rootStore;

const depList = [
  { key: 0, value: "总览表", depId: 0 },
  { key: 1, value: "调剂区", depId: 10 },
  { key: 2, value: "维修部", depId: 1 },
  { key: 3, value: "秘书部", depId: 2 },
  { key: 4, value: "项目部", depId: 3 },
  { key: 5, value: "网宣部", depId: 4 },
  { key: 6, value: "外联部", depId: 5 },
  { key: 7, value: "实践部", depId: 6 },
  { key: 8, value: "软件组", depId: 7 },
];

async function updateCardList(depId) {
  cardListStore.setIsLoading(true);
  // const res = await DataRequest.getBriefInfosByDepId(depId, 1, 6);
  // setTimeout(() => {
  //   cardListStore.setIsLoading(false);
  // }, 3000);
  cardListStore.setCardList();
  cardListStore.setIsLoading(false);
  // studentStore.setStudents(nStudents);
}

export default function LeftList() {
  const [select, setSelect] = useState(-1);

  // 选中
  const clickOnSelect = (event) => {
    // 更新当前视图
    const id = event.target.id;
    setSelect(id);
    const dep = depList[id];
    const depId = dep.depId;
    // 更新卡片列表
    updateCardList(depId);
  };

  return (
    <div
      style={{ width: "100%", height: "100%" }}
      className="left-list-body"
      onClick={clickOnSelect}
    >
      {depList.map((value, index) => {
        if (select === index + "") {
          return (
            <li
              key={value.key}
              id={index}
              style={{
                backgroundColor: "rgb(106, 90, 205)",
                color: "white",
                borderRadius: 6,
              }}
            >
              {value.value}
            </li>
          );
        }
        return (
          <li key={value.key} id={index}>
            {value.value}
          </li>
        );
      })}
    </div>
  );
}
