import React, { useEffect, useState } from "react";
import "./dataHostLeftList.css";
import ReactLogo from "../reactLogo/reactLogo";
import { DepInfoArr } from "../../../store/global";
import { clickSendGetCards } from "../utilClick/util";
import GdataHostCardListStore from "../../../store/dataHostCardListStore";
import { DEFAULT_PAGE_LIMIT } from "../../../requests/util";

const leftListInfoArr = [
  { name: "总览表", id: 0 },
  { name: "调剂表", id: 100 },
  ...DepInfoArr,
];

export default function DataHostLeftList() {
  const [selectId, setSelectId] = useState(0);
  const clickSelect = (event) => {
    if (!event.target.id) return;
    const targetId = parseInt(event.target.id);
    GdataHostCardListStore.setCurrentDepId(targetId);
    setSelectId(targetId);
  };

  useEffect(() => {
    clickSendGetCards(selectId, 1, DEFAULT_PAGE_LIMIT);
  }, [selectId]);

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
