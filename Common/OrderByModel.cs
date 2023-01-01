namespace GM.Model.Common
{
    public enum SortDirection  
    {
        Unspecified = -1,  
        Ascending   = 0,  
        Descending  = 1
    }  

    public class OrderByModel  
    {
       public OrderByModel()
       {
            SortDirection = SortDirection.Ascending;   
       }

       public string Name { get; set; }   
       public SortDirection SortDirection { get; set; }   
    }  
}