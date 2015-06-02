namespace Stage_Management_Aplication
{
    partial class ModuleUserControl
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
            this.removeCwComponent = new System.Windows.Forms.Button();
            this.cwComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.cwComponentsTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addCwComponentBtn = new System.Windows.Forms.Button();
            this.examMarkUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.moduleTermComboBox = new System.Windows.Forms.ComboBox();
            this.moduleTermLabel = new System.Windows.Forms.Label();
            this.moduleCreditsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.moduleCodeTextBox = new System.Windows.Forms.TextBox();
            this.moduleCodeLabel = new System.Windows.Forms.Label();
            this.examWeightUpDown = new System.Windows.Forms.NumericUpDown();
            this.courseworkWeightUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moduleNameLabel = new System.Windows.Forms.Label();
            this.moduleNameTextBox = new System.Windows.Forms.TextBox();
            this.cwComponentsUserControl = new Stage_Management_Aplication.CwComponentsUserControl();
            this.cwComponentsGroupBox.SuspendLayout();
            this.cwComponentsTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examMarkUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examWeightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseworkWeightUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // removeCwComponent
            // 
            this.removeCwComponent.Location = new System.Drawing.Point(806, 119);
            this.removeCwComponent.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.removeCwComponent.Name = "removeCwComponent";
            this.removeCwComponent.Size = new System.Drawing.Size(110, 70);
            this.removeCwComponent.TabIndex = 36;
            this.removeCwComponent.Text = "Remove this Component";
            this.removeCwComponent.UseVisualStyleBackColor = true;
            this.removeCwComponent.Click += new System.EventHandler(this.removeCwComponent_Click);
            // 
            // cwComponentsGroupBox
            // 
            this.cwComponentsGroupBox.AutoSize = true;
            this.cwComponentsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cwComponentsGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.cwComponentsGroupBox.Controls.Add(this.removeCwComponent);
            this.cwComponentsGroupBox.Controls.Add(this.cwComponentsTabControl);
            this.cwComponentsGroupBox.Controls.Add(this.addCwComponentBtn);
            this.cwComponentsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cwComponentsGroupBox.Location = new System.Drawing.Point(17, 168);
            this.cwComponentsGroupBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.cwComponentsGroupBox.Name = "cwComponentsGroupBox";
            this.cwComponentsGroupBox.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.cwComponentsGroupBox.Size = new System.Drawing.Size(922, 209);
            this.cwComponentsGroupBox.TabIndex = 51;
            this.cwComponentsGroupBox.TabStop = false;
            this.cwComponentsGroupBox.Text = "Coursework Components";
            // 
            // cwComponentsTabControl
            // 
            this.cwComponentsTabControl.Controls.Add(this.tabPage1);
            this.cwComponentsTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cwComponentsTabControl.Location = new System.Drawing.Point(6, 26);
            this.cwComponentsTabControl.Name = "cwComponentsTabControl";
            this.cwComponentsTabControl.SelectedIndex = 0;
            this.cwComponentsTabControl.Size = new System.Drawing.Size(794, 163);
            this.cwComponentsTabControl.TabIndex = 21;
            this.cwComponentsTabControl.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cwComponentsUserControl);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 132);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Component";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addCwComponentBtn
            // 
            this.addCwComponentBtn.Location = new System.Drawing.Point(806, 26);
            this.addCwComponentBtn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.addCwComponentBtn.Name = "addCwComponentBtn";
            this.addCwComponentBtn.Size = new System.Drawing.Size(110, 70);
            this.addCwComponentBtn.TabIndex = 34;
            this.addCwComponentBtn.Text = "Add a New Component";
            this.addCwComponentBtn.UseVisualStyleBackColor = true;
            this.addCwComponentBtn.Click += new System.EventHandler(this.addCwComponentBtn_Click);
            // 
            // examMarkUpDown
            // 
            this.examMarkUpDown.DecimalPlaces = 2;
            this.examMarkUpDown.Enabled = false;
            this.examMarkUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.examMarkUpDown.Location = new System.Drawing.Point(515, 117);
            this.examMarkUpDown.Name = "examMarkUpDown";
            this.examMarkUpDown.Size = new System.Drawing.Size(85, 24);
            this.examMarkUpDown.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(514, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 18);
            this.label8.TabIndex = 49;
            this.label8.Text = "Exam Mark";
            // 
            // moduleTermComboBox
            // 
            this.moduleTermComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.moduleTermComboBox.FormattingEnabled = true;
            this.moduleTermComboBox.Items.AddRange(new object[] {
            "AY",
            "T1",
            "T2"});
            this.moduleTermComboBox.Location = new System.Drawing.Point(697, 43);
            this.moduleTermComboBox.MaxDropDownItems = 3;
            this.moduleTermComboBox.Name = "moduleTermComboBox";
            this.moduleTermComboBox.Size = new System.Drawing.Size(85, 26);
            this.moduleTermComboBox.Sorted = true;
            this.moduleTermComboBox.TabIndex = 48;
            this.moduleTermComboBox.Text = "AY";
            // 
            // moduleTermLabel
            // 
            this.moduleTermLabel.AutoSize = true;
            this.moduleTermLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.moduleTermLabel.Location = new System.Drawing.Point(568, 47);
            this.moduleTermLabel.Name = "moduleTermLabel";
            this.moduleTermLabel.Size = new System.Drawing.Size(100, 18);
            this.moduleTermLabel.TabIndex = 47;
            this.moduleTermLabel.Text = "Module Term:";
            // 
            // moduleCreditsComboBox
            // 
            this.moduleCreditsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.moduleCreditsComboBox.FormatString = "N0";
            this.moduleCreditsComboBox.FormattingEnabled = true;
            this.moduleCreditsComboBox.Items.AddRange(new object[] {
            "0",
            "10",
            "20"});
            this.moduleCreditsComboBox.Location = new System.Drawing.Point(461, 42);
            this.moduleCreditsComboBox.MaxDropDownItems = 3;
            this.moduleCreditsComboBox.Name = "moduleCreditsComboBox";
            this.moduleCreditsComboBox.Size = new System.Drawing.Size(81, 26);
            this.moduleCreditsComboBox.Sorted = true;
            this.moduleCreditsComboBox.TabIndex = 46;
            this.moduleCreditsComboBox.Text = "0";
            this.moduleCreditsComboBox.SelectedIndexChanged += new System.EventHandler(this.moduleCreditsComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(325, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "Module Credits:";
            // 
            // moduleCodeTextBox
            // 
            this.moduleCodeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.moduleCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.moduleCodeTextBox.Location = new System.Drawing.Point(137, 43);
            this.moduleCodeTextBox.MaxLength = 15;
            this.moduleCodeTextBox.Name = "moduleCodeTextBox";
            this.moduleCodeTextBox.Size = new System.Drawing.Size(159, 24);
            this.moduleCodeTextBox.TabIndex = 44;
            this.moduleCodeTextBox.WordWrap = false;
            this.moduleCodeTextBox.TextChanged += new System.EventHandler(this.moduleCodeTextBox_TextChanged);
            // 
            // moduleCodeLabel
            // 
            this.moduleCodeLabel.AutoSize = true;
            this.moduleCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.moduleCodeLabel.Location = new System.Drawing.Point(14, 45);
            this.moduleCodeLabel.Name = "moduleCodeLabel";
            this.moduleCodeLabel.Size = new System.Drawing.Size(101, 18);
            this.moduleCodeLabel.TabIndex = 43;
            this.moduleCodeLabel.Text = "Module Code:";
            // 
            // examWeightUpDown
            // 
            this.examWeightUpDown.DecimalPlaces = 1;
            this.examWeightUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.examWeightUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.examWeightUpDown.Location = new System.Drawing.Point(347, 118);
            this.examWeightUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.examWeightUpDown.Name = "examWeightUpDown";
            this.examWeightUpDown.Size = new System.Drawing.Size(64, 24);
            this.examWeightUpDown.TabIndex = 42;
            this.examWeightUpDown.ValueChanged += new System.EventHandler(this.examWeightUpDown_ValueChanged);
            // 
            // courseworkWeightUpDown
            // 
            this.courseworkWeightUpDown.DecimalPlaces = 1;
            this.courseworkWeightUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.courseworkWeightUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.courseworkWeightUpDown.Location = new System.Drawing.Point(180, 118);
            this.courseworkWeightUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.courseworkWeightUpDown.Name = "courseworkWeightUpDown";
            this.courseworkWeightUpDown.Size = new System.Drawing.Size(58, 24);
            this.courseworkWeightUpDown.TabIndex = 41;
            this.courseworkWeightUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.courseworkWeightUpDown.ValueChanged += new System.EventHandler(this.courseworkWeightUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(339, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Exam Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(134, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Coursework Weight";
            // 
            // moduleNameLabel
            // 
            this.moduleNameLabel.AutoSize = true;
            this.moduleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.moduleNameLabel.Location = new System.Drawing.Point(11, 5);
            this.moduleNameLabel.Name = "moduleNameLabel";
            this.moduleNameLabel.Size = new System.Drawing.Size(105, 18);
            this.moduleNameLabel.TabIndex = 38;
            this.moduleNameLabel.Text = "Module Name:";
            // 
            // moduleNameTextBox
            // 
            this.moduleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.moduleNameTextBox.Location = new System.Drawing.Point(137, 5);
            this.moduleNameTextBox.MaxLength = 100;
            this.moduleNameTextBox.Name = "moduleNameTextBox";
            this.moduleNameTextBox.Size = new System.Drawing.Size(694, 24);
            this.moduleNameTextBox.TabIndex = 37;
            this.moduleNameTextBox.WordWrap = false;
            // 
            // cwComponentsUserControl
            // 
            this.cwComponentsUserControl.BackColor = System.Drawing.Color.White;
            this.cwComponentsUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cwComponentsUserControl.Location = new System.Drawing.Point(3, 3);
            this.cwComponentsUserControl.Name = "cwComponentsUserControl";
            this.cwComponentsUserControl.Size = new System.Drawing.Size(780, 126);
            this.cwComponentsUserControl.TabIndex = 0;
            // 
            // ModuleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.cwComponentsGroupBox);
            this.Controls.Add(this.examMarkUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.moduleTermComboBox);
            this.Controls.Add(this.moduleTermLabel);
            this.Controls.Add(this.moduleCreditsComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.moduleCodeTextBox);
            this.Controls.Add(this.moduleCodeLabel);
            this.Controls.Add(this.examWeightUpDown);
            this.Controls.Add(this.courseworkWeightUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moduleNameLabel);
            this.Controls.Add(this.moduleNameTextBox);
            this.Name = "ModuleUserControl";
            this.Size = new System.Drawing.Size(948, 382);
            this.Load += new System.EventHandler(this.ModuleUserControl_Load);
            this.cwComponentsGroupBox.ResumeLayout(false);
            this.cwComponentsTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.examMarkUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examWeightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseworkWeightUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeCwComponent;
        private System.Windows.Forms.GroupBox cwComponentsGroupBox;
        private System.Windows.Forms.TabControl cwComponentsTabControl;
        private System.Windows.Forms.Button addCwComponentBtn;
        private System.Windows.Forms.NumericUpDown examMarkUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox moduleTermComboBox;
        private System.Windows.Forms.Label moduleTermLabel;
        private System.Windows.Forms.ComboBox moduleCreditsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox moduleCodeTextBox;
        private System.Windows.Forms.Label moduleCodeLabel;
        private System.Windows.Forms.NumericUpDown examWeightUpDown;
        private System.Windows.Forms.NumericUpDown courseworkWeightUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label moduleNameLabel;
        private System.Windows.Forms.TextBox moduleNameTextBox;
        private System.Windows.Forms.TabPage tabPage1;
        private CwComponentsUserControl cwComponentsUserControl;
    }
}
