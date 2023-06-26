import cardListStore from "./cardListStore";
import checkinListStore from "./checkinListStore";

class RootStore {
  constructor(cardListStore, checkinListStore) {
    this.cardListStore = cardListStore;
    this.checkinListStore = checkinListStore;
  }
}

const rootStore = new RootStore(cardListStore, checkinListStore);
export default rootStore;
