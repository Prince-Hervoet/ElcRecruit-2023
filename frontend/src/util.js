export function getHostUrl() {
  return window.location.protocol + "//" + window.location.host;
}

export function joinRouterUrl(path, args) {
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

export function getUrlParam(name) {
  let u = arguments[1] || window.location.href,
    reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)"),
    r = u.substr(u.indexOf("?") + 1).match(reg);
  return r != null ? decodeURI(r[2]) : "";
}
