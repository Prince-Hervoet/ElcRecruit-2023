import dataHostCardListStore from "./dataHostCardListStore";

class RootStore {
  constructor(dataHostCardListStore) {
    this.dataHostCardListStore = dataHostCardListStore;
  }
}

const rootStore = new RootStore(dataHostCardListStore);
export default rootStore;
