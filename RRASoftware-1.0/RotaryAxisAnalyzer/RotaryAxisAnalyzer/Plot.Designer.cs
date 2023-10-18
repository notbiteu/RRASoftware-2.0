namespace RotaryAxisAnalyzer
{
    partial class Plot
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.testInfo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.saveTestBtn = new System.Windows.Forms.Button();
            this.oscTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rrsTab = new System.Windows.Forms.TabPage();
            this.fftTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.testInfoBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.zChannelBtn = new FontAwesome.Sharp.IconButton();
            this.yChannelBtn = new FontAwesome.Sharp.IconButton();
            this.xChannelBtn = new FontAwesome.Sharp.IconButton();
            this.testInfoPage1 = new RotaryAxisAnalyzer.testInfoPage();
            this.panelDecoration1 = new RotaryAxisAnalyzer.PanelDecoration();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OscGraphPanel = new System.Windows.Forms.Panel();
            this.OsilloscopePanel = new System.Windows.Forms.Panel();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.mainTabControl.SuspendLayout();
            this.testInfo.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.oscTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panelDecoration1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.OscGraphPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.testInfo);
            this.mainTabControl.Controls.Add(this.oscTab);
            this.mainTabControl.Controls.Add(this.rrsTab);
            this.mainTabControl.Controls.Add(this.fftTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(3, 3);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1334, 564);
            this.mainTabControl.TabIndex = 0;
            // 
            // testInfo
            // 
            this.testInfo.Controls.Add(this.tableLayoutPanel6);
            this.testInfo.Location = new System.Drawing.Point(4, 22);
            this.testInfo.Name = "testInfo";
            this.testInfo.Size = new System.Drawing.Size(1326, 538);
            this.testInfo.TabIndex = 3;
            this.testInfo.Text = "Test Info";
            this.testInfo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1326, 538);
            this.tableLayoutPanel6.TabIndex = 0;
            this.tableLayoutPanel6.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel6_Paint);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel16, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1320, 532);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 1;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.saveTestBtn, 0, 1);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(160, 10);
            this.tableLayoutPanel16.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(1150, 512);
            this.tableLayoutPanel16.TabIndex = 1;
            // 
            // saveTestBtn
            // 
            this.saveTestBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveTestBtn.BackColor = System.Drawing.Color.Snow;
            this.saveTestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTestBtn.Location = new System.Drawing.Point(518, 451);
            this.saveTestBtn.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.saveTestBtn.Name = "saveTestBtn";
            this.saveTestBtn.Size = new System.Drawing.Size(128, 38);
            this.saveTestBtn.TabIndex = 1;
            this.saveTestBtn.Text = "Save Test";
            this.saveTestBtn.UseVisualStyleBackColor = false;
            // 
            // oscTab
            // 
            this.oscTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.oscTab.Controls.Add(this.tableLayoutPanel1);
            this.oscTab.Location = new System.Drawing.Point(4, 22);
            this.oscTab.Name = "oscTab";
            this.oscTab.Padding = new System.Windows.Forms.Padding(3);
            this.oscTab.Size = new System.Drawing.Size(1326, 538);
            this.oscTab.TabIndex = 0;
            this.oscTab.Text = "Osilloscope";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelDecoration1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1320, 532);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 512);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.zChannelBtn, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.yChannelBtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.xChannelBtn, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(130, 512);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // rrsTab
            // 
            this.rrsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.rrsTab.Location = new System.Drawing.Point(4, 22);
            this.rrsTab.Name = "rrsTab";
            this.rrsTab.Padding = new System.Windows.Forms.Padding(3);
            this.rrsTab.Size = new System.Drawing.Size(1326, 538);
            this.rrsTab.TabIndex = 1;
            this.rrsTab.Text = "Radial - Rotating Sensitive";
            // 
            // fftTab
            // 
            this.fftTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.fftTab.Location = new System.Drawing.Point(4, 22);
            this.fftTab.Name = "fftTab";
            this.fftTab.Size = new System.Drawing.Size(1326, 538);
            this.fftTab.TabIndex = 2;
            this.fftTab.Text = "FFT";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.mainTabControl, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1340, 570);
            this.tableLayoutPanel5.TabIndex = 1;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.tableLayoutPanel9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 426);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.testInfoPage1, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1164, 426);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.testInfoBtn, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(130, 512);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // testInfoBtn
            // 
            this.testInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.testInfoBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.testInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testInfoBtn.ForeColor = System.Drawing.Color.White;
            this.testInfoBtn.Image = global::RotaryAxisAnalyzer.Properties.Resources.infomation;
            this.testInfoBtn.Location = new System.Drawing.Point(3, 3);
            this.testInfoBtn.Name = "testInfoBtn";
            this.testInfoBtn.Size = new System.Drawing.Size(124, 124);
            this.testInfoBtn.TabIndex = 1;
            this.testInfoBtn.Text = "\r\nTest\r\nInformation";
            this.testInfoBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.testInfoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.testInfoBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::RotaryAxisAnalyzer.Properties.Resources.computerized;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(3, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 124);
            this.button1.TabIndex = 2;
            this.button1.Text = "\r\nMachine Information";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // zChannelBtn
            // 
            this.zChannelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.zChannelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zChannelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zChannelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zChannelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zChannelBtn.ForeColor = System.Drawing.Color.Snow;
            this.zChannelBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.zChannelBtn.IconColor = System.Drawing.Color.Black;
            this.zChannelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.zChannelBtn.Location = new System.Drawing.Point(3, 143);
            this.zChannelBtn.Name = "zChannelBtn";
            this.zChannelBtn.Size = new System.Drawing.Size(124, 64);
            this.zChannelBtn.TabIndex = 2;
            this.zChannelBtn.Text = "Channel 1\r\nZ : ON";
            this.zChannelBtn.UseVisualStyleBackColor = false;
            this.zChannelBtn.Click += new System.EventHandler(this.zChannelBtn_Click);
            // 
            // yChannelBtn
            // 
            this.yChannelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(12)))));
            this.yChannelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yChannelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yChannelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yChannelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yChannelBtn.ForeColor = System.Drawing.Color.Snow;
            this.yChannelBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.yChannelBtn.IconColor = System.Drawing.Color.Black;
            this.yChannelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.yChannelBtn.Location = new System.Drawing.Point(3, 73);
            this.yChannelBtn.Name = "yChannelBtn";
            this.yChannelBtn.Size = new System.Drawing.Size(124, 64);
            this.yChannelBtn.TabIndex = 1;
            this.yChannelBtn.Text = "Channel 1\r\nY : ON";
            this.yChannelBtn.UseVisualStyleBackColor = false;
            this.yChannelBtn.Click += new System.EventHandler(this.yChannelBtn_Click);
            // 
            // xChannelBtn
            // 
            this.xChannelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(190)))), ((int)(((byte)(36)))));
            this.xChannelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xChannelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xChannelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xChannelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xChannelBtn.ForeColor = System.Drawing.Color.Snow;
            this.xChannelBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.xChannelBtn.IconColor = System.Drawing.Color.Black;
            this.xChannelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.xChannelBtn.Location = new System.Drawing.Point(3, 3);
            this.xChannelBtn.Name = "xChannelBtn";
            this.xChannelBtn.Size = new System.Drawing.Size(124, 64);
            this.xChannelBtn.TabIndex = 0;
            this.xChannelBtn.Text = "Channel 1\r\nX : ON";
            this.xChannelBtn.UseVisualStyleBackColor = false;
            this.xChannelBtn.Click += new System.EventHandler(this.xChannelBtn_Click);
            // 
            // testInfoPage1
            // 
            this.testInfoPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testInfoPage1.Location = new System.Drawing.Point(3, 3);
            this.testInfoPage1.Name = "testInfoPage1";
            this.testInfoPage1.Size = new System.Drawing.Size(1158, 420);
            this.testInfoPage1.TabIndex = 0;
            // 
            // panelDecoration1
            // 
            this.panelDecoration1.BackColor = System.Drawing.Color.Snow;
            this.panelDecoration1.Controls.Add(this.tableLayoutPanel3);
            this.panelDecoration1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDecoration1.Location = new System.Drawing.Point(160, 10);
            this.panelDecoration1.Margin = new System.Windows.Forms.Padding(10);
            this.panelDecoration1.Name = "panelDecoration1";
            this.panelDecoration1.Size = new System.Drawing.Size(1150, 512);
            this.panelDecoration1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.OscGraphPanel, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1150, 512);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1140, 60);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Osilloscope";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RotaryAxisAnalyzer.Properties.Resources.Legend;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(1023, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 60);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // OscGraphPanel
            // 
            this.OscGraphPanel.Controls.Add(this.OsilloscopePanel);
            this.OscGraphPanel.Controls.Add(this.plotView1);
            this.OscGraphPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OscGraphPanel.Location = new System.Drawing.Point(15, 85);
            this.OscGraphPanel.Margin = new System.Windows.Forms.Padding(15);
            this.OscGraphPanel.Name = "OscGraphPanel";
            this.OscGraphPanel.Size = new System.Drawing.Size(1120, 412);
            this.OscGraphPanel.TabIndex = 1;
            // 
            // OsilloscopePanel
            // 
            this.OsilloscopePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OsilloscopePanel.Location = new System.Drawing.Point(0, 0);
            this.OsilloscopePanel.Name = "OsilloscopePanel";
            this.OsilloscopePanel.Size = new System.Drawing.Size(1120, 412);
            this.OsilloscopePanel.TabIndex = 1;
            // 
            // plotView1
            // 
            this.plotView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotView1.Location = new System.Drawing.Point(0, 0);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(1120, 412);
            this.plotView1.TabIndex = 0;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Plot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1340, 570);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "Plot";
            this.Text = "Plot";
            this.Load += new System.EventHandler(this.Plot_Form_Load);
            this.mainTabControl.ResumeLayout(false);
            this.testInfo.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.oscTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.panelDecoration1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.OscGraphPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage oscTab;
        private System.Windows.Forms.TabPage rrsTab;
        private System.Windows.Forms.TabPage fftTab;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton xChannelBtn;
        private FontAwesome.Sharp.IconButton zChannelBtn;
        private FontAwesome.Sharp.IconButton yChannelBtn;
        private PanelDecoration panelDecoration1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel OscGraphPanel;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel OsilloscopePanel;
        private System.Windows.Forms.TabPage testInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.Button saveTestBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private testInfoPage testInfoPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button testInfoBtn;
        private System.Windows.Forms.Button button1;
    }
}