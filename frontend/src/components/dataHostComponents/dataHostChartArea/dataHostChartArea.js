import React, { useEffect, useRef } from "react";
import "./dataHostChartArea.css";
import * as echarts from "echarts";
import { observer } from "mobx-react-lite";
import dataHostChartStore from "../../../store/dataHostChartStore";
import { KeyToDepName } from "../../../store/global";

function getChartDataList(depSumList) {
  const ans = [];
  depSumList.forEach((value) => {
    ans.push({ value: value.size, name: KeyToDepName[value.depId] });
  });
  return ans;
}

function DataHostChartArea() {
  const { isShow, depSumList } = dataHostChartStore;
  const dom = useRef(null);

  useEffect(() => {
    if (isShow) {
      const dataList = getChartDataList(depSumList);
      const mc = echarts.init(dom.current);
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
            data: dataList,
          },
        ],
      };
      mc.setOption(option);
    }
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
