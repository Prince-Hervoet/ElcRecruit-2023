import { ServiceUrls } from "./util";

export async function sendSubmitForm(sendObj) {
  const url = ServiceUrls.submit;
  return { code: 4000, msg: "success" };
}
