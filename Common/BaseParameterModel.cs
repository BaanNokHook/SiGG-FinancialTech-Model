using System.Collections.Generic;

namespace GM.Model.Common
{
    public class BaseParameterModel
    {
      public BaseParameterModel()  
      {
            Parameters        = new List<Field>();
            ResultModelNames  = new List<string>();  
            Paging            = new PagingModel();   
            Orders            = new List<OrderByModel>();  
      }

      public string ProcedureName { get; set; }  
      public List<Field> Parameters { get; set; }  
      public List<OrderByModel> Orders { get; set; }    
      public PagingModel Paging { get; set; }   
      public List<string> ResultModelNames { get; set; }  
    }
}