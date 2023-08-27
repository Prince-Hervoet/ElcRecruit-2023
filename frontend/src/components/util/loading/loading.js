import React from "react";
import "./loading.css";

export default function Loading() {
  return (
    <div className="loading-body">
      <div className="loading-content">
        <div>
          <svg
            t="1687791112640"
            className="icon"
            viewBox="0 0 1024 1024"
            version="1.1"
            xmlns="http://www.w3.org/2000/svg"
            p-id="2325"
            width="42"
            height="42"
          >
            <path
              d="M768 68.266667H256a68.266667 68.266667 0 0 0-68.266667 68.266666v85.521067l0.085334 6.5536a238.9504 238.9504 0 0 0 61.320533 153.344l117.162667 130.0992-117.128534 129.962667A239.0016 239.0016 0 0 0 187.733333 801.962667V887.466667a68.266667 68.266667 0 0 0 68.266667 68.266666h512a68.266667 68.266667 0 0 0 68.266667-68.266666v-85.486934l-0.085334-6.5536a239.0016 239.0016 0 0 0-61.354666-153.412266l-117.1456-129.962667 117.179733-130.0992A238.9504 238.9504 0 0 0 836.266667 222.0544V136.533333a68.266667 68.266667 0 0 0-68.266667-68.266666zM256 136.533333h512v85.521067c0 42.171733-15.633067 82.875733-43.861333 114.2272l-137.762134 152.951467a34.133333 34.133333 0 0 0 0 45.687466l137.728 152.797867A170.734933 170.734933 0 0 1 768 801.979733V887.466667H256v-85.486934c0-42.1888 15.650133-82.909867 43.895467-114.261333l137.728-152.797867a34.133333 34.133333 0 0 0 0-45.687466l-137.762134-152.951467A170.683733 170.683733 0 0 1 256 222.037333V136.533333z"
              fill="#707070"
              p-id="2326"
            ></path>
            <path
              d="M682.666667 750.933333v34.133334a34.133333 34.133333 0 0 1-34.133334 34.133333H375.466667a34.133333 34.133333 0 0 1-34.133334-34.133333v-34.133334h341.333334z"
              fill="#707070"
              p-id="2327"
            ></path>
          </svg>
        </div>
      </div>
    </div>
  );
}