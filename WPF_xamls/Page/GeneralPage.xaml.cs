﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Croffle.Classes;
using Croffle.Data.SQLite;

namespace CROFFLE_WPF.WPF_xamls
{
    /// <summary>
    /// GeneralPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class GeneralPage : Page
    {

       /* private Settings setting;
        private SQLiteDB sqlite;*/

        public GeneralPage()
        {
            InitializeComponent();
            /*sqlite = new SQLiteDB();
            setting = new Settings(ref sqlite);
            setting.LoadAccount(ref sqlite);*/
        }
    }
}
