import React, { useEffect } from "react";
import "./dataHostCard.css";
import { Card } from "antd";
import { joinRouterUrl } from "../../../util";
import { CollegeObj, ColorObj, KeyToDepName } from "../../../store/global";
const { Meta } = Card;

export default function DataHostCard({ info }) {
  const { id, name, studentId, grade, college, firstDepartment, state } = info;
  const stateColor = ColorObj[state];
  const depName = KeyToDepName[firstDepartment];
  const collegeName = CollegeObj[college];

  useEffect(() => {});

  const clickGotoResume = () => {
    const targetUrl = joinRouterUrl("/resume", { userId: id });
    window.open(targetUrl, "_blank");
  };

  return (
    <div
      className="dataHostCard-body"
      onClick={clickGotoResume}
      style={{ borderRight: `6px solid ${stateColor}` }}
    >
      <Card
        title={name}
        style={{
          width: "100%",
          backgroundColor: "#fafafa",
          fontWeight: 700,
          whiteSpace: true,
        }}
      >
        <Meta
          description={`学院: ${collegeName} | 专业班级: ${grade} | 学号: ${studentId}`}
        />
        <p></p>
        <Meta description={`第一志愿: ${depName}`} />
      </Card>
    </div>
  );
}
