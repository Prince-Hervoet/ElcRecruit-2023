import React, { useEffect } from "react";
import "./dataHostCard.css";
import { EditOutlined } from "@ant-design/icons";
import { Card } from "antd";
import { useNavigate } from "react-router-dom";
import { joinRouterUrl } from "../../../util";
const { Meta } = Card;

export default function DataHostCard({ info }) {
  const { name, stuId, college, clazz } = info;

  const nav = useNavigate();

  useEffect(() => {});

  const clickGotoResume = () => {
    const targetUrl = joinRouterUrl("/resume");
    window.open(targetUrl);
  };

  return (
    <div className="dataHostCard-body">
      <Card
        style={{
          width: "100%",
        }}
        actions={[<EditOutlined key="edit" onClick={clickGotoResume} />]}
      >
        <Meta
          title={name}
          description={`学院: ${college} | 学号: ${stuId} | 班级: ${clazz}`}
        />
      </Card>
    </div>
  );
}
