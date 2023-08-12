import { Route, Routes } from "react-router-dom";
import React from "react";
import { routerInfos } from "./routerInfos";
import RouterElement from "./routerElement";

export default function RouterView() {
  return (
    <Routes>
      {routerInfos.map((item) => {
        const { name, path } = item;
        return (
          <Route
            key={name}
            path={path}
            element={<RouterElement {...item}></RouterElement>}
          ></Route>
        );
      })}
    </Routes>
  );
}
