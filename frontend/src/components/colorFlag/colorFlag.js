import React from "react";
import "./colorFlag.css";

export default function ColorFlag({ color, text }) {
  return (
    <div className="color-flag-body">
      <div>
        <div className="color-flag-sq" style={{ backgroundColor: color }}></div>
      </div>
      <div style={{ flex: 1 }}>{text}</div>
    </div>
  );
}
