import { Input } from "antd";
import React from "react";
import "./dataHostSearch.css";
import DataRequest from "../../../requests/dataRequest";
import GdataHostCardListStore from "../../../store/dataHostCardListStore";

const { Search } = Input;
export default function DataHostSearch() {
  const clickSearch = async (value) => {
    const depId = GdataHostCardListStore.getCurrentDepId();
    if (!value) return;
    GdataHostCardListStore.incRequestId();
    const currentRequestId = GdataHostCardListStore.getRequestId();
    GdataHostCardListStore.setIsLoading(true);
    const res = await DataRequest.getSearchBriefInfo(value, depId);
    GdataHostCardListStore.setIsLoading(false);
    if (currentRequestId < GdataHostCardListStore.getRequestId()) return;

    if (res.isRequestSuccess) {
      const responseData = res.data.data;
      if (!responseData.success) {
        alert("处理失败");
        return;
      }
      const searchList = responseData.data;
      GdataHostCardListStore.setCardList(searchList);
      GdataHostCardListStore.setPageCount(1);
      GdataHostCardListStore.setTotal(1);
    } else {
      alert(`请求失败: ${res.data.message}`);
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
