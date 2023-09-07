import React from "react";
import "./resumeStatusShow.css";

// 1表示通过 0暂定 -1淘汰
export default function ResumeStatusShow({ statusId }) {
  let color = "",
    text = "";
  switch (statusId) {
    case "1":
      color = "green";
      text = "通过";
      break;
    case "0":
      color = "gray";
      text = "待定";
      break;
    case "-1":
      color = "red";
      text = "淘汰";
      break;
    default:
      color = "blue";
      text = "未确认";
      break;
  }
  return (
    <div className="resumeStatusShow-body" style={{ backgroundColor: color }}>
      <div>{text}</div>
    </div>
  );
}
