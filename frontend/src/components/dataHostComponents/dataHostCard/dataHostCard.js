import React, { useEffect } from "react";
import "./dataHostCard.css";
import { EditOutlined } from "@ant-design/icons";
import { Card } from "antd";
const { Meta } = Card;


export default function DataHostCard({info}) {
  const {name,stuId,college,clazz} = info;

  useEffect(()=>{
  })

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
