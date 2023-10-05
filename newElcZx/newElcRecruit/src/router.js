import { createRouter, createWebHashHistory } from "vue-router";
import Welcome from "./views/Welcome.vue";
import Stepper from "./views/Stepper.vue";
import Login from "./views/Login.vue";
import UserInfoForm from "./views/UserInfoForm.vue";
import KnowMore from "./views/KnowMore.vue";
const routes = [
  {
    path: "/",
    component: UserInfoForm,
  },
  {
    path: "/login",
    component: Login,
  },
  {
    path: "/stepper",
    component: Stepper,
  },
  {
    path: "/userInfoForm",
    component: UserInfoForm,
  },
  {
    path: "/Welcome",
    component: Welcome,
  },
  {
    path: "/knowMore",
    component: KnowMore,
  },
];

const router = new createRouter({
  history: createWebHashHistory(),
  routes,
});

export default router;
