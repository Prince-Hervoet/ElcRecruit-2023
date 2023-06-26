import React from "react";
import "./card.css";

export default function Card({ color, baseInfo }) {
  return (
    <div className="card-body" style={{ borderLeft: "5px solid " + color }}>
      <div className="card-title">
        <div className="card-title-dep">
          <span>{baseInfo.department}</span>
        </div>
        <div className="card-title-name">
          <span>{baseInfo.name}</span>
        </div>
      </div>
      <div className="card-content">
        <div>
          <div className="card-content-text">学号: {baseInfo.stuId}</div>
        </div>
        <div>
          <div className="card-content-text">学院: {baseInfo.college}</div>
        </div>
        <div>
          <div className="card-content-text">班级: {baseInfo.grade}</div>
        </div>
      </div>
    </div>
  );
}
