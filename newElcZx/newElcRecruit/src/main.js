import router from "./router.js";
import { createApp } from "vue";
import App from "./App.vue";
import "view-ui-plus/dist/styles/viewuiplus.css";
import ViewUIPlus from "view-ui-plus";
import axios from "axios";

const BASE_URL = "http://recruit.gdutelc.com";

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

const app = createApp(App);
app.use(router).use(ViewUIPlus).mount("#app");
