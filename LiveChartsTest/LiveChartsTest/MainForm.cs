using LiveCharts;
using LiveCharts.Wpf;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;

namespace LiveChartsTest
{
    public partial class MainForm : Form
    {

        void FillCartesianChart()
        {
            cartesian.Series.Clear();
            cartesian.AxisX.Clear();
            cartesian.AxisY.Clear();
            cartesian.VisualElements.Clear();

            // Цвет линии
            var lineColor = System.Windows.Media.Color.FromRgb(33, 150, 243); // современный синий

            var lineSeries = new LineSeries
            {
                Title = "Продажи",
                Values = new ChartValues<int> { 10, 15, 12, 18, 25, 22 },

                Stroke = new SolidColorBrush(lineColor),
                StrokeThickness = 2,

                PointGeometry = DefaultGeometries.Circle,
                PointForeground = new SolidColorBrush(lineColor),
                PointGeometrySize = 7,

                // лёгкая прозрачная заливка
                Fill = new LinearGradientBrush(
                    System.Windows.Media.Color.FromArgb(90, 33, 150, 243),
                    System.Windows.Media.Color.FromArgb(0, 33, 150, 243),
                    90
                )
            };

            cartesian.Series = new SeriesCollection { lineSeries };

            // 🔹 Ось Y
            cartesian.AxisY.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.DimGray,

                LabelFormatter = value => value.ToString("N0"),

                // лёгкая, почти незаметная сетка
                Separator = new Separator
                {
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(40, 0, 0, 0)),
                    StrokeThickness = 1
                },
                MaxValue = 30
            });

            // 🔹 Ось X
            cartesian.AxisX.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Black,

                Labels = new[] { "Янв", "Фев", "Мар", "Апр", "Май", "Июн" },

                // отключаем сетку по X (часто выглядит чище)
                Separator = new Separator
                {
                    IsEnabled = false
                }
            });

            // 🔹 Фон
            cartesian.Background = System.Windows.Media.Brushes.White;

            // 🔹 Подсказки
            cartesian.DataTooltip = new DefaultTooltip();
        }

        void FillAngularGauge()
        {
            angular.Value = 65;
            angular.FromValue = 0;
            angular.ToValue = 100;
            angular.TicksForeground = System.Windows.Media.Brushes.Gray;
            angular.NeedleFill = System.Windows.Media.Brushes.DarkBlue;
        }

        void FillSolidGauge()
        {
            solid.Value = 40;
            solid.From = 0;
            solid.To = 100;
            solid.LabelFormatter = value => value + "%";
        }
        public MainForm()
        {
            InitializeComponent();
            FillCartesianChart();
            FillAngularGauge();
            FillSolidGauge();
        }
    }
}
