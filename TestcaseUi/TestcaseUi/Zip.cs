using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace zip
{
    public  class Zip: System.ComponentModel.BackgroundWorker
    {

        private  string sourcefolderData ;
        private  string sourcefolderExport ;
        private  string[] fileExtension ;
        private   string filename = "testcases.zip";
        private  string destinationPath ;
        public Zip(string sourcefolderData,string sourcefolderExport,string filename)
        {
            this.sourcefolderData = sourcefolderData;
            this.sourcefolderExport = sourcefolderExport;
            this.filename = filename;
            this.fileExtension = new string[] { ".in", ".out" };
            this.destinationPath = Path.Combine(sourcefolderExport,filename);
            WorkerReportsProgress = true;
        }
        protected  void ZipFilewithExtensions()
        {
            string[] files = Directory.GetFiles(sourcefolderData).Where(file => fileExtension.Contains(Path.GetExtension(file))).ToArray();
            using (FileStream stream = new FileStream(destinationPath, FileMode.Create))
            {
                using (ZipArchive zipArchive = new ZipArchive(stream, ZipArchiveMode.Create))
                {
                    foreach (var FilewithIndex in files.Select((file, index) => new { File = file, Index = index})  )
                    {
                        zipArchive.CreateEntryFromFile(FilewithIndex.File, Path.GetFileName(FilewithIndex.File));
                        this.ReportProgress(FilewithIndex.Index);
                    }
                }
            }
        }
        protected override void OnDoWork(DoWorkEventArgs e)
        {
            ZipFilewithExtensions();
        }
    }
}
