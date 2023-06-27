import { makeAutoObservable } from "mobx";

// 签到列表存储
class DanglingStore {
  constructor() {
    makeAutoObservable(this);
  }

  title = "Title";

  textContent = "text";

  isShow = false;

  setTitle(nTiile) {
    this.title = nTiile;
  }

  setTextContent(nTextContent) {
    this.textContent = nTextContent;
  }

  setIsShow(nIsShow) {
    this.isShow = nIsShow;
  }
}

const danglingStore = new DanglingStore();

export default danglingStore;
