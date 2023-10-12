import React, { useEffect, useRef, useState } from "react";
import { Descriptions, Input, Rate, List, Select } from "antd";
import {
  CaretRightOutlined,
  LoginOutlined,
  CloseOutlined,
  UpSquareOutlined,
} from "@ant-design/icons";
import { Button } from "antd";
import "./resume.css";
import { getUrlParam } from "../../toolFuncs";
import { ResumeRequest } from "../../requests/resumeRequest";
import { CollegeObj, KeyToDepName, StudentStatusObj } from "../../store/global";
const { TextArea } = Input;

export default function Resume() {
  const [items, setItems] = useState({});
  const [studentStatusStr, setStudentStatueStr] = useState("");
  const [showUpdateFirstDep, setShowUpdateFirstDep] = useState(false);
  const [commentAndScores, setCommentAndScores] = useState([]);
  const [comment, setComment] = useState("");
  const [score, setScore] = useState("");
  const [interviewerName, setInterviewerName] = useState("");
  const targetDepIdRef = useRef("7");
  const userIdRef = useRef("");

  // 进入页面完成挂载时，请求数据和评论
  useEffect(() => {
    userIdRef.current = getUrlParam("userId");
    sendGetUserInfo();
    sendGetComments();
    try {
      const roleData = JSON.parse(localStorage.getItem("roleJson"));
      if (roleData.role.includes("Admin")) {
        setShowUpdateFirstDep(true);
      }
    } catch (e) {}
  }, []);

  const sendGetUserInfo = async () => {
    const res = await ResumeRequest.sendGetStudentInfo(userIdRef.current);
    if (res.isRequestSuccess) {
      const responseData = res.data.data;
      if (!responseData.success) {
        alert(`处理失败: ${responseData.errorMessages[0]}`);
        return;
      }
      const userInfo = responseData.data;
      setItemsFunc(userInfo);
    } else {
      alert(`请求失败: ${res.data.message}`);
    }
  };

  const sendGetComments = async () => {
    const res = await ResumeRequest.sendGetComments(userIdRef.current);
    if (res.isRequestSuccess) {
      const responseData = res.data.data;
      if (!responseData.success) {
        alert("评论获取失败");
        return;
      }
      const commentList = responseData.data;
      setCommentAndScores(commentList);
    } else {
      alert(`请求失败: ${res.data.message}`);
    }
  };

  const setItemsFunc = (userInfo) => {
    userInfo.firstDepName = KeyToDepName[userInfo.firstDepartment];
    userInfo.secondDepName = KeyToDepName[userInfo.secondDepartment];
    userInfo.collegeName = CollegeObj[userInfo.college];
    setItems(userInfo);
    const state = userInfo.state;
    let str = "";
    if (state === 10) {
      str = "/已报名.png";
    } else if (state === 30) {
      str = "/进行中.png";
    } else if (state === 50) {
      str = "/已通过.png";
    } else if (state === 60) {
      str = "/已拒绝.png";
    }
    setStudentStatueStr(str);
  };

  // 开始面试按钮
  const clickStartInterview = async () => {
    const res = await ResumeRequest.sendUpdateStudentStatus(
      userIdRef.current,
      StudentStatusObj.INTERVIEWING
    );
    if (res.isRequestSuccess) {
      const responseData = res.data.data;
      if (!responseData.success) {
        alert(`处理失败: ${responseData.errorMessages[0]}`);
        return;
      }
      alert("修改成功");
      const userInfo = responseData.data;
      setItemsFunc(userInfo);
    } else {
      alert(`请求失败: ${res.data.message}`);
    }
  };

  // 通过按钮
  const clickAccept = async () => {
    const res = await ResumeRequest.sendUpdateStudentStatus(
      userIdRef.current,
      StudentStatusObj.ACCESS
    );
    if (res.isRequestSuccess) {
      const responseData = res.data.data;
      if (!responseData.success) {
        alert(`处理失败: ${responseData.errorMessages[0]}`);
        return;
      }
      alert("修改成功");
      const userInfo = responseData.data;
      setItemsFunc(userInfo);
    } else {
      alert(`请求失败: ${res.data.message}`);
    }
  };

  // 拒绝按钮
  const clickReject = async () => {
    const res = await ResumeRequest.sendUpdateStudentStatus(
      userIdRef.current,
      StudentStatusObj.REJECT
    );
    if (res.isRequestSuccess) {
      const responseData = res.data.data;
      if (!responseData.success) {
        alert(`处理失败: ${responseData.errorMessages[0]}`);
        return;
      }
      alert("修改成功");
      const userInfo = responseData.data;
      setItemsFunc(userInfo);
    } else {
      alert(`请求失败: ${res.data.message}`);
    }
  };

  // 提交评论
  const clickSubmitComment = async () => {
    if (!interviewerName || !comment || !score) {
      alert("请输入完整的评论信息 -- 评论、评分、名字");
      return;
    }
    const res = await ResumeRequest.sendCommentAndScore(
      userIdRef.current,
      interviewerName,
      comment,
      score
    );
    if (res.isRequestSuccess) {
      const responseData = res.data.data;
      if (!responseData.success) {
        alert(`处理失败: ${responseData.errorMessages[0]}`);
        return;
      }
      setCommentAndScores([
        ...commentAndScores,
        { interviewerName, content: comment, score },
      ]);
      setComment("");
      setInterviewerName("");
      setScore("");
      alert("提交成功");
    } else {
      alert(`请求失败: ${res.data.message}`);
    }
  };

  // 评论change触发
  const onChangeComment = (event) => {
    setComment(event.target.value);
  };

  // 评论者change触发
  const onChangeInterviewerName = (event) => {
    setInterviewerName(event.target.value);
  };

  // 评分change触发
  const onChangeScore = (value) => {
    setScore(value);
  };

  const selectSetDepId = (value) => {
    targetDepIdRef.current = value;
  };

  // 修改学生的第一志愿
  const clickTransferStudent = async () => {
    const userId = userIdRef.current;
    const sourceDepId = items.firstDepartment;
    const targetDepId = parseInt(targetDepIdRef.current);
    const res = await ResumeRequest.transferStudent(
      userId,
      sourceDepId,
      targetDepId
    );
    if (res.isRequestSuccess) {
      const responseData = res.data.data;
      if (!responseData.success) {
        alert(`处理失败: ${responseData.errorMessages[0]}`);
        return;
      }
      alert("修改成功");
      const userInfo = responseData.data;
      setItemsFunc(userInfo);
    } else {
      alert(`请求失败: ${res.data.message}`);
    }
  };

  return (
    <div className="resume-body">
      <div className="resume-content-body">
        <div className="resume-content-header">
          <Descriptions
            title="个人信息"
            column={4}
            labelStyle={{ fontWeight: 700, fontSize: "larger" }}
            contentStyle={{ fontSize: "larger" }}
          >
            <Descriptions.Item label="姓名">{items.name}</Descriptions.Item>
            <Descriptions.Item label="学号">
              {items.studentNumber}
            </Descriptions.Item>
            <Descriptions.Item label="学院">
              {items.collegeName}
            </Descriptions.Item>
            <Descriptions.Item label="专业班级">
              {items.grade}
            </Descriptions.Item>
            <Descriptions.Item label="掌握技能">
              {items.skills}
            </Descriptions.Item>
            <Descriptions.Item label="手机号码">
              {items.phone}
            </Descriptions.Item>
            <Descriptions.Item label="qq号码">{items.qq}</Descriptions.Item>
            <Descriptions.Item label="第一志愿">
              {items.firstDepName}
            </Descriptions.Item>
            <Descriptions.Item label="第二志愿">
              {items.secondDepName}
            </Descriptions.Item>
            <Descriptions.Item label="自我介绍">
              {items.introduction}
            </Descriptions.Item>
          </Descriptions>
        </div>
        <div className="resume-content-comment-body">
          <TextArea
            placeholder="请输入一些评论..."
            autoSize={{
              minRows: 8,
              maxRows: 10,
            }}
            styles={{
              fontSize: "16px",
            }}
            onChange={onChangeComment}
            value={comment}
            showCount={true}
            allowClear={true}
          />
        </div>
        <div className="resume-content-comment-buttons-body">
          <Rate count={10} onChange={onChangeScore} value={score} />
          <Input
            size="small"
            placeholder="评价者"
            style={{ width: "10%", marginLeft: 10 }}
            onChange={onChangeInterviewerName}
            value={interviewerName}
          />
          <Button
            style={{ marginLeft: 10 }}
            size={"large"}
            onClick={clickSubmitComment}
            value={score}
            allowClear={true}
            defaultChecked={0}
          >
            提交评论和分数
          </Button>
        </div>

        <div className="resume-content-buttons-body">
          <Button
            type="primary"
            icon={<CaretRightOutlined />}
            size={"large"}
            onClick={clickStartInterview}
          >
            开始面试
          </Button>
          <Button icon={<LoginOutlined />} size={"large"} onClick={clickAccept}>
            通过
          </Button>
          <Button icon={<CloseOutlined />} size={"large"} onClick={clickReject}>
            淘汰
          </Button>
        </div>
        <p></p>
        <div style={showUpdateFirstDep ? {} : { display: "none" }}>
          <Select
            defaultValue="7"
            style={{ width: 150, marginRight: "10px" }}
            options={[
              { value: "1", label: "维修部" },
              { value: "2", label: "秘书部" },
              { value: "3", label: "项目部" },
              { value: "4", label: "网宣部" },
              { value: "5", label: "外联部" },
              { value: "6", label: "实践部" },
              { value: "7", label: "软件组" },
            ]}
            onSelect={selectSetDepId}
          />
          <Button
            onClick={clickTransferStudent}
            danger
            icon={<UpSquareOutlined />}
            size={"default"}
          >
            修改第一志愿
          </Button>
        </div>
        <p></p>
        <List
          itemLayout="horizontal"
          dataSource={commentAndScores}
          renderItem={(item) => (
            <List.Item>
              <List.Item.Meta
                title={`${item.interviewerName} | 评分: ${item.score}`}
                description={`评论: ${item.content}`}
              />
            </List.Item>
          )}
        />
        <div className="resume-student-status">
          <img src={studentStatusStr}></img>
        </div>
      </div>
    </div>
  );
}
