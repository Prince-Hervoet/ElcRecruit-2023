import React, { useState } from "react";
import "./dataHostLeftList.css";
import ReactLogo from "../reactLogo/reactLogo";
import { DepInfoArr } from "../../../store/globalInfo";

const leftListInfoArr = [
  { name: "总览表", id: 0 },
  { name: "调剂表", id: 100 },
  ...DepInfoArr,
];

export default function DataHostLeftList() {
  const [selectId, setSelectId] = useState(0);

  const clickSelect = (event) => {
    const target = event.target;
    setSelectId(parseInt(target.id));
  };

  return (
    <div className="dataHost-left-list-body">
      <div className="dataHost-left-list-logo-body">
        <ReactLogo></ReactLogo>
      </div>

      {leftListInfoArr.map((value) => {
        let classNameStr = "dataHost-left-list-card-body";
        if (selectId === value.id) {
          classNameStr += " dataHost-left-list-card-select";
        }
        return (
          <div
            className={classNameStr}
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
