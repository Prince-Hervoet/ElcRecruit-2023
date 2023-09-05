import { makeAutoObservable } from "mobx";

class DataHostChartStore {
  constructor() {
    makeAutoObservable(this);
  }

  isShow = false;

  depSumList = [
    { size: 234, depId: "1" },
    { size: 121, depId: "2" },
    { size: 333, depId: "3" },
    { size: 414, depId: "4" },
    { size: 300, depId: "5" },
    { size: 400, depId: "6" },
    { size: 123, depId: "7" },
  ];

  setIsShow(nStatus) {
    this.isShow = nStatus;
  }

  setDepSumList(nList) {
    this.depSumList = nList;
  }
}

const dataHostChartStore = new DataHostChartStore();
export default dataHostChartStore;
