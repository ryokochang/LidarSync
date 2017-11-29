using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace LidarSync
{
    public partial class Form1 : Form
    {
        string[] frames;
        string path_apx, all_frames;
        int total_frames;
 
        public Form1()
        {
            InitializeComponent();
  
        }

        private void button_load_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            diag.ShowDialog();
            textBox_path_lidar.Text = diag.SelectedPath;
            if (diag.SelectedPath != "")
            {
                this.frames = Directory.GetFiles(Convert.ToString(textBox_path_lidar.Text), "*.csv", System.IO.SearchOption.TopDirectoryOnly);
            }
            else
                return;
        }

        private void button_load_apx_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Filter = "Txt file| *.txt";
            diag.ShowDialog();
            if(diag.CheckFileExists)
            {
                textBox_path_apx.Text = diag.FileName;
                this.path_apx = Convert.ToString(textBox_path_apx.Text);
            }
        }

        private void button_process_Click(object sender, EventArgs e)
        {
            if (textBox_path_apx.Text == "" || textBox_path_lidar.Text == "")
            {
                MessageBox.Show("Arquivos não selecionados!");
                return;
            }
            SaveFileDialog saved = new SaveFileDialog();
            saved.Filter = "Comma-separated values|*.Csv";
            saved.DefaultExt = ".csv";
            saved.ShowDialog();

            if(saved.FileName ==  "")
            {
                return;
            }

            this.all_frames = saved.FileName;

            backgroundWorker.RunWorkerAsync();
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            backgroundWorker.CancelAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.total_frames = frames.Length;
            int once=0;
            string newLine;

            var fileApx = File.OpenRead(path_apx);
            var fileSave = File.OpenWrite(all_frames);
            var readerApx = new StreamReader(fileApx);
            var writer = new StreamWriter(fileSave);

            //discart firt line of apx file
            var lineApx = readerApx.ReadLine();
            var valuesApx = lineApx.Split(',');
            // ---------------------------- //

            for (int i = 0; i < total_frames; i++)
            {
                if (backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                }
                else
                {
                    var fileFrames = File.ReadAllLines(frames[i]);
                    var lastLineFrame = fileFrames[fileFrames.Length - 1];
                    var valuesFrame = lastLineFrame.Split(',');

                    lineApx = readerApx.ReadLine();
                    valuesApx = lineApx.Split(',');
                    if (once == 0)
                    {
                        //do the first line of file
                        newLine = "X,Y,Z,GPS TIME,EASTING,NORTHING,ELLIPSOID HEIGHT,PITCH,ROLL,HEADING";
                        writer.WriteLine(newLine);
                        once++;
                    }

                    while (Convert.ToDouble(valuesApx[0]) < (Convert.ToDouble(valuesFrame[10])/10))
                    {
                        lineApx = readerApx.ReadLine();
                        valuesApx = lineApx.Split(',');
                    }
                    for (int j = 1; j < fileFrames.Length; j++)
                    {
                        var temp = fileFrames[j].Split(',');
                        newLine = temp[3] + ',' + temp[4] + ',' + temp[5] + ',' + 
                                valuesApx[0] + ',' + valuesApx[2] + ',' + valuesApx[3] + ',' + 
                                valuesApx[4] + ',' + valuesApx[5] + ',' + valuesApx[6] + ',' + valuesApx[7];

                        writer.WriteLine(newLine);
                    }                   
                    backgroundWorker.ReportProgress(i);
                }
            }
            readerApx.Close();
            writer.Close();             
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Maximum = total_frames-1;
            progressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {          
            if (e.Cancelled)
            {                
                MessageBox.Show("Cancelled");
            }
            else
            {
                MessageBox.Show("Complete");
                progressBar.Value = 0;
            }            
        }
    }
}
