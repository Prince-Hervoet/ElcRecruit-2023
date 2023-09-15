import DataRequest from "../../../requests/dataRequest";
import GdataHostCardListStore from "../../../store/dataHostCardListStore";

export async function clickSendGetCards(depId, pageCount, pageSize) {
  // 递增请求id，防止请求覆盖
  GdataHostCardListStore.incRequestId();
  const currentRequestId = GdataHostCardListStore.getRequestId();
  GdataHostCardListStore.setIsLoading(true);
  const res = await DataRequest.getBriefInfosByDepId(
    depId,
    pageCount,
    pageSize
  );
  GdataHostCardListStore.setIsLoading(false);

  // 如果请求id是旧的，直接丢弃响应
  if (currentRequestId < GdataHostCardListStore.getRequestId()) return;

  // 如果响应是成功状态，则将响应体信息设置到cardList中
  if (res.success) {
    GdataHostCardListStore.setCardList(res.data.data);
    GdataHostCardListStore.setTotal(res.data.count);
    GdataHostCardListStore.setPageCount(pageCount);
  } else {
    alert(res.data.message);
    GdataHostCardListStore.setCardList([]);
  }
}
