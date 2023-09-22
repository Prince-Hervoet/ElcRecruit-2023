import { Input } from "antd";
import React from "react";
import "./dataHostSearch.css";
import DataRequest from "../../../requests/dataRequest";
import GdataHostCardListStore from "../../../store/dataHostCardListStore";

const { Search } = Input;
export default function DataHostSearch() {
  const clickSearch = async (value) => {
    const res = await DataRequest.getSearchBriefInfo(
      value,
      GdataHostCardListStore.getCurrentDepId()
    );
    if (res.success) {
    } else {
    }
  };

  return (
    <div className="dataHostSearch-body">
      <Search
        placeholder="姓名或学号"
        allowClear
        enterButton="搜索"
        size="default"
        onSearch={clickSearch}
      />
    </div>
  );
}
