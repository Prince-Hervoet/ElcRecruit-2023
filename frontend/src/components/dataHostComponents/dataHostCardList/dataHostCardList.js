import React, { useEffect } from "react";
import "./dataHostCardList.css";
import DataHostCard from "../dataHostCard/dataHostCard";
import { Empty, Skeleton } from "antd";
import { observer } from "mobx-react-lite";
import DataHostPagination from "../dataHostPagination/dataHostPagination";
import GdataHostCardListStore from "../../../store/dataHostCardListStore";
import { DEFAULT_PAGE_LIMIT } from "../../../requests/util";

const DataHostCardList = () => {
  const { cardList, total, pageCount, isLoading } = GdataHostCardListStore;

  let showContent = <></>;
  if (isLoading) {
    showContent = <Skeleton></Skeleton>;
  } else {
    const cardListSlice = cardList.slice();
    showContent =
      cardListSlice.length === 0 ? (
        <Empty></Empty>
      ) : (
        cardListSlice.map((value) => {
          const info = { ...value };
          return (
            <div key={value.id}>
              <DataHostCard info={info}></DataHostCard>
            </div>
          );
        })
      );
  }

  return (
    <div className="dataHostCardList-body">
      {showContent}
      <DataHostPagination
        info={{ total, pageSize: DEFAULT_PAGE_LIMIT, current: pageCount }}
      ></DataHostPagination>
    </div>
  );
};

export default observer(DataHostCardList);
