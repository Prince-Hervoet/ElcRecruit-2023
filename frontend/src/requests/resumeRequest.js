import axios from "axios";
import { ServiceUrls, TestToken } from "./util";

/**
 * 获取学生个人信息
 * @param {*} userId
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
 * @param  userId
 */
async function sendGetComments(userId) {}

/**
 * 更新学生状态
 * @param {*} nStatus
 */
async function sendUpdateStudentStatus(userId, nStatus) {
  const url =
    ServiceUrls.updateStudentStatus + `?userId=${userId}&state=${nStatus}`;
  const ans = { success: true };
  try {
    const res = await axios({
      method: "GET",
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
 * @param {*} comment
 * @param {*} score
 * @param {*} userName
 */
async function sendCommentAndScore(comment, score, userName) {}

export const ResumeRequest = {
  sendCommentAndScore,
  sendGetComments,
  sendGetStudentInfo,
  sendUpdateStudentStatus,
};
