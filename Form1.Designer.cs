namespace lab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOut = new System.Windows.Forms.RichTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.btnReFill = new System.Windows.Forms.Button();
            this.listBoxQ = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(403, 262);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(367, 314);
            this.txtOut.TabIndex = 1;
            this.txtOut.Text = "";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(797, 262);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(204, 228);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Взять";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Location = new System.Drawing.Point(34, 381);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(342, 61);
            this.txtInfo.TabIndex = 3;
            this.txtInfo.Text = "";
            // 
            // btnReFill
            // 
            this.btnReFill.Location = new System.Drawing.Point(797, 505);
            this.btnReFill.Name = "btnReFill";
            this.btnReFill.Size = new System.Drawing.Size(204, 62);
            this.btnReFill.TabIndex = 4;
            this.btnReFill.Text = "Перезаполнить";
            this.btnReFill.UseVisualStyleBackColor = true;
            this.btnReFill.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxQ
            // 
            this.listBoxQ.FormattingEnabled = true;
            this.listBoxQ.ItemHeight = 20;
            this.listBoxQ.Location = new System.Drawing.Point(12, 12);
            this.listBoxQ.Name = "listBoxQ";
            this.listBoxQ.Size = new System.Drawing.Size(989, 244);
            this.listBoxQ.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 579);
            this.Controls.Add(this.listBoxQ);
            this.Controls.Add(this.btnReFill);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtOut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private RichTextBox txtOut;
        private Button btnGet;
        private RichTextBox txtInfo;
        private Button btnReFill;
        private ListBox listBoxQ;
    }
}