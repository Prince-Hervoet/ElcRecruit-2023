const BASE_URL = "http://127.0.0.1";

export function getToken() {
  return localStorage.getItem("token");
}

export function setToken(token) {
  localStorage.setItem("token", token);
}

export function clearToken() {
  localStorage.removeItem("token");
}

export const ServiceUrls = {
  login: `${BASE_URL}/login`,
};

export function handleResponse(res) {
  if (res.status === 200) {
    return { isSuccess: true, data: res.data, headers: res.headers };
  }
  return { isSuccess: false, data: res.data, headers: res.headers };
}
