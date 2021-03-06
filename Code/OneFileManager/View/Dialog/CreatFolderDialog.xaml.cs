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

namespace OneFileManager.View.Dialog
{
    /// <summary>
    /// CreatFileDialog.xaml 的交互逻辑
    /// </summary>
    public partial class CreatFolderDialog : Window
    {
        public CreatFolderDialog()
        {
            InitializeComponent();
            this.FileName.Focus();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
