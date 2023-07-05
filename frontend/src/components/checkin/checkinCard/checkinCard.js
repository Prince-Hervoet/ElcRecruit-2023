import React from "react";
import "./checkinCard.css";
import { ServiceUrls } from "../../../requests/util";

export default function CheckinCard({ userId, name, stuId }) {
  const clickOnCheckin = (event) => {
    const userId = event.target.id;
    window.open(ServiceUrls.resume + userId);
  };

  return (
    <div className="checkin-card-body" onClick={clickOnCheckin} id={userId}>
      <div>{name}</div>
      <div>{stuId}</div>
    </div>
  );
}
