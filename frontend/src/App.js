import React from "react";
import "./App.css";
import Host from "./pages/host/host";
import Login from "./pages/login/login";
import Resume from "./pages/resume/resume";
import { Route, Routes } from "react-router-dom";

export default function App() {
  return (
    <>
      <Routes>
        <Route path="/host" element={<Host></Host>}></Route>
        <Route path="/login" element={<Login></Login>}></Route>
        <Route path="/resume" element={<Resume></Resume>}></Route>
      </Routes>
    </>
  );
}
