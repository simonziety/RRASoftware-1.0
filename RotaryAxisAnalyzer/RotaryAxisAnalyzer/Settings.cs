using System;
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
            asBtn.FlatStyle = FlatStyle.Flat;
            asBtn.FlatAppearance.BorderSize = 0;
            gsBtn.FlatStyle = FlatStyle.Flat;
            gsBtn.FlatAppearance.BorderSize = 0;

            GeneralSettingPanel = new PanelDecoration();
            GeneralSettingPanel.BackColor = Color.LightBlue; // Set your desired background color
            GeneralSettingPanel.Padding = new Padding(10); // Set padding if needed
            GeneralSettingPanel.Dock = DockStyle.Fill; // Optional: Dock the panel to fill the parent container
            Controls.Add(GeneralSettingPanel); // Add the panel to the form

        }

        private void gsBtn_Click(object sender, EventArgs e)
        {
            gsBtn.BackColor = Color.FromArgb(49, 49, 49);
            gsBtn.ForeColor = Color.Snow;
            asBtn.BackColor = Color.Snow;
            asBtn.ForeColor = Color.FromArgb(49, 49, 49);
        }

        private void asBtn_Click(object sender, EventArgs e)
        {
            asBtn.BackColor = Color.FromArgb(49, 49, 49);
            asBtn.ForeColor = Color.Snow;
            gsBtn.BackColor = Color.Snow;
            gsBtn.ForeColor = Color.FromArgb(49, 49, 49);
        }
    }
}
