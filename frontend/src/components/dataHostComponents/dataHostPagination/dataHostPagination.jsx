import React from "react";
import { Pagination } from "antd";
import GdataHostCardListStore from "../../../store/dataHostCardListStore";
import { clickSendGetCards } from "../dataHostCardList/util";

export default function DataHostPagination({ info }) {
  const { total = 0, pageSize = 0, current = 0 } = info;

  return (
    <div>
      <br />
      <Pagination
        simple
        disabled={pageSize === 0}
        pageSize={pageSize}
        total={total}
        current={current}
        onChange={(pageCount, pageSize) => {
          clickSendGetCards(
            GdataHostCardListStore.getCurrentDepId(),
            pageCount,
            pageSize
          );
        }}
      />
    </div>
  );
}
