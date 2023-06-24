import React, { useState } from "react";
import "./leftList.css";

export default function LeftList({ values }) {
  const [select, setSelect] = useState(-1);
  const selectFunc = (event) => {
    const el = event.target;
    setSelect(el.id);
  };

  return (
    <div
      style={{ width: "100%", height: "100%" }}
      className="left-list-body"
      onClick={selectFunc}
    >
      {values.map((value, index) => {
        if (select === index + "") {
          return (
            <li
              key={value.key}
              id={index}
              style={{
                backgroundColor: "rgb(106, 90, 205)",
                color: "white",
                borderRadius: 6,
              }}
            >
              {value.value}
            </li>
          );
        }
        return (
          <li key={value.key} id={index}>
            {value.value}
          </li>
        );
      })}
    </div>
  );
}
