import axios from "axios";
import { ServiceUrls } from "./util";

// 登录
async function login(userName, password) {
  const url = ServiceUrls.login;
  const res = await axios({
    method: "POST",
    data: { userName, password },
    url,
  });
  return res;
}

// 获取当前登录状态
async function judgeLoginStatus() {}

const LoginRequest = {
  login,
  judgeLoginStatus,
};

export default LoginRequest;
