import { createRouter, createWebHashHistory } from "vue-router";
import Welcome from "./views/Welcome.vue";
import Process from "./views/Progress.vue";

const routes = [
  { path: "/", component: Welcome },
  { path: "/progress", component: Process },
];

const router = new createRouter({
  history: createWebHashHistory(),
  routes,
});

export default router;
