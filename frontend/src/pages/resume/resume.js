import React, { useEffect, useRef, useState } from "react";
import { Descriptions, Input, Rate, List, Select } from "antd";
import {
  CaretRightOutlined,
  LoginOutlined,
  CloseOutlined,
  PauseOutlined,
  UpSquareOutlined,
} from "@ant-design/icons";
import { Button } from "antd";
import "./resume.css";
import { getUrlParam } from "../../util";
import ResumeStatusShow from "../../components/resumeComponents/resumeStatusShow";
import { ResumeRequest } from "../../requests/resumeRequest";
import { CollegeObj, KeyToDepName } from "../../store/global";
const { TextArea } = Input;

export default function Resume() {
  const [items, setItems] = useState({});
  const [commentAndScores, setCommentAndScores] = useState([]);
  const [comment, setComment] = useState("");
  const [score, setScore] = useState("");
  const [interviewerName, setInterviewerName] = useState("");

  const userIdRef = useRef("");

  useEffect(() => {
    userIdRef.current = getUrlParam("userId");
    (async function () {
      const res = await ResumeRequest.sendGetStudentInfo(userIdRef.current);
      if (res.success) {
        const {
          college,
          firstDepartment,
          grade,
          id,
          introduction,
          name,
          phone,
          qq,
          secondDepartment,
          skills,
          state,
          studentId,
          weChat,
        } = res.data.data;
        const firstDepName = KeyToDepName[firstDepartment];
        const secondDepName = KeyToDepName[secondDepartment];
        const collegeName = CollegeObj[college];
        const nItems = {
          collegeName,
          firstDepName,
          grade,
          id,
          introduction,
          name,
          phone,
          qq,
          secondDepName,
          skills,
          state,
          studentId,
          weChat,
        };
        setItems(nItems);
      } else {
        alert(res.data.message);
      }
    })();

    (async function () {
      const res = await ResumeRequest.sendGetComments(userIdRef.current);
      const commentList = res.data.data;
      setCommentAndScores(commentList);
    })();
  }, []);

  // 开始面试按钮
  const clickStartInterview = async () => {
    const res = await ResumeRequest.sendUpdateStudentStatus(
      userIdRef.current,
      30
    );
    if (res.success) {
      alert("修改成功");
    } else {
      alert("修改失败，请检查角色权限和网络情况");
    }
  };

  // 通过按钮
  const clickAccept = async () => {
    const res = await ResumeRequest.sendUpdateStudentStatus(
      userIdRef.current,
      50
    );
    if (res.success) {
      alert("修改成功");
    } else {
      alert(res.data.response.data?.errors[0]);
    }
  };

  // 拒绝按钮
  const clickReject = async () => {
    const res = await ResumeRequest.sendUpdateStudentStatus(
      userIdRef.current,
      60
    );
    if (res.success) {
      alert("修改成功");
    } else {
      alert(res.data.response.data?.errors[0]);
    }
  };

  // 待定按钮
  const clickPending = async () => {
    const res = await ResumeRequest.sendUpdateStudentStatus(
      userIdRef.current,
      40
    );
    if (res.success) {
      alert("修改成功");
    } else {
      alert(res.data.response.data?.errors[0]);
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
    if (res.success) {
      alert("提交成功");
      setCommentAndScores([
        ...commentAndScores,
        { interviewerName, content: comment, score },
      ]);
      setComment("");
      setInterviewerName("");
      setScore("");
    } else {
      alert("提交失败，请检查权限和网络");
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
              {items.studentId}
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
              fontSize: "larger",
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
          <Button
            icon={<PauseOutlined />}
            size={"large"}
            onClick={clickPending}
          >
            待定
          </Button>
        </div>
        <p></p>
        <div>
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
          />
          <Button danger icon={<UpSquareOutlined />} size={"default"}>
            调剂至
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
      </div>
      <ResumeStatusShow></ResumeStatusShow>
    </div>
  );
}
