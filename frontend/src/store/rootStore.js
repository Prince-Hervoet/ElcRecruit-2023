import cardListStore from "./cardListStore";
import checkinListStore from "./checkinListStore";
import dataHostCardListStore from "./dataHostCardListStore";

class RootStore {
  constructor(cardListStore, checkinListStore, dataHostCardListStore) {
    this.cardListStore = cardListStore;
    this.checkinListStore = checkinListStore;
    this.dataHostCardListStore = dataHostCardListStore;
  }
}

const rootStore = new RootStore(cardListStore, checkinListStore,dataHostCardListStore);
export default rootStore;
