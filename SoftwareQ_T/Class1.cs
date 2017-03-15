using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.JustMock;
using System.Threading.Tasks;

namespace SoftwareQ_T
{
    
    public class SoftQ_T
    {
        

        public double CalcPremium(int age, string gender)
        {
            double premium = 0;
            if (gender == "female")
            {
                if ((age >= 18) && (age <= 30))
                {
                    premium = 5.0;

                }
                else
                    if (age >= 31)
                    premium = 2.50;
                else
                    premium = 0.0;

            }
            else
                if (gender == "male")
            {
                if ((age >= 18) && (age <= 35))
                {
                    premium = 6.0;

                }

                if (age >= 36)
                {
                    premium = 5.0;

                }
                else
                    premium = 0.0;

            }
            else
                premium = 0.0;

            if(age >= 50)
            {
                premium = premium * 0.15;
                return premium;
            }
            return premium;
        }
    }
}
