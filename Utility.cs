using QuanlyKho1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyKho1
{
    internal class Utility
    {   
        public static string ImagePath { get; internal set; }
        //static public string ImagePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Images\";
        internal static User? employee;
        static public bool IsOpeningForm(string formname)
        {
            foreach (Form f in Application.OpenForms)
                if (f.Name == formname)
                    return true;
            return false;
        }
    }
}
