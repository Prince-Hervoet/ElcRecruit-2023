import GdataHostCardListStore from "../../../store/dataHostCardListStore";
import DataRequest from "./../../../requests/dataRequest";

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

  if (res.isRequestSuccess) {
    const responseData = res.data.data;
    if (!responseData.success) {
      alert(`处理失败: ${responseData.errorMessages[0]}`);
      return;
    }
    const briefInfos = responseData.data;
    GdataHostCardListStore.setCardList(briefInfos.pageStudents);
    GdataHostCardListStore.setTotal(briefInfos.count);
    GdataHostCardListStore.setPageCount(pageCount);
  } else {
    alert(`请求失败: ${res.data.message}`);
  }
}
