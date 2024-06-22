namespace ReadTXT
{
    partial class PrintBarcodeList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintBarcodeList));
            this.picbox_obj1 = new System.Windows.Forms.PictureBox();
            this.lbl_ErpSend = new System.Windows.Forms.Label();
            this.tbx_ErpSendChar = new System.Windows.Forms.TextBox();
            this.tm_CountSpan = new System.Windows.Forms.Timer(this.components);
            this.lbl_TimeSpan = new System.Windows.Forms.Label();
            this.tbx_Readtxt = new System.Windows.Forms.TextBox();
            this.pbx_1arrayBarcode = new System.Windows.Forms.PictureBox();
            this.lbl_Barcode = new System.Windows.Forms.Label();
            this.lbl_Readtxt = new System.Windows.Forms.Label();
            this.ptPvwDig1 = new System.Windows.Forms.PrintPreviewDialog();
            this.ptDoc1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_obj1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_1arrayBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_obj1
            // 
            this.picbox_obj1.Image = ((System.Drawing.Image)(resources.GetObject("picbox_obj1.Image")));
            this.picbox_obj1.Location = new System.Drawing.Point(307, 310);
            this.picbox_obj1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picbox_obj1.Name = "picbox_obj1";
            this.picbox_obj1.Size = new System.Drawing.Size(178, 62);
            this.picbox_obj1.TabIndex = 0;
            this.picbox_obj1.TabStop = false;
            // 
            // lbl_ErpSend
            // 
            this.lbl_ErpSend.AutoSize = true;
            this.lbl_ErpSend.Font = new System.Drawing.Font("DFKai-SB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ErpSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_ErpSend.Location = new System.Drawing.Point(11, 20);
            this.lbl_ErpSend.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ErpSend.Name = "lbl_ErpSend";
            this.lbl_ErpSend.Size = new System.Drawing.Size(112, 16);
            this.lbl_ErpSend.TabIndex = 1;
            this.lbl_ErpSend.Text = "ERP 傳送字串";
            // 
            // tbx_ErpSendChar
            // 
            this.tbx_ErpSendChar.Location = new System.Drawing.Point(121, 14);
            this.tbx_ErpSendChar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_ErpSendChar.Multiline = true;
            this.tbx_ErpSendChar.Name = "tbx_ErpSendChar";
            this.tbx_ErpSendChar.Size = new System.Drawing.Size(376, 27);
            this.tbx_ErpSendChar.TabIndex = 2;
            // 
            // tm_CountSpan
            // 
            this.tm_CountSpan.Tick += new System.EventHandler(this.tm_CountSpan_Tick);
            // 
            // lbl_TimeSpan
            // 
            this.lbl_TimeSpan.AutoSize = true;
            this.lbl_TimeSpan.Font = new System.Drawing.Font("DFKai-SB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_TimeSpan.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_TimeSpan.Location = new System.Drawing.Point(71, 330);
            this.lbl_TimeSpan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TimeSpan.Name = "lbl_TimeSpan";
            this.lbl_TimeSpan.Size = new System.Drawing.Size(150, 24);
            this.lbl_TimeSpan.TabIndex = 3;
            this.lbl_TimeSpan.Text = "等待中.....";
            // 
            // tbx_Readtxt
            // 
            this.tbx_Readtxt.Location = new System.Drawing.Point(22, 144);
            this.tbx_Readtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_Readtxt.Multiline = true;
            this.tbx_Readtxt.Name = "tbx_Readtxt";
            this.tbx_Readtxt.Size = new System.Drawing.Size(474, 162);
            this.tbx_Readtxt.TabIndex = 4;
            // 
            // pbx_1arrayBarcode
            // 
            this.pbx_1arrayBarcode.BackColor = System.Drawing.Color.OrangeRed;
            this.pbx_1arrayBarcode.Location = new System.Drawing.Point(257, 56);
            this.pbx_1arrayBarcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbx_1arrayBarcode.Name = "pbx_1arrayBarcode";
            this.pbx_1arrayBarcode.Size = new System.Drawing.Size(238, 60);
            this.pbx_1arrayBarcode.TabIndex = 5;
            this.pbx_1arrayBarcode.TabStop = false;
            this.pbx_1arrayBarcode.Click += new System.EventHandler(this.pbx_1arrayBarcode_Click);
            // 
            // lbl_Barcode
            // 
            this.lbl_Barcode.AutoSize = true;
            this.lbl_Barcode.Font = new System.Drawing.Font("DFKai-SB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Barcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Barcode.Location = new System.Drawing.Point(146, 79);
            this.lbl_Barcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Barcode.Name = "lbl_Barcode";
            this.lbl_Barcode.Size = new System.Drawing.Size(110, 16);
            this.lbl_Barcode.TabIndex = 6;
            this.lbl_Barcode.Text = "編號條碼圖示";
            // 
            // lbl_Readtxt
            // 
            this.lbl_Readtxt.AutoSize = true;
            this.lbl_Readtxt.Font = new System.Drawing.Font("DFKai-SB", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Readtxt.Location = new System.Drawing.Point(25, 126);
            this.lbl_Readtxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Readtxt.Name = "lbl_Readtxt";
            this.lbl_Readtxt.Size = new System.Drawing.Size(65, 11);
            this.lbl_Readtxt.TabIndex = 7;
            this.lbl_Readtxt.Text = "TXT檔內容";
            // 
            // ptPvwDig1
            // 
            this.ptPvwDig1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ptPvwDig1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ptPvwDig1.ClientSize = new System.Drawing.Size(400, 300);
            this.ptPvwDig1.Document = this.ptDoc1;
            this.ptPvwDig1.Enabled = true;
            this.ptPvwDig1.Icon = ((System.Drawing.Icon)(resources.GetObject("ptPvwDig1.Icon")));
            this.ptPvwDig1.Name = "ptPvwDig1";
            this.ptPvwDig1.Visible = false;
            // 
            // ptDoc1
            // 
            this.ptDoc1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ptDoc1_PrintPage);
            // 
            // PrintBarcodeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(512, 386);
            this.Controls.Add(this.lbl_Readtxt);
            this.Controls.Add(this.lbl_Barcode);
            this.Controls.Add(this.pbx_1arrayBarcode);
            this.Controls.Add(this.tbx_Readtxt);
            this.Controls.Add(this.lbl_TimeSpan);
            this.Controls.Add(this.tbx_ErpSendChar);
            this.Controls.Add(this.lbl_ErpSend);
            this.Controls.Add(this.picbox_obj1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrintBarcodeList";
            this.Text = "PrintBarcodeList";
            this.Load += new System.EventHandler(this.PrintBarcodeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_obj1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_1arrayBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_obj1;
        private System.Windows.Forms.Label lbl_ErpSend;
        private System.Windows.Forms.TextBox tbx_ErpSendChar;
        private System.Windows.Forms.Timer tm_CountSpan;
        private System.Windows.Forms.Label lbl_TimeSpan;
        private System.Windows.Forms.TextBox tbx_Readtxt;
        private System.Windows.Forms.PictureBox pbx_1arrayBarcode;
        private System.Windows.Forms.Label lbl_Barcode;
        private System.Windows.Forms.Label lbl_Readtxt;
        private System.Windows.Forms.PrintPreviewDialog ptPvwDig1;
        private System.Drawing.Printing.PrintDocument ptDoc1;

    }
}