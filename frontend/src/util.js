export function getHostUrl() {
  return window.location.protocol + "//" + window.location.host;
}

export function joinRouterUrl(path, args = {}) {
  const keys = Object.keys(args);
  let argsStr = keys.length === 0 ? "" : "?";
  keys.forEach((key, index) => {
    const value = args[key];
    argsStr += key + "=" + value;
    if (index < keys.length - 1) {
      argsStr += "&";
    }
  });
  return getHostUrl() + "/#" + path + argsStr;
}

// 获取url问号后面的参数
export function getUrlParam(variable) {
  const query = window.location.href.split("?")[1];
  if (query) {
    const vars = query.split("&");
    for (let i = 0; i < vars.length; i++) {
      const pair = vars[i].split("=");
      if (pair[0] === variable) {
        return pair[1];
      }
    }
  }
  return null;
}
