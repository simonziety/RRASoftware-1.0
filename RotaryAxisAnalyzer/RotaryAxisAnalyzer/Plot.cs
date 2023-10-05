﻿using OxyPlot.Axes;
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

        private void Plot_Form_Load(object sender,  EventArgs e)
        {
            // create arrays
            double[] channel1 =
                { 1.85E+00,1.85E+00   ,
1.85E+00      ,
1.84E+00      ,
1.83E+00      ,
1.82E+00      ,
1.82E+00      ,
1.82E+00      ,
1.82E+00      ,
1.82E+00      ,
1.83E+00      ,
1.83E+00      ,
1.84E+00      ,
1.85E+00      ,
1.86E+00      ,
1.88E+00      ,
1.89E+00      ,
1.91E+00      ,
1.93E+00      ,
1.95E+00      ,
1.96E+00      ,
1.99E+00      ,
2.01E+00      ,
2.03E+00      ,
2.06E+00      ,
2.08E+00      ,
2.11E+00      ,
2.13E+00      ,
2.16E+00      ,
2.19E+00      ,
2.22E+00      ,
2.25E+00      ,
2.28E+00      ,
2.31E+00      ,
2.34E+00      ,
2.36E+00      ,
2.40E+00      ,
2.43E+00      ,
2.45E+00      ,
2.48E+00      ,
2.51E+00      ,
2.54E+00      ,
2.55E+00      ,
2.58E+00      ,
2.61E+00      ,
2.63E+00      ,
2.64E+00      ,
2.66E+00      ,
2.68E+00      ,
2.69E+00      ,
2.70E+00      ,
2.72E+00      ,
2.73E+00      ,
2.73E+00      ,
2.74E+00      ,
2.75E+00      ,
2.75E+00      ,
2.74E+00      ,
2.75E+00      ,
2.75E+00      ,
2.74E+00      ,
2.73E+00      ,
2.73E+00      ,
2.72E+00      ,
2.71E+00      ,
2.69E+00      ,
2.69E+00      ,
2.67E+00      ,
2.65E+00      ,
2.64E+00      ,
2.62E+00      ,
2.59E+00      ,
2.57E+00      ,
2.55E+00      ,
2.52E+00      ,
2.49E+00      ,
2.46E+00      ,
2.44E+00      ,
2.41E+00      ,
2.38E+00      ,
2.35E+00      ,
2.33E+00      ,
2.31E+00      ,
2.27E+00      ,
2.24E+00      ,
2.22E+00      ,
2.20E+00      ,
2.16E+00      ,
2.13E+00      ,
2.12E+00      ,
2.09E+00      ,
2.05E+00      ,
2.03E+00      ,
2.02E+00      ,
1.98E+00      ,
1.96E+00      ,
1.95E+00      ,
1.93E+00      ,
1.90E+00      ,
1.89E+00      ,
1.88E+00      ,
1.87E+00      ,
1.85E+00      ,
1.84E+00      ,
1.84E+00      ,
1.83E+00      ,
1.82E+00      ,
1.83E+00      ,
1.83E+00      ,
1.82E+00      ,
1.83E+00      ,
1.84E+00      ,
1.84E+00      ,
1.84E+00      ,
1.85E+00      ,
1.87E+00      ,
1.88E+00      ,
1.89E+00      ,
1.91E+00      ,
1.93E+00      ,
1.94E+00      ,
1.96E+00      ,
1.99E+00      ,
2.01E+00      ,
2.03E+00      ,
2.05E+00      ,
2.09E+00      ,
2.11E+00      ,
2.13E+00      ,
2.16E+00      ,
2.20E+00      ,
2.22E+00      ,
2.25E+00      ,
2.28E+00      ,
2.32E+00      ,
2.34E+00      ,
2.37E+00      ,
2.40E+00      ,
2.43E+00      ,
2.46E+00      ,
2.48E+00      ,
2.51E+00      ,
2.53E+00      ,
2.56E+00      ,
2.58E+00      ,
2.60E+00      ,
2.62E+00      ,
2.64E+00      ,
2.66E+00      ,
2.68E+00      ,
2.69E+00      ,
2.70E+00      ,
2.72E+00      ,
2.73E+00      ,
2.74E+00      ,
2.75E+00      ,
2.75E+00      ,
2.75E+00      ,
2.75E+00      ,
2.75E+00      ,
2.75E+00      ,
2.74E+00      ,
2.74E+00      ,
2.73E+00      ,
2.72E+00      ,
2.71E+00      ,
2.70E+00      ,
2.68E+00      ,
2.66E+00      ,
2.65E+00      ,
2.63E+00      ,
2.61E+00      ,
2.59E+00      ,
2.57E+00      ,
2.55E+00      ,
2.52E+00      ,
2.50E+00      ,
2.47E+00      ,
2.45E+00      ,
2.42E+00      ,
2.39E+00      ,
2.36E+00      ,
2.33E+00      ,
2.30E+00      ,
2.27E+00      ,
2.25E+00      ,
2.22E+00      ,
2.18E+00      ,
2.16E+00      ,
2.14E+00      ,
2.11E+00      ,
2.08E+00      ,
2.06E+00      ,
2.03E+00      ,
2.00E+00      ,
1.98E+00      ,
1.97E+00      ,
1.94E+00      ,
1.92E+00      ,
1.91E+00      ,
1.90E+00      ,
1.88E+00      ,
1.87E+00      ,
1.86E+00      ,
1.85E+00      ,
1.84E+00      ,
1.83E+00      ,
1.83E+00      ,
1.82E+00      ,
1.82E+00      ,
1.82E+00      ,
1.82E+00      ,
1.83E+00      ,
1.83E+00      ,
1.84E+00      ,
1.85E+00      ,
1.86E+00      ,
1.87E+00      ,
1.89E+00      ,
1.91E+00      ,
1.93E+00      ,
1.94E+00      ,
1.96E+00      ,
1.99E+00      ,
2.01E+00      ,
2.03E+00      ,
2.06E+00      ,
2.09E+00      ,
2.11E+00      ,
2.13E+00      ,
2.17E+00      ,
2.20E+00      ,
2.22E+00      ,
2.25E+00      ,
2.29E+00      ,
2.31E+00      ,
2.33E+00      ,
2.36E+00      ,
2.40E+00      ,
2.42E+00      ,
2.44E+00      ,
2.48E+00      ,
2.51E+00      ,
2.53E+00      ,
2.55E+00      ,
2.59E+00      ,
2.61E+00      ,
2.62E+00      ,
2.64E+00      ,
2.67E+00      ,
2.68E+00      ,
2.68E+00      ,
2.71E+00      ,
2.72E+00      ,
2.72E+00      ,
2.73E+00      ,
2.75E+00      ,
2.75E+00      ,
2.74E+00      ,
2.75E+00      ,
2.75E+00      ,
2.74E+00      ,
2.73E+00      ,
2.74E+00      ,
2.73E+00      ,
2.71E+00      ,
2.70E+00      ,
2.70E+00      ,
2.68E+00      ,
2.66E+00      ,
2.65E+00      ,
2.64E+00      ,
2.61E+00      ,
2.59E+00      ,
2.57E+00      ,
2.55E+00      ,
2.52E+00      ,
2.49E+00      ,
2.47E+00      ,
2.44E+00      ,
2.41E+00      ,
2.38E+00      ,
2.36E+00      ,
2.33E+00      ,
2.30E+00      ,
2.27E+00      ,
2.25E+00      ,
2.22E+00      ,
2.19E+00      ,
2.16E+00      ,
2.14E+00      ,
2.11E+00      ,
2.08E+00      ,
2.06E+00      ,
2.04E+00      ,
2.01E+00      ,
1.98E+00      ,
1.97E+00      ,
1.95E+00      ,
1.92E+00      ,
1.91E+00      ,
1.90E+00      ,
1.88E+00      ,
1.86E+00      ,
1.85E+00      ,
1.85E+00      ,
1.83E+00      ,
1.83E+00      ,
1.83E+00      ,
1.82E+00      ,
1.82E+00      ,
1.82E+00      ,
1.83E+00      ,
1.83E+00      ,
1.84E+00      ,
1.85E+00      ,
1.85E+00      ,
1.86E+00      ,
1.88E+00      ,
1.90E+00      ,
1.91E+00      ,
1.93E+00      ,
1.95E+00      ,
1.97E+00      ,
1.99E+00      ,
2.01E+00      ,
2.03E+00      ,
2.06E+00      ,
2.08E+00      ,
2.10E+00      ,
2.14E+00      ,
2.16E+00      ,
2.19E+00      ,
2.22E+00      ,
2.25E+00      ,
2.28E+00      ,
2.31E+00      ,
2.34E+00      ,
2.37E+00      ,
2.40E+00      ,
2.43E+00      ,
2.46E+00      ,
2.49E+00      ,
2.51E+00      ,
2.53E+00      ,
2.56E+00      ,
2.59E+00      ,
2.60E+00      ,
2.62E+00      ,
2.65E+00      ,
2.66E+00      ,
2.67E+00      ,
2.69E+00      ,
2.71E+00      ,
2.72E+00      ,
2.72E+00      ,
2.74E+00      ,
2.75E+00      ,
2.75E+00      ,
2.75E+00      ,
2.76E+00      ,
2.76E+00      ,
2.75E+00      ,
2.75E+00      ,
2.75E+00      ,
2.73E+00      ,
2.72E+00      ,
2.71E+00      ,
2.70E+00      ,
2.68E+00      ,
2.66E+00      ,
2.66E+00      ,
2.64E+00      ,
2.61E+00      ,
2.59E+00      ,
2.58E+00      ,
2.55E+00      ,
2.52E+00      ,
2.50E+00      ,
2.48E+00      ,
2.44E+00      ,
2.41E+00      ,
2.39E+00      ,
2.36E+00      ,
2.33E+00      ,
2.30E+00      ,
2.28E+00      ,
2.25E+00      ,
2.22E+00      ,
2.19E+00      ,
2.17E+00      ,
2.14E+00      ,
2.11E+00      ,
2.08E+00      ,
2.06E+00      ,
2.03E+00      ,
2.00E+00      ,
1.98E+00      ,
1.97E+00      ,
1.94E+00      ,
1.92E+00      ,
1.91E+00      ,
1.90E+00      ,
1.88E+00      ,
1.87E+00      ,
1.86E+00      ,
1.85E+00      ,
1.84E+00      ,
1.83E+00      ,
1.83E+00      ,
1.83E+00      ,
1.82E+00      ,
1.82E+00      ,
1.83E+00      ,
1.83E+00      ,
1.83E+00      ,
1.85E+00      ,
1.86E+00      ,
1.86E+00      ,
1.87E+00      ,
1.90E+00      ,
1.91E+00      ,
1.92E+00      ,
1.94E+00      ,
1.97E+00      ,
1.98E+00      ,
2.00E+00      ,
2.04E+00      ,
2.07E+00      ,
2.08E+00      ,
2.11E+00      ,
2.15E+00      ,
2.17E+00      ,
2.19E+00      ,
2.22E+00      ,
2.26E+00      ,
2.28E+00      ,
2.30E+00      ,
2.33E+00      ,
2.37E+00      ,
2.39E+00      ,
2.42E+00      ,
2.45E+00      ,
2.48E+00      ,
2.50E+00      ,
2.53E+00      ,
2.56E+00      ,
2.58E+00      ,
2.59E+00      ,
2.62E+00      ,
2.65E+00      ,
2.66E+00      ,
2.67E+00      ,
2.70E+00      ,
2.71E+00      ,
2.71E+00      ,
2.73E+00      ,
2.74E+00      ,
2.74E+00      ,
2.74E+00      ,
2.75E+00      ,
2.75E+00      ,
2.75E+00      ,
2.74E+00      ,
2.74E+00      ,
2.74E+00      ,
2.72E+00      ,
2.71E+00      ,
2.71E+00      ,
2.70E+00      ,
2.68E+00      ,
2.67E+00      ,
2.66E+00      ,
2.64E+00      ,
2.61E+00      ,
2.59E+00      ,
2.57E+00      ,
2.55E+00      ,
2.52E+00      ,
2.49E+00      ,
2.47E+00      ,
2.44E+00      ,
2.41E+00      ,
2.38E+00      ,
2.37E+00      ,
2.33E+00      ,
2.30E+00      ,
2.27E+00      ,
2.25E+00      ,
2.21E+00      ,
2.18E+00      ,
2.16E+00      ,
2.13E+00      ,
2.10E+00      ,
2.08E+00      ,
2.06E+00      ,
2.03E+00      ,
2.01E+00      ,
1.99E+00      ,
1.97E+00      ,
 };
            double[] channel2 =
                { -1.13E+00,-1.13E+00     ,
-1.11E+00     ,
-1.09E+00     ,
-1.06E+00     ,
-1.02E+00     ,
-1.00E+00     ,
-9.76E-01     ,
-9.41E-01     ,
-9.08E-01     ,
-8.87E-01     ,
-8.62E-01     ,
-8.28E-01     ,
-7.99E-01     ,
-7.80E-01     ,
-7.57E-01     ,
-7.28E-01     ,
-7.05E-01     ,
-6.93E-01     ,
-6.71E-01     ,
-6.42E-01     ,
-6.31E-01     ,
-6.21E-01     ,
-5.99E-01     ,
-5.84E-01     ,
-5.81E-01     ,
-5.69E-01     ,
-5.52E-01     ,
-5.50E-01     ,
-5.52E-01     ,
-5.40E-01     ,
-5.35E-01     ,
-5.43E-01     ,
-5.47E-01     ,
-5.44E-01     ,
-5.51E-01     ,
-5.64E-01     ,
-5.70E-01     ,
-5.77E-01     ,
-5.89E-01     ,
-6.06E-01     ,
-6.21E-01     ,
-6.34E-01     ,
-6.52E-01     ,
-6.79E-01     ,
-6.99E-01     ,
-7.14E-01     ,
-7.40E-01     ,
-7.70E-01     ,
-7.88E-01     ,
-8.06E-01     ,
-8.38E-01     ,
-8.63E-01     ,
-8.83E-01     ,
-9.10E-01     ,
-9.44E-01     ,
-9.71E-01     ,
-9.92E-01     ,
-1.02E+00     ,
-1.05E+00     ,
-1.08E+00     ,
-1.10E+00     ,
-1.13E+00     ,
-1.16E+00     ,
-1.18E+00     ,
-1.20E+00     ,
-1.23E+00     ,
-1.26E+00     ,
-1.27E+00     ,
-1.29E+00     ,
-1.32E+00     ,
-1.34E+00     ,
-1.35E+00     ,
-1.37E+00     ,
-1.39E+00     ,
-1.40E+00     ,
-1.40E+00     ,
-1.42E+00     ,
-1.43E+00     ,
-1.43E+00     ,
-1.43E+00     ,
-1.44E+00     ,
-1.44E+00     ,
-1.43E+00     ,
-1.43E+00     ,
-1.44E+00     ,
-1.43E+00     ,
-1.41E+00     ,
-1.41E+00     ,
-1.41E+00     ,
-1.39E+00     ,
-1.36E+00     ,
-1.36E+00     ,
-1.35E+00     ,
-1.32E+00     ,
-1.30E+00     ,
-1.29E+00     ,
-1.26E+00     ,
-1.23E+00     ,
-1.21E+00     ,
-1.19E+00     ,
-1.16E+00     ,
-1.13E+00     ,
-1.11E+00     ,
-1.08E+00     ,
-1.05E+00     ,
-1.02E+00     ,
-9.95E-01     ,
-9.69E-01     ,
-9.38E-01     ,
-9.09E-01     ,
-8.89E-01     ,
-8.67E-01     ,
-8.33E-01     ,
-8.05E-01     ,
-7.90E-01     ,
-7.67E-01     ,
-7.32E-01     ,
-7.12E-01     ,
-7.00E-01     ,
-6.72E-01     ,
-6.44E-01     ,
-6.35E-01     ,
-6.24E-01     ,
-5.97E-01     ,
-5.79E-01     ,
-5.81E-01     ,
-5.71E-01     ,
-5.49E-01     ,
-5.44E-01     ,
-5.50E-01     ,
-5.41E-01     ,
-5.30E-01     ,
-5.40E-01     ,
-5.50E-01     ,
-5.47E-01     ,
-5.48E-01     ,
-5.68E-01     ,
-5.80E-01     ,
-5.79E-01     ,
-5.91E-01     ,
-6.14E-01     ,
-6.26E-01     ,
-6.32E-01     ,
-6.54E-01     ,
-6.78E-01     ,
-6.92E-01     ,
-7.07E-01     ,
-7.35E-01     ,
-7.62E-01     ,
-7.81E-01     ,
-8.04E-01     ,
-8.35E-01     ,
-8.64E-01     ,
-8.86E-01     ,
-9.13E-01     ,
-9.46E-01     ,
-9.73E-01     ,
-9.96E-01     ,
-1.03E+00     ,
-1.05E+00     ,
-1.08E+00     ,
-1.10E+00     ,
-1.13E+00     ,
-1.16E+00     ,
-1.18E+00     ,
-1.21E+00     ,
-1.24E+00     ,
-1.26E+00     ,
-1.28E+00     ,
-1.30E+00     ,
-1.32E+00     ,
-1.34E+00     ,
-1.35E+00     ,
-1.37E+00     ,
-1.38E+00     ,
-1.40E+00     ,
-1.41E+00     ,
-1.42E+00     ,
-1.43E+00     ,
-1.44E+00     ,
-1.44E+00     ,
-1.44E+00     ,
-1.44E+00     ,
-1.45E+00     ,
-1.44E+00     ,
-1.44E+00     ,
-1.43E+00     ,
-1.43E+00     ,
-1.42E+00     ,
-1.40E+00     ,
-1.39E+00     ,
-1.38E+00     ,
-1.36E+00     ,
-1.34E+00     ,
-1.32E+00     ,
-1.30E+00     ,
-1.28E+00     ,
-1.26E+00     ,
-1.23E+00     ,
-1.21E+00     ,
-1.19E+00     ,
-1.16E+00     ,
-1.13E+00     ,
-1.11E+00     ,
-1.09E+00     ,
-1.06E+00     ,
-1.03E+00     ,
-1.01E+00     ,
-9.77E-01     ,
-9.37E-01     ,
-9.14E-01     ,
-8.96E-01     ,
-8.58E-01     ,
-8.22E-01     ,
-8.09E-01     ,
-7.89E-01     ,
-7.49E-01     ,
-7.27E-01     ,
-7.21E-01     ,
-6.94E-01     ,
-6.61E-01     ,
-6.52E-01     ,
-6.43E-01     ,
-6.15E-01     ,
-5.94E-01     ,
-5.94E-01     ,
-5.83E-01     ,
-5.62E-01     ,
-5.57E-01     ,
-5.58E-01     ,
-5.48E-01     ,
-5.40E-01     ,
-5.45E-01     ,
-5.48E-01     ,
-5.43E-01     ,
-5.45E-01     ,
-5.57E-01     ,
-5.65E-01     ,
-5.68E-01     ,
-5.76E-01     ,
-5.91E-01     ,
-6.08E-01     ,
-6.18E-01     ,
-6.33E-01     ,
-6.57E-01     ,
-6.78E-01     ,
-6.92E-01     ,
-7.11E-01     ,
-7.42E-01     ,
-7.67E-01     ,
-7.81E-01     ,
-8.07E-01     ,
-8.43E-01     ,
-8.64E-01     ,
-8.81E-01     ,
-9.16E-01     ,
-9.52E-01     ,
-9.68E-01     ,
-9.93E-01     ,
-1.03E+00     ,
-1.05E+00     ,
-1.07E+00     ,
-1.10E+00     ,
-1.14E+00     ,
-1.15E+00     ,
-1.17E+00     ,
-1.21E+00     ,
-1.23E+00     ,
-1.25E+00     ,
-1.27E+00     ,
-1.30E+00     ,
-1.32E+00     ,
-1.33E+00     ,
-1.36E+00     ,
-1.38E+00     ,
-1.38E+00     ,
-1.40E+00     ,
-1.41E+00     ,
-1.42E+00     ,
-1.43E+00     ,
-1.43E+00     ,
-1.44E+00     ,
-1.44E+00     ,
-1.44E+00     ,
-1.44E+00     ,
-1.44E+00     ,
-1.43E+00     ,
-1.43E+00     ,
-1.42E+00     ,
-1.41E+00     ,
-1.40E+00     ,
-1.39E+00     ,
-1.37E+00     ,
-1.36E+00     ,
-1.34E+00     ,
-1.32E+00     ,
-1.30E+00     ,
-1.29E+00     ,
-1.26E+00     ,
-1.23E+00     ,
-1.22E+00     ,
-1.19E+00     ,
-1.16E+00     ,
-1.13E+00     ,
-1.11E+00     ,
-1.08E+00     ,
-1.05E+00     ,
-1.02E+00     ,
-9.99E-01     ,
-9.64E-01     ,
-9.34E-01     ,
-9.15E-01     ,
-8.89E-01     ,
-8.56E-01     ,
-8.30E-01     ,
-8.12E-01     ,
-7.83E-01     ,
-7.52E-01     ,
-7.36E-01     ,
-7.19E-01     ,
-6.87E-01     ,
-6.60E-01     ,
-6.55E-01     ,
-6.40E-01     ,
-6.07E-01     ,
-5.98E-01     ,
-5.98E-01     ,
-5.74E-01     ,
-5.53E-01     ,
-5.59E-01     ,
-5.54E-01     ,
-5.34E-01     ,
-5.30E-01     ,
-5.44E-01     ,
-5.40E-01     ,
-5.33E-01     ,
-5.46E-01     ,
-5.61E-01     ,
-5.60E-01     ,
-5.66E-01     ,
-5.85E-01     ,
-5.99E-01     ,
-6.02E-01     ,
-6.18E-01     ,
-6.44E-01     ,
-6.56E-01     ,
-6.65E-01     ,
-6.92E-01     ,
-7.22E-01     ,
-7.36E-01     ,
-7.52E-01     ,
-7.88E-01     ,
-8.14E-01     ,
-8.31E-01     ,
-8.58E-01     ,
-8.95E-01     ,
-9.15E-01     ,
-9.36E-01     ,
-9.71E-01     ,
-1.00E+00     ,
-1.02E+00     ,
-1.05E+00     ,
-1.08E+00     ,
-1.10E+00     ,
-1.13E+00     ,
-1.16E+00     ,
-1.19E+00     ,
-1.21E+00     ,
-1.23E+00     ,
-1.26E+00     ,
-1.28E+00     ,
-1.30E+00     ,
-1.32E+00     ,
-1.33E+00     ,
-1.35E+00     ,
-1.37E+00     ,
-1.38E+00     ,
-1.39E+00     ,
-1.41E+00     ,
-1.42E+00     ,
-1.42E+00     ,
-1.43E+00     ,
-1.44E+00     ,
-1.45E+00     ,
-1.43E+00     ,
-1.44E+00     ,
-1.45E+00     ,
-1.44E+00     ,
-1.42E+00     ,
-1.43E+00     ,
-1.42E+00     ,
-1.40E+00     ,
-1.38E+00     ,
-1.38E+00     ,
-1.37E+00     ,
-1.33E+00     ,
-1.32E+00     ,
-1.31E+00     ,
-1.28E+00     ,
-1.25E+00     ,
-1.24E+00     ,
-1.22E+00     ,
-1.18E+00     ,
-1.15E+00     ,
-1.14E+00     ,
-1.11E+00     ,
-1.08E+00     ,
-1.06E+00     ,
-1.03E+00     ,
-1.00E+00     ,
-9.68E-01     ,
-9.46E-01     ,
-9.25E-01     ,
-8.90E-01     ,
-8.55E-01     ,
-8.36E-01     ,
-8.15E-01     ,
-7.81E-01     ,
-7.53E-01     ,
-7.42E-01     ,
-7.17E-01     ,
-6.84E-01     ,
-6.70E-01     ,
-6.62E-01     ,
-6.32E-01     ,
-6.09E-01     ,
-6.06E-01     ,
-5.95E-01     ,
-5.71E-01     ,
-5.63E-01     ,
-5.66E-01     ,
-5.56E-01     ,
-5.44E-01     ,
-5.45E-01     ,
-5.49E-01     ,
-5.48E-01     ,
-5.43E-01     ,
-5.49E-01     ,
-5.60E-01     ,
-5.62E-01     ,
-5.66E-01     ,
-5.81E-01     ,
-5.96E-01     ,
-6.05E-01     ,
-6.17E-01     ,
-6.38E-01     ,
-6.58E-01     ,
-6.71E-01     ,
-6.89E-01     ,
-7.16E-01     ,
-7.37E-01     ,
-7.56E-01     ,
-7.81E-01     ,
-8.12E-01     ,
-8.39E-01     ,
-8.58E-01     ,
-8.88E-01     ,
-9.24E-01     ,
-9.47E-01     ,
-9.65E-01     ,
-1.00E+00     ,
-1.03E+00     ,
-1.05E+00     ,
-1.07E+00     ,
-1.11E+00     ,
-1.13E+00     ,
-1.15E+00     ,
-1.18E+00     ,
-1.21E+00     ,
-1.23E+00     ,
-1.25E+00     ,
-1.28E+00     ,
-1.30E+00     ,
-1.31E+00     ,
-1.33E+00     ,
-1.36E+00     ,
-1.38E+00     ,
-1.38E+00     ,
-1.40E+00     ,
-1.42E+00     ,
-1.42E+00     ,
-1.42E+00     ,
-1.44E+00     ,
-1.44E+00     ,
-1.44E+00     ,
-1.44E+00     ,
-1.45E+00     ,
-1.44E+00     ,
-1.43E+00     ,
-1.43E+00     ,
-1.42E+00     ,
-1.41E+00     ,
-1.40E+00     ,
-1.39E+00     ,
-1.37E+00     ,
-1.36E+00     ,
-1.34E+00     ,
-1.32E+00     ,
-1.31E+00     ,
};
            double[] channel3 =
                { -5.86E-01,-5.86E-01     ,
-5.88E-01     ,
-5.88E-01     ,
-5.91E-01     ,
-5.94E-01     ,
-5.93E-01     ,
-5.93E-01     ,
-5.93E-01     ,
-5.93E-01     ,
-5.95E-01     ,
-5.95E-01     ,
-5.94E-01     ,
-5.90E-01     ,
-5.88E-01     ,
-5.88E-01     ,
-5.86E-01     ,
-5.83E-01     ,
-5.81E-01     ,
-5.79E-01     ,
-5.77E-01     ,
-5.76E-01     ,
-5.76E-01     ,
-5.78E-01     ,
-5.77E-01     ,
-5.76E-01     ,
-5.74E-01     ,
-5.75E-01     ,
-5.74E-01     ,
-5.72E-01     ,
-5.72E-01     ,
-5.72E-01     ,
-5.68E-01     ,
-5.65E-01     ,
-5.66E-01     ,
-5.66E-01     ,
-5.63E-01     ,
-5.61E-01     ,
-5.62E-01     ,
-5.65E-01     ,
-5.63E-01     ,
-5.62E-01     ,
-5.65E-01     ,
-5.68E-01     ,
-5.67E-01     ,
-5.66E-01     ,
-5.68E-01     ,
-5.70E-01     ,
-5.68E-01     ,
-5.67E-01     ,
-5.68E-01     ,
-5.67E-01     ,
-5.64E-01     ,
-5.65E-01     ,
-5.65E-01     ,
-5.62E-01     ,
-5.60E-01     ,
-5.60E-01     ,
-5.59E-01     ,
-5.57E-01     ,
-5.54E-01     ,
-5.52E-01     ,
-5.51E-01     ,
-5.48E-01     ,
-5.44E-01     ,
-5.42E-01     ,
-5.40E-01     ,
-5.36E-01     ,
-5.33E-01     ,
-5.31E-01     ,
-5.29E-01     ,
-5.27E-01     ,
-5.28E-01     ,
-5.27E-01     ,
-5.23E-01     ,
-5.25E-01     ,
-5.27E-01     ,
-5.25E-01     ,
-5.23E-01     ,
-5.24E-01     ,
-5.24E-01     ,
-5.23E-01     ,
-5.23E-01     ,
-5.25E-01     ,
-5.26E-01     ,
-5.27E-01     ,
-5.29E-01     ,
-5.33E-01     ,
-5.37E-01     ,
-5.41E-01     ,
-5.46E-01     ,
-5.48E-01     ,
-5.51E-01     ,
-5.58E-01     ,
-5.64E-01     ,
-5.67E-01     ,
-5.67E-01     ,
-5.70E-01     ,
-5.76E-01     ,
-5.79E-01     ,
-5.81E-01     ,
-5.84E-01     ,
-5.86E-01     ,
-5.87E-01     ,
-5.90E-01     ,
-5.91E-01     ,
-5.92E-01     ,
-5.91E-01     ,
-5.93E-01     ,
-5.94E-01     ,
-5.93E-01     ,
-5.91E-01     ,
-5.91E-01     ,
-5.95E-01     ,
-5.94E-01     ,
-5.89E-01     ,
-5.89E-01     ,
-5.91E-01     ,
-5.87E-01     ,
-5.84E-01     ,
-5.85E-01     ,
-5.85E-01     ,
-5.81E-01     ,
-5.79E-01     ,
-5.81E-01     ,
-5.80E-01     ,
-5.74E-01     ,
-5.73E-01     ,
-5.74E-01     ,
-5.69E-01     ,
-5.65E-01     ,
-5.65E-01     ,
-5.66E-01     ,
-5.62E-01     ,
-5.62E-01     ,
-5.65E-01     ,
-5.65E-01     ,
-5.61E-01     ,
-5.63E-01     ,
-5.68E-01     ,
-5.69E-01     ,
-5.65E-01     ,
-5.66E-01     ,
-5.70E-01     ,
-5.68E-01     ,
-5.64E-01     ,
-5.68E-01     ,
-5.71E-01     ,
-5.69E-01     ,
-5.66E-01     ,
-5.68E-01     ,
-5.67E-01     ,
-5.65E-01     ,
-5.62E-01     ,
-5.63E-01     ,
-5.62E-01     ,
-5.58E-01     ,
-5.59E-01     ,
-5.62E-01     ,
-5.58E-01     ,
-5.55E-01     ,
-5.55E-01     ,
-5.57E-01     ,
-5.54E-01     ,
-5.51E-01     ,
-5.46E-01     ,
-5.43E-01     ,
-5.40E-01     ,
-5.40E-01     ,
-5.37E-01     ,
-5.30E-01     ,
-5.28E-01     ,
-5.27E-01     ,
-5.26E-01     ,
-5.21E-01     ,
-5.18E-01     ,
-5.19E-01     ,
-5.21E-01     ,
-5.18E-01     ,
-5.15E-01     ,
-5.18E-01     ,
-5.21E-01     ,
-5.21E-01     ,
-5.21E-01     ,
-5.24E-01     ,
-5.26E-01     ,
-5.28E-01     ,
-5.31E-01     ,
-5.37E-01     ,
-5.37E-01     ,
-5.37E-01     ,
-5.41E-01     ,
-5.48E-01     ,
-5.49E-01     ,
-5.50E-01     ,
-5.54E-01     ,
-5.61E-01     ,
-5.64E-01     ,
-5.68E-01     ,
-5.71E-01     ,
-5.74E-01     ,
-5.77E-01     ,
-5.82E-01     ,
-5.85E-01     ,
-5.85E-01     ,
-5.89E-01     ,
-5.93E-01     ,
-5.94E-01     ,
-5.93E-01     ,
-5.96E-01     ,
-5.98E-01     ,
-5.98E-01     ,
-5.96E-01     ,
-5.97E-01     ,
-5.98E-01     ,
-5.95E-01     ,
-5.92E-01     ,
-5.93E-01     ,
-5.90E-01     ,
-5.85E-01     ,
-5.83E-01     ,
-5.83E-01     ,
-5.80E-01     ,
-5.76E-01     ,
-5.76E-01     ,
-5.77E-01     ,
-5.77E-01     ,
-5.75E-01     ,
-5.74E-01     ,
-5.77E-01     ,
-5.75E-01     ,
-5.71E-01     ,
-5.72E-01     ,
-5.72E-01     ,
-5.69E-01     ,
-5.67E-01     ,
-5.67E-01     ,
-5.66E-01     ,
-5.64E-01     ,
-5.66E-01     ,
-5.67E-01     ,
-5.64E-01     ,
-5.62E-01     ,
-5.65E-01     ,
-5.67E-01     ,
-5.65E-01     ,
-5.64E-01     ,
-5.68E-01     ,
-5.68E-01     ,
-5.66E-01     ,
-5.66E-01     ,
-5.70E-01     ,
-5.69E-01     ,
-5.66E-01     ,
-5.64E-01     ,
-5.66E-01     ,
-5.65E-01     ,
-5.63E-01     ,
-5.62E-01     ,
-5.60E-01     ,
-5.58E-01     ,
-5.58E-01     ,
-5.57E-01     ,
-5.54E-01     ,
-5.51E-01     ,
-5.50E-01     ,
-5.46E-01     ,
-5.43E-01     ,
-5.38E-01     ,
-5.34E-01     ,
-5.31E-01     ,
-5.30E-01     ,
-5.27E-01     ,
-5.25E-01     ,
-5.26E-01     ,
-5.26E-01     ,
-5.24E-01     ,
-5.23E-01     ,
-5.24E-01     ,
-5.23E-01     ,
-5.23E-01     ,
-5.25E-01     ,
-5.23E-01     ,
-5.20E-01     ,
-5.23E-01     ,
-5.27E-01     ,
-5.25E-01     ,
-5.26E-01     ,
-5.30E-01     ,
-5.33E-01     ,
-5.32E-01     ,
-5.36E-01     ,
-5.42E-01     ,
-5.46E-01     ,
-5.48E-01     ,
-5.52E-01     ,
-5.58E-01     ,
-5.62E-01     ,
-5.65E-01     ,
-5.70E-01     ,
-5.73E-01     ,
-5.75E-01     ,
-5.79E-01     ,
-5.83E-01     ,
-5.83E-01     ,
-5.85E-01     ,
-5.88E-01     ,
-5.91E-01     ,
-5.93E-01     ,
-5.92E-01     ,
-5.91E-01     ,
-5.92E-01     ,
-5.92E-01     ,
-5.93E-01     ,
-5.93E-01     ,
-5.90E-01     ,
-5.87E-01     ,
-5.89E-01     ,
-5.90E-01     ,
-5.87E-01     ,
-5.85E-01     ,
-5.86E-01     ,
-5.86E-01     ,
-5.82E-01     ,
-5.82E-01     ,
-5.87E-01     ,
-5.82E-01     ,
-5.77E-01     ,
-5.79E-01     ,
-5.80E-01     ,
-5.75E-01     ,
-5.71E-01     ,
-5.72E-01     ,
-5.70E-01     ,
-5.68E-01     ,
-5.68E-01     ,
-5.67E-01     ,
-5.66E-01     ,
-5.65E-01     ,
-5.65E-01     ,
-5.67E-01     ,
-5.66E-01     ,
-5.67E-01     ,
-5.69E-01     ,
-5.71E-01     ,
-5.69E-01     ,
-5.67E-01     ,
-5.69E-01     ,
-5.71E-01     ,
-5.71E-01     ,
-5.71E-01     ,
-5.71E-01     ,
-5.69E-01     ,
-5.68E-01     ,
-5.69E-01     ,
-5.69E-01     ,
-5.66E-01     ,
-5.61E-01     ,
-5.61E-01     ,
-5.63E-01     ,
-5.60E-01     ,
-5.57E-01     ,
-5.56E-01     ,
-5.57E-01     ,
-5.57E-01     ,
-5.51E-01     ,
-5.50E-01     ,
-5.50E-01     ,
-5.45E-01     ,
-5.40E-01     ,
-5.38E-01     ,
-5.36E-01     ,
-5.33E-01     ,
-5.31E-01     ,
-5.30E-01     ,
-5.27E-01     ,
-5.22E-01     ,
-5.21E-01     ,
-5.23E-01     ,
-5.21E-01     ,
-5.17E-01     ,
-5.17E-01     ,
-5.20E-01     ,
-5.18E-01     ,
-5.18E-01     ,
-5.21E-01     ,
-5.24E-01     ,
-5.24E-01     ,
-5.26E-01     ,
-5.31E-01     ,
-5.32E-01     ,
-5.35E-01     ,
-5.40E-01     ,
-5.43E-01     ,
-5.43E-01     ,
-5.46E-01     ,
-5.53E-01     ,
-5.58E-01     ,
-5.57E-01     ,
-5.60E-01     ,
-5.66E-01     ,
-5.71E-01     ,
-5.71E-01     ,
-5.76E-01     ,
-5.79E-01     ,
-5.78E-01     ,
-5.80E-01     ,
-5.84E-01     ,
-5.87E-01     ,
-5.87E-01     ,
-5.88E-01     ,
-5.91E-01     ,
-5.95E-01     ,
-5.94E-01     ,
-5.95E-01     ,
-5.93E-01     ,
-5.92E-01     ,
-5.90E-01     ,
-5.92E-01     ,
-5.91E-01     ,
-5.84E-01     ,
-5.82E-01     ,
-5.83E-01     ,
-5.82E-01     ,
-5.79E-01     ,
-5.79E-01     ,
-5.77E-01     ,
-5.73E-01     ,
-5.71E-01     ,
-5.72E-01     ,
-5.69E-01     ,
-5.68E-01     ,
-5.69E-01     ,
-5.71E-01     ,
-5.71E-01     ,
-5.67E-01     ,
-5.67E-01     ,
-5.69E-01     ,
-5.68E-01     ,
-5.65E-01     ,
-5.63E-01     ,
-5.65E-01     ,
-5.67E-01     ,
-5.66E-01     ,
-5.66E-01     ,
-5.67E-01     ,
-5.67E-01     ,
-5.68E-01     ,
-5.67E-01     ,
-5.69E-01     ,
-5.67E-01     ,
-5.66E-01     ,
-5.67E-01     ,
-5.70E-01     ,
-5.69E-01     ,
-5.66E-01     ,
-5.66E-01     ,
-5.67E-01     ,
-5.65E-01     ,
-5.66E-01     ,
-5.67E-01     ,
-5.63E-01     ,
-5.61E-01     ,
-5.62E-01     ,
-5.63E-01     ,
-5.58E-01     ,
-5.54E-01     ,
-5.53E-01     ,
-5.50E-01     ,
-5.44E-01     ,
-5.41E-01     ,
-5.38E-01     ,
-5.34E-01     ,
-5.31E-01     ,
-5.31E-01     ,
-5.30E-01     ,
-5.26E-01     ,
-5.25E-01     ,
-5.26E-01     ,
-5.26E-01     ,
-5.23E-01     ,
-5.22E-01     ,
-5.26E-01     ,
-5.26E-01     ,
-5.23E-01     ,
-5.23E-01     ,
-5.26E-01     ,
-5.29E-01     ,
-5.28E-01     ,
-5.29E-01     ,
-5.29E-01     ,
-5.31E-01     ,
-5.35E-01     ,
-5.39E-01     ,
-5.41E-01     ,
-5.42E-01     ,
-5.46E-01     ,
-5.53E-01     ,
-5.57E-01     ,
-5.59E-01
};

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
            meanChannel[0] = channel1_displacement.Average();
            meanChannel[1] = channel2_displacement.Average();
            meanChannel[2] = channel3_displacement.Average();

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


        private void xChannelBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void yChannelBtn_Click(object sender, EventArgs e)
        {

        }

        private void zChannelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
