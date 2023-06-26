import { makeAutoObservable } from "mobx";

// 签到列表存储
class CheckinListStore {
  constructor() {
    makeAutoObservable(this);
  }

  checkinList = [];

  isLoading = false;

  setCheckinList(nCheckinList) {
    this.checkinList = nCheckinList;
  }

  setIsLoading(nIsLoading) {
    this.isLoading = nIsLoading;
  }
}

const checkinListStore = new CheckinListStore();

export default checkinListStore;
