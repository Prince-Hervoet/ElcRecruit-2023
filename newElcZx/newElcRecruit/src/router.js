import { createRouter, createWebHashHistory } from "vue-router";
import Welcome from "./views/Welcome.vue";

const routes = [{ path: "/", component: Welcome }];

const router = new createRouter({
  history: createWebHashHistory(),
  routes,
});

export default router;
