#region Copyright Syncfusion Inc. 2001 - 2020
// Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using Syncfusion.Windows.PropertyGrid;
using Syncfusion.Windows.Tools.Controls;

namespace CustomEditorDemo
{
    /// <summary>
    /// Interaction logic for ImageBrowser.xaml
    /// </summary>
    public partial class ImageBrowser : UserControl
    {
        public ImageBrowser()
        {
            InitializeComponent();
        }

        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(ImageBrowser), new UIPropertyMetadata(null));

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Small Icon (*.png, *.jpeg)|*.png*;*.jpeg";
            if (dialog.ShowDialog().Value)
            {
                BitmapImage bmp = new BitmapImage(new Uri(dialog.FileName, UriKind.RelativeOrAbsolute));
                ImageSource = bmp;
            } 
        }
    }
}
