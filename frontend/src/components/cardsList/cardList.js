import React from "react";
import "./cardList.css";
import { Pagination } from "antd";
import Card from "../card/card";
import Empty from "../empty/empty";
import Loading from "../loading/loading";
import { observer } from "mobx-react-lite";
import cardListStore from "../../store/cardListStore";

const colorObj = {
  10: "yellow",
  20: "blue",
  30: "purple",
  40: "cyan",
  50: "green",
  60: "red",
};

function CardList() {
  // 获取学生信息
  const { cardList: students, isLoading } = cardListStore;

  let contents = [];
  if (isLoading) {
    contents.push(<Loading></Loading>);
  } else {
    if (students.length > 0) {
      contents = students.map((student) => {
        const color = colorObj[student.status];
        const department = student.department;
        const baseInfo = {
          name: student.name,
          stuId: student.stuId,
          college: student.college,
          grade: student.grade,
        };
        return (
          <div>
            <Card
              color={color}
              department={department}
              baseInfo={baseInfo}
            ></Card>
          </div>
        );
      });
    } else {
      contents.push(<Empty></Empty>);
    }
  }

  return (
    <div className="cards-list-body">
      <div className="cards-list-content">
        {contents.map((ccontent) => {
          return ccontent;
        })}
      </div>
      <div className="cards-list-pagination">
        <div>
          <Pagination
            defaultCurrent={1}
            defaultPageSize={6}
            current={1}
            pageSize={6}
            pageSizeOptions={[]}
            total={students.length}
          />
        </div>
      </div>
    </div>
  );
}

export default observer(CardList);
