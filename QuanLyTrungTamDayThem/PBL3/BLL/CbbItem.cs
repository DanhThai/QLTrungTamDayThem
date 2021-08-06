using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    class CbbItem
    {
        public string value { get; set; }
        public string text { get; set; }
        public override string ToString()
        {
            return text;
        }
    }
}
