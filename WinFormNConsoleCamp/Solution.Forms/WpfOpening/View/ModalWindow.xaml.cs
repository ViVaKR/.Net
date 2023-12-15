﻿
using System.Diagnostics.CodeAnalysis;
using System.Windows;

namespace WpfOpening.View
{
    public partial class ModalWindow : Window
    {
        public bool Success { get; set; }

        [AllowNull]
        public string Input { get; set; }

        public ModalWindow()
        {
            InitializeComponent();
        }



        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            Success = true;
            Input = TbInput.Text;
            Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
