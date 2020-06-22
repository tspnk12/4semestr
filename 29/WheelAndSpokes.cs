using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Petzold.WheelAndSpokes
{
    public class WheelAndSpokes : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new WheelAndSpokes());
        }
        public WheelAndSpokes()
        {
            Title = "Wheel and Spokes";

            
            Canvas canv = new Canvas();
            Content = canv;

           
            Ellipse elips = new Ellipse();
            elips.Stroke = SystemColors.WindowTextBrush;
            elips.Width = 200;
            elips.Height = 200;
            canv.Children.Add(elips);
            Canvas.SetLeft(elips, 50);
            Canvas.SetTop(elips, 50);

           
            for (int i = 0; i < 72; i++)
            {
                
                Line line = new Line();
                line.Stroke = SystemColors.WindowTextBrush;
                line.X1 = 150;
                line.Y1 = 150;
                line.X2 = 250;
                line.Y2 = 150;

               
                line.RenderTransform = new RotateTransform(5 * i, 150, 150);
                canv.Children.Add(line);
            }

            
            elips = new Ellipse();
            elips.Stroke = SystemColors.WindowTextBrush;
            elips.Width = 200;
            elips.Height = 200;
            canv.Children.Add(elips);
            Canvas.SetLeft(elips, 300);
            Canvas.SetTop(elips, 50);

            
            for (int i = 0; i < 72; i++)
            {
               
                Line line = new Line();
                line.Stroke = SystemColors.WindowTextBrush;
                line.X1 = 0;
                line.Y1 = 0;
                line.X2 = 100;
                line.Y2 = 0;

                line.RenderTransform = new RotateTransform(5 * i);

                
                canv.Children.Add(line);
                Canvas.SetLeft(line, 400);
                Canvas.SetTop(line, 150);
            }
        }
    }
}