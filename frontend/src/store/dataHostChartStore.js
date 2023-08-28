import { makeAutoObservable } from "mobx";

class DataHostChartStore {
  constructor() {
    makeAutoObservable(this);
  }

  isShow = false;

  setIsShow(nStatus) {
    this.isShow = nStatus;
  }
}

const dataHostChartStore = new DataHostChartStore();
export default dataHostChartStore;
