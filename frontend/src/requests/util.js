import axios from "axios";

// 基础url
const BASE_URL = "http://localhost:3000";

// 默认每页显示的数量
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
  // 提交评论
  commitComment: `${BASE_URL}/elc_recruit/interviewer/commit_comment`,
  // 获取所有评论
  getCommentAndScore: `${BASE_URL}/elc_recruit/interviewer/get_comment_score`,
  // 搜索
  getSearchBriefInfo: `${BASE_URL}`,
};

// 请求头加上token
axios.interceptors.request.use(function (config) {
  const token = localStorage.getItem("token");
  if (token) {
    config.headers = {
      Authorization: token,
    };
  }
  return config;
});
