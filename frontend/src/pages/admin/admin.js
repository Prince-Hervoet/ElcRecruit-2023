import React from "react";
import "./admin.css";
import { Steps } from "antd";
import { Button } from "antd";
import { Radio } from "antd";

export default function Admin() {
  return (
    <div className="admin-body">
      <div className="admin-content">
        <Steps
          current={1}
          items={[
            {
              title: "Finished",
            },
            {
              title: "In Progress",
              //   subTitle: "Left 00:00:08",
            },
            {
              title: "Waiting",
            },
          ]}
        />
        <hr></hr>
        <p style={{ textAlign: "center" }}>
          <Radio.Group
            onChange={() => {}}
            defaultValue="a"
            style={{ fontWeight: 700 }}
          >
            <Radio.Button value="a">维修部</Radio.Button>
            <Radio.Button value="b">秘书部</Radio.Button>
            <Radio.Button value="c">项目部</Radio.Button>
            <Radio.Button value="d">网宣部</Radio.Button>
            <Radio.Button value="e">外联部</Radio.Button>
            <Radio.Button value="f">实践部</Radio.Button>
            <Radio.Button value="g">软件组</Radio.Button>
          </Radio.Group>
        </p>

        <hr></hr>
        <p style={{ textAlign: "center" }}>
          <Button type="primary" size="large" style={{ marginRight: 20 }}>
            导出当前所有名单
          </Button>
          <Button type="primary" size="large" style={{ marginRight: 20 }}>
            导出当前通过名单
          </Button>
          <Button type="primary" size="large" style={{ marginRight: 20 }}>
            导出当前淘汰名单
          </Button>
          <Button danger size="large">
            推进进度
          </Button>
        </p>
      </div>
    </div>
  );
}
