namespace GM.Model.ExternalInterface.FloatingIndexSummit
{
    public class InterfaceFloatingIndexSummitReqModel : InterfaceFloatingIndexSummitModel
    {
        public InterfaceFloatingIndexSummitReqModel() => FloatModel = new FloatingIndexEntity();

        public FloatingIndexEntity FloatModel { get; set; }
    }
}
