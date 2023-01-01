namespace GM.Model.Common
{
   public class PagingModel()   
   {
      public PagingModel()
      {
            PageNumber    = 1;  
            RecordPerPage = 10;
      }

      public int PageNumber    { get; set; }   
      public int RecordPerPage { get; set; }   
   }  
}   