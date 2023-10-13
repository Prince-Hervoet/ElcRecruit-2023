export const BASE_URL = "https://recruit.gdutelc.com";

/**
 * 服务端接口url
 */
export const ServiceUrls = {
  login: `${BASE_URL}/xxx/login`,
  getInfo: `/elc_recruit/student/get_info`,
  getProcess: `/elc_recruit/student/get_process`,
  getLogin:`/elc_recruit/interviewer/student_login`,
  getCode:`/elc_recruit/student/send_verification_code?`,
  getRegister:`/elc_recruit/interviewer/register_student?`,
  getCommit:`/elc_recruit/student/commit`,
  getForget:`/elc_recruit/interviewer/reset_password?`,
  getCheck:`/elc_recruit/student/is_logined`,
  getCurrent:`/elc_recruit/root/get_current_process`,
};
