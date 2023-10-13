import { ServiceUrls, commonRequest } from "./util";

/**
 * @param {string} userName 用户名
 * @param {string} password 密码
 * @returns {token:"AAAA",currentDepId:"1"}
 */
async function login(userName, password) {
  const res = await commonRequest("POST", ServiceUrls.login, {
    userName,
    password,
  });
  return res;
}

async function judgeLogin() {
  const res = await commonRequest("GET", ServiceUrls.judgeLogin);
  return res;
}

export const LoginRequest = {
  login,
  judgeLogin,
};
