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
    public partial class DataStorage : Form
    {
        public DataStorage()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            //button image insert
            importDBbtn.ImageIndex = 1;
            deleteBtn.ImageIndex = 2;
            refreshBtn.ImageIndex = 3;
            exportBtn.ImageIndex = 0;
        }

        private void deleteBtn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
