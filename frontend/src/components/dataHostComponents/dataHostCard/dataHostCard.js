import React from "react";
import "./dataHostCard.css";
import { EditOutlined } from "@ant-design/icons";
import { Card } from "antd";
const { Meta } = Card;

function getIntroStr(...items) {
  let ans = "";
  return items.map((value) => {});
}

export default function DataHostCard(props) {
  const { name, stuId, college, clazz } = props;
  return (
    <div className="dataHostCard-body">
      <Card
        style={{
          width: "100%",
        }}
        actions={[<EditOutlined key="edit" />]}
      >
        <Meta
          title={name}
          description={`学院: ${college} | 学号: ${stuId} | 班级: ${clazz}`}
        />
      </Card>
    </div>
  );
}
