using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot.WindowsForms;
using OxyPlot.Legends;

namespace RotaryAxisAnalyzer
{

    public partial class Plot : Form
    {
        public double[] X_Axis { get; private set; }
        public double[] Y_Axis { get; private set; }
        public double[] Z_Axis { get; private set; }

        private PlotView plotView;
        public Plot()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            xChannelBtn.FlatStyle = FlatStyle.Flat;
            xChannelBtn.FlatAppearance.BorderSize = 0;

            yChannelBtn.FlatStyle = FlatStyle.Flat;
            yChannelBtn.FlatAppearance.BorderSize = 0;

            zChannelBtn.FlatStyle = FlatStyle.Flat;
            zChannelBtn.FlatAppearance.BorderSize = 0;

            xChannelBtn.Paint += (sender, e) => ChannelButtonDecoration.ChannelBtnDecoration(xChannelBtn, e);
            yChannelBtn.Paint += (sender, e) => ChannelButtonDecoration.ChannelBtnDecoration(yChannelBtn, e);
            zChannelBtn.Paint += (sender, e) => ChannelButtonDecoration.ChannelBtnDecoration(zChannelBtn, e);

        }

        public void SetData(double[] x, double[] y, double[] z)
        {
            X_Axis = x;
            Y_Axis = y;
            Z_Axis = z;

            UpdatePlot();
        }


        private void UpdatePlot()
        {
            if (X_Axis == null || Y_Axis == null || Z_Axis == null)
            {
                return;
            }

            Console.WriteLine("Data loaded successfully!");

            Console.WriteLine("X_Axis values:");
            foreach (var value in X_Axis)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Y_Axis values:");
            foreach (var value in Y_Axis)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Z_Axis values:");
            foreach (var value in Z_Axis)
            {
                Console.WriteLine(value);
            }
        }

        private void Plot_Form_Load(object sender,  EventArgs e)
        {


            // create arrays
            double[] channel1 = X_Axis;
            double[] channel2 = Y_Axis;
            double[] channel3 = Z_Axis;

            // Check boolean
            bool[] validIndices = new bool[channel1.Length];

            for (int i = 0; i < channel1.Length; i++)
            {
                validIndices[i] = (channel1[i] != 0) && (channel2[i] != 0) && (channel3[i] != 0);
            }

            double[] channel1_filtered = new double[channel1.Length];
            double[] channel2_filtered = new double[channel2.Length];
            double[] channel3_filtered = new double[channel3.Length];

            int validCount = 0;
            for (int i = 0; i < channel1.Length; i++)
            {
                if (validIndices[i])
                {
                    channel1_filtered[validCount] = channel1[i];
                    channel2_filtered[validCount] = channel2[i];
                    channel3_filtered[validCount] = channel3[i];
                    validCount++;
                }
            }

            // Resize the filtered arrays to the actual valid count
            Array.Resize(ref channel1_filtered, validCount); //(array,new size)
            Array.Resize(ref channel2_filtered, validCount);
            Array.Resize(ref channel3_filtered, validCount);

            // Convert volts to displacement
            double sensitivity = 0.080;

            double[] channel1_displacement = new double[channel1_filtered.Length];
            double[] channel2_displacement = new double[channel2_filtered.Length];
            double[] channel3_displacement = new double[channel3_filtered.Length];

            for (int i = 0; i < channel1.Length; i++)
            {
                channel1_displacement[i] = (channel1_filtered[i] / sensitivity) * 0.985;
                channel2_displacement[i] = (channel2_filtered[i] / sensitivity) * 0.985;
                channel3_displacement[i] = (channel3_filtered[i] / sensitivity) * 0.985;
            }


            // declare Time
            int length = channel1.Length;
            // Enumerable.Range(start, count);
            double[] t = Enumerable.Range(0, length).Select(i => (double)i / (length - 1) * 10).ToArray();

            //Find the average pressure in each channel.
            double[] meanChannel = new double[3];

            if (channel1_displacement.Length > 0 && channel2_displacement.Length > 0 && channel3_displacement.Length > 0)
            {
                meanChannel[0] = channel1_displacement.Average();
                meanChannel[1] = channel2_displacement.Average();
                meanChannel[2] = channel3_displacement.Average();
            }
            else
            {
                Console.WriteLine("IT IS NO VALUE IN ARRAY AGAINNN!!!");
            }
                

            //Subtract the average value
            double[] channel1_plot = new double[channel1_displacement.Length];
            double[] channel2_plot = new double[channel2_displacement.Length];
            double[] channel3_plot = new double[channel3_displacement.Length];

            for (int i = 0; i < channel1_displacement.Length; i++)
            {
                channel1_plot[i] = channel1_displacement[i] - meanChannel[0];
                channel2_plot[i] = channel2_displacement[i] - meanChannel[1];
                channel3_plot[i] = channel3_displacement[i] - meanChannel[2];
            }


            // plotting
            plotView = new PlotView();
            plotView.Dock = DockStyle.Fill;
            OsilloscopePanel.Controls.Add(plotView);

            // send parameter tp PlotModel
            var model = CreatePlotModel(t, channel1_plot, channel2_plot, channel3_plot);
            plotView.Model = model;
            plotView.Model.InvalidatePlot(true);
        }

        private PlotModel CreatePlotModel(double[] x, double[] y1, double[] y2, double[] y3)
        {
            //x=time, y1=channel1, y2=channel2, y3=channel3

            var model = new PlotModel { Title = "Signal Graph" };
            model.Legends.Add(new Legend()
            {
                LegendPosition = LegendPosition.RightBottom,
            });

            // create lineseries for each channel
            var line1 = new LineSeries { Title = "Channel 1" };
            var line2 = new LineSeries { Title = "Channel 2" };
            var line3 = new LineSeries { Title = "Channel 3" };

            // plot linegraph
            for (int i = 0; i < x.Length; i++)
            {
                line1.Points.Add(new DataPoint(x[i], y1[i]));
                line2.Points.Add(new DataPoint(x[i], y2[i]));
                line3.Points.Add(new DataPoint(x[i], y3[i]));
            }

            // add line graph in PlotModel
            model.Series.Add(line1);
            model.Series.Add(line2);
            model.Series.Add(line3);

            // positon & title
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Title = "Time (s)" }); // x axis
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = "Displacement (nm)" }); // y axis

            return model;
        }

        private void ToggleLine(LineSeries line)
        {
            line.IsVisible = !line.IsVisible;
            plotView.InvalidatePlot(true);
        }
        
        private void xChannelBtn_Click(object sender, EventArgs e)
        {
            LineSeries line1 = new LineSeries();
            ToggleLine(line1);
        }

        private void yChannelBtn_Click(object sender, EventArgs e)
        {
            LineSeries line2 = new LineSeries();
            ToggleLine(line2);
        }

        private void zChannelBtn_Click(object sender, EventArgs e)
        {
            LineSeries line3 = new LineSeries();
            ToggleLine(line3);
        }
    }
}
