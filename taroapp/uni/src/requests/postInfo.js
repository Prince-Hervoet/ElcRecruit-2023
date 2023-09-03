import { ServiceUrls } from "./util";

export async function sendSubmitForm(sendObj) {
  const url = ServiceUrls.submit;
  return { code: 4000, msg: "success" };
}

export async function sendGetInfo(openId) {
  const url = ServiceUrls.getInfo + `?openId=${openId}`;
  return {
    code: 4000,
    msg: "success",
    data: {
      studentName: "test",
      studentId: "test",
      college: "test",
      major: "test",
      clazz: "test",
      phoneNum: "test",
      firstDepId: "test",
      secondDepId: "test",
      intro: "test",
      qq: "test",
      skills: "test",
    },
  };
}
