using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace GameDemo
{
    public sealed partial class Flower : UserControl
    {
        public double locationX { get; set; }
        public double locationY { get; set; }

        public Flower()
        {
            this.InitializeComponent();

            Width = Height = 50;
        }

        public void SetLocation()
        {
            SetValue(Canvas.LeftProperty, locationX);
            SetValue(Canvas.TopProperty, locationY);
        }
    }
}
