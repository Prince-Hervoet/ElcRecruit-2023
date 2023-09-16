import { makeAutoObservable } from "mobx";

class DataHostChartStore {
  constructor() {
    makeAutoObservable(this);
  }

  isShow = false;

  setIsShow(nStatus) {
    this.isShow = nStatus;
  }

  clear() {}
}

const dataHostChartStore = new DataHostChartStore();
export default dataHostChartStore;
