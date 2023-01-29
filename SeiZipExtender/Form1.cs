using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeiZipExtender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ProcessZipFiles_Click(object sender, EventArgs e)
        {
            string sInputDirLocation = txt_FolderPath.Text.Trim();
            string sOutputDirLocation = txt_OutputPath.Text.Trim();
            string sTempDirLocation = txt_TempPath.Text.Trim();
            int filesToZipCount = Convert.ToInt32(txt_PdfFileCounter.Text);

            if (!Directory.Exists(sTempDirLocation))
                Directory.CreateDirectory(sTempDirLocation);

            List<string> zipFiles = Directory.GetFiles(sInputDirLocation, "*.zip", SearchOption.AllDirectories).ToList();
            
            lbl_ZipStatus.Text = "Processing : 0" + " of Total Zip Files : " + Convert.ToString(zipFiles.Count());
            lbl_ZipStatus.Refresh();


            long exclusiveNameCounter = 0;
            int zipFileProcessingProgressCounter = 0;
            int fileProcessingProgressCounter = 0;
            foreach (string zipFile in zipFiles)
            {
                zipFileProcessingProgressCounter++;
                lbl_ZipStatus.Text = "Processing : " + Convert.ToString(zipFileProcessingProgressCounter) + " of Total Zip Files : " + Convert.ToString(zipFiles.Count());
                lbl_ZipStatus.Refresh();
                using (ZipArchive individualFiles = ZipFile.OpenRead(zipFile))
                {
                    int localCounter = 0;
                    foreach (ZipArchiveEntry individualFile in individualFiles.Entries)
                    {
                        fileProcessingProgressCounter++;
                        lbl_FileStatus.Text = "Processing : " + Convert.ToString(fileProcessingProgressCounter) + " of Total Files : " + Convert.ToString(individualFiles.Entries.Count());
                        lbl_FileStatus.Refresh();
                        if (localCounter == filesToZipCount)
                        {
                            string filenm = string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt-}" + Convert.ToString(exclusiveNameCounter) + new FileInfo(zipFile).Name, DateTime.Now);
                            CreateZip(filenm, sTempDirLocation, sOutputDirLocation);
                            foreach (System.IO.FileInfo file in new DirectoryInfo(sTempDirLocation).GetFiles()) file.Delete();
                            localCounter = 0;
                            exclusiveNameCounter++;
                        }
                        localCounter++;

                        long lSize = individualFile.Length;
                        individualFile.ExtractToFile(Path.Combine(sTempDirLocation, individualFile.FullName));                        
                    }
                    //For the last batch this is going to not hit the if condition of the above loop                    
                    string filenm1 = string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt-}" + Convert.ToString(exclusiveNameCounter) + new FileInfo(zipFile).Name, DateTime.Now);
                    CreateZip(filenm1, sTempDirLocation, sOutputDirLocation);
                    foreach (System.IO.FileInfo file in new DirectoryInfo(sTempDirLocation).GetFiles()) file.Delete();
                    exclusiveNameCounter++;
                }               
            }

            MessageBox.Show("Processing Complete - Please check your output Folder", "Success");
        }

      

        public void CreateZip(string sFileName, string sTempDirLocation, string sOutputDirLocation)
        {
            string startPath = txt_OutputPath.Text;
            string zipPath = sOutputDirLocation + "\\" + sFileName;

            ZipFile.CreateFromDirectory(sTempDirLocation, zipPath);
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            string sourceDir = txt_OutputPath.Text.Trim();
            string targetDir = txt_UploadLocation.Text.Trim();

            List<string> totalUploadFiles = Directory.GetFiles(sourceDir, "*.*", SearchOption.AllDirectories).ToList();
            int fileUploadCounter = 0;
            foreach (var file in Directory.GetFiles(sourceDir))
            {
                fileUploadCounter++;
                lbl_UploadStatus.Text = "Uploaded : " + Convert.ToString(fileUploadCounter) + " of Total Files : " + Convert.ToString(totalUploadFiles.Count());
                File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)), true);
            }

            MessageBox.Show("Upload Complete - Please check SFTP Target Folder", "Success");
        }

        //private void Createzip(string sTempDirLocation, string[] filesToZip1, string sOutputDirLocation)
        //{
        //    string dirRoot = sTempDirLocation;

        //    string[] filesToZip = filesToZip1;

        //    string zipFileName = string.Format("zipfile-{0:yyyy-MM-dd_hh-mm-ss-tt}.zip", DateTime.Now);

        //    using (MemoryStream zipMS = new MemoryStream())
        //    {
        //        using (ZipArchive zipArchive = new ZipArchive(zipMS, ZipArchiveMode.Create, true))
        //        {
        //            foreach (string fileToZip in filesToZip)
        //            {
        //                byte[] fileToZipBytes = System.IO.File.ReadAllBytes(fileToZip);

        //                ZipArchiveEntry zipFileEntry = zipArchive.CreateEntry(fileToZip.Replace(dirRoot, "").Replace('\\', '/'));

        //                using (Stream zipEntryStream = zipFileEntry.Open())
        //                using (BinaryWriter zipFileBinary = new BinaryWriter(zipEntryStream))
        //                {
        //                    zipFileBinary.Write(fileToZipBytes);
        //                }
        //            }
        //        }

        //        using (FileStream finalZipFileStream = new FileStream(@"c:\ZipLocationOutput\" + zipFileName, FileMode.Create))
        //        {
        //            zipMS.Seek(0, SeekOrigin.Begin);
        //            zipMS.CopyTo(finalZipFileStream);
        //        }

        //        //lstLog.Items.Add("ZIP Archive Created.");
        //    }
        //}
    }
}
