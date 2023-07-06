import React from "react";
import "./comment.css";

export default function Comment({ interviewerName, content }) {
  return (
    <div className="comment-body">
      <div className="comment-title">{interviewerName}: </div>
      <div className="comment-content">{content}</div>
    </div>
  );
}
