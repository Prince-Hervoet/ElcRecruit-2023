import axios from "axios";
import { ServiceUrls } from "./util";

// 登录
async function login(userName, password) {
  // const url = ServiceUrls.login;
  // const res = await axios({
  //   method: "POST",
  //   data: { userName, password },
  //   url,
  // });
  const res = {
    code: 4000,
    msg: "success",
    data: {
      token:
        "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c",
    },
  };
  return res;
}

// 获取当前登录状态
async function judgeLoginStatus() {}

const LoginRequest = {
  login,
  judgeLoginStatus,
};

export default LoginRequest;
