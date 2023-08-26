import Admin from "../pages/admin/admin";
import Host from "../pages/host/host";
import Login from "../pages/login/login";
import Resume from "../pages/resume/resume";

export const routerInfos = [
  {
    name: "index",
    path: "/",
    element: Login,
    data: {},
  },
  {
    name: "host",
    path: "/host",
    element: Host,
    data: {},
  },
  {
    name: "login",
    path: "/login",
    element: Login,
    data: {},
  },
  {
    name: "resume",
    path: "/resume",
    element: Resume,
    data: {},
  },
  {
    name: "admin",
    path: "/admin",
    element: Admin,
    data: {},
  },
];
