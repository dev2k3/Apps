using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework
{
    public class Item : Iitem
    {
        private string _name;
        private List<string> _dependencies;
        //constructors
        public Item()
        {
            _name = "";
            _dependencies = new List<string>();
        }
        public Item(string name)
        {
            _name = name;
            _dependencies = new List<string>();

        }

    #region properties

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List<string> Dependencies
        {
            get { return _dependencies; }
           
        }
    #endregion
    #region public methods
        public void AddDependency(string name)
        {
            _dependencies.Add(name);
        }
        public int GetNumberofDependent()
        {
            return _dependencies.Count;
        }

        public override string ToString()
        {
            // Return the string representation <name>-><dependencies> of the item
            return this._name + " Dependencies: " + string.Join(",", this._dependencies.ToArray());
        }
    #endregion
    }
}
