using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using HeighwayDragon.Calculations;
using HeighwayDragon.Models;
using Microsoft.Win32;
using HeighwayDragon.UI.WPF.Convertions;

namespace HeighwayDragon.UI.WPF
{
    public partial class MainWindow : Window
    {
        public Dragon Dragon { get; set; }
        public Bitmap Bmp { get; set; }
        private DragonCalculator _calc;

        private float x;
        private float y;

        public MainWindow()
        {
            int iterations = Convert.ToInt32(ConfigurationManager.AppSettings.Get("iterations"));

            InitializeComponent();
            InitializeDragonObjects(iterations);
            CalculatePoints(iterations);
            PrintDragon();
        }

        private void CalculatePoints(int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                bool firstTransformation = _calc.ChooseTransformation();

                if (firstTransformation)
                {
                    x = _calc.CalculateX1(x, y);
                    y = _calc.CalculateY1(x, y);
                }
                else
                {
                    x = _calc.CalculateX2(x, y);
                    y = _calc.CalculateY2(x, y);
                }

                Dragon.Points.Add(new DragonPoint(x, y));
            }
        }

        private void PrintDragon()
        {
            Bmp = Dragon.GenerateBMP((int)DragonImage.Width, (int)DragonImage.Height, Color.White, Color.Blue);
            DragonImage.Source = Bmp.ToWpfBitmap();
        }

        private void InitializeDragonObjects(int iterations)
        {
            Dragon = new Dragon(iterations);
            _calc = new DragonCalculator();
        }

        private void SaveToFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png",
                Title = "Save an Image File"
            };
            dialog.ShowDialog();

            if (!string.IsNullOrEmpty(dialog.FileName))
            {
                using (FileStream fs = (FileStream)dialog.OpenFile())
                {
                    switch (dialog.FilterIndex)
                    {
                        case 1:
                            Bmp.Save(fs, ImageFormat.Jpeg);
                            break;
                        case 2:
                            Bmp.Save(fs, ImageFormat.Bmp);
                            break;
                        case 3:
                            Bmp.Save(fs, ImageFormat.Gif);
                            break;
                        case 4:
                            Bmp.Save(fs, ImageFormat.Png);
                            break;
                    }
                }
            }
        }
    }
}
