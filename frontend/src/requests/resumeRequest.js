import axios from "axios";
import { ServiceUrls } from "./util";

/**
 * 获取学生个人信息
 * @param {string} userId
 */
async function sendGetStudentInfo(userId) {
  const url = ServiceUrls.getDetailedInfo + `?userId=${userId}`;
  const ans = {};
  try {
    const res = await axios({
      method: "GET",
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

/**
 * 获取所有评论
 * @param {string} userId
 * @returns {object}
 */
async function sendGetComments(userId) {
  const url = ServiceUrls.getCommentAndScore + `?studentUserId=${userId}`;
  const ans = {};
  try {
    const res = await axios({
      method: "GET",
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

/**
 * 更新学生状态
 * @param {string} userId
 * @param {number} nStatus
 */
async function sendUpdateStudentStatus(userId, nStatus) {
  const url = ServiceUrls.updateStudentStatus;
  const ans = { success: true };
  try {
    const res = await axios({
      method: "POST",
      data: {
        userId,
        state: nStatus,
      },
      url,
    });
    ans.data = res.data;
  } catch (e) {
    ans.success = false;
    ans.data = e;
  }
  return ans;
}

/**
 * 提交评论和评分
 * @param {string} userId
 * @param {string} interviewerName
 * @param {string} content
 * @param {number} score
 */
async function sendCommentAndScore(userId, interviewerName, content, score) {
  const url = ServiceUrls.commitComment;
  const ans = { success: true };
  try {
    const res = await axios({
      method: "POST",
      data: {
        id: "",
        studentUserId: userId,
        interviewerName,
        score,
        content,
      },
      url,
    });
    ans.data = res.data;
  } catch (e) {
    ans.success = false;
    ans.data = e;
  }
  return ans;
}

export const ResumeRequest = {
  sendCommentAndScore,
  sendGetComments,
  sendGetStudentInfo,
  sendUpdateStudentStatus,
};
