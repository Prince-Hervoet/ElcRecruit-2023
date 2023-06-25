import React from "react";
import "./App.css";
import Host from "./pages/host/host";
import Loading from "./components/loading/loading";
import Login from "./pages/login/login";
import Resume from "./pages/resume/resume";

export default function App() {
  return (
    <>
      {/* <Resume></Resume> */}
      <Host></Host>
      {/* <div style={{ width: 200, height: 200 }}>
        <Loading></Loading>
      </div> */}
    </>
  );
}
