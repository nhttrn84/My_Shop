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
using System.Windows.Shapes;

namespace My_Shop
{
    /// <summary>
    /// Interaction logic for EditPhoneWindow.xaml
    /// </summary>
    public partial class EditPhoneWindow : Window
    {
        public EditPhoneWindow(Phone phone)
        {
            InitializeComponent();
        }

        public Phone EditedPhone { get; internal set; }
    }
}
