import React from "react";
import "./dataHostColorFlag.css";

export default function DataHostColorFlag({ color, text }) {
  return (
    <div className="dataHostColorFlag-body">
      <div
        className="dataHostColorFlag-color-body"
        style={{ backgroundColor: color }}
      ></div>
      <span className="dataHostColorFlag-text-body">{text}</span>
    </div>
  );
}
