import React, { useEffect, useRef } from "react";
import "./dataHostChartArea.css";
import * as echarts from "echarts";
import { observer } from "mobx-react-lite";
import dataHostChartStore from "../../../store/dataHostChartStore";

function DataHostChartArea() {
  const { isShow } = dataHostChartStore;
  const dom = useRef(null);

  useEffect(() => {
    if (isShow) {
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
            name: "Access From",
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
                fontSize: 40,
                fontWeight: "bold",
              },
            },
            labelLine: {
              show: false,
            },
            data: [
              { value: 1048, name: "Search Engine" },
              { value: 735, name: "Direct" },
              { value: 580, name: "Email" },
              { value: 484, name: "Union Ads" },
              { value: 300, name: "Video Ads" },
            ],
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
      <div ref={dom} style={{ width: "400px", height: "100%" }}></div>
    </div>
  );
}

export default observer(DataHostChartArea);
