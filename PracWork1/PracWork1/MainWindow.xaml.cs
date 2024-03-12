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

namespace PracWork1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

          

            Ellipse el = new Ellipse();
            el.Width = 50;
            el.Height = 50;
            el.VerticalAlignment = VerticalAlignment.Top;
            el.Fill = Brushes.Green;
            el.Stroke = Brushes.Red;
            el.StrokeThickness = 3;
            grid1.Children.Add(el);

            // Намалювання вертикальної лінії
            Line vertL = new Line();
            vertL.X1 = 10;
            vertL.Y1 = 150;
            vertL.X2 = 10;
            vertL.Y2 = 10;
            vertL.Stroke = Brushes.Black;
            grid1.Children.Add(vertL);

            // Намалювання горизонтальної лінії
            Line horL = new Line();
            horL.X1 = 10;
            horL.X2 = 150;
            horL.Y1 = 150;
            horL.Y2 = 150;
            horL.Stroke = Brushes.Black;
            grid1.Children.Add(horL);

            // Додавання вертикальних ліній сітки
            for (byte i = 2; i < 14; i++)
            {
                Line a = new Line();
                a.X1 = i * 10;
                a.X2 = i * 10;
                a.Y1 = 155;
                a.Y2 = 145;
                a.Stroke = Brushes.Black;
                grid1.Children.Add(a);
            }

            // Додавання горизонтальних ліній сітки
            for (byte i = 2; i < 14; i++)
            {
                Line a = new Line();
                a.X1 = 5;
                a.X2 = 15;
                a.Y1 = i * 10;
                a.Y2 = i * 10;
                a.Stroke = Brushes.Black;
                grid1.Children.Add(a);
            }

            // Намалювання вертикальних стрілочок
            Polyline vertArr = new Polyline();
            vertArr.Points = new PointCollection();
            vertArr.Points.Add(new Point(5, 15));
            vertArr.Points.Add(new Point(10, 10));
            vertArr.Points.Add(new Point(15, 15));
            vertArr.Stroke = Brushes.Black;
            grid1.Children.Add(vertArr);

            // Намалювання горизонтальних стрілочок
            Polyline horArr = new Polyline();
            horArr.Points = new PointCollection();
            horArr.Points.Add(new Point(145, 145));
            horArr.Points.Add(new Point(150, 150));
            horArr.Points.Add(new Point(145, 155));
            horArr.Stroke = Brushes.Black;
            grid1.Children.Add(horArr);

            // 16. ProgrammaticCreationOfSegments

            //PathGeometry pathGeom = new PathGeometry();
            //Path p = new Path();

            //LineSegment vertLS = new LineSegment();
            //PathFigure vertPF = new PathFigure();
            //vertPF.StartPoint = new Point(10, 150);
            //vertLS.Point = new Point(10, 10);
            //vertPF.Segments.Add(vertLS);
            //pathGeom.Figures.Add(vertPF);

            //LineSegment horLS = new LineSegment();
            //PathFigure horPF = new PathFigure();
            //horPF.StartPoint = new Point(10, 150);
            //horLS.Point = new Point(150, 150);
            //horPF.Segments.Add(horLS);
            //pathGeom.Figures.Add(horPF);

            //for (byte i = 2; i < 14; i++)
            //{
            //    PathFigure pf = new PathFigure();
            //    pf.StartPoint = new Point(i * 10, 155);
            //    LineSegment a = new LineSegment();
            //    a.Point = new Point(i * 10, 145);
            //    pf.Segments.Add(a);
            //    pathGeom.Figures.Add(pf);
            //}

            //for (byte i = 3; i < 15; i++)
            //{
            //    PathFigure pf = new PathFigure();
            //    pf.StartPoint = new Point(5, i * 10);
            //    LineSegment a = new LineSegment();
            //    a.Point = new Point(15, i * 10);
            //    pf.Segments.Add(a);
            //    pathGeom.Figures.Add(pf);
            //}

            //PolyLineSegment vertArr = new PolyLineSegment();
            //vertArr.Points = new PointCollection();
            //vertArr.Points.Add(new Point(10, 10));
            //vertArr.Points.Add(new Point(15, 15));
            //PathFigure vertArrF = new PathFigure();
            //vertArrF.StartPoint = new Point(5, 15);
            //vertArrF.Segments.Add(vertArr);
            //pathGeom.Figures.Add(vertArrF);

            //PolyLineSegment horArr = new PolyLineSegment();
            //horArr.Points = new PointCollection();
            //horArr.Points.Add(new Point(150, 150));
            //horArr.Points.Add(new Point(145, 155));
            //PathFigure horArrF = new PathFigure();
            //horArrF.StartPoint = new Point(145, 145);
            //horArrF.Segments.Add(horArr);
            //pathGeom.Figures.Add(horArrF);

            //p.Data = pathGeom;
            //p.Stroke = Brushes.Black;

            //grid1.Children.Add(p);


        }
    }
}
