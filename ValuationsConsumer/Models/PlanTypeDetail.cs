using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValuationsConsumer.Models
{
    public abstract class PlanTypeDetail
    {
        public long AccessNumber { get; set; }

        public string AccessNumberTrim
        {
            get
            {
                var len = AccessNumber.ToString().Length;
                return AccessNumber.ToString().Substring(0, len - 2);
            }
        }
    }
}