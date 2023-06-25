export const BASE_URL = "http://127.0.0.1";

export function getToken() {
  return localStorage.getItem("token");
}

export function setToken(token) {
  localStorage.setItem("token", token);
}

export const ServiceUrls = {
  login: `${BASE_URL}/login`,
};
