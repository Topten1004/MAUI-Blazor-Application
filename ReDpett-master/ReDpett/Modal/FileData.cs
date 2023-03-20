using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDpett.Modal
{
    public class FileData
    {
        public string Att_FileName { get; set; }
        public string Report_Title { get; set; }
        public string TypeOfReport { get; set; }
        public string File_Att { get; set; }
        public string ContentType { get; set; }
   
        public string FileSize { get; set; }
    }
}
