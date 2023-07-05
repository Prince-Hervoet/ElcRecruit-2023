import React from "react";
import "./cardList.css";
import { Pagination } from "antd";
import Card from "../card/card";
import Empty from "../empty/empty";
import Loading from "../loading/loading";
import { observer } from "mobx-react-lite";
import cardListStore from "../../store/cardListStore";

const colorObj = {
  10: "yellow",
  20: "blue",
  30: "purple",
  40: "cyan",
  50: "green",
  60: "red",
};

function CardList() {
  // 获取学生信息
  const { cardList, isLoading } = cardListStore;

  let contents = [];
  if (isLoading) {
    contents.push(<Loading key={"loading"}></Loading>);
  } else {
    if (cardList.length > 0) {
      contents = cardList.map((card) => {
        const { userId, stuId, depId, college, grade, status } = card;
        const baseInfo = { depId };
        return (
          <div key={userId}>
            <Card baseInfo={baseInfo}></Card>
          </div>
        );
      });
    } else {
      contents.push(<Empty key={"empty"}></Empty>);
    }
  }

  return (
    <div className="cards-list-body">
      <div className="cards-list-content">
        {contents.map((ccontent) => {
          return ccontent;
        })}
      </div>
      <div className="cards-list-pagination">
        <div>
          <Pagination
            defaultCurrent={1}
            defaultPageSize={6}
            current={1}
            pageSize={6}
            pageSizeOptions={[]}
            total={cardList.length}
          />
        </div>
      </div>
    </div>
  );
}

export default observer(CardList);
