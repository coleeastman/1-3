using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int C2f(int c)
        {
            return (c * 9 / 5) + 32;
        }

        public int F2c(int f)
        {
            return (f - 32) * 5 / 9;
        }

        public string Sort(string nums)
        {

            if (string.IsNullOrEmpty(nums)) return string.Empty;

            var numList = nums.Split(',')
                .Select(n => float.Parse(n.Trim()))
                .ToList();

            numList.Sort();

            return string.Join(",", numList);
        }
    }
}
