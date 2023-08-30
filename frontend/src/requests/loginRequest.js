import axios from "axios";
import { ServiceUrls } from "./util";

/**
 * 登录成功之后，后端需要返回当前用户token，用户所属的部门
 */

/**
 * @param {string} userName 用户名
 * @param {string} password 密码
 * @returns {token:"AAAA",currentDepId:"1"}
 */
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
      currentDepId: "12",
    },
  };
  return res;
}

/**
 * 获取当前登录状态
 * @returns "{}"
 */
async function judgeLogin() {
  const token = localStorage.getItem("token");
  const res = {
    code: 4002,
    msg: "scuccess",
    data: {},
  };
  return res;
}

const LoginRequest = {
  login,
  judgeLogin,
};

export default LoginRequest;
