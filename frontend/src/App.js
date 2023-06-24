import React from "react";
import "./App.css";
import Host from "./pages/host/host";
import Loading from "./components/loading/loading";

export default function App() {
  return (
    <>
      <Host></Host>
      {/* <div style={{ width: 200, height: 200 }}>
        <Loading></Loading>
      </div> */}
    </>
  );
}
