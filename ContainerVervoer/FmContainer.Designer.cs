namespace ContainerTransport
{
    partial class FmContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmContainer));
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpSettings = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rtbProgramLog = new System.Windows.Forms.RichTextBox();
            this.lblShipBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalContainerWeight = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalContainers = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblShipMinWeight = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblShipMaxWeight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbContainerList = new System.Windows.Forms.ListBox();
            this.gpContainerAdd = new System.Windows.Forms.GroupBox();
            this.nbContainerWeight = new System.Windows.Forms.NumericUpDown();
            this.rbCooled = new System.Windows.Forms.RadioButton();
            this.rbValuable = new System.Windows.Forms.RadioButton();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.btnRemoveContainer = new System.Windows.Forms.Button();
            this.btnAddContainer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nbShipWeight = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSetShip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpShip = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbContainerSection7 = new System.Windows.Forms.ListBox();
            this.lbContainerSection8 = new System.Windows.Forms.ListBox();
            this.lbContainerSection5 = new System.Windows.Forms.ListBox();
            this.lbContainerSection6 = new System.Windows.Forms.ListBox();
            this.lbContainerSection3 = new System.Windows.Forms.ListBox();
            this.lbContainerSection4 = new System.Windows.Forms.ListBox();
            this.lbContainerSection2 = new System.Windows.Forms.ListBox();
            this.lbContainerSection1 = new System.Windows.Forms.ListBox();
            this.tbcMain.SuspendLayout();
            this.tbpSettings.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gpContainerAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbContainerWeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbShipWeight)).BeginInit();
            this.tbpShip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbpSettings);
            this.tbcMain.Controls.Add(this.tbpShip);
            this.tbcMain.Location = new System.Drawing.Point(16, 15);
            this.tbcMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(1163, 380);
            this.tbcMain.TabIndex = 7;
            // 
            // tbpSettings
            // 
            this.tbpSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbpSettings.Controls.Add(this.groupBox5);
            this.tbpSettings.Controls.Add(this.groupBox4);
            this.tbpSettings.Controls.Add(this.gpContainerAdd);
            this.tbpSettings.Controls.Add(this.groupBox1);
            this.tbpSettings.Location = new System.Drawing.Point(4, 25);
            this.tbpSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpSettings.Name = "tbpSettings";
            this.tbpSettings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpSettings.Size = new System.Drawing.Size(1155, 351);
            this.tbpSettings.TabIndex = 0;
            this.tbpSettings.Text = "Ship Settings";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rtbProgramLog);
            this.groupBox5.Controls.Add(this.lblShipBalance);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.lblTotalContainerWeight);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.lblTotalContainers);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.lblShipMinWeight);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.lblShipMaxWeight);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(364, 32);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(401, 252);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Status Log";
            // 
            // rtbProgramLog
            // 
            this.rtbProgramLog.ForeColor = System.Drawing.Color.Black;
            this.rtbProgramLog.Location = new System.Drawing.Point(8, 107);
            this.rtbProgramLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbProgramLog.Name = "rtbProgramLog";
            this.rtbProgramLog.ReadOnly = true;
            this.rtbProgramLog.Size = new System.Drawing.Size(335, 128);
            this.rtbProgramLog.TabIndex = 2;
            this.rtbProgramLog.Text = "";
            // 
            // lblShipBalance
            // 
            this.lblShipBalance.AutoSize = true;
            this.lblShipBalance.Location = new System.Drawing.Point(103, 82);
            this.lblShipBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShipBalance.Name = "lblShipBalance";
            this.lblShipBalance.Size = new System.Drawing.Size(20, 17);
            this.lblShipBalance.TabIndex = 1;
            this.lblShipBalance.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total container weight:";
            // 
            // lblTotalContainerWeight
            // 
            this.lblTotalContainerWeight.AutoSize = true;
            this.lblTotalContainerWeight.Location = new System.Drawing.Point(323, 57);
            this.lblTotalContainerWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalContainerWeight.Name = "lblTotalContainerWeight";
            this.lblTotalContainerWeight.Size = new System.Drawing.Size(20, 17);
            this.lblTotalContainerWeight.TabIndex = 1;
            this.lblTotalContainerWeight.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 82);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Ship Balance:";
            // 
            // lblTotalContainers
            // 
            this.lblTotalContainers.AutoSize = true;
            this.lblTotalContainers.Location = new System.Drawing.Point(323, 28);
            this.lblTotalContainers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalContainers.Name = "lblTotalContainers";
            this.lblTotalContainers.Size = new System.Drawing.Size(20, 17);
            this.lblTotalContainers.TabIndex = 1;
            this.lblTotalContainers.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total containers:";
            // 
            // lblShipMinWeight
            // 
            this.lblShipMinWeight.AutoSize = true;
            this.lblShipMinWeight.Location = new System.Drawing.Point(120, 57);
            this.lblShipMinWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShipMinWeight.Name = "lblShipMinWeight";
            this.lblShipMinWeight.Size = new System.Drawing.Size(20, 17);
            this.lblShipMinWeight.TabIndex = 1;
            this.lblShipMinWeight.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ship min weight:";
            // 
            // lblShipMaxWeight
            // 
            this.lblShipMaxWeight.AutoSize = true;
            this.lblShipMaxWeight.Location = new System.Drawing.Point(120, 28);
            this.lblShipMaxWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShipMaxWeight.Name = "lblShipMaxWeight";
            this.lblShipMaxWeight.Size = new System.Drawing.Size(20, 17);
            this.lblShipMaxWeight.TabIndex = 1;
            this.lblShipMaxWeight.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ship max weight:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbContainerList);
            this.groupBox4.Location = new System.Drawing.Point(765, 32);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(379, 254);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Current Containers";
            // 
            // lbContainerList
            // 
            this.lbContainerList.FormattingEnabled = true;
            this.lbContainerList.HorizontalScrollbar = true;
            this.lbContainerList.ItemHeight = 16;
            this.lbContainerList.Location = new System.Drawing.Point(8, 23);
            this.lbContainerList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbContainerList.Name = "lbContainerList";
            this.lbContainerList.Size = new System.Drawing.Size(361, 212);
            this.lbContainerList.TabIndex = 0;
            // 
            // gpContainerAdd
            // 
            this.gpContainerAdd.Controls.Add(this.nbContainerWeight);
            this.gpContainerAdd.Controls.Add(this.rbCooled);
            this.gpContainerAdd.Controls.Add(this.rbValuable);
            this.gpContainerAdd.Controls.Add(this.rbStandard);
            this.gpContainerAdd.Controls.Add(this.btnRemoveContainer);
            this.gpContainerAdd.Controls.Add(this.btnAddContainer);
            this.gpContainerAdd.Controls.Add(this.label2);
            this.gpContainerAdd.Location = new System.Drawing.Point(69, 138);
            this.gpContainerAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpContainerAdd.Name = "gpContainerAdd";
            this.gpContainerAdd.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpContainerAdd.Size = new System.Drawing.Size(287, 145);
            this.gpContainerAdd.TabIndex = 8;
            this.gpContainerAdd.TabStop = false;
            this.gpContainerAdd.Text = "Create Container";
            // 
            // nbContainerWeight
            // 
            this.nbContainerWeight.Location = new System.Drawing.Point(112, 23);
            this.nbContainerWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nbContainerWeight.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nbContainerWeight.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nbContainerWeight.Name = "nbContainerWeight";
            this.nbContainerWeight.Size = new System.Drawing.Size(160, 22);
            this.nbContainerWeight.TabIndex = 7;
            this.nbContainerWeight.Value = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            // 
            // rbCooled
            // 
            this.rbCooled.AutoSize = true;
            this.rbCooled.Location = new System.Drawing.Point(204, 58);
            this.rbCooled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbCooled.Name = "rbCooled";
            this.rbCooled.Size = new System.Drawing.Size(73, 21);
            this.rbCooled.TabIndex = 6;
            this.rbCooled.Text = "Cooled";
            this.rbCooled.UseVisualStyleBackColor = true;
            // 
            // rbValuable
            // 
            this.rbValuable.AutoSize = true;
            this.rbValuable.Location = new System.Drawing.Point(107, 58);
            this.rbValuable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbValuable.Name = "rbValuable";
            this.rbValuable.Size = new System.Drawing.Size(84, 21);
            this.rbValuable.TabIndex = 6;
            this.rbValuable.Text = "Valuable";
            this.rbValuable.UseVisualStyleBackColor = true;
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Checked = true;
            this.rbStandard.Location = new System.Drawing.Point(8, 58);
            this.rbStandard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(87, 21);
            this.rbStandard.TabIndex = 6;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "Standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            // 
            // btnRemoveContainer
            // 
            this.btnRemoveContainer.Location = new System.Drawing.Point(12, 82);
            this.btnRemoveContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveContainer.Name = "btnRemoveContainer";
            this.btnRemoveContainer.Size = new System.Drawing.Size(100, 28);
            this.btnRemoveContainer.TabIndex = 4;
            this.btnRemoveContainer.Text = "Remove";
            this.btnRemoveContainer.UseVisualStyleBackColor = true;
            this.btnRemoveContainer.Click += new System.EventHandler(this.btnRemoveContainer_Click);
            // 
            // btnAddContainer
            // 
            this.btnAddContainer.Location = new System.Drawing.Point(172, 82);
            this.btnAddContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddContainer.Name = "btnAddContainer";
            this.btnAddContainer.Size = new System.Drawing.Size(100, 28);
            this.btnAddContainer.TabIndex = 4;
            this.btnAddContainer.Text = "Add";
            this.btnAddContainer.UseVisualStyleBackColor = true;
            this.btnAddContainer.Click += new System.EventHandler(this.btnAddContainer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight in Kg:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nbShipWeight);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnClearAll);
            this.groupBox1.Controls.Add(this.btnSetShip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(65, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(287, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Ship";
            // 
            // nbShipWeight
            // 
            this.nbShipWeight.Location = new System.Drawing.Point(96, 25);
            this.nbShipWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nbShipWeight.Maximum = new decimal(new int[] {
            1200000,
            0,
            0,
            0});
            this.nbShipWeight.Name = "nbShipWeight";
            this.nbShipWeight.Size = new System.Drawing.Size(160, 22);
            this.nbShipWeight.TabIndex = 7;
            this.nbShipWeight.Value = new decimal(new int[] {
            1200000,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(95, 59);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(76, 28);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(4, 58);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(83, 28);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "Restart";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnSetShip
            // 
            this.btnSetShip.Location = new System.Drawing.Point(179, 62);
            this.btnSetShip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetShip.Name = "btnSetShip";
            this.btnSetShip.Size = new System.Drawing.Size(97, 26);
            this.btnSetShip.TabIndex = 3;
            this.btnSetShip.Text = "Set Weight";
            this.btnSetShip.UseVisualStyleBackColor = true;
            this.btnSetShip.Click += new System.EventHandler(this.btnSetShip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weight in Kg:";
            // 
            // tbpShip
            // 
            this.tbpShip.Controls.Add(this.groupBox2);
            this.tbpShip.Location = new System.Drawing.Point(4, 25);
            this.tbpShip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpShip.Name = "tbpShip";
            this.tbpShip.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpShip.Size = new System.Drawing.Size(1155, 351);
            this.tbpShip.TabIndex = 1;
            this.tbpShip.Text = "Ship";
            this.tbpShip.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbContainerSection7);
            this.groupBox2.Controls.Add(this.lbContainerSection8);
            this.groupBox2.Controls.Add(this.lbContainerSection5);
            this.groupBox2.Controls.Add(this.lbContainerSection6);
            this.groupBox2.Controls.Add(this.lbContainerSection3);
            this.groupBox2.Controls.Add(this.lbContainerSection4);
            this.groupBox2.Controls.Add(this.lbContainerSection2);
            this.groupBox2.Controls.Add(this.lbContainerSection1);
            this.groupBox2.Location = new System.Drawing.Point(8, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1128, 354);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ship";
            // 
            // lbContainerSection7
            // 
            this.lbContainerSection7.FormattingEnabled = true;
            this.lbContainerSection7.HorizontalScrollbar = true;
            this.lbContainerSection7.ItemHeight = 16;
            this.lbContainerSection7.Location = new System.Drawing.Point(841, 23);
            this.lbContainerSection7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbContainerSection7.Name = "lbContainerSection7";
            this.lbContainerSection7.Size = new System.Drawing.Size(267, 148);
            this.lbContainerSection7.TabIndex = 0;
            // 
            // lbContainerSection8
            // 
            this.lbContainerSection8.FormattingEnabled = true;
            this.lbContainerSection8.HorizontalScrollbar = true;
            this.lbContainerSection8.ItemHeight = 16;
            this.lbContainerSection8.Location = new System.Drawing.Point(841, 180);
            this.lbContainerSection8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbContainerSection8.Name = "lbContainerSection8";
            this.lbContainerSection8.Size = new System.Drawing.Size(267, 148);
            this.lbContainerSection8.TabIndex = 0;
            // 
            // lbContainerSection5
            // 
            this.lbContainerSection5.FormattingEnabled = true;
            this.lbContainerSection5.HorizontalScrollbar = true;
            this.lbContainerSection5.ItemHeight = 16;
            this.lbContainerSection5.Location = new System.Drawing.Point(565, 23);
            this.lbContainerSection5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbContainerSection5.Name = "lbContainerSection5";
            this.lbContainerSection5.Size = new System.Drawing.Size(267, 148);
            this.lbContainerSection5.TabIndex = 0;
            // 
            // lbContainerSection6
            // 
            this.lbContainerSection6.FormattingEnabled = true;
            this.lbContainerSection6.HorizontalScrollbar = true;
            this.lbContainerSection6.ItemHeight = 16;
            this.lbContainerSection6.Location = new System.Drawing.Point(565, 180);
            this.lbContainerSection6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbContainerSection6.Name = "lbContainerSection6";
            this.lbContainerSection6.Size = new System.Drawing.Size(267, 148);
            this.lbContainerSection6.TabIndex = 0;
            // 
            // lbContainerSection3
            // 
            this.lbContainerSection3.FormattingEnabled = true;
            this.lbContainerSection3.HorizontalScrollbar = true;
            this.lbContainerSection3.ItemHeight = 16;
            this.lbContainerSection3.Location = new System.Drawing.Point(289, 23);
            this.lbContainerSection3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbContainerSection3.Name = "lbContainerSection3";
            this.lbContainerSection3.Size = new System.Drawing.Size(267, 148);
            this.lbContainerSection3.TabIndex = 0;
            // 
            // lbContainerSection4
            // 
            this.lbContainerSection4.FormattingEnabled = true;
            this.lbContainerSection4.HorizontalScrollbar = true;
            this.lbContainerSection4.ItemHeight = 16;
            this.lbContainerSection4.Location = new System.Drawing.Point(289, 180);
            this.lbContainerSection4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbContainerSection4.Name = "lbContainerSection4";
            this.lbContainerSection4.Size = new System.Drawing.Size(267, 148);
            this.lbContainerSection4.TabIndex = 0;
            // 
            // lbContainerSection2
            // 
            this.lbContainerSection2.BackColor = System.Drawing.SystemColors.Window;
            this.lbContainerSection2.FormattingEnabled = true;
            this.lbContainerSection2.HorizontalScrollbar = true;
            this.lbContainerSection2.ItemHeight = 16;
            this.lbContainerSection2.Location = new System.Drawing.Point(13, 180);
            this.lbContainerSection2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbContainerSection2.Name = "lbContainerSection2";
            this.lbContainerSection2.Size = new System.Drawing.Size(267, 148);
            this.lbContainerSection2.TabIndex = 0;
            // 
            // lbContainerSection1
            // 
            this.lbContainerSection1.BackColor = System.Drawing.SystemColors.Window;
            this.lbContainerSection1.FormattingEnabled = true;
            this.lbContainerSection1.HorizontalScrollbar = true;
            this.lbContainerSection1.ItemHeight = 16;
            this.lbContainerSection1.Location = new System.Drawing.Point(13, 23);
            this.lbContainerSection1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbContainerSection1.Name = "lbContainerSection1";
            this.lbContainerSection1.Size = new System.Drawing.Size(267, 148);
            this.lbContainerSection1.TabIndex = 0;
            // 
            // FmContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1195, 409);
            this.Controls.Add(this.tbcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FmContainer";
            this.Text = "Container Transportation";
            this.tbcMain.ResumeLayout(false);
            this.tbpSettings.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.gpContainerAdd.ResumeLayout(false);
            this.gpContainerAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbContainerWeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbShipWeight)).EndInit();
            this.tbpShip.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpSettings;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox rtbProgramLog;
        private System.Windows.Forms.Label lblShipBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalContainerWeight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalContainers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblShipMinWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblShipMaxWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbContainerList;
        private System.Windows.Forms.GroupBox gpContainerAdd;
        private System.Windows.Forms.NumericUpDown nbContainerWeight;
        private System.Windows.Forms.RadioButton rbCooled;
        private System.Windows.Forms.RadioButton rbValuable;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.Button btnRemoveContainer;
        private System.Windows.Forms.Button btnAddContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nbShipWeight;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnSetShip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbpShip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbContainerSection7;
        private System.Windows.Forms.ListBox lbContainerSection8;
        private System.Windows.Forms.ListBox lbContainerSection5;
        private System.Windows.Forms.ListBox lbContainerSection6;
        private System.Windows.Forms.ListBox lbContainerSection3;
        private System.Windows.Forms.ListBox lbContainerSection4;
        private System.Windows.Forms.ListBox lbContainerSection2;
        private System.Windows.Forms.ListBox lbContainerSection1;
    }
}

