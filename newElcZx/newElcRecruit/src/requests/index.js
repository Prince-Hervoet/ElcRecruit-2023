import { axios } from "axios";
import { ServiceUrls } from "./util";

async function getUserInfo(userId) {
  const url = ServiceUrls.login;
  // todo: 写axios
}

export const IndexRequest = {
  getUserInfo,
};
