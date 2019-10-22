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

using Microsoft.Win32;

namespace GraficadorDeSeñales
{
    /// <summary>
    /// Lógica de interacción para ConfiguraciónAudio.xaml
    /// </summary>
    public partial class ConfiguraciónAudio : UserControl
    {
        public ConfiguraciónAudio()
        {
            InitializeComponent();
        }

        private void BtnElegirArchivo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if ((bool)fileDialog.ShowDialog())
            {
                txtRutaArchivo.Text = fileDialog.FileName;
            }
        }
    }
}