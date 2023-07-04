import React, { useState } from "react";
import "./checkin.css";
import Empty from "../empty/empty";
import rootStore from "../../store/rootStore";
import Loading from "../loading/loading";
import { observer } from "mobx-react-lite";
import CheckinCard from "./checkinCard/checkinCard";

const { checkinListStore } = rootStore;

function Checkin() {
  const { checkinList, isLoading } = checkinListStore;

  let contents = [];
  if (isLoading) {
    contents.push(<Loading></Loading>);
  } else {
    if (checkinList.length === 0) {
      contents.push(
        <div
          style={{
            width: "100%",
            height: "100%",
            display: "flex",
            alignItems: "center",
            justifyContent: "center",
          }}
        >
          <Empty></Empty>
        </div>
      );
    } else {
      contents = checkinList.map((checkin, index) => {
        const { userId, name, stuId } = checkinList[index];
        return <CheckinCard></CheckinCard>;
      });
    }
  }

  return (
    <div className="checkin-body">
      <div className="checkin-content-title">签到列表 (当前部门)</div>
      <div className="checkin-content-card-list">
        {contents.map((content) => {
          return content;
        })}
      </div>
    </div>
  );
}

export default observer(Checkin);
