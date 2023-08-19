using System.Collections.Generic;
using System.Linq;

namespace Assets.Scripts.Grid
{
    public class GridData
    {
        public GridObject[] GridObjects;
        public Dictionary<int, GridObject> GridObjectDictionary { get; set; }
        
        public GridData ReplaceGridObjects()
        {
            GridObjects = GridObjectDictionary.Values.ToArray();
            return this;
        }
    }
}