import React from "react";
import "./dataHost.css";
import DataHostLeftList from "../../components/dataHostComponents/dataHostLeftList/dataHostLeftList";
import DataHostCardList from "../../components/dataHostComponents/dataHostCardList/dataHostCardList";
import DataHostRefresh from "../../components/dataHostComponents/dataHostRefresh/dataHostRefresh";
import DataHostExitMe from "../../components/dataHostComponents/dataHostExitMe/dataHostExitMe";
import DataHostChart from "../../components/dataHostComponents/dataHostChart/dataHostChart";
import DataHostChartArea from "../../components/dataHostComponents/dataHostChartArea/dataHostChartArea";
import DataHostSearch from "../../components/dataHostComponents/dataHostSearch/dataHostSearch";

export default function DataHost() {
  return (
    <div className="dataHost-body dataHost-default-var">
      <div className="dataHost-left">
        <DataHostLeftList></DataHostLeftList>
      </div>
      <div className="dataHost-middle">
        <div className="dataHost-middle-header">
          <DataHostSearch></DataHostSearch>
          <DataHostChart></DataHostChart>
          <DataHostRefresh></DataHostRefresh>
          <DataHostExitMe></DataHostExitMe>
        </div>
        <div className="dataHost-middle-body">
          <div className="dataHost-middle-content-body">
            <DataHostCardList></DataHostCardList>
          </div>
        </div>
      </div>

      <DataHostChartArea></DataHostChartArea>
    </div>
  );
}
