import React from "react";
import "./card.css";

const colorMapping = {};

export default function Card({ colorFlag, title, content }) {
  return (
    <div className="card-body" style={{ borderLeft: "5px solid red" }}>
      <div className="card-title">
        <div className="card-title-dep">
          <span>维修部</span>
        </div>
        <div className="card-title-name">
          <span>振炫哥哥</span>
        </div>
      </div>
      <div className="card-content">
        <div>
          <div className="card-content-text">学号: 3120007474</div>
        </div>
        <div>
          <div className="card-content-text">学院: 物理与光电工程学院</div>
        </div>
        <div>
          <div className="card-content-text">班级: 光电1班</div>
        </div>
      </div>
    </div>
  );
}
