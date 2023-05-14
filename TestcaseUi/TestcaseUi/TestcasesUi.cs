using System;
using System.Windows.Forms;
using clean;
using zip;
using start;
using System.IO;

namespace TestcaseUi
{
    public partial class TestcasesUi : Form
    {
        private string path = AppContext.BaseDirectory;
        public TestcasesUi()
        {
            InitializeComponent();
            this.tbLoadFileSolution.Text = this.path + "Data\\solution.cpp";
            this.tbLoadFileGenerator.Text = this.path + "Data\\generator.cpp";
        }
        
        private void btLoadFileSolution_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "cpp files (*.cpp)|*.cpp|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbLoadFileSolution.Text = openFileDialog.FileName;
            }
        }

        private void btLoadFileGenerator_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "cpp files (*.cpp)|*.cpp|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbLoadFileGenerator.Text = openFileDialog.FileName;
            }

        }

        private void rdOptionLoadFileSolution_CheckedChanged(object sender, EventArgs e)
        {
            this.btLoadFileSolution.Enabled = true;
            this.tbLoadFileSolution.ReadOnly = false;
            this.tbLoadFileSolution.Text = "";
        }

        private void rdLoadFileSolution_CheckedChanged(object sender, EventArgs e)
        {
            this.tbLoadFileSolution.Text = this.path + "Data\\solution.cpp";
            this.tbLoadFileSolution.ReadOnly = true;
            this.btLoadFileSolution.Enabled = false;
        }

        private void rdLoadFileGenerator_CheckedChanged(object sender, EventArgs e)
        {
            this.tbLoadFileGenerator.Text = this.path + "Data\\generator.cpp";
            this.tbLoadFileGenerator.ReadOnly = true;
            this.btLoadFileGenerator.Enabled = false;
        }

        private void rdOptionLoadFileGenerator_CheckedChanged(object sender, EventArgs e)
        {
            this.btLoadFileGenerator.Enabled = true;
            this.tbLoadFileGenerator.ReadOnly = false;
            this.tbLoadFileGenerator.Text = "";
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            this.prStart.Visible = true;
            this.lbStartInfo.Visible = true;
            this.tbOutputFile.Text = "";
            this.btStart.Enabled = false;
            this.btOpenOutputFiles.Enabled = false;
            this.btOpenOutputFiles.Enabled = false;
            start.Start Hiddenstart = new Start(this.tbLoadFileSolution.Text, this.tbLoadFileGenerator.Text,(int)this.nmInDeTestcases.Value);
            Hiddenstart.RunWorkerAsync();
            Hiddenstart.ProgressChanged += Hiddenstart_ProgressChanged;
            Hiddenstart.RunWorkerCompleted += Hiddenstart_RunWorkerCompleted;
        }

        private void Hiddenstart_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Generator Testcases is completed successfully!","Notification",MessageBoxButtons.OK, MessageBoxIcon.Information);
            zip.Zip Hiddenzip = new Zip(path + "Data\\", path + "Export\\", "testcases.zip");
            Hiddenzip.RunWorkerCompleted += Hiddenzip_RunWorkerCompleted;
            Hiddenzip.ProgressChanged += Hiddenzip_ProgressChanged;
            Hiddenzip.RunWorkerAsync();
            this.prStart.Style = ProgressBarStyle.Marquee;
            this.prStart.MarqueeAnimationSpeed = 50;
        }

        private void Hiddenzip_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            this.lbStartInfo.Text = "Zipping data .";
            this.lbStartInfo.Text = "Zipping data ..";
            this.lbStartInfo.Text = "Zipping data ...";
        }

        private void Hiddenzip_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this.btStart.Enabled = true;
            this.tbOutputFile.Text = AppContext.BaseDirectory + "Export\\";
            this.btOpenOutputFiles.Enabled = true;
            clean.Clean HiddenClean = new Clean(path + "Data\\");
            HiddenClean.RunWorkerAsync();
            HiddenClean.RunWorkerCompleted += HiddenClean_RunWorkerCompleted;
            HiddenClean.ProgressChanged += HiddenClean_ProgressChanged;
            
        }

        private void HiddenClean_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            this.lbStartInfo.Text = "Cleaning data .";
            this.lbStartInfo.Text = "Cleaning data ..";
            this.lbStartInfo.Text = "Cleaning data ...";
        }

        private void HiddenClean_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this.prStart.Style = ProgressBarStyle.Continuous;
            this.prStart.Value = 0;
            this.prStart.Visible = false;
            this.lbStartInfo.Visible = false;
        }

        private void Hiddenstart_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            this.prStart.Value = e.ProgressPercentage;
            this.lbStartInfo.Text = this.prStart.Value.ToString() + "%";
        }

        private void btOpenOutputFiles_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe",this.tbOutputFile.Text);
        }
    }
}
