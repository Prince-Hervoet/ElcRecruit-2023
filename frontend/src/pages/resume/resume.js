import React, { useState } from "react";
import { Descriptions } from "antd";
import { Input, Rate, Avatar, List } from "antd";
import {
  CaretRightOutlined,
  LoginOutlined,
  CloseOutlined,
  PauseOutlined,
} from "@ant-design/icons";
import { Button } from "antd";
import "./resume.css";

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
      </div>
    </div>
  );
}
