import { createRouter, createWebHashHistory } from "vue-router";
import Welcome from "./views/Welcome.vue";
// import PostInfo from "./views/PostInfo.vue"
const routes = [
  { 
    path: "/",
    component: Welcome
  },
  // {
  //   path:"/postInfo",
  //   component:PostInfo
  // }
];

const router = new createRouter({
  history: createWebHashHistory(),
  routes,
});

export default router;
