namespace GM.Model.Common
{
    public class DropdownModel  
    {
        public string ProcedureName { get; set; }  
        public string DdltTableList { get; set; }  
        public object SearchValue   { get; set; }   
        public object SearchValue2  { get; set; }  
        public object SearchValue3  { get; set; }   
        public object SearchValue4  { get; set; }  
        public object SearchValue5  { get; set; }    
        public virtual PagingModel Paging { get; set; }  
    }  
}