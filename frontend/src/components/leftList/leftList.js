import React, { useCallback, useState } from "react";
import "./leftList.css";
import DataRequest from "../../requests/dataRequest";
import rootStore from "../../store/rootStore";

const { cardListStore } = rootStore;

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

async function updateCardList() {
  cardListStore.setIsLoading(true);
  // const res = await DataRequest.getDepartmentSizeById();
  // const nStudents = JSON.parse(res.data);
  setTimeout(() => {
    cardListStore.setIsLoading(false);
  }, 3000);

  // studentStore.setStudents(nStudents);
}

export default function LeftList({ values }) {
  const [select, setSelect] = useState(-1);

  // 选中
  const clickOnSelect = useCallback((event) => {
    // 更新当前视图
    setSelect(event.target.id);
    // 更新卡片列表
    updateCardList();
  }, []);

  return (
    <div
      style={{ width: "100%", height: "100%" }}
      className="left-list-body"
      onClick={clickOnSelect}
    >
      {leftListArray.map((value, index) => {
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
