namespace GM.Model.ExternalInterface
{
    public class InterfaceCounterRateExRateReqModel : InterfaceCounterRateExRateModel
    {

        public InterfaceCounterRateExRateReqModel() => ExRateResponse = new CounterExRateResponseModel();

        public CounterExRateResponseModel ExRateResponse { get; set; }
    }
}
