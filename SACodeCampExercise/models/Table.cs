using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACodeCampExercise.models
{
    public class Table : IEnumerable<TableLineItem>
    {
        public List<TableLineItem> LineItem;

        public Table()
        {
            LineItem = new List<TableLineItem>();
        }
        public Table(string itemName)
        {
            LineItem = new List<TableLineItem>();
            TableLineItem thisItem = new(itemName);
            LineItem.Add(thisItem);
        }
        public IEnumerator<TableLineItem> GetEnumerator()
        {
            foreach (TableLineItem thisItem in LineItem)
            {
                yield return thisItem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
