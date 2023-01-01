using System;
using System.Collections.Generic;
using System.Text;

namespace GM.Model.Common
{
   public class FileServiceModel
   {
      public string key    { get; set; }
      public string title  { get; set; }  
      public bool   folder { get; set; }  
      public bool   lazy   { get; set; }   
   
      public FileServiceModel()   
      {
            folder = false;   
            lazy   = false;  
      }
   }
}