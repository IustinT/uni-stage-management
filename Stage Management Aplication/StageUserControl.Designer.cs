namespace Stage_Management_Aplication
{
    partial class StageUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components . Dispose();
            }
            base . Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.stageNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.programNameLabel = new System.Windows.Forms.Label();
            this.stageNumberLabel = new System.Windows.Forms.Label();
            this.programNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.placementYearCheckBox = new System.Windows.Forms.CheckBox();
            this.hrLabel = new System.Windows.Forms.Label();
            this.modulesGroupBox = new System.Windows.Forms.GroupBox();
            this.modulesTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.moduleUserControl = new Stage_Management_Aplication.ModuleUserControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stageNumberUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.modulesGroupBox.SuspendLayout();
            this.modulesTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 969F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.modulesGroupBox, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 458F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(969, 633);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.47248F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.52752F));
            this.tableLayoutPanel2.Controls.Add(this.stageNumberUpDown, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.programNameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.stageNumberLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.programNameTextBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.7027F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.2973F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(963, 89);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // stageNumberUpDown
            // 
            this.stageNumberUpDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.stageNumberUpDown.Location = new System.Drawing.Point(151, 49);
            this.stageNumberUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.stageNumberUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stageNumberUpDown.Name = "stageNumberUpDown";
            this.stageNumberUpDown.Size = new System.Drawing.Size(60, 22);
            this.stageNumberUpDown.TabIndex = 4;
            this.stageNumberUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stageNumberUpDown.ValueChanged += new System.EventHandler(this.stageNumberUpDown_ValueChanged);
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.programNameLabel.Location = new System.Drawing.Point(3, 0);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(142, 46);
            this.programNameLabel.TabIndex = 2;
            this.programNameLabel.Text = "Program Name:";
            this.programNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stageNumberLabel
            // 
            this.stageNumberLabel.AutoSize = true;
            this.stageNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stageNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.stageNumberLabel.Location = new System.Drawing.Point(3, 46);
            this.stageNumberLabel.Name = "stageNumberLabel";
            this.stageNumberLabel.Size = new System.Drawing.Size(142, 43);
            this.stageNumberLabel.TabIndex = 0;
            this.stageNumberLabel.Text = "Stage Number:";
            this.stageNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // programNameTextBox
            // 
            this.programNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programNameTextBox.Location = new System.Drawing.Point(151, 3);
            this.programNameTextBox.Name = "programNameTextBox";
            this.programNameTextBox.Size = new System.Drawing.Size(809, 22);
            this.programNameTextBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.placementYearCheckBox);
            this.panel1.Controls.Add(this.hrLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 47);
            this.panel1.TabIndex = 7;
            // 
            // placementYearCheckBox
            // 
            this.placementYearCheckBox.AutoSize = true;
            this.placementYearCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.placementYearCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.placementYearCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.placementYearCheckBox.Location = new System.Drawing.Point(0, 1);
            this.placementYearCheckBox.Name = "placementYearCheckBox";
            this.placementYearCheckBox.Size = new System.Drawing.Size(408, 46);
            this.placementYearCheckBox.TabIndex = 6;
            this.placementYearCheckBox.Text = "This stage is a placement year - it has no modules";
            this.placementYearCheckBox.UseVisualStyleBackColor = true;
            this.placementYearCheckBox.CheckedChanged += new System.EventHandler(this.placementYearCheckBox_CheckedChanged);
            // 
            // hrLabel
            // 
            this.hrLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hrLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.hrLabel.Location = new System.Drawing.Point(0, 0);
            this.hrLabel.Name = "hrLabel";
            this.hrLabel.Size = new System.Drawing.Size(963, 1);
            this.hrLabel.TabIndex = 0;
            // 
            // modulesGroupBox
            // 
            this.modulesGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.modulesGroupBox.Controls.Add(this.modulesTabControl);
            this.modulesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modulesGroupBox.Location = new System.Drawing.Point(3, 169);
            this.modulesGroupBox.Name = "modulesGroupBox";
            this.modulesGroupBox.Size = new System.Drawing.Size(963, 452);
            this.modulesGroupBox.TabIndex = 9;
            this.modulesGroupBox.TabStop = false;
            this.modulesGroupBox.Text = "Modules";
            // 
            // modulesTabControl
            // 
            this.modulesTabControl.Controls.Add(this.tabPage1);
            this.modulesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modulesTabControl.Location = new System.Drawing.Point(3, 18);
            this.modulesTabControl.Name = "modulesTabControl";
            this.modulesTabControl.SelectedIndex = 0;
            this.modulesTabControl.Size = new System.Drawing.Size(957, 431);
            this.modulesTabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.moduleUserControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(949, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Module";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // moduleUserControl
            // 
            this.moduleUserControl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.moduleUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleUserControl.Location = new System.Drawing.Point(3, 3);
            this.moduleUserControl.Name = "moduleUserControl";
            this.moduleUserControl.Size = new System.Drawing.Size(943, 396);
            this.moduleUserControl.TabIndex = 0;
            // 
            // StageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StageUserControl";
            this.Size = new System.Drawing.Size(969, 633);
            this.Load += new System.EventHandler(this.StagePageUserControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stageNumberUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.modulesGroupBox.ResumeLayout(false);
            this.modulesTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown stageNumberUpDown;
        private System.Windows.Forms.Label programNameLabel;
        private System.Windows.Forms.Label stageNumberLabel;
        private System.Windows.Forms.TextBox programNameTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label hrLabel;
        private System.Windows.Forms.CheckBox placementYearCheckBox;
        private System.Windows.Forms.GroupBox modulesGroupBox;
        private System.Windows.Forms.TabControl modulesTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private ModuleUserControl moduleUserControl;
    }
}
