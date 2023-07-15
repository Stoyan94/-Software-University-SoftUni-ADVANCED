using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Date_Modifier
{
    public class DateModifier
    {
        public static int CalculateDate(string firstDate,string seckondDate)
        {
            DateTime startDate = DateTime.Parse(firstDate);
            DateTime endDate = DateTime.Parse(seckondDate);

            int result = (int)Math.Abs((startDate-endDate).TotalDays);

            return result;
        }
    }
}
