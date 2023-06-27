import React from "react";
import "./danglingBox.css";

export default function DanglingBox({ title, textContent, isShow }) {
  return (
    <div
      className="dangling-box-body"
      style={isShow ? { left: 5 } : { left: "-999px" }}
    >
      <div className="dangling-box-title">{title}</div>
      <div className="dangling-box-content">{textContent}</div>
    </div>
  );
}
