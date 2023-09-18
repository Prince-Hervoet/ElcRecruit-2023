import { ServiceUrls } from "./util";

export async function sendSubmitForm(sendObj) {
  const url = ServiceUrls.submit;
  return { code: 4000, msg: "success" };
}

//提交表单的请求
// clickSubmitForm.onclick = function () {
//   axios
//     .post("elc_recruit/student/commit")
//     .then(function (response) {
//       console.log(response);
//     })
//     .catch(function (error) {
//       console.log(error);
//     });
// };

wx.login({
  success(res) {
    if (res.code) {
      //发起网络请求
      wx.request({
        url: "http://192.168.123.86:8081/elc_recruit/interviewer/WeChatLogin",
        data: {
          code: res.code,
        },
      });
    } else {
      console.log("登录失败！" + res.errMsg);
    }
  },
});

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
