import { axios } from "axios";
import { ServiceUrls } from "./util";

async function getUserInfo(userId) {
  const url = ServiceUrls.login;
  // todo: 写axios
}

/**
 * 暴露出去，让页面js代码引用
 */
export const IndexRequest = {
  getUserInfo,
};
