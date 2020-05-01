using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateSRTFromSAPTranscriptPDF
{
    public class SRTInfo
    {
        public int Index;
        public DateTime StartTime;
        public DateTime EndTime;
        public List<string> SRT_Lines;
        public string SRT_Text;
        public bool isRemoved;
    }
}
