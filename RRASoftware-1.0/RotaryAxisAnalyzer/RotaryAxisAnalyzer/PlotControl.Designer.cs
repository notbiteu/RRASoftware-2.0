﻿namespace RotaryAxisAnalyzer
{
    partial class PlotControl
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

        #region Component Designer generated code

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
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.testInfoBtn = new System.Windows.Forms.Button();
            this.machinfoBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.blank = new System.Windows.Forms.Panel();
            this.saveTestBtn = new System.Windows.Forms.Button();
            this.oscTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.zChannelBtn = new FontAwesome.Sharp.IconButton();
            this.yChannelBtn = new FontAwesome.Sharp.IconButton();
            this.xChannelBtn = new FontAwesome.Sharp.IconButton();
            this.panelDecoration1 = new RotaryAxisAnalyzer.PanelDecoration();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OscPanel = new System.Windows.Forms.Panel();
            this.rrsTab = new System.Windows.Forms.TabPage();
            this.radialPanel = new System.Windows.Forms.Panel();
            this.fftTab = new System.Windows.Forms.TabPage();
            this.fftPanel = new System.Windows.Forms.Panel();
            this.mainTabControl.SuspendLayout();
            this.testInfo.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.oscTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelDecoration1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.rrsTab.SuspendLayout();
            this.fftTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.testInfo);
            this.mainTabControl.Controls.Add(this.oscTab);
            this.mainTabControl.Controls.Add(this.rrsTab);
            this.mainTabControl.Controls.Add(this.fftTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1345, 610);
            this.mainTabControl.TabIndex = 1;
            // 
            // testInfo
            // 
            this.testInfo.Controls.Add(this.tableLayoutPanel6);
            this.testInfo.Location = new System.Drawing.Point(4, 22);
            this.testInfo.Name = "testInfo";
            this.testInfo.Size = new System.Drawing.Size(1337, 584);
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
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1337, 584);
            this.tableLayoutPanel6.TabIndex = 0;
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
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1331, 578);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.testInfoBtn, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.machinfoBtn, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(130, 558);
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
            this.testInfoBtn.Click += new System.EventHandler(this.testInfoBtn_Click);
            // 
            // machinfoBtn
            // 
            this.machinfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.machinfoBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.machinfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.machinfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machinfoBtn.ForeColor = System.Drawing.Color.White;
            this.machinfoBtn.Image = global::RotaryAxisAnalyzer.Properties.Resources.computerized;
            this.machinfoBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.machinfoBtn.Location = new System.Drawing.Point(3, 133);
            this.machinfoBtn.Name = "machinfoBtn";
            this.machinfoBtn.Size = new System.Drawing.Size(124, 124);
            this.machinfoBtn.TabIndex = 2;
            this.machinfoBtn.Text = "\r\nMachine Information";
            this.machinfoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.machinfoBtn.UseVisualStyleBackColor = false;
            this.machinfoBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 1;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Controls.Add(this.blank, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.saveTestBtn, 0, 1);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(160, 10);
            this.tableLayoutPanel16.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(1161, 558);
            this.tableLayoutPanel16.TabIndex = 1;
            // 
            // blank
            // 
            this.blank.BackColor = System.Drawing.Color.Snow;
            this.blank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blank.Location = new System.Drawing.Point(0, 0);
            this.blank.Margin = new System.Windows.Forms.Padding(0);
            this.blank.Name = "blank";
            this.blank.Size = new System.Drawing.Size(1161, 458);
            this.blank.TabIndex = 0;
            // 
            // saveTestBtn
            // 
            this.saveTestBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveTestBtn.BackColor = System.Drawing.Color.Snow;
            this.saveTestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTestBtn.Location = new System.Drawing.Point(516, 483);
            this.saveTestBtn.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.saveTestBtn.Name = "saveTestBtn";
            this.saveTestBtn.Size = new System.Drawing.Size(128, 38);
            this.saveTestBtn.TabIndex = 1;
            this.saveTestBtn.Text = "Save Test";
            this.saveTestBtn.UseVisualStyleBackColor = false;
            this.saveTestBtn.Click += new System.EventHandler(this.saveTestBtn_Click);
            // 
            // oscTab
            // 
            this.oscTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.oscTab.Controls.Add(this.tableLayoutPanel1);
            this.oscTab.Location = new System.Drawing.Point(4, 22);
            this.oscTab.Name = "oscTab";
            this.oscTab.Padding = new System.Windows.Forms.Padding(3);
            this.oscTab.Size = new System.Drawing.Size(1337, 584);
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
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1331, 578);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 538);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(130, 538);
            this.tableLayoutPanel2.TabIndex = 0;
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
            // 
            // panelDecoration1
            // 
            this.panelDecoration1.BackColor = System.Drawing.Color.Snow;
            this.panelDecoration1.Controls.Add(this.tableLayoutPanel3);
            this.panelDecoration1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDecoration1.Location = new System.Drawing.Point(160, 10);
            this.panelDecoration1.Margin = new System.Windows.Forms.Padding(10);
            this.panelDecoration1.Name = "panelDecoration1";
            this.panelDecoration1.Size = new System.Drawing.Size(1161, 538);
            this.panelDecoration1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.OscPanel, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1161, 538);
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
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1151, 60);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Osilloscope";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RotaryAxisAnalyzer.Properties.Resources.Legend;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(1026, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 60);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // OscPanel
            // 
            this.OscPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.OscPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OscPanel.Location = new System.Drawing.Point(10, 80);
            this.OscPanel.Margin = new System.Windows.Forms.Padding(10);
            this.OscPanel.Name = "OscPanel";
            this.OscPanel.Size = new System.Drawing.Size(1141, 448);
            this.OscPanel.TabIndex = 1;
            // 
            // rrsTab
            // 
            this.rrsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.rrsTab.Controls.Add(this.radialPanel);
            this.rrsTab.Location = new System.Drawing.Point(4, 22);
            this.rrsTab.Name = "rrsTab";
            this.rrsTab.Padding = new System.Windows.Forms.Padding(3);
            this.rrsTab.Size = new System.Drawing.Size(1337, 584);
            this.rrsTab.TabIndex = 1;
            this.rrsTab.Text = "Radial - Rotating Sensitive";
            // 
            // radialPanel
            // 
            this.radialPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radialPanel.Location = new System.Drawing.Point(3, 3);
            this.radialPanel.Name = "radialPanel";
            this.radialPanel.Size = new System.Drawing.Size(1331, 578);
            this.radialPanel.TabIndex = 0;
            this.radialPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.radialPanel_Paint);
            // 
            // fftTab
            // 
            this.fftTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.fftTab.Controls.Add(this.fftPanel);
            this.fftTab.Location = new System.Drawing.Point(4, 22);
            this.fftTab.Name = "fftTab";
            this.fftTab.Size = new System.Drawing.Size(1337, 584);
            this.fftTab.TabIndex = 2;
            this.fftTab.Text = "FFT";
            // 
            // fftPanel
            // 
            this.fftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fftPanel.Location = new System.Drawing.Point(0, 0);
            this.fftPanel.Name = "fftPanel";
            this.fftPanel.Size = new System.Drawing.Size(1337, 584);
            this.fftPanel.TabIndex = 0;
            this.fftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.fftPanel_Paint);
            // 
            // PlotControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Controls.Add(this.mainTabControl);
            this.Name = "PlotControl";
            this.Size = new System.Drawing.Size(1345, 610);
            this.Load += new System.EventHandler(this.Plot_Form_Load);
            this.mainTabControl.ResumeLayout(false);
            this.testInfo.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.oscTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelDecoration1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.rrsTab.ResumeLayout(false);
            this.fftTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage testInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button testInfoBtn;
        private System.Windows.Forms.Button machinfoBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.Panel blank;
        private System.Windows.Forms.Button saveTestBtn;
        private System.Windows.Forms.TabPage oscTab;
        private System.Windows.Forms.TabPage rrsTab;
        private System.Windows.Forms.TabPage fftTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton zChannelBtn;
        private FontAwesome.Sharp.IconButton yChannelBtn;
        private FontAwesome.Sharp.IconButton xChannelBtn;
        private PanelDecoration panelDecoration1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel OscPanel;
        private System.Windows.Forms.Panel radialPanel;
        private System.Windows.Forms.Panel fftPanel;
    }
}
