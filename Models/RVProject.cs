using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_3.Models
{
    public class RVProject
    {
        private Document _doc;
        private List<Level> _rvLevels;

        public RVProject(Document doc)
        {
            _doc = doc;

            _rvLevels = new FilteredElementCollector(_doc)
                                .WhereElementIsNotElementType()
                                .OfCategory(BuiltInCategory.INVALID)
                                .OfClass(typeof(Level)).Cast<Level>().ToList();
        }

        public List<Level> RVLevels => _rvLevels;
    }
}
