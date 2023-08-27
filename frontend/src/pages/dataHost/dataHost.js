import React from "react";
import "./dataHost.css";
import DataHostLeftList from "../../components/dataHostComponents/dataHostLeftList/dataHostLeftList";
import DataHostCardList from "../../components/dataHostComponents/dataHostCardList/dataHostCardList";
import DataHostRefresh from "../../components/dataHostComponents/dataHostRefresh/dataHostRefresh";
import DataHostExitMe from "../../components/dataHostComponents/dataHostExitMe/dataHostExitMe";

export default function DataHost() {
  return (
    <div className="dataHost-body dataHost-default-var">
      <div className="dataHost-left">
        <div style={{ width: 200 }}></div>
        <DataHostLeftList></DataHostLeftList>
      </div>
      <div className="dataHost-middle">
        <div className="dataHost-middle-header">
          <DataHostRefresh></DataHostRefresh>
          <DataHostExitMe></DataHostExitMe>
        </div>
        <div className="dataHost-middle-body">
          <div className="dataHost-middle-content-body">
            <DataHostCardList></DataHostCardList>
          </div>
        </div>
      </div>
    </div>
  );
}
