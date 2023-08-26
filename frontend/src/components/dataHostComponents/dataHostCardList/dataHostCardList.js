import React, { useEffect } from "react";
import "./dataHostCardList.css";
import DataHostCard from "../dataHostCard/dataHostCard";

export default function DataHostCardList() {
  useEffect(() => {}, []);

  return (
    <div className="dataHostCardList-body">
      <div>
        <DataHostCard></DataHostCard>
      </div>
      <div>
        <DataHostCard></DataHostCard>
      </div>
      <div>
        <DataHostCard></DataHostCard>
      </div>
      <div>
        <DataHostCard></DataHostCard>
      </div>
      <div>
        <DataHostCard></DataHostCard>
      </div>
      <div>
        <DataHostCard></DataHostCard>
      </div>
    </div>
  );
}
