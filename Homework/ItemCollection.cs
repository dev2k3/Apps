using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework
{
    public class ItemCollection
    {
        #region private section
        private List<Item> items;
        private List<Item> visitedItems;
        private List<string> sortedItems;
        private void Search(Item anItem)
        {
            if (!visitedItems.Contains(anItem))
          {
                  
                visitedItems.Add(anItem);
                
                foreach (string st in anItem.Dependencies)
                {
                    Item dep = items.Find(it=> it.Name == st);
                    if (dep != null)
                    {
                        Search(dep);
                    }
                }
                sortedItems.Add(anItem.ToString()); 
               
            }
        }
    #endregion
        
        public ItemCollection()
        {
            items = new List<Item>();
                     
        }
        #region public methods
       
        /// <summary>
        /// adds item to the collection 
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dependent"></param>
        public void Add(string its)
        {
              Item it = new Item();
            if (!string.IsNullOrEmpty(its))
            {
                int i = 0;
                foreach (string d in its.Split(','))
                {

                    if (i == 0)
                        it.Name = d;
                    else
                        it.AddDependency(d);
                    i++;

                }

            }
            items.Add(it);

        }
       
        /// <summary>
        /// sort items such that in an order such that items with dependencies come later in the order
        ///than the item or items they depend on.
        /// </summary>
        /// <returns></returns>
        public List<string> Sort()
        {
            sortedItems = new List<string>();
            visitedItems = new List<Item>();
            foreach (Item it in items)
            {
                Search(it);    
            }
            return sortedItems;
        }
        #endregion

    }
}
