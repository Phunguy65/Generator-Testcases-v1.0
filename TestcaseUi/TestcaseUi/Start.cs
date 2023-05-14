using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using start;

namespace start
{
    public class Start: System.ComponentModel.BackgroundWorker
    {
        private string generator;
        private string solution;
        private string pathApp;
        private string folderData;
        private string folderExport;
        private int nTest;
        public Start(string solution, string generator, int nTest)
        {
            this.WorkerReportsProgress = true;
            this.pathApp = AppContext.BaseDirectory;
            this.generator = generator;
            this.solution = solution;
            this.folderData = "Data\\";
            this.folderExport = "Export\\";
            this.nTest = nTest;
         
        }
        protected void generatorGenerator()
        {
            
            System.Diagnostics.Process pGenerator = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo pStartInfo = new System.Diagnostics.ProcessStartInfo();
            if (Path.Combine(pathApp, folderData, "generator.cpp") != this.generator)
            { System.IO.File.Copy(this.generator, this.pathApp + this.folderData + System.IO.Path.GetFileName(this.generator), true); }
            pStartInfo.FileName = "cmd.exe";
            pStartInfo.CreateNoWindow = true;
            pStartInfo.UseShellExecute = false;
            pStartInfo.Arguments = "/c " + "g++ -o " + this.pathApp + this.folderData + "generator.exe " + this.pathApp + this.folderData + System.IO.Path.GetFileName(this.generator);
            pGenerator.StartInfo = pStartInfo;
            pGenerator.Start();
            pGenerator.WaitForExit();
            pGenerator.Close();
        }
        protected void generatorSolution()
        {
            System.Diagnostics.Process  pSolution =  new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo  pStartInfo = new System.Diagnostics.ProcessStartInfo();
            pStartInfo.FileName = "cmd.exe";
            pStartInfo.Arguments = "/c " + "g++ -o " + this.pathApp + this.folderData + "solution.exe " + this.solution;
            pStartInfo.CreateNoWindow = true;
            pStartInfo.UseShellExecute = false;
            pSolution.StartInfo = pStartInfo;
            pSolution.Start();
            pSolution.WaitForExit();
            pSolution.Close();
        }
        protected void generatorInput(ref int iTest)
        {
            System.Diagnostics.Process  pInput = new System.Diagnostics.Process();
            System.String  tmp = this.pathApp + this.folderData + "generator.exe >" + this.pathApp + this.folderData + iTest + ".in";
            System.Diagnostics.ProcessStartInfo  pStartInfo = new System.Diagnostics.ProcessStartInfo();
            pStartInfo.FileName = "cmd.exe";
            pStartInfo.Arguments = "/c " + tmp;
            pStartInfo.CreateNoWindow = true;
            pStartInfo.UseShellExecute = false;
            pInput.StartInfo = pStartInfo;
            pInput.Start();
            pInput.WaitForExit();
            pInput.Close();
        }
        protected void generatorOutput(ref int iTest)
        {
            System.Diagnostics.Process  pOutput = new System.Diagnostics.Process();
            System.String  tmp = this.pathApp + this.folderData + "solution.exe <" + this.pathApp + this.folderData + iTest + ".in >" + this.pathApp + this.folderData + iTest + ".out";
            System.Diagnostics.ProcessStartInfo  pStartInfo = new System.Diagnostics.ProcessStartInfo();
            pStartInfo.FileName = "cmd.exe";
            pStartInfo.Arguments = "/c " + tmp;
            pStartInfo.CreateNoWindow = true;
            pStartInfo.UseShellExecute = false;
            pOutput.StartInfo = pStartInfo;
            pOutput.Start();
            pOutput.WaitForExit();
            pOutput.Close();
        }

        protected override void OnDoWork(DoWorkEventArgs e)
        {
            generatorGenerator();
            generatorSolution();
            for (int iTest = 1; iTest <= this.nTest; iTest++)
            {
                generatorInput(ref iTest);
                generatorOutput(ref iTest);
                this.ReportProgress((int)iTest * 100 / nTest);
            }
        }
    }
}
