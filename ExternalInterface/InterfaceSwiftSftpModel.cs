using System;
using System.Collections.Generic;
using System.Text;
using GM.Model.Static;

namespace GM.Model.ExternalInterface
{
    public class InterfaceSwiftSftpModel
    {
        public string Text { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public List<string> FileSuccess { get; set; }
        public List<string> FileFail { get; set; }
        public virtual List<RpConfigModel> RpConfigModel { get; set; }
        public string create_by { get; set; }
    }
}
