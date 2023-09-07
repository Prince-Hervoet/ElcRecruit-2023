import React from "react";
import { Pagination } from "antd";
import { sendGetCards } from "../util/util";
import dataHostCardListStore from "../../../store/dataHostCardListStore";

export default function DataHostPagination({ info }) {
  const { total = 0, pageSize = 0 } = info;

  return (
    <div>
      <br />
      <Pagination
        simple
        disabled={pageSize === 0}
        pageSize={pageSize}
        total={total}
        onChange={(pageCount, pageSize) => {
          sendGetCards(
            dataHostCardListStore.getCurrentDepId(),
            pageCount,
            pageSize
          );
        }}
      />
    </div>
  );
}
