import cardListStore from "./cardListStore";
import checkinListStore from "./checkinListStore";
import danglingStore from "./danglingStore";

class RootStore {
  constructor(cardListStore, checkinListStore, danglingStore) {
    this.cardListStore = cardListStore;
    this.checkinListStore = checkinListStore;
    this.danglingStore = danglingStore;
  }
}

const rootStore = new RootStore(cardListStore, checkinListStore, danglingStore);
export default rootStore;
