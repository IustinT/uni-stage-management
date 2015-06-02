namespace Stage_Management_Aplication
{
    partial class StageManagementForm
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.stageInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.programStageLabel = new System.Windows.Forms.Label();
            this.overallStageMarkLabel = new System.Windows.Forms.Label();
            this.programTitleLabel = new System.Windows.Forms.Label();
            this.stagesLabel = new System.Windows.Forms.Label();
            this.modulesListLabel = new System.Windows.Forms.Label();
            this.modulesListBox = new System.Windows.Forms.ListBox();
            this.stagesListBox = new System.Windows.Forms.ListBox();
            this.moduleNameLabel = new System.Windows.Forms.Label();
            this.courseworkWeightLabel = new System.Windows.Forms.Label();
            this.examWeightLabel = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.componentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.componentType = new System.Windows.Forms.Label();
            this.componentMark = new System.Windows.Forms.Label();
            this.componentWeighting = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.examMarkLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.courseworkMarkLabel = new System.Windows.Forms.Label();
            this.moduleMarkLabel = new System.Windows.Forms.Label();
            this.moduleCreditsLabel = new System.Windows.Forms.Label();
            this.moduleTermLabel = new System.Windows.Forms.Label();
            this.courseworkElementsListBox = new System.Windows.Forms.ListBox();
            this.hrLabel2 = new System.Windows.Forms.Label();
            this.hrLabel3 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableBoxesLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.leftTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.editRecordsButton = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.stageInfoTableLayoutPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.componentInfoGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableBoxesLayoutPanel.SuspendLayout();
            this.leftTableLayoutPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(3, 3);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1176, 28);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanelTop.ColumnCount = 2;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.65712F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.34288F));
            this.tableLayoutPanelTop.Controls.Add(this.stageInfoTableLayoutPanel, 1, 0);
            this.tableLayoutPanelTop.Controls.Add(this.programTitleLabel, 0, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(1176, 79);
            this.tableLayoutPanelTop.TabIndex = 1;
            // 
            // stageInfoTableLayoutPanel
            // 
            this.stageInfoTableLayoutPanel.ColumnCount = 1;
            this.stageInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.stageInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.stageInfoTableLayoutPanel.Controls.Add(this.programStageLabel, 0, 0);
            this.stageInfoTableLayoutPanel.Controls.Add(this.overallStageMarkLabel, 0, 1);
            this.stageInfoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stageInfoTableLayoutPanel.Location = new System.Drawing.Point(715, 8);
            this.stageInfoTableLayoutPanel.Name = "stageInfoTableLayoutPanel";
            this.stageInfoTableLayoutPanel.RowCount = 2;
            this.stageInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.57534F));
            this.stageInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.42466F));
            this.stageInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.stageInfoTableLayoutPanel.Size = new System.Drawing.Size(453, 63);
            this.stageInfoTableLayoutPanel.TabIndex = 0;
            // 
            // programStageLabel
            // 
            this.programStageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programStageLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.programStageLabel.Location = new System.Drawing.Point(3, 0);
            this.programStageLabel.Name = "programStageLabel";
            this.programStageLabel.Size = new System.Drawing.Size(447, 29);
            this.programStageLabel.TabIndex = 1;
            this.programStageLabel.Text = "Stage 1";
            this.programStageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // overallStageMarkLabel
            // 
            this.overallStageMarkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overallStageMarkLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.overallStageMarkLabel.Location = new System.Drawing.Point(3, 29);
            this.overallStageMarkLabel.Name = "overallStageMarkLabel";
            this.overallStageMarkLabel.Size = new System.Drawing.Size(447, 34);
            this.overallStageMarkLabel.TabIndex = 0;
            this.overallStageMarkLabel.Text = "Overall Stage Mark: no info";
            this.overallStageMarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // programTitleLabel
            // 
            this.programTitleLabel.AutoSize = true;
            this.programTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programTitleLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programTitleLabel.Location = new System.Drawing.Point(8, 5);
            this.programTitleLabel.Name = "programTitleLabel";
            this.programTitleLabel.Size = new System.Drawing.Size(701, 69);
            this.programTitleLabel.TabIndex = 0;
            this.programTitleLabel.Text = "Program Name: no info available";
            this.programTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stagesLabel
            // 
            this.stagesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stagesLabel.Location = new System.Drawing.Point(3, 0);
            this.stagesLabel.Name = "stagesLabel";
            this.stagesLabel.Size = new System.Drawing.Size(145, 40);
            this.stagesLabel.TabIndex = 17;
            this.stagesLabel.Text = "Stages";
            this.stagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modulesListLabel
            // 
            this.modulesListLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modulesListLabel.Location = new System.Drawing.Point(154, 0);
            this.modulesListLabel.Name = "modulesListLabel";
            this.modulesListLabel.Size = new System.Drawing.Size(145, 40);
            this.modulesListLabel.TabIndex = 14;
            this.modulesListLabel.Text = "Modules";
            this.modulesListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modulesListBox
            // 
            this.modulesListBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.modulesListBox.FormattingEnabled = true;
            this.modulesListBox.HorizontalScrollbar = true;
            this.modulesListBox.ItemHeight = 22;
            this.modulesListBox.Location = new System.Drawing.Point(154, 43);
            this.modulesListBox.Name = "modulesListBox";
            this.modulesListBox.Size = new System.Drawing.Size(145, 356);
            this.modulesListBox.TabIndex = 4;
            this.modulesListBox.SelectedIndexChanged += new System.EventHandler(this.modulesListBox_SelectedIndexChanged);
            // 
            // stagesListBox
            // 
            this.stagesListBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.stagesListBox.FormattingEnabled = true;
            this.stagesListBox.HorizontalScrollbar = true;
            this.stagesListBox.ItemHeight = 22;
            this.stagesListBox.Location = new System.Drawing.Point(3, 43);
            this.stagesListBox.Name = "stagesListBox";
            this.stagesListBox.Size = new System.Drawing.Size(145, 356);
            this.stagesListBox.TabIndex = 16;
            this.stagesListBox.SelectedIndexChanged += new System.EventHandler(this.stagesListBox_SelectedIndexChanged);
            // 
            // moduleNameLabel
            // 
            this.moduleNameLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.moduleNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.moduleNameLabel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.moduleNameLabel.Location = new System.Drawing.Point(3, 112);
            this.moduleNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.moduleNameLabel.Name = "moduleNameLabel";
            this.moduleNameLabel.Padding = new System.Windows.Forms.Padding(5);
            this.moduleNameLabel.Size = new System.Drawing.Size(1176, 71);
            this.moduleNameLabel.TabIndex = 10;
            this.moduleNameLabel.Text = "Please select a module";
            this.moduleNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // courseworkWeightLabel
            // 
            this.courseworkWeightLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseworkWeightLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.courseworkWeightLabel.Location = new System.Drawing.Point(0, 0);
            this.courseworkWeightLabel.Name = "courseworkWeightLabel";
            this.courseworkWeightLabel.Size = new System.Drawing.Size(428, 44);
            this.courseworkWeightLabel.TabIndex = 1;
            this.courseworkWeightLabel.Text = "Coursework Weighting:  No info";
            this.courseworkWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // examWeightLabel
            // 
            this.examWeightLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.examWeightLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.examWeightLabel.Location = new System.Drawing.Point(0, 0);
            this.examWeightLabel.Name = "examWeightLabel";
            this.examWeightLabel.Size = new System.Drawing.Size(428, 43);
            this.examWeightLabel.TabIndex = 4;
            this.examWeightLabel.Text = "Exam weight: No info";
            this.examWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightPanel
            // 
            this.rightPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rightPanel.Controls.Add(this.componentInfoGroupBox);
            this.rightPanel.Controls.Add(this.label7);
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Controls.Add(this.moduleMarkLabel);
            this.rightPanel.Controls.Add(this.moduleCreditsLabel);
            this.rightPanel.Controls.Add(this.moduleTermLabel);
            this.rightPanel.Controls.Add(this.courseworkElementsListBox);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(311, 185);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(868, 568);
            this.rightPanel.TabIndex = 13;
            // 
            // componentInfoGroupBox
            // 
            this.componentInfoGroupBox.Controls.Add(this.componentType);
            this.componentInfoGroupBox.Controls.Add(this.componentMark);
            this.componentInfoGroupBox.Controls.Add(this.componentWeighting);
            this.componentInfoGroupBox.Location = new System.Drawing.Point(316, 268);
            this.componentInfoGroupBox.Name = "componentInfoGroupBox";
            this.componentInfoGroupBox.Size = new System.Drawing.Size(363, 142);
            this.componentInfoGroupBox.TabIndex = 26;
            this.componentInfoGroupBox.TabStop = false;
            this.componentInfoGroupBox.Text = "Coursework Component";
            // 
            // componentType
            // 
            this.componentType.AutoSize = true;
            this.componentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.componentType.Location = new System.Drawing.Point(6, 50);
            this.componentType.Name = "componentType";
            this.componentType.Size = new System.Drawing.Size(50, 20);
            this.componentType.TabIndex = 25;
            this.componentType.Text = "Type:";
            // 
            // componentMark
            // 
            this.componentMark.AutoSize = true;
            this.componentMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.componentMark.Location = new System.Drawing.Point(6, 95);
            this.componentMark.Name = "componentMark";
            this.componentMark.Size = new System.Drawing.Size(51, 20);
            this.componentMark.TabIndex = 24;
            this.componentMark.Text = "Mark:";
            // 
            // componentWeighting
            // 
            this.componentWeighting.AutoSize = true;
            this.componentWeighting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.componentWeighting.Location = new System.Drawing.Point(171, 95);
            this.componentWeighting.Name = "componentWeighting";
            this.componentWeighting.Size = new System.Drawing.Size(88, 20);
            this.componentWeighting.TabIndex = 23;
            this.componentWeighting.Text = "Weighting:";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(868, 2);
            this.label7.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(868, 101);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.examMarkLabel);
            this.panel2.Controls.Add(this.examWeightLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(437, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 95);
            this.panel2.TabIndex = 1;
            // 
            // examMarkLabel
            // 
            this.examMarkLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.examMarkLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.examMarkLabel.Location = new System.Drawing.Point(0, 51);
            this.examMarkLabel.Name = "examMarkLabel";
            this.examMarkLabel.Size = new System.Drawing.Size(428, 44);
            this.examMarkLabel.TabIndex = 5;
            this.examMarkLabel.Text = "Exam mark: No info";
            this.examMarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.courseworkMarkLabel);
            this.panel1.Controls.Add(this.courseworkWeightLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 95);
            this.panel1.TabIndex = 0;
            // 
            // courseworkMarkLabel
            // 
            this.courseworkMarkLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.courseworkMarkLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.courseworkMarkLabel.Location = new System.Drawing.Point(0, 51);
            this.courseworkMarkLabel.Name = "courseworkMarkLabel";
            this.courseworkMarkLabel.Size = new System.Drawing.Size(428, 44);
            this.courseworkMarkLabel.TabIndex = 2;
            this.courseworkMarkLabel.Text = "Coursework Mark:  No info";
            this.courseworkMarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moduleMarkLabel
            // 
            this.moduleMarkLabel.AutoSize = true;
            this.moduleMarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.moduleMarkLabel.Location = new System.Drawing.Point(659, 203);
            this.moduleMarkLabel.Name = "moduleMarkLabel";
            this.moduleMarkLabel.Size = new System.Drawing.Size(110, 20);
            this.moduleMarkLabel.TabIndex = 20;
            this.moduleMarkLabel.Text = "Module Mark:";
            // 
            // moduleCreditsLabel
            // 
            this.moduleCreditsLabel.AutoSize = true;
            this.moduleCreditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.moduleCreditsLabel.Location = new System.Drawing.Point(477, 203);
            this.moduleCreditsLabel.Name = "moduleCreditsLabel";
            this.moduleCreditsLabel.Size = new System.Drawing.Size(127, 20);
            this.moduleCreditsLabel.TabIndex = 18;
            this.moduleCreditsLabel.Text = "Module Credits:";
            // 
            // moduleTermLabel
            // 
            this.moduleTermLabel.AutoSize = true;
            this.moduleTermLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.moduleTermLabel.Location = new System.Drawing.Point(312, 203);
            this.moduleTermLabel.Name = "moduleTermLabel";
            this.moduleTermLabel.Size = new System.Drawing.Size(112, 20);
            this.moduleTermLabel.TabIndex = 17;
            this.moduleTermLabel.Text = "Module Term:";
            // 
            // courseworkElementsListBox
            // 
            this.courseworkElementsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.courseworkElementsListBox.FormattingEnabled = true;
            this.courseworkElementsListBox.HorizontalScrollbar = true;
            this.courseworkElementsListBox.ItemHeight = 25;
            this.courseworkElementsListBox.Location = new System.Drawing.Point(7, 189);
            this.courseworkElementsListBox.Name = "courseworkElementsListBox";
            this.courseworkElementsListBox.Size = new System.Drawing.Size(289, 304);
            this.courseworkElementsListBox.TabIndex = 15;
            this.courseworkElementsListBox.SelectedIndexChanged += new System.EventHandler(this.courseworkElementsListBox_SelectedIndexChanged);
            // 
            // hrLabel2
            // 
            this.hrLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hrLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.hrLabel2.Location = new System.Drawing.Point(3, 183);
            this.hrLabel2.Name = "hrLabel2";
            this.hrLabel2.Size = new System.Drawing.Size(1176, 2);
            this.hrLabel2.TabIndex = 14;
            // 
            // hrLabel3
            // 
            this.hrLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hrLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.hrLabel3.Location = new System.Drawing.Point(3, 110);
            this.hrLabel3.Name = "hrLabel3";
            this.hrLabel3.Size = new System.Drawing.Size(1176, 2);
            this.hrLabel3.TabIndex = 13;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Records";
            this.openFileDialog.Filter = "Xml Files (.xml) | *.xml";
            // 
            // tableBoxesLayoutPanel
            // 
            this.tableBoxesLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableBoxesLayoutPanel.ColumnCount = 2;
            this.tableBoxesLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBoxesLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBoxesLayoutPanel.Controls.Add(this.modulesListBox, 1, 1);
            this.tableBoxesLayoutPanel.Controls.Add(this.modulesListLabel, 1, 0);
            this.tableBoxesLayoutPanel.Controls.Add(this.stagesLabel, 0, 0);
            this.tableBoxesLayoutPanel.Controls.Add(this.stagesListBox, 0, 1);
            this.tableBoxesLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBoxesLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableBoxesLayoutPanel.Name = "tableBoxesLayoutPanel";
            this.tableBoxesLayoutPanel.RowCount = 2;
            this.tableBoxesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableBoxesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableBoxesLayoutPanel.Size = new System.Drawing.Size(302, 410);
            this.tableBoxesLayoutPanel.TabIndex = 18;
            // 
            // leftTableLayoutPanel
            // 
            this.leftTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.leftTableLayoutPanel.ColumnCount = 1;
            this.leftTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.leftTableLayoutPanel.Controls.Add(this.tableBoxesLayoutPanel, 0, 0);
            this.leftTableLayoutPanel.Controls.Add(this.buttonsPanel, 0, 1);
            this.leftTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftTableLayoutPanel.Location = new System.Drawing.Point(3, 185);
            this.leftTableLayoutPanel.Name = "leftTableLayoutPanel";
            this.leftTableLayoutPanel.RowCount = 2;
            this.leftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.32293F));
            this.leftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.67707F));
            this.leftTableLayoutPanel.Size = new System.Drawing.Size(308, 568);
            this.leftTableLayoutPanel.TabIndex = 14;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonsPanel.Controls.Add(this.editRecordsButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsPanel.Location = new System.Drawing.Point(3, 419);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(302, 146);
            this.buttonsPanel.TabIndex = 19;
            // 
            // editRecordsButton
            // 
            this.editRecordsButton.Location = new System.Drawing.Point(80, 37);
            this.editRecordsButton.Name = "editRecordsButton";
            this.editRecordsButton.Size = new System.Drawing.Size(124, 69);
            this.editRecordsButton.TabIndex = 0;
            this.editRecordsButton.Text = "Edit Records";
            this.editRecordsButton.UseVisualStyleBackColor = true;
            this.editRecordsButton.Click += new System.EventHandler(this.editRecordsButton_Click);
            // 
            // StageManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 756);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftTableLayoutPanel);
            this.Controls.Add(this.hrLabel2);
            this.Controls.Add(this.moduleNameLabel);
            this.Controls.Add(this.hrLabel3);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(1160, 700);
            this.Name = "StageManagementForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Stage Management Application";
            this.Shown += new System.EventHandler(this.StageManagementForm_Shown);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.stageInfoTableLayoutPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.componentInfoGroupBox.ResumeLayout(false);
            this.componentInfoGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableBoxesLayoutPanel.ResumeLayout(false);
            this.leftTableLayoutPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.TableLayoutPanel stageInfoTableLayoutPanel;
        private System.Windows.Forms.Label programStageLabel;
        private System.Windows.Forms.Label overallStageMarkLabel;
        private System.Windows.Forms.Label programTitleLabel;
        private System.Windows.Forms.ListBox modulesListBox;
        private System.Windows.Forms.Label moduleNameLabel;
        private System.Windows.Forms.Label courseworkWeightLabel;
        private System.Windows.Forms.Label modulesListLabel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label hrLabel3;
        private System.Windows.Forms.Label hrLabel2;
        private System.Windows.Forms.ListBox courseworkElementsListBox;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label examWeightLabel;
        private System.Windows.Forms.Label moduleTermLabel;
        private System.Windows.Forms.Label moduleMarkLabel;
        private System.Windows.Forms.Label moduleCreditsLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label examMarkLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label courseworkMarkLabel;
        private System.Windows.Forms.Label componentType;
        private System.Windows.Forms.Label componentMark;
        private System.Windows.Forms.Label componentWeighting;
        private System.Windows.Forms.GroupBox componentInfoGroupBox;
        private System.Windows.Forms.Label stagesLabel;
        private System.Windows.Forms.ListBox stagesListBox;
        private System.Windows.Forms.TableLayoutPanel tableBoxesLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel leftTableLayoutPanel;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button editRecordsButton;
    }
}

