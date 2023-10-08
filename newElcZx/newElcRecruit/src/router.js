import { createRouter, createWebHashHistory } from "vue-router";
import Stepper from "./views/Stepper.vue";
import Login from "./views/Login.vue";
import Register from "./views/Register.vue";
import UserInfoForm from "./views/UserInfoForm.vue";
import DepIntros from "./views/DepIntros.vue";
import KnowElc from "./views/KnowElc.vue";
import NewWelcome from "./views/NewWelcome.vue";
<<<<<<< HEAD
import ForgetPassword from "./views/ForgetPassword.vue";
=======

>>>>>>> 84fe03d11ea6bfa86a8f636a851719f8b2772da2
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
    path: "/welcome",
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
];

const router = new createRouter({
  history: createWebHashHistory(),
  routes,
});

export default router;
