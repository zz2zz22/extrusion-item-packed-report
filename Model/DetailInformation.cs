using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extrusion_item_packed_report
{
    [Serializable()]
    public class DetailInformation
    {
        public string Date { get; set; }
        public string MainCode { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
    }
}
