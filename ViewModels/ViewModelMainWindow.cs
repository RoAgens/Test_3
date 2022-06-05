using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_3.Models;
using Test_3.ViewModelsBase;
using Test_3.Views;

namespace Test_3.ViewModels
{
    public class ViewModelMainWindow : NotifyProperty
    {
        private Document _doc;
        private List<Level> _levels;

        private RVProject rvProject;

        public ViewModelMainWindow(Document _doc)
        {
            rvProject = new RVProject(_doc);
        }

        public List<Level> Levels
        {
            get
            {
                if (_levels == null)
                {
                    _levels = rvProject.RVLevels;
                }
                return _levels;
            }

            set
            {
                _levels = value;
                OnPropertyChanged();
            }
        }
    }
}