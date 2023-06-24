import axios from "axios";

// 获取所有部门报名信息 分页
async function getAllInfos(pageCount, pageLimit) {}

// 按照部门id获取部门报名信息 分页
async function getInfosByDepartmentId(depId, pageCount, pageLimit) {}

// 获取当前部门的调剂列表
async function getAdjustInfos(depId) {}

// 按照部门id获取部门的总人数
async function getDepartmentSizeById(depId) {}

// 按照学生id获取个人信息
async function getStudentInfoById(stuId) {}

// 获取当前部门的签到列表
async function getCheckinInfos(depId) {}

// 更新学生的面试状态
async function updateStudentStatus(stuId, nStatus) {}

// 更新评价和评分
async function updateCommentAndScore(stuId, content, score) {}

// 获取当前总进度
async function getCurrentProcess() {}
