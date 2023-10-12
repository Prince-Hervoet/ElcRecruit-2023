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
  { title: "结束" },
];

export default function Admin() {
  const [process, setProcess] = useState(0);
  const [select, setSelect] = useState("0");

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
      const res = await AdminRequest.pushProcess(true);
      if (res.success) {
        if (res.data.success) {
          setProcess(process + 1);
        } else {
          alert(res.data.errorMessages[0]);
        }
      } else {
        alert("请检查网络或权限");
      }
    }
  };

  const clickExportAll = async () => {
    await AdminRequest.exportMenu();
  };

  const clickExportDepAll = async () => {
    await AdminRequest.exportMenu(undefined, select);
  };

  const clickExportDepAccess = async () => {
    await AdminRequest.exportMenu(50, select);
  };

  const clickExportDepReject = async () => {
    await AdminRequest.exportMenu(60, select);
  };

  const onChangeSetDepId = (event) => {
    const value = event.target.value;
    setSelect(value);
  };

  return (
    <div className="admin-body">
      <div className="admin-content">
        <Steps current={process} items={processNameList} />
        <hr></hr>
        <div style={{ textAlign: "center", marginTop: 20 }}>
          <Radio.Group
            defaultValue="a"
            style={{ fontWeight: 700 }}
            onChange={onChangeSetDepId}
            value={select}
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
            onClick={clickExportDepAll}
          >
            导出当前部门所有名单
          </Button>
          <Button
            type="primary"
            size="large"
            style={{ marginRight: 20 }}
            onClick={clickExportDepAccess}
          >
            导出当前部门通过名单
          </Button>
          <Button
            type="primary"
            size="large"
            style={{ marginRight: 20 }}
            onClick={clickExportDepReject}
          >
            导出当前部门淘汰名单
          </Button>
          <Button danger size="large" onClick={clickPushProcess}>
            推进进度
          </Button>
        </p>
      </div>
    </div>
  );
}
