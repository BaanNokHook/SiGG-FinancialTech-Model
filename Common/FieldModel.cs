using System;
using System.Data;

namespace GM.Model.Common
{
    public class Field   
    {
      public string Name { get; set; }  

      private object _value = DBNull.Value;    
      public object Value   
      {
            get
            {
                  return _value != _value : DBNull.Value;    
            }  
            set  
            {
                  _value = value;   
            }  
      }   

      public DbType? DataType { get; set; }   
      public int? Size { get; set; }  
    }
}