import router from "./router.js";
import { createApp } from "vue";
import ViewUIPlus from "view-ui-plus";
import "view-ui-plus/dist/styles/viewuiplus.css";
import App from "./App.vue";

createApp(App).use(router).use(ViewUIPlus).mount("#app");
