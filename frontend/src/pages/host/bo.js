import React from "react";
import "./bo.css";

export default function Bo() {
  return (
    <div className="bo-body">
      <svg
        width="100%"
        height="100%"
        id="svg"
        viewBox="0 0 1000 160"
        xmlns="http://www.w3.org/2000/svg"
        class="transition duration-300 ease-in-out delay-150"
      >
        <defs>
          <linearGradient id="gradient" x1="0%" y1="50%" x2="100%" y2="50%">
            <stop offset="5%" stop-color="#8ed1fc"></stop>
            <stop offset="95%" stop-color="#7bdcb5"></stop>
          </linearGradient>
        </defs>
        <path
          d="M 0,400 C 0,400 0,133 0,133 C 81.1866028708134,111.38277511961724 162.3732057416268,89.76555023923446 260,101 C 357.6267942583732,112.23444976076554 471.6937799043062,156.3205741626794 562,160 C 652.3062200956938,163.6794258373206 718.8516746411483,126.95215311004786 828,116 C 937.1483253588517,105.04784688995214 1088.8995215311004,119.87081339712918 1198,127 C 1307.1004784688996,134.12918660287082 1373.5502392344497,133.56459330143542 1440,133 C 1440,133 1440,400 1440,400 Z"
          stroke="none"
          stroke-width="0"
          fill="url(#gradient)"
          fill-opacity="0.53"
          class="transition-all duration-300 ease-in-out delay-150 path-0"
        ></path>
        <defs>
          <linearGradient id="gradient" x1="0%" y1="50%" x2="100%" y2="50%">
            <stop offset="5%" stop-color="#8ed1fc"></stop>
            <stop offset="95%" stop-color="#7bdcb5"></stop>
          </linearGradient>
        </defs>
        <path
          d="M 0,400 C 0,400 0,266 0,266 C 102.61244019138758,265.12918660287085 205.22488038277515,264.25837320574163 290,264 C 374.77511961722485,263.74162679425837 441.7129186602871,264.0956937799043 552,256 C 662.2870813397129,247.90430622009572 815.9234449760764,231.3588516746412 914,226 C 1012.0765550239236,220.6411483253588 1054.5933014354066,226.46889952153109 1133,235 C 1211.4066985645934,243.53110047846891 1325.7033492822966,254.76555023923447 1440,266 C 1440,266 1440,400 1440,400 Z"
          stroke="none"
          stroke-width="0"
          fill="url(#gradient)"
          fill-opacity="1"
          class="transition-all duration-300 ease-in-out delay-150 path-1"
        ></path>
      </svg>
    </div>
  );
}
