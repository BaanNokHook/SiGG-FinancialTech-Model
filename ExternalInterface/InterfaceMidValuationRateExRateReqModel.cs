namespace GM.Model.ExternalInterface
{
    public class InterfaceMidValuationRateExRateReqModel : InterfaceMidValuationRateExRateModel
    {
        public InterfaceMidValuationRateExRateReqModel() => ExRateResponse = new MidExRateResponseModel();

        public MidExRateResponseModel ExRateResponse { get; set; }
    }
}
