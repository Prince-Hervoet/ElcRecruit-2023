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
  const url = ServiceUrls.login;
  const res = await axios({
    method: "POST",
    data: { userName, password },
    url,
  });
  if (res.status !== 200) {
    return { code: 4002, msg: "请求失败" };
  }
  const { access_token, token_type, errors } = res.data;
  if (errors) {
    return { code: 4002, msg: "账号或密码错误" };
  }
  return {
    code: 4000,
    msg: "登录成功",
    data: { token: token_type + " " + access_token },
  };
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
