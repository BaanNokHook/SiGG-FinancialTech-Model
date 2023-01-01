namespace GM.Model.ExternalInterface.ExchRateCounterRate
{
    public class ReqGetCounterRates
    {
        public string exDate { get; set; }
        public string exTime { get; set; }
        public int exRound { get; set; }
        public string[] ccyCodes { get; set; }
    }
}
