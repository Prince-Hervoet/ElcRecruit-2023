import React from "react";
import "./card.css";
import { ServiceUrls } from "../../requests/util";
import { ColorObj, DepObj } from "../../store/globalInfo";

export default function Card({
  uid,
  name,
  stuId,
  depId,
  college,
  major,
  status,
}) {
  const color = ColorObj[status + ""];
  const dep = DepObj[depId + ""];

  const clickOnLinkTo = () => {
    const hrefStr = window.location.href;
    const flag = hrefStr.indexOf("#");
    const source = hrefStr.substring(0, flag + 1);
    window.open(`${source}/resume?uid=` + uid);
  };

  return (
    <div
      className="card-body"
      style={{
        borderLeft: "8px solid " + color,
      }}
      onClick={clickOnLinkTo}
    >
      <input type="hidden" value={uid}></input>
      <div className="card-title">
        <div className="card-title-dep">
          <span>{dep}</span>
        </div>
        <div className="card-title-name">
          <span>{name}</span>
        </div>
      </div>
      <div className="card-content">
        <div>
          <div className="card-content-text">学号: {stuId}</div>
        </div>
        <div>
          <div className="card-content-text">学院: {college}</div>
        </div>
        <div>
          <div className="card-content-text">专业: {major}</div>
        </div>
      </div>
    </div>
  );
}
