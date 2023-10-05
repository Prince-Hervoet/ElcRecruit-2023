import React from "react";
import ReactDOM from "react-dom/client";
import App from "./App.js";
import { HashRouter } from "react-router-dom";
import axios from "axios";
import { BASE_URL } from "../src/requests/util.js";

(function initAxios() {
  // 请求头加上token
  axios.interceptors.request.use(function (config) {
    const token = localStorage.getItem("token");
    if (token) {
      config.headers = {
        Authorization: token,
      };
    }
    return config;
  });

  axios.defaults.baseURL = BASE_URL;
})();

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(
  <React.StrictMode>
    <HashRouter>
      <App />
    </HashRouter>
  </React.StrictMode>
);
