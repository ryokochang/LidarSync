namespace LidarSync
{
    partial class Form1
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
            this.button_load_folder = new System.Windows.Forms.Button();
            this.button_load_apx = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_cancel = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button_process = new System.Windows.Forms.Button();
            this.label_apx = new System.Windows.Forms.Label();
            this.label_folder = new System.Windows.Forms.Label();
            this.textBox_path_apx = new System.Windows.Forms.TextBox();
            this.textBox_path_lidar = new System.Windows.Forms.TextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_load_folder
            // 
            this.button_load_folder.Location = new System.Drawing.Point(350, 52);
            this.button_load_folder.Name = "button_load_folder";
            this.button_load_folder.Size = new System.Drawing.Size(75, 23);
            this.button_load_folder.TabIndex = 0;
            this.button_load_folder.Text = "Select";
            this.button_load_folder.UseVisualStyleBackColor = true;
            this.button_load_folder.Click += new System.EventHandler(this.button_load_folder_Click);
            // 
            // button_load_apx
            // 
            this.button_load_apx.Location = new System.Drawing.Point(350, 126);
            this.button_load_apx.Name = "button_load_apx";
            this.button_load_apx.Size = new System.Drawing.Size(75, 23);
            this.button_load_apx.TabIndex = 1;
            this.button_load_apx.Text = "Select";
            this.button_load_apx.UseVisualStyleBackColor = true;
            this.button_load_apx.Click += new System.EventHandler(this.button_load_apx_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_cancel);
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.button_process);
            this.panel1.Controls.Add(this.label_apx);
            this.panel1.Controls.Add(this.label_folder);
            this.panel1.Controls.Add(this.textBox_path_apx);
            this.panel1.Controls.Add(this.textBox_path_lidar);
            this.panel1.Controls.Add(this.button_load_folder);
            this.panel1.Controls.Add(this.button_load_apx);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 261);
            this.panel1.TabIndex = 2;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(272, 215);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(94, 34);
            this.button_cancel.TabIndex = 8;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 178);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(440, 25);
            this.progressBar.TabIndex = 7;
            // 
            // button_process
            // 
            this.button_process.Location = new System.Drawing.Point(99, 215);
            this.button_process.Name = "button_process";
            this.button_process.Size = new System.Drawing.Size(94, 34);
            this.button_process.TabIndex = 6;
            this.button_process.Text = "Start";
            this.button_process.UseVisualStyleBackColor = true;
            this.button_process.Click += new System.EventHandler(this.button_process_Click);
            // 
            // label_apx
            // 
            this.label_apx.AutoSize = true;
            this.label_apx.Location = new System.Drawing.Point(29, 101);
            this.label_apx.Name = "label_apx";
            this.label_apx.Size = new System.Drawing.Size(53, 13);
            this.label_apx.TabIndex = 5;
            this.label_apx.Text = "Select file";
            // 
            // label_folder
            // 
            this.label_folder.AutoSize = true;
            this.label_folder.Location = new System.Drawing.Point(29, 29);
            this.label_folder.Name = "label_folder";
            this.label_folder.Size = new System.Drawing.Size(66, 13);
            this.label_folder.TabIndex = 4;
            this.label_folder.Text = "Select folder";
            // 
            // textBox_path_apx
            // 
            this.textBox_path_apx.Location = new System.Drawing.Point(32, 128);
            this.textBox_path_apx.Name = "textBox_path_apx";
            this.textBox_path_apx.Size = new System.Drawing.Size(312, 20);
            this.textBox_path_apx.TabIndex = 3;
            // 
            // textBox_path_lidar
            // 
            this.textBox_path_lidar.Location = new System.Drawing.Point(32, 54);
            this.textBox_path_lidar.Name = "textBox_path_lidar";
            this.textBox_path_lidar.Size = new System.Drawing.Size(312, 20);
            this.textBox_path_lidar.TabIndex = 2;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 261);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Lidar Data Sync";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_load_folder;
        private System.Windows.Forms.Button button_load_apx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_apx;
        private System.Windows.Forms.Label label_folder;
        private System.Windows.Forms.TextBox textBox_path_apx;
        private System.Windows.Forms.TextBox textBox_path_lidar;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button_process;
        private System.Windows.Forms.Button button_cancel;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

