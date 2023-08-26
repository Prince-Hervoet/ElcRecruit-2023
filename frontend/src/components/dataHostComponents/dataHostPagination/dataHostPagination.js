import React from "react";
import { Pagination } from "antd";

export default function DataHostPagination() {
  return (
    <div>
      <Pagination simple defaultCurrent={2} total={50} />
      <br />
      <Pagination disabled simple defaultCurrent={2} total={50} />
    </div>
  );
}
