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

const data = [
  {
    title: "Ant Design Title 1",
  },
  {
    title: "Ant Design Title 2",
  },
  {
    title: "Ant Design Title 3",
  },
  {
    title: "Ant Design Title 4",
  },
];

export default function Resume() {
  const [items, setItems] = useState({});
  const [comments, setComments] = useState([]);

  let userId = "";
  const commentRef = useRef("");
  const scoreRef = useRef("");
  const interviewerNameRef = useRef("");

  useEffect(() => {
    userId = getUrlParam("userId");
    (async function () {
      const res = await ResumeRequest.sendGetStudentInfo(userId);
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
  }, []);

  // 开始面试按钮
  const clickStartInterview = async () => {
    const res = await ResumeRequest.sendUpdateStudentStatus(userId, 30);
    console.log(res);
    if (res.success) {
      alert("修改成功");
    } else {
      alert("修改失败，请检查角色权限和网络情况");
    }
  };

  // 通过按钮
  const clickAccept = async () => {
    const res = await ResumeRequest.sendUpdateStudentStatus(userId, 50);
    if (res.success) {
      alert("修改成功");
    } else {
      alert(res.data.response.data?.errors[0]);
    }
  };

  // 拒绝按钮
  const clickReject = async () => {
    const res = await ResumeRequest.sendUpdateStudentStatus(userId, 60);
    if (res.success) {
      alert("修改成功");
    } else {
      alert(res.data.response.data?.errors[0]);
    }
  };

  // 待定按钮
  const clickPending = async () => {
    const res = await ResumeRequest.sendUpdateStudentStatus(userId, 40);
    if (res.success) {
      alert("修改成功");
    } else {
      alert(res.data.response.data?.errors[0]);
    }
  };

  // 提交评论
  const clickSubmitComment = async () => {
    const interviewerName = interviewerNameRef.current;
    const comment = commentRef.current;
    const score = scoreRef.current;
    if (!interviewerName || !comment || !score) {
      alert("请输入完整的评论信息 -- 评论、评分、名字");
      return;
    }
    const res = await ResumeRequest.sendCommentAndScore(
      userId,
      interviewerName,
      comment,
      score
    );
    console.log(res);
  };

  // 评论change触发
  const onChangeComment = (event) => {
    commentRef.current = event.target.value;
  };

  // 评论者change触发
  const onChangeInterviewerName = (event) => {
    interviewerNameRef.current = event.target.value;
  };

  // 评分change触发
  const onChangeScore = (value) => {
    scoreRef.current = value;
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
          />
        </div>
        <div className="resume-content-comment-buttons-body">
          <Rate count={10} onChange={onChangeScore} />
          <Input
            size="small"
            placeholder="评价者"
            style={{ width: "10%", marginLeft: 10 }}
            onChange={onChangeInterviewerName}
          />
          <Button
            style={{ marginLeft: 10 }}
            size={"large"}
            onClick={clickSubmitComment}
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
          dataSource={data}
          renderItem={(item, index) => (
            <List.Item>
              <List.Item.Meta
                title={item.title}
                description="Ant Design, a design language for background applications, is refined by Ant UED Team"
              />
            </List.Item>
          )}
        />
      </div>
      <ResumeStatusShow></ResumeStatusShow>
    </div>
  );
}
