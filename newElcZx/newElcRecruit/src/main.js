import router from "./router.js";
import { createApp } from "vue";
import App from "./App.vue";
import "view-ui-plus/dist/styles/viewuiplus.css";
import ViewUIPlus from "view-ui-plus";
import axios from "axios";

// const BASE_URL = "http://139.159.220.241:8081";
const BASE_URL = "https://recruit.gdutelc.com";

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

console.log(`■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■`);
console.log(`■===========================================■`);
console.log(`■===========Software Team Welcome===========■`);
console.log(`■==============painted eggshell=============■`);
console.log(`■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■`);
console.log(`■--------------MTIwICsgNjYgPSA/-------------■`);
console.log(
  `Above is a string generated by an encoding algorithm commonly used in the market based on Sixty-four printable characters to represent binary data: Can you know its original text?`
);

const app = createApp(App);
app.use(router).use(ViewUIPlus).mount("#app");
