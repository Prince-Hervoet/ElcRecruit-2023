import Admin from "../pages/admin/admin";
import DataHost from "../pages/dataHost/dataHost";
import Login from "../pages/login/login";
import Resume from "../pages/resume/resume";

export const routerInfos = [
  {
    name: "index",
    path: "/",
    element: Login,
  },
  {
    name: "login",
    path: "/login",
    element: Login,
  },
  {
    name: "resume",
    path: "/resume",
    element: Resume,
  },
  {
    name: "admin",
    path: "/admin",
    element: Admin,
  },
  {
    name: "dataHost",
    path: "/dataHost",
    element: DataHost,
  },
];
