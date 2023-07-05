// 基础url
const BASE_URL = "http://localhost:3000";

// 请求服务端的所有url集合
export const ServiceUrls = {
  // 登录
  login: `${BASE_URL}/login`,
  // 请求简历
  resume: `${BASE_URL}/#/resume?userId=`,
  // 分页获取人员简要信息
  getBriefInfos: `${BASE_URL}/getBriefInfos`,
  // 获取报名者详细信息
  getDetailedInfo: `${BASE_URL}/getDetailedInfo`,
  // 更改学生面试状态
  updateStudentStatus: `${BASE_URL}/updateStudentStatus`,
};

export const Defined = {
  SUCCESS: "",
};

export const httpCodeObj = {
  200: "success",
  400: "请求有误",
  403: "权限不足",
  500: "服务器繁忙",
};

export const myCodeObj = {
  4000: "处理成功",
  4002: "处理失败",
  4005: "处理异常",
};

export function getToken() {
  return localStorage.getItem("token");
}

export function setToken(token) {
  localStorage.setItem("token", token);
}

export function clearToken() {
  localStorage.removeItem("token");
}
