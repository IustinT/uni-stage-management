namespace Stage_Management_Aplication
{
    partial class CwComponentsUserControl
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
            this.componentMarkUpDown = new System.Windows.Forms.NumericUpDown();
            this.componentMarkLabel = new System.Windows.Forms.Label();
            this.componentWeightingUpDown = new System.Windows.Forms.NumericUpDown();
            this.componentWeigthingLabel = new System.Windows.Forms.Label();
            this.componentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.componentTypeLabel = new System.Windows.Forms.Label();
            this.componentNameTextBox = new System.Windows.Forms.TextBox();
            this.componentNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.componentMarkUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentWeightingUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // componentMarkUpDown
            // 
            this.componentMarkUpDown.DecimalPlaces = 2;
            this.componentMarkUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.componentMarkUpDown.Location = new System.Drawing.Point(258, 81);
            this.componentMarkUpDown.Name = "componentMarkUpDown";
            this.componentMarkUpDown.Size = new System.Drawing.Size(76, 24);
            this.componentMarkUpDown.TabIndex = 39;
            // 
            // componentMarkLabel
            // 
            this.componentMarkLabel.AutoSize = true;
            this.componentMarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.componentMarkLabel.Location = new System.Drawing.Point(200, 84);
            this.componentMarkLabel.Name = "componentMarkLabel";
            this.componentMarkLabel.Size = new System.Drawing.Size(42, 18);
            this.componentMarkLabel.TabIndex = 38;
            this.componentMarkLabel.Text = "Mark";
            // 
            // componentWeightingUpDown
            // 
            this.componentWeightingUpDown.DecimalPlaces = 1;
            this.componentWeightingUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.componentWeightingUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.componentWeightingUpDown.Location = new System.Drawing.Point(92, 81);
            this.componentWeightingUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.componentWeightingUpDown.Name = "componentWeightingUpDown";
            this.componentWeightingUpDown.Size = new System.Drawing.Size(58, 24);
            this.componentWeightingUpDown.TabIndex = 37;
            // 
            // componentWeigthingLabel
            // 
            this.componentWeigthingLabel.AutoSize = true;
            this.componentWeigthingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.componentWeigthingLabel.Location = new System.Drawing.Point(9, 84);
            this.componentWeigthingLabel.Name = "componentWeigthingLabel";
            this.componentWeigthingLabel.Size = new System.Drawing.Size(73, 18);
            this.componentWeigthingLabel.TabIndex = 36;
            this.componentWeigthingLabel.Text = "Weighting";
            // 
            // componentTypeComboBox
            // 
            this.componentTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.componentTypeComboBox.FormattingEnabled = true;
            this.componentTypeComboBox.Items.AddRange(new object[] {
            "Essay",
            "Exercise",
            "In-class Test",
            "Software Development"});
            this.componentTypeComboBox.Location = new System.Drawing.Point(64, 43);
            this.componentTypeComboBox.MaxDropDownItems = 3;
            this.componentTypeComboBox.Name = "componentTypeComboBox";
            this.componentTypeComboBox.Size = new System.Drawing.Size(181, 26);
            this.componentTypeComboBox.Sorted = true;
            this.componentTypeComboBox.TabIndex = 35;
            this.componentTypeComboBox.Tag = "cwComponentTypeComboBox";
            this.componentTypeComboBox.Text = "Essay";
            this.componentTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.cwComponentTypeComboBox_SelectedIndexChanged);
            // 
            // componentTypeLabel
            // 
            this.componentTypeLabel.AutoSize = true;
            this.componentTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.componentTypeLabel.Location = new System.Drawing.Point(9, 43);
            this.componentTypeLabel.Name = "componentTypeLabel";
            this.componentTypeLabel.Size = new System.Drawing.Size(44, 18);
            this.componentTypeLabel.TabIndex = 34;
            this.componentTypeLabel.Text = "Type:";
            // 
            // componentNameTextBox
            // 
            this.componentNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.componentNameTextBox.Location = new System.Drawing.Point(64, 9);
            this.componentNameTextBox.Name = "componentNameTextBox";
            this.componentNameTextBox.Size = new System.Drawing.Size(520, 24);
            this.componentNameTextBox.TabIndex = 33;
            this.componentNameTextBox.WordWrap = false;
            // 
            // componentNameLabel
            // 
            this.componentNameLabel.AutoSize = true;
            this.componentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.componentNameLabel.Location = new System.Drawing.Point(9, 9);
            this.componentNameLabel.Name = "componentNameLabel";
            this.componentNameLabel.Size = new System.Drawing.Size(52, 18);
            this.componentNameLabel.TabIndex = 32;
            this.componentNameLabel.Text = "Name:";
            // 
            // CwComponentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.componentMarkUpDown);
            this.Controls.Add(this.componentMarkLabel);
            this.Controls.Add(this.componentWeightingUpDown);
            this.Controls.Add(this.componentWeigthingLabel);
            this.Controls.Add(this.componentTypeComboBox);
            this.Controls.Add(this.componentTypeLabel);
            this.Controls.Add(this.componentNameTextBox);
            this.Controls.Add(this.componentNameLabel);
            this.Name = "CwComponentsUserControl";
            this.Size = new System.Drawing.Size(589, 117);
            ((System.ComponentModel.ISupportInitialize)(this.componentMarkUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentWeightingUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown componentMarkUpDown;
        private System.Windows.Forms.Label componentMarkLabel;
        private System.Windows.Forms.NumericUpDown componentWeightingUpDown;
        private System.Windows.Forms.Label componentWeigthingLabel;
        private System.Windows.Forms.ComboBox componentTypeComboBox;
        private System.Windows.Forms.Label componentTypeLabel;
        private System.Windows.Forms.TextBox componentNameTextBox;
        private System.Windows.Forms.Label componentNameLabel;

    }
}
