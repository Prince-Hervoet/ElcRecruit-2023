// 基础url
const BASE_URL = "http://localhost:3000";

// 请求服务端的所有url集合
export const ServiceUrls = {
  // 登录
  login: `${BASE_URL}/elc_recruit/interviewer/Login`,
  // 判断是否登录
  judgeLogin: `${BASE_URL}/judgeLogin`,
  // 请求简历
  resume: `${BASE_URL}/#/resume?userId=`,
  // 分页获取人员简要信息
  getBriefInfos: `${BASE_URL}/getBriefInfos`,
  // 获取报名者详细信息
  getDetailedInfo: `${BASE_URL}/getDetailedInfo`,
  // 更改学生面试状态
  updateStudentStatus: `${BASE_URL}/updateStudentStatus`,
};
