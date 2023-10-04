import { createRouter, createWebHashHistory } from "vue-router";
import Welcome from "./views/Welcome.vue";
import Stepper from "./views/Stepper.vue";
import Login from "./views/Login.vue"
// import PostInfo from "./views/PostInfo.vue"
const routes = [
  { 
    path: "/",
    component: Login
  },
  {
    path:"/Stepper",
    component:Stepper
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
