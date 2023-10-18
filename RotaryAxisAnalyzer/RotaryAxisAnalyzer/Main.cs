using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using OxyPlot.WindowsForms;
using OxyPlot.Axes;

namespace RotaryAxisAnalyzer
{
    
    public partial class Main_Form : Form
    {
        
        Timer delayTimer;
        private PlotView plotView;

        public Main_Form()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;

            timer1.Start();

            //button image insert
            plotBtn.ImageIndex = 1;
            importDataBtn.ImageIndex = 2;
            dataStorageBtn.ImageIndex = 3;
            settingsBtn.ImageIndex = 4;

            //button decorate
            plotBtn.Paint += (sender, e) => BtnDecoration.ButtonDecoration(plotBtn, e);
            importDataBtn.Paint += (sender, e) => BtnDecoration.ButtonDecoration(importDataBtn, e);
            dataStorageBtn.Paint += (sender, e) => BtnDecoration.ButtonDecoration(dataStorageBtn, e);
            settingsBtn.Paint += (sender, e) => BtnDecoration.ButtonDecoration(settingsBtn, e);

            //delay for Setting Screen appear when program start, I will make it begin only first use later
            delayTimer = new Timer();
            delayTimer.Interval = 1000;
            delayTimer.Tick += (sender, e) => ShowSettingsForm();
            delayTimer.Start();

        }


        //Make multiple Panel for Plot and Datastorage to appear on Main Screen
        public void loadform(Form formToLoad)
        {
            mainPanel.Controls.Clear();

            formToLoad.TopLevel = false;
            formToLoad.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(formToLoad);

            formToLoad.Show();
        }

        private void ShowSettingsForm()
        {
            delayTimer.Stop();
            Settings ST = new Settings();
            ST.StartPosition = FormStartPosition.CenterScreen;
            ST.Show();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            createSaveDataFolder();

        }

        private void createSaveDataFolder()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderName = "SaveDataRRA";

            string folderPath = Path.Combine(documentsPath, folderName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        //Date Time
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.DateLabel.Text = dateTime.ToString();
        }

        private void SettingLabel_Click(object sender, EventArgs e)
        {

            Settings STS = new Settings();
            STS.Show();
            this.Hide();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Btn Event
        private void plotBtn_Click_1(object sender, EventArgs e)
        {
            Plot plotForm = new Plot();
            loadform(plotForm);

        }


        private void dataStorageBtn_Click(object sender, EventArgs e)
        {
            DataStorage dataStorageForm = new DataStorage();
            loadform(dataStorageForm);
        }

        private double[][] ReadXYZDataFromCSV(string filePath)
        {
            try
            {
                List<double> xData = new List<double>();
                List<double> yData = new List<double>();
                List<double> zData = new List<double>();

                bool isFirstLine = true;

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);

                        if (isFirstLine)
                        {
                            isFirstLine = false;
                            continue;
                        }

                        string[] values = line.Split(',');
                        Console.WriteLine($"Number of values in this line: {values.Length}");
                        if (values.Length >= 3)
                        {

                            string xValueString = values[0].Trim().Replace("\"", "");
                            if (double.TryParse(values[0].Trim(), out double xValue))
                            {
                                xData.Add(xValue);
                                Console.WriteLine("xValue: " + xValue);
                            }
                            else
                            {
                                Console.WriteLine("Failed to parse xValue.");
                            }

                            if (double.TryParse(values[1].Trim(), out double yValue))
                                yData.Add(yValue);

                            if (double.TryParse(values[2].Trim(), out double zValue))
                                zData.Add(zValue);

                        }
                    }
                }
                
                return new double[][] { xData.ToArray(), yData.ToArray(), zData.ToArray() };

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error reading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        private void importDataBtn_Click(object sender, EventArgs e)
        {
            importDataDialog.FileName = "";
            importDataDialog.Filter = "CSV Files|*.csv";
            importDataDialog.InitialDirectory = @"C:\Users\Simon\Documents\SaveDataRRA";
            importDataDialog.ShowDialog();

            if (!string.IsNullOrEmpty(importDataDialog.FileName))
            {
                string filePath = importDataDialog.FileName;
                
                double[][] importedData = ReadXYZDataFromCSV(filePath);

                if (importedData != null && importedData.Length == 3)
                {
                    double[] importedXData = importedData[0];
                    double[] importedYData = importedData[1];
                    double[] importedZData = importedData[2];

                    Console.WriteLine("Data loaded successfully!");

                    Console.WriteLine("importedXData values:");
                    foreach (var value in importedXData)
                    {
                        Console.WriteLine(value);
                    }

                    Console.WriteLine("importedYData values:");
                    foreach (var value in importedYData)
                    {
                        Console.WriteLine(value);
                    }

                    Console.WriteLine("importedZData values:");
                    foreach (var value in importedZData)
                    {
                        Console.WriteLine(value);
                    }

                    Plot plotForm = new Plot();
                    plotForm.SetData(importedXData, importedYData, importedZData);
                    loadform(plotForm);
                }
                else
                {
                    Console.WriteLine("Nothing Here at the first time");
                }
            }
        }


        private void settingsBtn_Click_1(object sender, EventArgs e)
        {
            Settings ST = new Settings();
            ST.StartPosition = FormStartPosition.CenterScreen;
            ST.Show();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
