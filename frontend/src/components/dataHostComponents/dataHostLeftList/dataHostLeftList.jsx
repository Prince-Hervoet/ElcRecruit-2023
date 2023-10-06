import React, { useEffect, useState } from "react";
import "./dataHostLeftList.css";
import ReactLogo from "../reactLogo/reactLogo";
import { DepInfoArr } from "../../../store/global";
import { clickSendGetCards } from "../utilClick/util";
import GdataHostCardListStore from "../../../store/dataHostCardListStore";
import { DEFAULT_PAGE_LIMIT } from "../../../requests/util";

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

  const defaultClassName = "dataHost-left-list-card-body";
  const selectClassName =
    "dataHost-left-list-card-body dataHost-left-list-card-select";

  const content = DepInfoArr.map((value) => {
    return (
      <div
        className={selectId === value.id ? selectClassName : defaultClassName}
        id={value.id}
        key={value.id}
        onClick={clickSelect}
      >
        <div>{value.name}</div>
      </div>
    );
  });

  return (
    <div className="dataHost-left-list-body">
      <div className="dataHost-left-list-logo-body">
        <ReactLogo></ReactLogo>
      </div>
      {content}
    </div>
  );
}
