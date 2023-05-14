using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean
{
    public class Clean: System.ComponentModel.BackgroundWorker
    {
        private  string sourceClean ;
        private  string[] fileExtension;
        private string[] excludefile; 
        public Clean(string sourceClean) {
            this.sourceClean = sourceClean;
            this.fileExtension = new string[] { ".in", ".out", ".exe",".cpp" };
            this.excludefile = new string[] { "solution.cpp", "generator.cpp" };
            WorkerReportsProgress = true;
        }
        protected  void CleanData()
        {
            string[] files = Directory.GetFiles(sourceClean).Where(file => !excludefile.Contains(Path.GetFileName(file),StringComparer.OrdinalIgnoreCase)&&fileExtension.Contains(Path.GetExtension(file))).ToArray();
            foreach (var FilewithIndex in files.Select ((file, index) => new { File = file, Index = index }))
            {
                File.Delete(FilewithIndex.File);
                this.ReportProgress(FilewithIndex.Index);
            }
        }
        protected override void OnDoWork(DoWorkEventArgs e)
        {
            CleanData();
        }
    }
}
