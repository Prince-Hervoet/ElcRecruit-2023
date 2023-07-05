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
    if (contents.length > 0) {
      contents = checkinList.map((checkin, index) => {
        const { userId, name, stuId } = checkinList[index];
        return (
          <CheckinCard key={userId} name={name} stuId={stuId}></CheckinCard>
        );
      });
    }
  }

  return (
    <div className="checkin-body">
      <div className="checkin-content-title">签到列表 (当前部门)</div>
      <div className="checkin-content-card-list">
        {contents.length > 0 ? (
          contents.map((content) => {
            return content;
          })
        ) : (
          <Empty></Empty>
        )}
      </div>
    </div>
  );
}

export default observer(Checkin);
