import React from "react";
import { Pagination } from "antd";

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
      />
    </div>
  );
}
