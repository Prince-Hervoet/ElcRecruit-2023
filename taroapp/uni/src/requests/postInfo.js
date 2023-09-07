import { ServiceUrls } from "./util";
import axios from "axios";

export async function sendSubmitForm(sendObj) {
  const url = ServiceUrls.submit;
  return { code: 4000, msg: "success" };
}

//提交表单的请求
// clickSubmitForm.onclick = function () {
//   axios
//     .post("/user")
//     .then(function (response) {
//       console.log(response);
//     })
//     .catch(function (error) {
//       console.log(error);
//     });
// };

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
