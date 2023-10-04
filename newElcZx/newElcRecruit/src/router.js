import { createRouter, createWebHashHistory } from "vue-router";
import Welcome from "./views/Welcome.vue";
import Stepper from "./views/Stepper.vue";

// 注册路由
const routes = [
  { path: "/", component: Welcome },
  { path: "/progress", component: Stepper },
];

const router = new createRouter({
  history: createWebHashHistory(),
  routes,
});

export default router;
