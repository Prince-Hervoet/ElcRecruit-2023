import React, { useEffect } from "react";
import "./dataHostCardList.css";
import DataHostCard from "../dataHostCard/dataHostCard";
import rootStore from "../../../store/rootStore";
import { Empty } from "antd";
import { observer } from "mobx-react-lite";
import DataHostPagination from "../dataHostPagination/dataHostPagination";

const { dataHostCardListStore } = rootStore;

const DataHostCardList = () => {
  const { cardList, total } = dataHostCardListStore;

  useEffect(() => {}, []);

  return (
    <div className="dataHostCardList-body">
      {cardList.length === 0 ? (
        <Empty></Empty>
      ) : (
        cardList.map((value) => {
          const info = { ...value };
          return (
            <div key={value.id}>
              <DataHostCard info={info}></DataHostCard>
            </div>
          );
        })
      )}
      <DataHostPagination
        info={{ total, pageSize: cardList.length }}
      ></DataHostPagination>
    </div>
  );
};

export default observer(DataHostCardList);
