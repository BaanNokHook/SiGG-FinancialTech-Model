using System;

namespace GM.Model.Common
{
    public class AuditModel
    {
      // Audit Properties  
      public Guid AuditID { get; set; }  
      public string UserName { get; set; }   
      public string IPAddress { get; set; }   
      public string AreaAccessed { get; set; }
      public DateTime Timestamp { get; set; }
      }
} 