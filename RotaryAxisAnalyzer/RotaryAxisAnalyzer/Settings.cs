﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotaryAxisAnalyzer
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            //Panel Design


            //Btn Design
            gsBtn.Paint += (sender, e) => BtnDecoration.ButtonDecoration(gsBtn, e);
            asBtn.Paint += (sender, e) => BtnDecoration.ButtonDecoration(asBtn, e);
            applyBtn.Paint += (sender, e) => BtnDecoration.ButtonDecoration(applyBtn, e);
            cancelBtn.Paint += (sender, e) => BtnDecoration.ButtonDecoration(cancelBtn, e);

            asBtn.FlatStyle = FlatStyle.Flat;
            asBtn.FlatAppearance.BorderSize = 0;

            gsBtn.FlatStyle = FlatStyle.Flat;
            gsBtn.FlatAppearance.BorderSize = 0;

            applyBtn.FlatStyle = FlatStyle.Flat;
            applyBtn.FlatAppearance.BorderSize = 0;

            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.FlatAppearance.BorderSize = 0;

        }
        public void loadform(Form formToLoad)
        {
            settingPanel.Controls.Clear();

            formToLoad.TopLevel = false;
            formToLoad.Dock = DockStyle.Fill;

            settingPanel.Controls.Add(formToLoad);
        }

        private void gsBtn_Click(object sender, EventArgs e)
        {
            gsBtn.BackColor = Color.FromArgb(49, 49, 49);
            gsBtn.ForeColor = Color.Snow;
            asBtn.BackColor = Color.Snow;
            asBtn.ForeColor = Color.FromArgb(49, 49, 49);

            GeneralST generalForm = new GeneralST();
            loadform(generalForm);
        }

        private void asBtn_Click(object sender, EventArgs e)
        {
            asBtn.BackColor = Color.FromArgb(49, 49, 49);
            asBtn.ForeColor = Color.Snow;
            gsBtn.BackColor = Color.Snow;
            gsBtn.ForeColor = Color.FromArgb(49, 49, 49);

            AutoSetST AutoSet = new AutoSetST();
            loadform(AutoSet);
        }



        private void settingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
