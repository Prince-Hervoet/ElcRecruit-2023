import React, { useEffect, useRef, useState } from "react";
import { Descriptions, Input, Rate, List, Select } from "antd";
import {
  CaretRightOutlined,
  LoginOutlined,
  CloseOutlined,
  PauseOutlined,
  UpSquareOutlined,
} from "@ant-design/icons";
import { Button } from "antd";
import "./resume.css";
import { getUrlParam } from "../../util";
import ResumeStatusShow from "../../components/resumeComponents/resumeStatusShow";

const { TextArea } = Input;

const data = [
  {
    title: "Ant Design Title 1",
  },
  {
    title: "Ant Design Title 2",
  },
  {
    title: "Ant Design Title 3",
  },
  {
    title: "Ant Design Title 4",
  },
];

export default function Resume() {
  const [items, setItems] = useState({});
  const [comments, setComments] = useState([]);
  const userIdInputRef = useRef();
  const nComment = useRef("");
  const nScore = useRef("");

  useEffect(() => {
    const userId = getUrlParam("userId");
    userIdInputRef.current.setAttribute("value", userId);
  }, []);

  const clickStartInterview = () => {};

  const clickAccept = () => {};

  const clickReject = () => {};

  const clickPending = () => {};

  const clickSubmitComment = () => {};

  const onChangeComment = (value) => {
    console.log(value);
    nComment.current = value;
  };

  return (
    <div className="resume-body">
      <div className="resume-content-body">
        <div className="resume-content-header">
          <Descriptions
            title="User Info"
            column={4}
            labelStyle={{ fontWeight: 700, fontSize: "larger" }}
            contentStyle={{ fontSize: "larger" }}
          >
            <Descriptions.Item label="姓名">{items.name}</Descriptions.Item>
            <Descriptions.Item label="电话">{items.phone}</Descriptions.Item>
            <Descriptions.Item label="学院">{items.college}</Descriptions.Item>
            <Descriptions.Item label="班级">{items.clazz}</Descriptions.Item>
            <Descriptions.Item label="自我介绍">
              {items.intro}
            </Descriptions.Item>
          </Descriptions>
        </div>
        <div className="resume-content-comment-body">
          <TextArea
            placeholder="请输入一些评论..."
            autoSize={{
              minRows: 8,
              maxRows: 10,
            }}
            styles={{
              fontSize: "larger",
            }}
          />
        </div>
        <div className="resume-content-comment-buttons-body">
          <Rate count={10} />
          <Input
            size="small"
            placeholder="评价者"
            style={{ width: "10%", marginLeft: 10 }}
            onChange={onChangeComment}
          />
          <Button style={{ marginLeft: 10 }} size={"large"}>
            提交评论和分数
          </Button>
        </div>

        <div className="resume-content-buttons-body">
          <Button type="primary" icon={<CaretRightOutlined />} size={"large"}>
            开始面试
          </Button>
          <Button icon={<LoginOutlined />} size={"large"}>
            通过
          </Button>
          <Button icon={<CloseOutlined />} size={"large"}>
            淘汰
          </Button>
          <Button icon={<PauseOutlined />} size={"large"}>
            待定
          </Button>
        </div>
        <p></p>
        <div>
          <Select
            defaultValue="7"
            style={{ width: 150, marginRight: "10px" }}
            options={[
              { value: "1", label: "维修部" },
              { value: "2", label: "秘书部" },
              { value: "3", label: "项目部" },
              { value: "4", label: "网宣部" },
              { value: "5", label: "外联部" },
              { value: "6", label: "实践部" },
              { value: "7", label: "软件组" },
            ]}
          />
          <Button danger icon={<UpSquareOutlined />} size={"default"}>
            调剂至
          </Button>
        </div>
        <p></p>
        <List
          itemLayout="horizontal"
          dataSource={data}
          renderItem={(item, index) => (
            <List.Item>
              <List.Item.Meta
                title={item.title}
                description="Ant Design, a design language for background applications, is refined by Ant UED Team"
              />
            </List.Item>
          )}
        />
        <input
          id="userIdInput"
          ref={userIdInputRef}
          style={{ display: "none" }}
        ></input>
      </div>
      <ResumeStatusShow></ResumeStatusShow>
    </div>
  );
}
