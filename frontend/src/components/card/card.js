import React from "react";
import "./card.css";

const colorMapping = {};

export default function Card({ colorFlag, title, content }) {
  return (
    <div className="card-body">
      <div className="card-title"></div>
      <div className="card-content"></div>
    </div>
  );
}
