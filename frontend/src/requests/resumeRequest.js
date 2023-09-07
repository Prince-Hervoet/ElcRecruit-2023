import { ServiceUrls } from "./util";

/**
 * 获取学生个人信息
 * @param {*} userId
 */
async function sendGetStudentInfo(userId) {}

/**
 * 获取所有评论
 * @param  userId
 */
async function sendGetComments(userId) {}

/**
 * 更新学生状态
 * @param {*} nStatus
 */
async function sendUpdateStudentStatus(nStatus) {}

/**
 * 提交评论和评分
 * @param {*} comment
 * @param {*} score
 * @param {*} userName
 */
async function sendCommentAndScore(comment, score, userName) {}

export const ResumeRequest = {
  sendCommentAndScore,
  sendStartInterview,
  sendGetComments,
  sendGetStudentInfo,
  sendUpdateStudentStatus,
};
