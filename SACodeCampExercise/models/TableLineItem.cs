using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACodeCampExercise.models
{
    public class TableLineItem
    {
        string name;
        public TableLineItem()
        {
            name = "New Item";
        }
        public TableLineItem(string itemName)
        {
            name = itemName;
        }

    }
}
