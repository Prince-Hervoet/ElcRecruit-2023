import { createRouter, createWebHashHistory } from "vue-router";
import Stepper from "./views/Stepper.vue";
import Login from "./views/Login.vue";
import Register from "./views/Register.vue";
import UserInfoForm from "./views/UserInfoForm.vue";
import DepIntros from "./views/DepIntros.vue";
import KnowElc from "./views/KnowElc.vue";
import NewWelcome from "./views/NewWelcome.vue";
import ForgetPassword from "./views/ForgetPassword.vue";
import Welcome from "./views/Welcome.vue";

const routes = [
  {
    path: "/",
    component: Login,
  },
  {
    path: "/login",
    component: Login,
  },
  {
    path: "/register",
    component: Register,
  },
  {
    path: "/forgetPassword",
    component: ForgetPassword,
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
    path: "/newWelcome",
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
  {
    path: "/register",
    component: Register,
  },
  { path: "/welcome", component: Welcome },
];

const router = new createRouter({
  history: createWebHashHistory(),
  routes,
});

export default router;
