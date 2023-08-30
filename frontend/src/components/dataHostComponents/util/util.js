import DataRequest from "../../../requests/dataRequest";
import dataHostCardListStore from "../../../store/dataHostCardListStore";

export async function fetchGetCards(depId, pageCount, pageSize) {
  // 获取请求id
  dataHostCardListStore.incRequestId();
  const currentRequestId = dataHostCardListStore.getRequestId();
  dataHostCardListStore.setIsLoading(true);
  const res = await DataRequest.getBriefInfosByDepId(
    depId,
    pageCount,
    pageSize
  );
  if (currentRequestId < dataHostCardListStore.getRequestId()) {
    return;
  }
  dataHostCardListStore.setIsLoading(false);
  dataHostCardListStore.setCardList(res);
}
