using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Without_ISP
{
    internal class Developer : IT_Industry
    {
        void IT_Industry.WriteCode()
        {
            throw new NotImplementedException();
        }
        void IT_Industry.DebugCode()
        {
            throw new NotImplementedException();
        }

        //void IT_Industry.ManageEmployee()
        //{
        //    throw new NotImplementedException();
        //}

        //void IT_Industry.Recruit()
        //{
        //    throw new NotImplementedException();
        //}

        //void IT_Industry.ReportBugs()
        //{
        //    throw new NotImplementedException();
        //}

        //void IT_Industry.TestCode()
        //{
        //    throw new NotImplementedException();
        //}

       
    }
}
