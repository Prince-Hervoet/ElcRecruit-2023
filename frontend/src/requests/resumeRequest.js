import { ServiceUrls, commonRequest } from "./util";

/**
 * 获取学生个人信息
 * @param {string} userId
 */
async function sendGetStudentInfo(userId) {
  const res = await commonRequest(
    "GET",
    `${ServiceUrls.getDetailedInfo}?userId=${userId}`
  );
  return res;
}

/**
 * 获取所有评论
 * @param {string} userId
 * @returns {object}
 */
async function sendGetComments(userId) {
  const res = commonRequest(
    "GET",
    `${ServiceUrls.getCommentAndScore}?studentUserId=${userId}`
  );
  return res;
}

/**
 * 更新学生状态
 * @param {string} userId
 * @param {number} nStatus
 */
async function sendUpdateStudentStatus(userId, nStatus) {
  const res = await commonRequest("POST", ServiceUrls.updateStudentStatus, {
    userId,
    state: nStatus,
  });
  return res;
}

/**
 * 提交评论和评分
 * @param {string} userId
 * @param {string} interviewerName
 * @param {string} content
 * @param {number} score
 */
async function sendCommentAndScore(userId, interviewerName, content, score) {
  const res = await commonRequest("POST", ServiceUrls.commitComment, {
    id: "",
    studentUserId: userId,
    interviewerName,
    score,
    content,
  });
  return res;
}

async function transferStudent(userId, sourceDepId, targetDepId) {
  const res = await commonRequest("POST", ServiceUrls.transferStudent, {
    studentId: userId,
    sourceDepId,
    targetDepId,
  });
  return res;
}

export const ResumeRequest = {
  sendCommentAndScore,
  sendGetComments,
  sendGetStudentInfo,
  sendUpdateStudentStatus,
  transferStudent,
};
