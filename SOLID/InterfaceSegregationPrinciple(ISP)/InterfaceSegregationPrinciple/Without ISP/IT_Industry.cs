using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public interface IT_Industry
    {
        //Before ISP
        void WriteCode();
        void DebugCode();
        void TestCode();
        void ReportBugs();
        void Recruit();
        void ManageEmployee();
    }

}
