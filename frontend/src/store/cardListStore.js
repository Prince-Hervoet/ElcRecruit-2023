import { makeAutoObservable } from "mobx";

// 卡片列表存储
class CardListStore {
  constructor() {
    makeAutoObservable(this);
  }

  // 学生信息列表
  cardList = [];
  // 部门总人数列表
  depSizeList = [];
  // 是否进入loading状态
  isLoading = false;

  setCardList(nStudents) {
    this.cardList = nStudents;
  }

  setDepSizeList(nDepSizeList) {
    this.depSizeList = nDepSizeList;
  }

  setIsLoading(nIsLoading) {
    this.isLoading = nIsLoading;
  }

  clear() {
    this.cardList = [];
    this.depSizeList = [];
  }
}

const cardListStore = new CardListStore();

export default cardListStore;
