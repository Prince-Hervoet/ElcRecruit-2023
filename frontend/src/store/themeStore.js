import { makeAutoObservable } from "mobx";

class ThemeStore {
  constructor() {
    makeAutoObservable(this);
  }

  theme = "light";

  setTheme(nTheme) {
    this.theme = nTheme;
  }
}
