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
async function pushProcess() {}

export const AdminRequest = {
  getCurrentProcess,
  pushProcess,
};
