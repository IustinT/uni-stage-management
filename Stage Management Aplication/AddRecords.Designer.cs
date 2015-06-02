namespace Stage_Management_Aplication
{
    partial class AddRecords
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveStagesBtn = new System.Windows.Forms.Button();
            this.removeModuleBtn = new System.Windows.Forms.Button();
            this.addModuleBtn = new System.Windows.Forms.Button();
            this.removeStageBtn = new System.Windows.Forms.Button();
            this.addStageBtn = new System.Windows.Forms.Button();
            this.stagesGroupBox = new System.Windows.Forms.GroupBox();
            this.stagesTabControl = new System.Windows.Forms.TabControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.stagesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.stagesGroupBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.04899F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.95101F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1267, 771);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveStagesBtn);
            this.panel1.Controls.Add(this.removeModuleBtn);
            this.panel1.Controls.Add(this.addModuleBtn);
            this.panel1.Controls.Add(this.removeStageBtn);
            this.panel1.Controls.Add(this.addStageBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 689);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 79);
            this.panel1.TabIndex = 0;
            // 
            // saveStagesBtn
            // 
            this.saveStagesBtn.Location = new System.Drawing.Point(729, 9);
            this.saveStagesBtn.Name = "saveStagesBtn";
            this.saveStagesBtn.Size = new System.Drawing.Size(97, 55);
            this.saveStagesBtn.TabIndex = 4;
            this.saveStagesBtn.Text = "Save";
            this.saveStagesBtn.UseVisualStyleBackColor = true;
            this.saveStagesBtn.Click += new System.EventHandler(this.saveStagesBtn_Click);
            // 
            // removeModuleBtn
            // 
            this.removeModuleBtn.Location = new System.Drawing.Point(395, 9);
            this.removeModuleBtn.Name = "removeModuleBtn";
            this.removeModuleBtn.Size = new System.Drawing.Size(97, 55);
            this.removeModuleBtn.TabIndex = 3;
            this.removeModuleBtn.Text = "Remove This Module";
            this.removeModuleBtn.UseVisualStyleBackColor = true;
            this.removeModuleBtn.Click += new System.EventHandler(this.removeModuleBtn_Click);
            // 
            // addModuleBtn
            // 
            this.addModuleBtn.Location = new System.Drawing.Point(281, 9);
            this.addModuleBtn.Name = "addModuleBtn";
            this.addModuleBtn.Size = new System.Drawing.Size(97, 55);
            this.addModuleBtn.TabIndex = 2;
            this.addModuleBtn.Text = "Add a New Module";
            this.addModuleBtn.UseVisualStyleBackColor = true;
            this.addModuleBtn.Click += new System.EventHandler(this.addModuleBtn_Click);
            // 
            // removeStageBtn
            // 
            this.removeStageBtn.Location = new System.Drawing.Point(136, 9);
            this.removeStageBtn.Name = "removeStageBtn";
            this.removeStageBtn.Size = new System.Drawing.Size(97, 55);
            this.removeStageBtn.TabIndex = 1;
            this.removeStageBtn.Text = "Remove this Stage";
            this.removeStageBtn.UseVisualStyleBackColor = true;
            this.removeStageBtn.Click += new System.EventHandler(this.removeStageBtn_Click);
            // 
            // addStageBtn
            // 
            this.addStageBtn.Location = new System.Drawing.Point(22, 9);
            this.addStageBtn.Name = "addStageBtn";
            this.addStageBtn.Size = new System.Drawing.Size(97, 55);
            this.addStageBtn.TabIndex = 0;
            this.addStageBtn.Text = "Add a New Stage";
            this.addStageBtn.UseVisualStyleBackColor = true;
            this.addStageBtn.Click += new System.EventHandler(this.addStageBtn_Click);
            // 
            // stagesGroupBox
            // 
            this.stagesGroupBox.Controls.Add(this.stagesTabControl);
            this.stagesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stagesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.stagesGroupBox.Name = "stagesGroupBox";
            this.stagesGroupBox.Size = new System.Drawing.Size(1261, 680);
            this.stagesGroupBox.TabIndex = 1;
            this.stagesGroupBox.TabStop = false;
            this.stagesGroupBox.Text = "Stages";
            // 
            // stagesTabControl
            // 
            this.stagesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stagesTabControl.Location = new System.Drawing.Point(3, 18);
            this.stagesTabControl.Name = "stagesTabControl";
            this.stagesTabControl.SelectedIndex = 0;
            this.stagesTabControl.Size = new System.Drawing.Size(1255, 659);
            this.stagesTabControl.TabIndex = 0;
            // 
            // AddRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 771);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddRecords";
            this.Text = "AddRecords";
            this.Shown += new System.EventHandler(this.AddRecords_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.stagesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addStageBtn;
        private System.Windows.Forms.GroupBox stagesGroupBox;
        private System.Windows.Forms.TabControl stagesTabControl;
        private System.Windows.Forms.Button saveStagesBtn;
        private System.Windows.Forms.Button removeModuleBtn;
        private System.Windows.Forms.Button addModuleBtn;
        private System.Windows.Forms.Button removeStageBtn;
    }
}