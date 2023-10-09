import React, { useEffect, useRef } from "react";
import "./dataHostChartArea.css";
import * as echarts from "echarts";
import { observer } from "mobx-react-lite";
import dataHostChartStore from "../../../store/dataHostChartStore";
import { KeyToDepName, KeyToLeftListName } from "../../../store/global";
import DataRequest from "../../../requests/dataRequest";

const option = {
  tooltip: {
    trigger: "item",
  },
  legend: {
    top: "5%",
    left: "center",
  },
  series: [
    {
      name: "部门人数",
      type: "pie",
      radius: ["40%", "70%"],
      avoidLabelOverlap: false,
      itemStyle: {
        borderRadius: 10,
        borderColor: "#fff",
        borderWidth: 2,
      },
      label: {
        show: false,
        position: "center",
      },
      emphasis: {
        label: {
          show: true,
          fontSize: 45,
          fontWeight: "bold",
        },
      },
      labelLine: {
        show: false,
      },
      data: [
        { value: 0, name: "维修部" },
        { value: 0, name: "秘书部" },
        { value: 0, name: "项目部" },
        { value: 0, name: "网宣部" },
        { value: 0, name: "外联部" },
        { value: 0, name: "实践部" },
        { value: 0, name: "软件组" },
      ],
    },
  ],
};

function getChartDataList(depSumList) {
  const ans = [];
  depSumList.forEach((value) => {
    if (KeyToDepName[value.depId]) {
      ans.push({ value: value.size, name: KeyToDepName[value.depId] });
    }
  });
  return ans;
}

function DataHostChartArea() {
  const { isShow } = dataHostChartStore;
  const dom = useRef(null);
  const mc = useRef(null);

  useEffect(() => {
    if (!isShow) {
      return;
    }
    if (mc.current === null) mc.current = echarts.init(dom.current);
    (async function () {
      const res = await DataRequest.getDepSizeList();
      if (res.isRequestSuccess) {
        const responseData = res.data.data;
        if (!responseData.success) {
          return;
        }
        const depSizeList = getChartDataList(responseData.data);
        option.series[0].data = depSizeList;
        mc.current.setOption(option);
      } else {
      }
    })();
  }, [isShow]);

  return (
    <div
      className="dataHostChartArea-body"
      style={isShow ? {} : { display: "none" }}
    >
      <div className="dataHostChartArea-chart-body">
        <div ref={dom} style={{ width: "400px", height: "100%" }}></div>
      </div>
    </div>
  );
}

export default observer(DataHostChartArea);
