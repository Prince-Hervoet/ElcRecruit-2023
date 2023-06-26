import React, { useEffect, useRef, useState } from "react";
import "./modalChart.css";
import * as echarts from "echarts";
import { observer } from "mobx-react-lite";
import rootStore from "../../store/rootStore";

const { cardListStore } = rootStore;

function ModalChart({ clickOnSpace }) {
  // 所需信息 -- 部门总人数
  const { depSizeList } = cardListStore;

  const echart = useRef();
  function createEchart() {
    const chart = echarts.init(echart.current);
    const option = {
      series: [
        {
          name: "Nightingale Chart",
          type: "pie",
          radius: [50, 250],
          center: ["50%", "50%"],
          roseType: "area",
          itemStyle: {
            borderRadius: 8,
          },
          data: [
            { value: 40, name: "维修部 40" },
            { value: 38, name: "秘书部 56" },
            { value: 32, name: "项目部" },
            { value: 30, name: "网宣部" },
            { value: 28, name: "外联部" },
            { value: 26, name: "实践部" },
            { value: 22, name: "软件组" },
          ],
        },
      ],
    };
    chart.setOption(option);
  }

  useEffect(() => {
    createEchart();
  }, []);

  const cancelClick = (event) => {
    const el = event.target;
    if (el.id === "body") {
      clickOnSpace();
    }
  };

  return (
    <div className="modal-chart-body" onClick={cancelClick} id="body">
      <div className="modal-chart-content" id="content" ref={echart}>
        {/* <div style={{ width: "100%", height: "100%" }} ></div> */}
      </div>
    </div>
  );
}

export default observer(ModalChart);
