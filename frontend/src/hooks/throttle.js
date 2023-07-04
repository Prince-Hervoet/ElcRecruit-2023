import React, { useCallback, useState } from "react";

// 节流包装hook
export default function useThrottle(targetFunc, interval, ...args) {
  let [lastUpdateAt, setLastUpdateAt] = useState(0);
  const func = useCallback(() => {
    const now = new Date().getTime();
    if (now - lastUpdateAt >= interval) {
      targetFunc.apply(this, args);
      lastUpdateAt = now;
    }
  }, []);
  return func;
}
