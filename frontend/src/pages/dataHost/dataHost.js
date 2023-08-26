import React from "react";
import "./dataHost.css";
import DataHostLeftList from "../../components/dataHostComponents/leftList/dataHostLeftList";

export default function DataHost() {
  return (
    <div className="dataHost-body">
      <DataHostLeftList></DataHostLeftList>
      <div className="dataHost-content-body"></div>
    </div>
  );
}
