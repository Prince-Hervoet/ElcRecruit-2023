import axios from "axios";
import { ServiceUrls } from "./util";

// 分页 pageCount：页码  pageLimit：每页显示的数量

/**
 * 按照部门id获取部门报名信息 分页
 * @param {部门id 0表示全部 10表示调剂} depId
 * @param {*} pageCount
 * @param {*} pageLimit
 * @returns 简要信息: 姓名、部门、学号、学院、班级
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

// 按照部门id获取部门的总人数
async function getDepSizeById(depId) {}

// 按照学生id获取个人信息
async function getStudentInfoById(stuId) {}

// 获取当前部门的签到列表
async function getCheckinInfos(depId) {}

// 获取当前总进度
async function getCurrentProcess() {}

// 更新学生的面试状态
async function updateStudentStatus(stuId, nStatus) {}

// 更新评价和评分
async function updateCommentAndScore(stuId, content, score) {}

const DataRequest = {
  getInfosByDepId: getBriefInfosByDepId,
  getAdjustInfos,
  getDepartmentSizeById: getDepSizeById,
  getStudentInfoById,
  getCheckinInfos,
  getCurrentProcess,
  updateStudentStatus,
  updateCommentAndScore,
};

export default DataRequest;
