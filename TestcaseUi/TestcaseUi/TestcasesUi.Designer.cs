using System.Windows.Forms;

namespace TestcaseUi
{
    partial class TestcasesUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestcasesUi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdOptionLoadFileSolution = new System.Windows.Forms.RadioButton();
            this.tbLoadFileSolution = new System.Windows.Forms.TextBox();
            this.lbLoadFileSolution = new System.Windows.Forms.Label();
            this.rdLoadFileSolution = new System.Windows.Forms.RadioButton();
            this.btLoadFileSolution = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdOptionLoadFileGenerator = new System.Windows.Forms.RadioButton();
            this.tbLoadFileGenerator = new System.Windows.Forms.TextBox();
            this.lbLoadFileGenerator = new System.Windows.Forms.Label();
            this.rdLoadFileGenerator = new System.Windows.Forms.RadioButton();
            this.btLoadFileGenerator = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbOutputFile = new System.Windows.Forms.TextBox();
            this.lbOutputFile = new System.Windows.Forms.Label();
            this.rdOuputFile = new System.Windows.Forms.RadioButton();
            this.btOpenOutputFiles = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbStartInfo = new System.Windows.Forms.Label();
            this.prStart = new System.Windows.Forms.ProgressBar();
            this.btStart = new System.Windows.Forms.Button();
            this.lbNumberofTestcases = new System.Windows.Forms.Label();
            this.nmInDeTestcases = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmInDeTestcases)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdOptionLoadFileSolution);
            this.panel1.Controls.Add(this.tbLoadFileSolution);
            this.panel1.Controls.Add(this.lbLoadFileSolution);
            this.panel1.Controls.Add(this.rdLoadFileSolution);
            this.panel1.Controls.Add(this.btLoadFileSolution);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 87);
            this.panel1.TabIndex = 0;
            // 
            // rdOptionLoadFileSolution
            // 
            this.rdOptionLoadFileSolution.AutoSize = true;
            this.rdOptionLoadFileSolution.Location = new System.Drawing.Point(71, 26);
            this.rdOptionLoadFileSolution.Name = "rdOptionLoadFileSolution";
            this.rdOptionLoadFileSolution.Size = new System.Drawing.Size(56, 17);
            this.rdOptionLoadFileSolution.TabIndex = 2;
            this.rdOptionLoadFileSolution.Text = "Option";
            this.rdOptionLoadFileSolution.UseVisualStyleBackColor = true;
            this.rdOptionLoadFileSolution.CheckedChanged += new System.EventHandler(this.rdOptionLoadFileSolution_CheckedChanged);
            // 
            // tbLoadFileSolution
            // 
            this.tbLoadFileSolution.AcceptsReturn = true;
            this.tbLoadFileSolution.Location = new System.Drawing.Point(6, 49);
            this.tbLoadFileSolution.Name = "tbLoadFileSolution";
            this.tbLoadFileSolution.ReadOnly = true;
            this.tbLoadFileSolution.Size = new System.Drawing.Size(271, 20);
            this.tbLoadFileSolution.TabIndex = 3;
            // 
            // lbLoadFileSolution
            // 
            this.lbLoadFileSolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLoadFileSolution.AutoSize = true;
            this.lbLoadFileSolution.Location = new System.Drawing.Point(3, 10);
            this.lbLoadFileSolution.Name = "lbLoadFileSolution";
            this.lbLoadFileSolution.Size = new System.Drawing.Size(94, 13);
            this.lbLoadFileSolution.TabIndex = 2;
            this.lbLoadFileSolution.Text = "Load File Solution:";
            // 
            // rdLoadFileSolution
            // 
            this.rdLoadFileSolution.AutoSize = true;
            this.rdLoadFileSolution.Checked = true;
            this.rdLoadFileSolution.Location = new System.Drawing.Point(6, 26);
            this.rdLoadFileSolution.Name = "rdLoadFileSolution";
            this.rdLoadFileSolution.Size = new System.Drawing.Size(59, 17);
            this.rdLoadFileSolution.TabIndex = 1;
            this.rdLoadFileSolution.TabStop = true;
            this.rdLoadFileSolution.Text = "Default";
            this.rdLoadFileSolution.UseVisualStyleBackColor = true;
            this.rdLoadFileSolution.CheckedChanged += new System.EventHandler(this.rdLoadFileSolution_CheckedChanged);
            // 
            // btLoadFileSolution
            // 
            this.btLoadFileSolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLoadFileSolution.Enabled = false;
            this.btLoadFileSolution.Location = new System.Drawing.Point(283, 49);
            this.btLoadFileSolution.Name = "btLoadFileSolution";
            this.btLoadFileSolution.Size = new System.Drawing.Size(55, 20);
            this.btLoadFileSolution.TabIndex = 0;
            this.btLoadFileSolution.Text = "Load";
            this.btLoadFileSolution.UseCompatibleTextRendering = true;
            this.btLoadFileSolution.UseVisualStyleBackColor = true;
            this.btLoadFileSolution.Click += new System.EventHandler(this.btLoadFileSolution_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdOptionLoadFileGenerator);
            this.panel2.Controls.Add(this.tbLoadFileGenerator);
            this.panel2.Controls.Add(this.lbLoadFileGenerator);
            this.panel2.Controls.Add(this.rdLoadFileGenerator);
            this.panel2.Controls.Add(this.btLoadFileGenerator);
            this.panel2.Location = new System.Drawing.Point(429, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 87);
            this.panel2.TabIndex = 1;
            // 
            // rdOptionLoadFileGenerator
            // 
            this.rdOptionLoadFileGenerator.AutoSize = true;
            this.rdOptionLoadFileGenerator.Location = new System.Drawing.Point(71, 26);
            this.rdOptionLoadFileGenerator.Name = "rdOptionLoadFileGenerator";
            this.rdOptionLoadFileGenerator.Size = new System.Drawing.Size(56, 17);
            this.rdOptionLoadFileGenerator.TabIndex = 2;
            this.rdOptionLoadFileGenerator.Text = "Option";
            this.rdOptionLoadFileGenerator.UseVisualStyleBackColor = true;
            this.rdOptionLoadFileGenerator.CheckedChanged += new System.EventHandler(this.rdOptionLoadFileGenerator_CheckedChanged);
            // 
            // tbLoadFileGenerator
            // 
            this.tbLoadFileGenerator.AcceptsReturn = true;
            this.tbLoadFileGenerator.Location = new System.Drawing.Point(6, 49);
            this.tbLoadFileGenerator.Name = "tbLoadFileGenerator";
            this.tbLoadFileGenerator.ReadOnly = true;
            this.tbLoadFileGenerator.Size = new System.Drawing.Size(271, 20);
            this.tbLoadFileGenerator.TabIndex = 3;
            // 
            // lbLoadFileGenerator
            // 
            this.lbLoadFileGenerator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLoadFileGenerator.AutoSize = true;
            this.lbLoadFileGenerator.Location = new System.Drawing.Point(3, 10);
            this.lbLoadFileGenerator.Name = "lbLoadFileGenerator";
            this.lbLoadFileGenerator.Size = new System.Drawing.Size(103, 13);
            this.lbLoadFileGenerator.TabIndex = 2;
            this.lbLoadFileGenerator.Text = "Load File Generator:";
            // 
            // rdLoadFileGenerator
            // 
            this.rdLoadFileGenerator.AutoSize = true;
            this.rdLoadFileGenerator.Checked = true;
            this.rdLoadFileGenerator.Location = new System.Drawing.Point(6, 26);
            this.rdLoadFileGenerator.Name = "rdLoadFileGenerator";
            this.rdLoadFileGenerator.Size = new System.Drawing.Size(59, 17);
            this.rdLoadFileGenerator.TabIndex = 1;
            this.rdLoadFileGenerator.TabStop = true;
            this.rdLoadFileGenerator.Text = "Default";
            this.rdLoadFileGenerator.UseVisualStyleBackColor = true;
            this.rdLoadFileGenerator.CheckedChanged += new System.EventHandler(this.rdLoadFileGenerator_CheckedChanged);
            // 
            // btLoadFileGenerator
            // 
            this.btLoadFileGenerator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLoadFileGenerator.Enabled = false;
            this.btLoadFileGenerator.Location = new System.Drawing.Point(283, 49);
            this.btLoadFileGenerator.Name = "btLoadFileGenerator";
            this.btLoadFileGenerator.Size = new System.Drawing.Size(55, 20);
            this.btLoadFileGenerator.TabIndex = 0;
            this.btLoadFileGenerator.Text = "Load";
            this.btLoadFileGenerator.UseCompatibleTextRendering = true;
            this.btLoadFileGenerator.UseVisualStyleBackColor = true;
            this.btLoadFileGenerator.Click += new System.EventHandler(this.btLoadFileGenerator_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbOutputFile);
            this.panel3.Controls.Add(this.lbOutputFile);
            this.panel3.Controls.Add(this.rdOuputFile);
            this.panel3.Controls.Add(this.btOpenOutputFiles);
            this.panel3.Location = new System.Drawing.Point(221, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 88);
            this.panel3.TabIndex = 2;
            // 
            // tbOutputFile
            // 
            this.tbOutputFile.AcceptsReturn = true;
            this.tbOutputFile.Location = new System.Drawing.Point(6, 49);
            this.tbOutputFile.Name = "tbOutputFile";
            this.tbOutputFile.ReadOnly = true;
            this.tbOutputFile.Size = new System.Drawing.Size(271, 20);
            this.tbOutputFile.TabIndex = 3;
            // 
            // lbOutputFile
            // 
            this.lbOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOutputFile.AutoSize = true;
            this.lbOutputFile.Location = new System.Drawing.Point(3, 10);
            this.lbOutputFile.Name = "lbOutputFile";
            this.lbOutputFile.Size = new System.Drawing.Size(113, 13);
            this.lbOutputFile.TabIndex = 2;
            this.lbOutputFile.Text = "Output File Testcases:";
            // 
            // rdOuputFile
            // 
            this.rdOuputFile.AutoSize = true;
            this.rdOuputFile.Checked = true;
            this.rdOuputFile.Location = new System.Drawing.Point(6, 26);
            this.rdOuputFile.Name = "rdOuputFile";
            this.rdOuputFile.Size = new System.Drawing.Size(59, 17);
            this.rdOuputFile.TabIndex = 1;
            this.rdOuputFile.TabStop = true;
            this.rdOuputFile.Text = "Default";
            this.rdOuputFile.UseVisualStyleBackColor = true;
            // 
            // btOpenOutputFiles
            // 
            this.btOpenOutputFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOpenOutputFiles.Enabled = false;
            this.btOpenOutputFiles.Location = new System.Drawing.Point(294, 49);
            this.btOpenOutputFiles.Name = "btOpenOutputFiles";
            this.btOpenOutputFiles.Size = new System.Drawing.Size(55, 20);
            this.btOpenOutputFiles.TabIndex = 0;
            this.btOpenOutputFiles.Text = "Open";
            this.btOpenOutputFiles.UseCompatibleTextRendering = true;
            this.btOpenOutputFiles.UseVisualStyleBackColor = true;
            this.btOpenOutputFiles.Click += new System.EventHandler(this.btOpenOutputFiles_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbStartInfo);
            this.panel4.Controls.Add(this.prStart);
            this.panel4.Controls.Add(this.btStart);
            this.panel4.Controls.Add(this.lbNumberofTestcases);
            this.panel4.Controls.Add(this.nmInDeTestcases);
            this.panel4.Location = new System.Drawing.Point(302, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(196, 113);
            this.panel4.TabIndex = 3;
            // 
            // lbStartInfo
            // 
            this.lbStartInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbStartInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbStartInfo.Location = new System.Drawing.Point(3, 55);
            this.lbStartInfo.Name = "lbStartInfo";
            this.lbStartInfo.Size = new System.Drawing.Size(190, 26);
            this.lbStartInfo.TabIndex = 4;
            this.lbStartInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbStartInfo.UseCompatibleTextRendering = true;
            this.lbStartInfo.Visible = false;
            // 
            // prStart
            // 
            this.prStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prStart.Location = new System.Drawing.Point(3, 84);
            this.prStart.Name = "prStart";
            this.prStart.Size = new System.Drawing.Size(190, 26);
            this.prStart.TabIndex = 3;
            this.prStart.Visible = false;
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStart.ImageKey = "(none)";
            this.btStart.Location = new System.Drawing.Point(3, 3);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(190, 23);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Start";
            this.btStart.UseCompatibleTextRendering = true;
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lbNumberofTestcases
            // 
            this.lbNumberofTestcases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberofTestcases.Location = new System.Drawing.Point(7, 32);
            this.lbNumberofTestcases.Name = "lbNumberofTestcases";
            this.lbNumberofTestcases.Size = new System.Drawing.Size(141, 20);
            this.lbNumberofTestcases.TabIndex = 1;
            this.lbNumberofTestcases.Text = "Number of Tescases:";
            // 
            // nmInDeTestcases
            // 
            this.nmInDeTestcases.Location = new System.Drawing.Point(154, 32);
            this.nmInDeTestcases.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmInDeTestcases.Name = "nmInDeTestcases";
            this.nmInDeTestcases.Size = new System.Drawing.Size(39, 20);
            this.nmInDeTestcases.TabIndex = 0;
            this.nmInDeTestcases.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // TestcasesUi
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TestcasesUi";
            this.Text = "Generator Testcases";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmInDeTestcases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdOptionLoadFileSolution;
        private System.Windows.Forms.TextBox tbLoadFileSolution;
        private System.Windows.Forms.Label lbLoadFileSolution;
        private System.Windows.Forms.RadioButton rdLoadFileSolution;
        private System.Windows.Forms.Button btLoadFileSolution;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdOptionLoadFileGenerator;
        private System.Windows.Forms.TextBox tbLoadFileGenerator;
        private System.Windows.Forms.Label lbLoadFileGenerator;
        private System.Windows.Forms.RadioButton rdLoadFileGenerator;
        private System.Windows.Forms.Button btLoadFileGenerator;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbOutputFile;
        private System.Windows.Forms.Label lbOutputFile;
        private System.Windows.Forms.RadioButton rdOuputFile;
        private System.Windows.Forms.Button btOpenOutputFiles;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbStartInfo;
        private System.Windows.Forms.ProgressBar prStart;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lbNumberofTestcases;
        private System.Windows.Forms.NumericUpDown nmInDeTestcases;
    }
}

