import React from "react";
import "./App.css";
import { observer } from "mobx-react-lite";
import RouterView from "./router/routerView";

function App() {
  return (
    <RouterView></RouterView>
    // <Routes>
    //   <Route path="/" element={<Login></Login>}></Route>
    //   <Route path="/host" element={<Host></Host>}></Route>
    //   <Route path="/login" element={<Login></Login>}></Route>
    //   <Route path="/resume" element={<Resume></Resume>}></Route>
    //   <Route path="/admin" element={<Admin></Admin>}></Route>
    // </Routes>
  );
}

export default observer(App);
