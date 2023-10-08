import { makeAutoObservable } from "mobx";

// 卡片列表存储
class DataHostCardListStore {
  constructor() {
    makeAutoObservable(this);
  }

  // 学生信息列表
  cardList = [];

  // 总数量
  total = 0;

  // 当前页码
  pageCount = 0;

  // 部门总人数列表
  depSizeList = [];

  // 是否进入loading状态
  isLoading = false;

  // 当前所属部门
  currentDepId = 0;

  // 递增请求id
  requestId = 0;

  setCardList(nStudents) {
    this.cardList = nStudents;
  }

  setDepSizeList(nDepSizeList) {
    this.depSizeList = nDepSizeList;
  }

  setIsLoading(nIsLoading) {
    this.isLoading = nIsLoading;
  }

  incRequestId() {
    this.requestId += 1;
  }

  getRequestId() {
    return this.requestId;
  }

  getCurrentDepId() {
    return this.currentDepId;
  }

  setCurrentDepId(nDepId) {
    this.currentDepId = nDepId;
  }

  setTotal(nTotal) {
    this.total = nTotal;
  }

  setPageCount(nPageCount) {
    this.pageCount = nPageCount;
  }

  clear() {
    this.cardList = [];
    this.depSizeList = [];
    this.total = 0;
    this.isLoading = false;
    this.currentDepId = -1;
  }
}

const GdataHostCardListStore = new DataHostCardListStore();
export default GdataHostCardListStore;
