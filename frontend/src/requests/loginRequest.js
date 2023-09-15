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
  const ans = {};
  try {
    const res = await axios({
      method: "POST",
      data: { userName, password },
      url,
    });
    ans.success = true;
    ans.data = res.data;
  } catch (e) {
    ans.success = false;
    ans.data = e;
  }
  return ans;
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
