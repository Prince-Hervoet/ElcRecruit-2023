import React from "react";
import { useNavigate } from "react-router-dom";
import dataHostCardListStore from "../../../store/dataHostCardListStore";
import dataHostChartStore from "./../../../store/dataHostChartStore";

export default function DataHostExitMe() {
  const nav = useNavigate();
  const clickExitMe = () => {
    localStorage.removeItem("token");
    dataHostCardListStore.clear();
    dataHostChartStore.clear();
    nav("/login");
  };

  return (
    <svg
      t="1693061349990"
      viewBox="0 0 1024 1024"
      version="1.1"
      xmlns="http://www.w3.org/2000/svg"
      p-id="11834"
      width="32"
      height="32"
      onClick={clickExitMe}
    >
      <path
        d="M1024 512c0 282.72-229.28 512-512 512S0 794.72 0 512 229.28 0 512 0s512 229.28 512 512"
        fill="#5A89FF"
        p-id="11835"
      ></path>
      <path
        d="M628 822.72H246.4c-13.44 0-24.32-10.88-24.32-24.32V261.76c0-13.44 10.88-24.32 24.32-24.32h379.2c0.8 0 1.6-0.16 2.4-0.16 13.44 0 24.32 10.88 24.32 24.32v143.2h-48.64v-118.72H270.72v488h332.96v-118.72h48.64v143.2c0 13.28-10.88 24.16-24.32 24.16z"
        fill="#FFFFFF"
        p-id="11836"
      ></path>
      <path
        d="M761.28 654.4l-34.4-34.4 89.92-89.92-89.92-89.92 34.4-34.4 107.2 107.2c4.64 4.64 7.2 10.72 7.2 17.28 0 6.4-2.56 12.64-7.2 17.28l-107.2 106.88z"
        fill="#FFFFFF"
        p-id="11837"
      ></path>
      <path
        d="M389.92 505.6H851.2v48.64H389.92z"
        fill="#FFFFFF"
        p-id="11838"
      ></path>
    </svg>
  );
}
