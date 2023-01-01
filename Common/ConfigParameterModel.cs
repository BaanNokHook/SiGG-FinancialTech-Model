using System.Collections.Generic;

namespace GM.Model.Common
{

    public class ConfigParameterModel()   
    {
      public ConfigParameterModel()   
      {
          Paging     =  new PagingModel();   
          Parameters =  new List<Field>();   
          OrdersBy   =  new List<OrderByModel>();   
      }

      public string ProcedureName { get; set; }  
      public string ModelResult { get; set; }   
      public List<Field> Parameters { get; set; }    
      public virtual PagingModel Paging { get; set; }  
      public virtual List<OrderByModel> OrderBy { get; set; 0  }
    }
}