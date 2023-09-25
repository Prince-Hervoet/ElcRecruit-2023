import React, { useEffect, useState } from "react";
import "./admin.css";
import { Steps } from "antd";
import { Button } from "antd";
import { Radio } from "antd";
import { AdminRequest } from "../../requests/adminRequest";

const processNameList = [
  {
    title: "报名",
  },
  {
    title: "一面",
  },
  {
    title: "笔试",
  },
  {
    title: "二面",
  },
];

export default function Admin() {
  const [process, setProcess] = useState(0);

  useEffect(() => {
    (async function () {
      const res = await AdminRequest.getCurrentProcess();
      if (res.success) {
        setProcess(res.data?.data);
      }
    })();
  }, []);

  const clickPushProcess = async () => {
    if (
      window.confirm("确定要推进进度吗?") &&
      process < processNameList.length
    ) {
      const res = await AdminRequest.pushProcess();
      setProcess(process + 1);
    }
  };

  const clickExportAll = () => {};

  const clickExportAccess = () => {};

  const clickExportReject = () => {};

  return (
    <div className="admin-body">
      <div className="admin-content">
        <Steps current={process} items={processNameList} />
        <hr></hr>
        <div style={{ textAlign: "center", marginTop: 20 }}>
          <Radio.Group
            onChange={() => {}}
            defaultValue="a"
            style={{ fontWeight: 700 }}
          >
            <Radio.Button value="1">维修部</Radio.Button>
            <Radio.Button value="2">秘书部</Radio.Button>
            <Radio.Button value="3">项目部</Radio.Button>
            <Radio.Button value="4">网宣部</Radio.Button>
            <Radio.Button value="5">外联部</Radio.Button>
            <Radio.Button value="6">实践部</Radio.Button>
            <Radio.Button value="7">软件组</Radio.Button>
          </Radio.Group>
        </div>

        <hr></hr>
        <p style={{ textAlign: "center" }}>
          <Button
            type="primary"
            size="large"
            style={{ marginRight: 20 }}
            onClick={clickExportAll}
          >
            导出当前所有名单
          </Button>
          <Button
            type="primary"
            size="large"
            style={{ marginRight: 20 }}
            onClick={clickExportAccess}
          >
            导出当前通过名单
          </Button>
          <Button
            type="primary"
            size="large"
            style={{ marginRight: 20 }}
            onClick={clickExportReject}
          >
            导出当前淘汰名单
          </Button>
          <Button danger size="large" onClick={clickPushProcess}>
            推进进度
          </Button>
        </p>
      </div>
    </div>
  );
}
