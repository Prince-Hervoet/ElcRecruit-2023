import axios from "axios";
import { ServiceUrls } from "./util";

/**
 * 获取当前进度
 */
async function getCurrentProcess() {
  const url = ServiceUrls.getCurrentProcess;
  let ans = {};
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
 * 推进进度
 */
async function pushProcess(isForce) {
  const url = ServiceUrls.pushCurrentProcess + `?force=${isForce}`;
  let ans = {};
  try {
    const res = await axios({
      method: "POST",
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

async function exportMenu(status, depId) {
  let url = ServiceUrls.exportMenu;
  if (status && depId) {
    url += `?studentState=${status}&department=${depId}`;
  }
  let ans = {};
  try {
    const res = await axios({
      method: "GET",
      url,
    });
    const blob = new Blob([res.data], { type: "application/vnd.ms-excel" });
    const objectUrl = URL.createObjectURL(blob);
    window.location.href = objectUrl;
    URL.revokeObjectURL(objectUrl);
    ans.success = true;
    ans.data = res.data;
  } catch (e) {
    ans.success = false;
    ans.data = e;
  }
  return ans;
}

export const AdminRequest = {
  getCurrentProcess,
  pushProcess,
  exportMenu,
};
