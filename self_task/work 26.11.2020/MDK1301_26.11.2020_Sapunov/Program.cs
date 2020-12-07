using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDK1301_26._11._2020_Sapunov.Views;
using MDK1301_26._11._2020_Sapunov.Controllers;
using MDK1301_26._11._2020_Sapunov.Services;

namespace MDK1301_26._11._2020_Sapunov
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SpecialtiesForm specForm = new SpecialtiesForm();
            StorageContext context = new StorageContext();
            _ = new SpecialtiesController(specForm, context);
            Application.Run(specForm);
        }
    }
}