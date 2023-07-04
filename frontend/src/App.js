import React from "react";
import "./App.css";
import Host from "./pages/host/host";
import Login from "./pages/login/login";
import Resume from "./pages/resume/resume";
import { Route, Routes } from "react-router-dom";
import Admin from "./pages/admin/admin";
import rootStore from "./store/rootStore";
import { observer } from "mobx-react-lite";
import DanglingBox from "./components/danglingBox/danglingBox";

const { danglingStore } = rootStore;

function App() {
  const { title, textContent, isShow } = danglingStore;
  return (
    <>
      <Routes>
        <Route path="/" element={<Login></Login>}></Route>
        <Route path="/host" element={<Host></Host>}></Route>
        <Route path="/login" element={<Login></Login>}></Route>
        <Route path="/resume" element={<Resume></Resume>}></Route>
      </Routes>
      {
        <DanglingBox
          title={title}
          textContent={textContent}
          isShow={isShow}
        ></DanglingBox>
      }
    </>
  );
}

export default observer(App);
