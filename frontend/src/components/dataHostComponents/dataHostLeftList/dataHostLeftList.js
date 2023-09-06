import React, { useState } from "react";
import "./dataHostLeftList.css";
import ReactLogo from "../reactLogo/reactLogo";
import { DepInfoArr } from "../../../store/global";
import { sendGetCards } from "../util/util";
import dataHostCardListStore from "../../../store/dataHostCardListStore";

const leftListInfoArr = [
  { name: "总览表", id: 0 },
  { name: "调剂表", id: 100 },
  ...DepInfoArr,
];

export default function DataHostLeftList() {
  const [selectId, setSelectId] = useState(0);
  const clickSelect = (event) => {
    const target = event.target;
    const targetId = parseInt(target.id);
    setSelectId(targetId);
    dataHostCardListStore.setCurrentDepId(targetId);

    // todo: 发送网络请求
    sendGetCards();
  };

  return (
    <div className="dataHost-left-list-body">
      <div className="dataHost-left-list-logo-body">
        <ReactLogo></ReactLogo>
      </div>

      {leftListInfoArr.map((value) => {
        return (
          <div
            className={
              selectId === value.id
                ? "dataHost-left-list-card-body dataHost-left-list-card-select"
                : "dataHost-left-list-card-body"
            }
            onClick={clickSelect}
            id={value.id}
            key={value.id}
          >
            <div>{value.name}</div>
          </div>
        );
      })}
    </div>
  );
}
