import axios from "axios";
import { ServiceUrls } from "./util";

// 分页 pageCount：页码  pageLimit：每页显示的数量

/**
 * 按照部门id获取部门报名信息 分页
 * @param {string} depId 部门id 0表示全部 100表示调剂
 * @param {number} pageCount
 * @param {number} pageLimit
 * @returns 简要信息 {uid:"1Njd12",name:"张三",depId:"1",stuId:"3120003333",college:"ddd",major:"光电",status:10}
 */
async function getBriefInfosByDepId(depId, pageCount, pageLimit) {
  const url = ServiceUrls.getBriefInfos;
  const res = await axios({
    method: "GET",
    data: { depId, pageCount, pageLimit },
    url,
  });
  try {
    res.data = JSON.parse(res.data);
  } catch (e) {
    res.data = {};
    console.log(e);
  }
  return res;
}

// 获取当前部门的调剂列表
async function getAdjustInfos(depId) {}

/**
 * 按照部门id获取部门的总人数
 * @param {string} depId
 * @returns "[{depId:"1",size:"42"},{},{}]"
 */
async function getDepSizeById(depId) {}

/**
 * 按照学生id获取个人信息
 * @param {string} uid
 * @returns "{stuId:"3120003333",name:"张三",phoneNum:"1903129394",college:"1",grade:"光电4班",skills:"adf",intro:"adjflk1"}"
 */
async function getDetailedInfoById(uid) {}

/**
 * 获取当前部门的签到列表
 * @param {string} depId
 * @returns "{uid:"123123",name:"张三",stuId:"3120007433"}"
 */
async function getCheckinInfos(depId) {}

/**
 * 获取当前总进度
 * @returns "{currentProcess:"10"}"
 */
async function getCurrentProcess() {}

// 更新学生的面试状态
async function updateStudentStatus(uid, nStatus) {}

/**
 * 更新评价和评分
 * @param {string} uid
 * @param {string} content
 * @param {number} score
 */
async function updateCommentAndScore(uid, content, score) {}

/**
 * 获取指定学生的评论
 * @param {string} uid
 * @returns "[{interviewerName:"年少",content:"123123",score:12},{},{}]"
 */
async function getCommentsByUid(uid) {}

const DataRequest = {
  getBriefInfosByDepId,
  getAdjustInfos,
  getDepSizeById,
  getDetailedInfoById,
  getCheckinInfos,
  getCurrentProcess,
  updateStudentStatus,
  updateCommentAndScore,
};

export default DataRequest;
