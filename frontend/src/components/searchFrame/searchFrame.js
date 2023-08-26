import React from "react";
import "./searchFrame.css";

export default function SearchFrame() {
  return (
    <div className="search-frame-body">
      <input className="search-frame-input" placeholder="search..."></input>
      <div className="search-frame-img">
        <svg
          t="1690484310669"
          class="icon"
          viewBox="0 0 1024 1024"
          version="1.1"
          xmlns="http://www.w3.org/2000/svg"
          p-id="2278"
          width="20"
          height="20"
        >
          <path
            d="M581.973333 846.933333a380.8 380.8 0 1 1 380.8-380.8A381.226667 381.226667 0 0 1 581.973333 846.933333z m0-688a307.2 307.2 0 1 0 307.2 307.2 307.413333 307.413333 0 0 0-307.2-307.2z"
            fill="#FA6302"
            p-id="2279"
          ></path>
          <path
            d="M146.56 938.666667a36.906667 36.906667 0 0 1-26.026667-64l192-190.933334a36.906667 36.906667 0 0 1 52.053334 52.266667l-192 192a37.333333 37.333333 0 0 1-26.026667 10.666667z"
            fill="#43D7B4"
            p-id="2280"
          ></path>
          <path
            d="M470.826667 274.773333m-49.066667 0a49.066667 49.066667 0 1 0 98.133333 0 49.066667 49.066667 0 1 0-98.133333 0Z"
            fill="#43D7B4"
            p-id="2281"
          ></path>
          <path
            d="M312.106667 684.8l-23.68 23.466667A388.693333 388.693333 0 0 0 341.333333 760.32l23.466667-23.253333a36.906667 36.906667 0 0 0-52.053333-52.266667z"
            fill="#425300"
            p-id="2282"
          ></path>
        </svg>
      </div>
    </div>
  );
}
