﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using FaysConcept.FrontOffice;
using FaysConcept.BackOffice.Ana_Menu;

namespace FaysConcept.BackOffice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new RibbonForm1());
            //Application.Run(new FrmAnaMenuFluent()); 
        }
    }
}
