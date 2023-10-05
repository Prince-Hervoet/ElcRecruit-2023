// 基础url
export const BASE_URL = "http://localhost:3000";

// 默认每页显示的数量
export const DEFAULT_PAGE_LIMIT = 7;

// 请求服务端的所有url集合
export const ServiceUrls = {
  // 登录
  login: `/elc_recruit/interviewer/Login`,
  // 判断是否登录
  judgeLogin: `/judgeLogin`,
  // 请求简历
  resume: `/#/resume?userId=`,
  // 分页获取人员简要信息
  getBriefInfos: `/elc_recruit/interviewer/get_brief_infos`,
  // 获取报名者详细信息
  getDetailedInfo: `/elc_recruit/interviewer/get_detailed_info`,
  // 获取部门总人数列表
  getDepSizeList: `/elc_recruit/interviewer/get_deps_size`,
  // 更改学生面试状态
  updateStudentStatus: `/elc_recruit/interviewer/update_student_status`,
  // 提交评论
  commitComment: `/elc_recruit/interviewer/commit_comment`,
  // 获取所有评论
  getCommentAndScore: `/elc_recruit/interviewer/get_comment_score`,
  // 修改学生第一志愿
  transferStudent: `/elc_recruit/interviewer/transfer_student`,
  // 搜索
  getSearchBriefInfo: `${BASE_URL}`,
  // 获取当前进度
  getCurrentProcess: `/elc_recruit/root/get_current_process`,
  // 推进进度
  pushCurrentProcess: `/elc_recruit/root/push_status`,
  // 导出名单
  exportMenu: `/elc_recruit/root/ex_access`,
};
