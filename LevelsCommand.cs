using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_3.ViewModels;

namespace Test_3
{
    [Transaction(TransactionMode.Manual)]
    public class LevelsCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            ViewModelMainWindow viewModelMainWindow = new ViewModelMainWindow(doc);
            viewModelMainWindow.MainWindow.ShowDialog();

            return Result.Succeeded;
        }
    }
}
