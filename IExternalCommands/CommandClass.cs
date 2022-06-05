using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_3.ViewModels;
using Test_3.Views;

namespace Test_3.Models
{
    [Transaction(TransactionMode.Manual)]
    public class CommandClass : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            var viewModelMainWindow = new ViewModelMainWindow(doc);
            var mainwindow = new MainWindow();

            mainwindow.DataContext = viewModelMainWindow;
            mainwindow.Show();

            return Result.Succeeded;
        }
    }
}
