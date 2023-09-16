import React, { useEffect, useRef } from "react";
import "./login.css";
import { UserOutlined } from "@ant-design/icons";
import { Input, Button } from "antd";
import LoginRequest from "../../requests/loginRequest";
import { useNavigate } from "react-router-dom";
import Bo from "../../components/loginComponents/bo/bo";

export default function Login() {
  let userNameRef = useRef("");
  let passwordRef = useRef("");
  const nav = useNavigate();

  useEffect(() => {
    // 判断是否已经登录，如果已经登录直接跳转到host页面
    // (async function judge() {
    //   const res = await LoginRequest.judgeLogin();
    //   if (res.code === 4000) {
    //     nav("/dataHost");
    //   }
    // })();
  }, []);

  // 点击登录
  const clickOnLogin = async () => {
    const userName = userNameRef.current;
    const password = passwordRef.current;
    if (!userName || !password) {
      alert("用户名或密码不能为空！");
      return;
    } else if (userName.length >= 100 || password.length >= 100) {
      alert("请输入有效长度的值！");
      return;
    }
    const res = await LoginRequest.login(userName, password);
    if (res.success) {
      if (res.data.errors) {
        alert(res.data.errors[0]);
      } else {
        localStorage.setItem(
          "token",
          res.data.token_type + " " + res.data.access_token
        );
        nav("/dataHost", { replace: true });
      }
    } else {
      alert(res.data.message);
    }
  };

  const clickOnKeyDown = (event) => {
    if (event.key === "Enter") {
      clickOnLogin();
    }
  };

  return (
    <div className="login-body" onKeyDown={clickOnKeyDown}>
      <Bo></Bo>
      <div className="login-content">
        <div className="login-content-title">
          <svg
            t="1687689207775"
            className="icon"
            viewBox="0 0 1024 1024"
            version="1.1"
            xmlns="http://www.w3.org/2000/svg"
            p-id="4096"
            width="40"
            height="40"
          >
            <path
              d="M289.773614 1024v-47.163154h450.847776v47.163154H289.773614zM734.226386 943.263076V653.889149l-430.064013 0.799376V943.263076h-58.35441c-41.567525 0-71.144418-11.191257-88.73068-34.373146-27.178767-35.172521-18.385636-86.332553-8.79313-121.505074l55.956284-211.035129c7.993755-37.570648 25.580016-69.545667 53.558158-95.125683l7.993755-7.19438L399.288056 439.656518c-11.191257-8.79313-20.783763-19.185012-30.376268-30.376268-23.981265-29.576893-41.567525-66.348165-49.561281-107.116316v-1.598751c-11.990632-91.128806-11.990632-169.467603-0.799375-239.01327l1.598751-8.793131 8.79313-6.395004C374.507416 15.188134 418.473068 0 463.238095 0c39.968774 0 74.34192 11.990632 107.915691 23.981265 30.376269 10.391881 58.354411 20.783763 88.730679 20.783762 7.194379 0 13.589383-0.799375 20.783763-1.598751l23.981265-3.996877 3.197502 23.981265c8.79313 71.144418 6.395004 171.86573-5.595629 235.815768-7.194379 41.567525-24.78064 79.937549-50.360656 111.113193a244.608899 244.608899 0 0 1-28.777517 28.777518L767.800156 474.82904l8.79313 11.191257c14.388759 19.185012 33.57377 63.150664 33.573771 63.150663l8.79313 27.178767 55.956285 211.035129c9.592506 35.172521 18.385636 86.332553-8.793131 121.505074-17.586261 23.181889-47.962529 34.373146-89.530055 34.373146h-42.3669zM288.174863 517.195941c-18.385636 17.586261-31.175644 41.567525-37.570648 69.545667l-55.956284 211.834504c-10.391881 39.968774-9.592506 67.147541 0.799376 80.736925 7.993755 10.391881 25.580016 15.98751 51.160031 15.987509h10.391881V606.725995h204.640125l-51.959406-110.313817-10.391882-7.993755L288.174863 517.195941z m494.014052 378.903981c23.181889-0.799375 39.169399-6.395004 47.163154-15.98751 10.391881-13.589383 10.391881-40.76815 0-80.736924l-47.163154-179.859485v276.583919zM515.197502 609.124122l61.551913-142.288837c-20.783763 8.79313-43.965652 13.589383-66.348166 13.589383-21.583138 0-42.366901-3.996877-61.551913-11.990632l66.348166 140.690086z m261.395784-3.197502l-3.996877-18.385636c-5.595628-25.580016-16.786885-50.360656-31.975019-71.144419l-114.310695-27.978142-10.391882 7.194379-47.962529 110.313818h208.637002zM364.115535 79.937549c-8.79313 61.551913-7.993755 134.295082 2.398126 214.232631 6.395004 32.774395 19.984387 62.351288 39.968775 85.533177 27.978142 34.373146 65.54879 53.558158 104.718189 53.558157s75.940671-19.185012 104.718188-53.558157c19.984387-24.78064 34.373146-55.956284 39.968775-89.530055 9.592506-52.758782 12.790008-134.295082 7.194379-199.044496h-2.398126c-39.169399 0-73.542545-11.990632-104.718189-23.18189C524.790008 56.75566 496.01249 46.363778 464.037471 46.363778c-33.57377 0.799375-64.749415 11.191257-99.921936 33.573771z"
              p-id="4097"
              fill="#707070"
            ></path>
          </svg>
          <span>面试端</span>
        </div>
        <div className="login-content-input-body">
          <div>
            <Input
              size="large"
              placeholder="请输入用户名"
              prefix={<UserOutlined />}
              onChange={(event) => {
                userNameRef.current = event.target.value;
              }}
            />
          </div>

          <div>
            <Input.Password
              size="large"
              placeholder="请输入密码"
              onChange={(event) => {
                passwordRef.current = event.target.value;
              }}
            />
          </div>
        </div>
        <div style={{ textAlign: "center" }}>
          <Button type="primary" size="large" onClick={clickOnLogin}>
            Click here,Login
          </Button>
        </div>
      </div>
    </div>
  );
}
