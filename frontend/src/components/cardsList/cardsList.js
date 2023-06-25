import React, { useEffect, useState } from "react";
import "./cardsList.css";
import { Pagination } from "antd";
import Card from "../card/card";
import ColorFlag from "../colorFlag/colorFlag";
import Empty from "../empty/empty";
import Loading from "../loading/loading";

export default function CardsList({ values }) {
  const [cards, setCards] = useState([]);
  const [isLoading, setIsLoading] = useState(true);
  useEffect(() => {
    setTimeout(() => {
      setCards(["asdf", "234", "asdf", "435u8", "234", "asdf"]);
      setIsLoading(false);
    }, 1000);
  }, []);
  let content = [];
  if (isLoading) {
    content.push(<Loading></Loading>);
  } else {
    if (cards.length > 0) {
      content = cards.map((card) => {
        return (
          <div>
            <Card></Card>
          </div>
        );
      });
    } else {
      content.push(<Empty></Empty>);
    }
  }

  return (
    <div className="cards-list-body">
      <div className="cards-list-content">
        {content.map((c) => {
          return c;
        })}
      </div>
      <div className="cards-list-pagination">
        <div>
          <Pagination
            defaultCurrent={1}
            defaultPageSize={6}
            pageSize={6}
            pageSizeOptions={[]}
            total={cards.length}
          />
        </div>
      </div>
    </div>
  );
}
