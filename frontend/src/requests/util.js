import axios from "axios";

// 基础url
const BASE_URL = "http://localhost:3000";

export const DEFAULT_PAGE_LIMIT = 7;

// 请求服务端的所有url集合
export const ServiceUrls = {
  // 登录
  login: `${BASE_URL}/elc_recruit/interviewer/Login`,
  // 判断是否登录
  judgeLogin: `${BASE_URL}/judgeLogin`,
  // 请求简历
  resume: `${BASE_URL}/#/resume?userId=`,
  // 分页获取人员简要信息
  getBriefInfos: `${BASE_URL}/elc_recruit/interviewer/get_brief_infos`,
  // 获取报名者详细信息
  getDetailedInfo: `${BASE_URL}/elc_recruit/interviewer/get_detailed_info`,
  // 获取部门总人数列表
  getDepSizeList: `${BASE_URL}/elc_recruit/interviewer/get_deps_size`,
  // 更改学生面试状态
  updateStudentStatus: `${BASE_URL}/elc_recruit/interviewer/update_student_status`,
};

export const TestToken =
  "bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJqdGkiOiJlMWI3MWU0Ni1iOTJhLTQ0ZmQtOGU1Ny01NGMwMDA2Zjc1MWIiLCJzdWIiOiIxNjhmMjdiMS1iNGRiLTQ4NmItODVkNy02MDIwZGM2YTQxMWIiLCJyb2xlIjoiSW50ZXJ2aWV3ZXIiLCJuYmYiOjE2OTQ3OTExMzEsImV4cCI6MTY5Njg2NDczMSwiaWF0IjoxNjk0NzkxMTMxfQ.kWQA84oWiT8ylX48pF9gynozWaALv7HLai7X2Y2UbQU";

axios.interceptors.request.use(function (config) {
  const token = localStorage.getItem("token");
  if (token) {
    config.headers = {
      Authorization: token,
    };
  }
  return config;
});
