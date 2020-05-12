namespace SomeProject.TcpClient
{
    partial class ClientMainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sendMsgBtn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelRes = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonOpF = new System.Windows.Forms.Button();
            this.buttonSndF = new System.Windows.Forms.Button();
            this.labelServRespond = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sendMsgBtn
            // 
            this.sendMsgBtn.Location = new System.Drawing.Point(196, 239);
            this.sendMsgBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sendMsgBtn.Name = "sendMsgBtn";
            this.sendMsgBtn.Size = new System.Drawing.Size(110, 19);
            this.sendMsgBtn.TabIndex = 0;
            this.sendMsgBtn.Text = "Send Message";
            this.sendMsgBtn.UseVisualStyleBackColor = true;
            this.sendMsgBtn.Click += new System.EventHandler(this.OnMsgBtnClick);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(25, 77);
            this.textBox.Margin = new System.Windows.Forms.Padding(2);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(281, 158);
            this.textBox.TabIndex = 1;
            // 
            // labelRes
            // 
            this.labelRes.Location = new System.Drawing.Point(25, 9);
            this.labelRes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(281, 24);
            this.labelRes.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(25, 263);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(281, 20);
            this.textBoxFile.TabIndex = 3;
            // 
            // buttonOpF
            // 
            this.buttonOpF.Location = new System.Drawing.Point(25, 289);
            this.buttonOpF.Name = "buttonOpF";
            this.buttonOpF.Size = new System.Drawing.Size(110, 19);
            this.buttonOpF.TabIndex = 4;
            this.buttonOpF.Text = "Open file";
            this.buttonOpF.UseVisualStyleBackColor = true;
            this.buttonOpF.Click += new System.EventHandler(this.buttonOpF_Click);
            // 
            // buttonSndF
            // 
            this.buttonSndF.Location = new System.Drawing.Point(196, 289);
            this.buttonSndF.Name = "buttonSndF";
            this.buttonSndF.Size = new System.Drawing.Size(110, 19);
            this.buttonSndF.TabIndex = 5;
            this.buttonSndF.Text = "Send file";
            this.buttonSndF.UseVisualStyleBackColor = true;
            this.buttonSndF.Click += new System.EventHandler(this.buttonSndF_Click);
            // 
            // labelServRespond
            // 
            this.labelServRespond.Location = new System.Drawing.Point(25, 33);
            this.labelServRespond.Name = "labelServRespond";
            this.labelServRespond.Size = new System.Drawing.Size(281, 42);
            this.labelServRespond.TabIndex = 6;
            // 
            // ClientMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 320);
            this.Controls.Add(this.labelServRespond);
            this.Controls.Add(this.buttonSndF);
            this.Controls.Add(this.buttonOpF);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.sendMsgBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientMainWindow";
            this.Text = "Client application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientMainWindow_FormClosed);
            this.Load += new System.EventHandler(this.ClientMainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendMsgBtn;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button buttonOpF;
        private System.Windows.Forms.Button buttonSndF;
        private System.Windows.Forms.Label labelServRespond;
    }
}

