using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

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

        private void importDataBtn_Click(object sender, EventArgs e)
        {
            importDataDialog.Filter = "Excel|*.csv|Data Files|*.lda";
            //"Text files (*.txt)|*.txt|All files (*.*)|*.*"'
            importDataDialog.ShowDialog();
            importDataDialog.Title = "Select a Text File";
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
