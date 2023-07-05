import React from "react";
import "./cardList.css";
import { Pagination } from "antd";
import Card from "../card/card";
import Empty from "../empty/empty";
import Loading from "../loading/loading";
import { observer } from "mobx-react-lite";
import cardListStore from "../../store/cardListStore";

function CardList() {
  // 获取学生信息
  // {uid:"1Njskdfj"",name:"张三",depId:"1",stuId:"3120003333",college:"ddd",major:"光电信息",status:10}
  const { cardList, isLoading } = cardListStore;

  return (
    <div className="cards-list-body">
      <div className="cards-list-content">
        {isLoading ? (
          <Loading></Loading>
        ) : cardList.length > 0 ? (
          cardList.map((info) => {
            return <Card key={info.uid} info={info}></Card>;
          })
        ) : (
          <Empty></Empty>
        )}
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
