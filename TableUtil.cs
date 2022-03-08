using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACodeCampExercise
{
    class TableUtil
    {
        public static double ParseToDoubleValue(string price)
        {
            string numString = new string(price.ToCharArray().Where(ch=>Char.IsDigit(ch)||ch=='.').ToArray());
            return double.Parse(numString);
        }

        

        public static int ParseToInt(string quantity)
        {
            return int.Parse(quantity);
        }
    }
}
