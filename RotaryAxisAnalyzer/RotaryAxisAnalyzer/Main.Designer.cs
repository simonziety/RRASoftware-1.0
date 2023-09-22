namespace RotaryAxisAnalyzer
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.importDataDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitBtn = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DateLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.plotBtn = new FontAwesome.Sharp.IconButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.importDataBtn = new FontAwesome.Sharp.IconButton();
            this.dataStorageBtn = new FontAwesome.Sharp.IconButton();
            this.settingsBtn = new FontAwesome.Sharp.IconButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // importDataDialog
            // 
            this.importDataDialog.FileName = "importDataDialog";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mainPanel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 681);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(100, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 45);
            this.panel1.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitBtn.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.exitBtn.ForeColor = System.Drawing.Color.Snow;
            this.exitBtn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.exitBtn.IconColor = System.Drawing.Color.Snow;
            this.exitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitBtn.IconSize = 45;
            this.exitBtn.Location = new System.Drawing.Point(1114, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(50, 45);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.DateLabel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 45);
            this.panel2.TabIndex = 1;
            // 
            // DateLabel
            // 
            this.DateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateLabel.ForeColor = System.Drawing.Color.Snow;
            this.DateLabel.Location = new System.Drawing.Point(0, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(100, 45);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "Time";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 636);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Controls.Add(this.plotBtn, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.importDataBtn, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.dataStorageBtn, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.settingsBtn, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(100, 636);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // plotBtn
            // 
            this.plotBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.plotBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plotBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plotBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plotBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.plotBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plotBtn.IconColor = System.Drawing.Color.Black;
            this.plotBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.plotBtn.ImageList = this.imageList1;
            this.plotBtn.Location = new System.Drawing.Point(13, 23);
            this.plotBtn.Name = "plotBtn";
            this.plotBtn.Size = new System.Drawing.Size(74, 74);
            this.plotBtn.TabIndex = 0;
            this.plotBtn.UseVisualStyleBackColor = false;
            this.plotBtn.Click += new System.EventHandler(this.plotBtn_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.imageList1.Images.SetKeyName(0, "attocube_logo.png");
            this.imageList1.Images.SetKeyName(1, "capture.png");
            this.imageList1.Images.SetKeyName(2, "importData.png");
            this.imageList1.Images.SetKeyName(3, "dataStorage.png");
            this.imageList1.Images.SetKeyName(4, "settings.png");
            // 
            // importDataBtn
            // 
            this.importDataBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.importDataBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.importDataBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importDataBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importDataBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.importDataBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.importDataBtn.IconColor = System.Drawing.Color.Black;
            this.importDataBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.importDataBtn.ImageList = this.imageList1;
            this.importDataBtn.Location = new System.Drawing.Point(13, 103);
            this.importDataBtn.Name = "importDataBtn";
            this.importDataBtn.Size = new System.Drawing.Size(74, 74);
            this.importDataBtn.TabIndex = 1;
            this.importDataBtn.UseVisualStyleBackColor = false;
            this.importDataBtn.Click += new System.EventHandler(this.importDataBtn_Click);
            // 
            // dataStorageBtn
            // 
            this.dataStorageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dataStorageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dataStorageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataStorageBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataStorageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataStorageBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dataStorageBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.dataStorageBtn.IconColor = System.Drawing.Color.Black;
            this.dataStorageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dataStorageBtn.ImageList = this.imageList1;
            this.dataStorageBtn.Location = new System.Drawing.Point(13, 183);
            this.dataStorageBtn.Name = "dataStorageBtn";
            this.dataStorageBtn.Size = new System.Drawing.Size(74, 74);
            this.dataStorageBtn.TabIndex = 2;
            this.dataStorageBtn.UseVisualStyleBackColor = false;
            this.dataStorageBtn.Click += new System.EventHandler(this.dataStorageBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.settingsBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.settingsBtn.IconColor = System.Drawing.Color.Black;
            this.settingsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsBtn.ImageList = this.imageList1;
            this.settingsBtn.Location = new System.Drawing.Point(13, 263);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(74, 74);
            this.settingsBtn.TabIndex = 3;
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click_1);
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = global::RotaryAxisAnalyzer.Properties.Resources.attocube_logo;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(110, 55);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(10);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1144, 616);
            this.mainPanel.TabIndex = 3;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Main_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "a";
            this.Text = "Attocube";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog importDataDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel mainPanel;
        private FontAwesome.Sharp.IconPictureBox exitBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton plotBtn;
        private FontAwesome.Sharp.IconButton importDataBtn;
        private FontAwesome.Sharp.IconButton dataStorageBtn;
        private FontAwesome.Sharp.IconButton settingsBtn;
    }
}

