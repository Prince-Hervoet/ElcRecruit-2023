import React from "react";
import "./App.css";
import Host from "./pages/host/host";
import Login from "./pages/login/login";
import Resume from "./pages/resume/resume";
import { Route, Routes } from "react-router-dom";
import Admin from "./pages/admin/admin";
import rootStore from "./store/rootStore";
import { observer } from "mobx-react-lite";

function App() {
  // const { title, textContent, isShow } = danglingStore;
  return (
    <>
      <Routes>
        <Route path="/" element={<Login></Login>}></Route>
        <Route path="/host" element={<Host></Host>}></Route>
        <Route path="/login" element={<Login></Login>}></Route>
        <Route path="/resume" element={<Resume></Resume>}></Route>
        <Route path="/admin" element={<Admin></Admin>}></Route>
      </Routes>
    </>
  );
}

export default observer(App);
