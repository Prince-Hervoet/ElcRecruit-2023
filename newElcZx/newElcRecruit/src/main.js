import router from "./router.js";
import { createApp } from "vue";
import App from "./App.vue";
import "view-ui-plus/dist/styles/viewuiplus.css";
import ViewUIPlus from "view-ui-plus";

const app = createApp(App);
app.use(router).use(ViewUIPlus).mount("#app");
