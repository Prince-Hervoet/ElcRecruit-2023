import { createRouter, createWebHashHistory } from "vue-router";
import Welcome from "./views/Welcome.vue";
import Stepper from "./views/Stepper.vue";
import Login from "./views/Login.vue";
import UserInfoForm from "./views/UserInfoForm.vue";
import DepIntro from "./views/DepIntro.vue";
import KnowMore from "./views/KnowMore.vue";
import NewWelcome from "./views/NewWelcome.vue"
const routes = [
  {
    path: "/",
    component: NewWelcome,
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
    path: "/welcome",
    component: Welcome,
  },
  {
    path: "/depIntro",
    component: DepIntro,
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
