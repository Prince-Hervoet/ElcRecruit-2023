import React, { useEffect } from "react";
import "./dataHostCard.css";
import { Card } from "antd";
import { joinRouterUrl } from "../../../util";
const { Meta } = Card;

export default function DataHostCard({ info }) {
  const { name, stuId, college, clazz, dep } = info;
  useEffect(() => {});

  const clickGotoResume = () => {
    const targetUrl = joinRouterUrl("/resume");
    window.open(targetUrl, "_blank");
  };

  return (
    <div className="dataHostCard-body" onClick={clickGotoResume}>
      <Card
        title={name}
        style={{
          width: "100%",
          backgroundColor: "#fafafa",
          fontWeight: 700,
        }}
      >
        <Meta
          description={`学院: ${college} | 学号: ${stuId} | 班级: ${clazz}`}
        />
        <p>第一志愿部门: {dep}</p>
      </Card>
    </div>
  );
}
