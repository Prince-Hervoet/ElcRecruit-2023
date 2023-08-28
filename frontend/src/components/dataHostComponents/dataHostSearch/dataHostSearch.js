import { Input } from "antd";
import React from "react";
import "./dataHostSearch.css";

const { Search } = Input;
export default function DataHostSearch() {
  return (
    <div className="dataHostSearch-body">
      <Search
        placeholder="姓名或学号"
        allowClear
        enterButton="搜索"
        size="default"
      />
    </div>
  );
}
