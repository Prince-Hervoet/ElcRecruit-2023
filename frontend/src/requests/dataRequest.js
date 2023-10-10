import { ServiceUrls, commonRequest } from "./util.js";

// 分页 pageCount：页码  pageLimit：每页显示的数量

/**
 * 按照部门id获取部门报名信息 分页
 * @param {number} depId 部门id 0表示全部 100表示调剂
 * @param {number} pageCount 页码
 * @param {number} pageLimit 每页数量
 * @returns {uid:"1Njd12",name:"张三",depId:"1",stuId:"3120003333",college:"ddd",major:"光电",status:10}
 */
async function getBriefInfosByDepId(depId, pageCount, pageLimit) {
  const res = await commonRequest(
    "GET",
    `${ServiceUrls.getBriefInfos}?depId=${depId}&pageCount=${pageCount}&pageLimit=${pageLimit}`
  );
  return res;
}

/**
 * 按照部门id获取部门的总人数
 * @returns {[{depId:1,size:"42"},{},{}]}
 */
async function getDepSizeList() {
  const res = await commonRequest("GET", ServiceUrls.getDepSizeList);
  return res;
}

/**
 * 搜索
 * @param {string} keyword
 * @param {number} depId
 */
async function getSearchBriefInfo(keyword, depId) {
  const res = await commonRequest(
    "GET",
    `${ServiceUrls.getSearchBriefInfo}?keyword=${keyword}&depId=${depId}`
  );
  return res;
}

const DataRequest = {
  getBriefInfosByDepId,
  getDepSizeList,
  getSearchBriefInfo,
};

export default DataRequest;
