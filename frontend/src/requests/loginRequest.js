import axios from "axios";
import { ServiceUrls } from "./util";

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

export const LoginRequest = {
  login,
};
