using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_3.ViewModelsBase;
using Test_3.Views;

namespace Test_3.ViewModels
{
    public class ViewModelMainWindow : NotifyProperty
    {
        private Document _doc;
        private List<Level> _levels;

        private MainWindow _mainWindow;

        public MainWindow MainWindow
        {
            get
            {
                if (_mainWindow == null)
                {
                    _mainWindow = new MainWindow() { DataContext = this };
                }
                return _mainWindow;
            }

            set
            {
                _mainWindow = value;
                OnPropertyChanged();
            }
        }

        public List<Level> Levels
        {
            get
            {
                if (_levels == null)
                {
                    _levels = new List<Level>();
                }
                return _levels;
            }

            set
            {
                _levels = value;
                OnPropertyChanged();
            }
        }

        public ViewModelMainWindow(Document doc)
        {
            _doc = doc;

            _levels = new FilteredElementCollector(doc)
            .WhereElementIsNotElementType()
            .OfCategory(BuiltInCategory.INVALID)
            .OfClass(typeof(Level)).Cast<Level>().ToList();
        }
    }
}