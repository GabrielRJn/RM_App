using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.Adapters;
using System.Windows.Forms;

namespace RM_App.Backend_classes.Controller
{
    internal class NavbarFunctions
    {
        //All classes that are not page specific can go here
        public static void showNewPage(Form oldPage, Form newPage)
        {
            oldPage.Hide();
            newPage.Show();
        }
    }
}
