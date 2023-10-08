import { createRouter, createWebHashHistory } from "vue-router";
import Welcome from "./views/Welcome.vue";
import Stepper from "./views/Stepper.vue";
import Login from "./views/Login.vue";
import Register from "./views/Register.vue";
import UserInfoForm from "./views/UserInfoForm.vue";
import DepIntros from "./views/DepIntros.vue";
import KnowElc from "./views/KnowElc.vue";
import NewWelcome from "./views/NewWelcome.vue";
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
    path: "/welcome",
    component: Welcome,
  },
  {
    path: "/Newwelcome",
    component: NewWelcome,
  },
  {
    path: "/Newwelcome",
    component: NewWelcome,
  },
  {
    path: "/depIntros/:depId",
    name: "depIntros",
    component: DepIntros,
  },
  {
    path: "/knowElc",
    component: KnowElc,
  },
];

const router = new createRouter({
  history: createWebHashHistory(),
  routes,
});

export default router;
