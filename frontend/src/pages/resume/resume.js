import React from "react";
import { Descriptions, Button } from "antd";
import { Input, InputNumber } from "antd";

import "./resume.css";

export default function Resume() {
  const { TextArea } = Input;
  return (
    <div className="resume-body">
      <div className="resume-content">
        <div className="resume-content-base-info">
          <Descriptions
            title="基本信息"
            labelStyle={{
              fontSize: "larger",
              fontWeight: 700,
              userSelect: "none",
            }}
            contentStyle={{ fontSize: "larger", fontWeight: 700 }}
          >
            <Descriptions.Item label="姓名">振炫</Descriptions.Item>
            <Descriptions.Item label="手机号码">1810000000</Descriptions.Item>
            <Descriptions.Item label="QQ号">
              Hangzhou, Zhejiang
            </Descriptions.Item>
            <Descriptions.Item label="学院">empty</Descriptions.Item>
            <Descriptions.Item label="班级">
              No. 18, Wantang Road
            </Descriptions.Item>
            <Descriptions.Item label="基本技能">empty</Descriptions.Item>
            <Descriptions.Item label="个人简介">empty</Descriptions.Item>
          </Descriptions>
        </div>

        <div className="resume-content-intro-comment">
          <div className="resume-comment">
            <div>
              <TextArea
                autoSize={{ minRows: 6, maxRows: 100 }}
                placeholder="写点评价吧？"
              />
            </div>
            <div>
              <span style={{ fontWeight: 700 }}>评分: </span>
              <InputNumber size="large" min={1} max={100000} defaultValue={3} />
            </div>
            <div>
              <Button size="large" style={{ marginRight: 10 }} danger>
                开始面试
              </Button>
              <Button
                size="large"
                style={{
                  marginRight: 10,
                  backgroundColor: "gray",
                  fontWeight: 700,
                  color: "white",
                }}
              >
                待定
              </Button>
              <Button
                type="primary"
                size="large"
                style={{
                  marginRight: 10,
                  backgroundColor: "green",
                  fontWeight: 700,
                }}
              >
                通过
              </Button>
              <Button
                type="primary"
                size="large"
                danger
                style={{ fontWeight: 700 }}
              >
                淘汰
              </Button>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}
