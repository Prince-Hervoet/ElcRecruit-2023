import React from "react";
import "./card.css";

const colorMapping = {};

export default function Card({ colorFlag, title, content }) {
  return (
    <div className="card-body" style={{ borderLeft: "5px solid red" }}>
      <div className="card-title">
        <div className="card-title-name">
          {/* <div
            style={{
              width: 18,
              height: 18,
              backgroundColor: "red",
              marginRight: 5,
              borderRadius: 6,
              border: "3px solid black",
            }}
          ></div> */}
          <span>振炫哥哥</span>
        </div>
        <div className="card-title-dep">
          <span>维修部</span>
        </div>
      </div>
      <div className="card-content"></div>
    </div>
  );
}
