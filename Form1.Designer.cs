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
            this.txtOut1 = new System.Windows.Forms.RichTextBox();
            this.txtOut = new System.Windows.Forms.RichTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.btnReFill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOut1
            // 
            this.txtOut1.Location = new System.Drawing.Point(12, 14);
            this.txtOut1.Name = "txtOut1";
            this.txtOut1.Size = new System.Drawing.Size(176, 231);
            this.txtOut1.TabIndex = 0;
            this.txtOut1.Text = "";
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(194, 123);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(171, 120);
            this.txtOut.TabIndex = 1;
            this.txtOut.Text = "";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(384, 125);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(152, 120);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Взять";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Location = new System.Drawing.Point(194, 56);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(342, 61);
            this.txtInfo.TabIndex = 3;
            this.txtInfo.Text = "";
            // 
            // btnReFill
            // 
            this.btnReFill.Location = new System.Drawing.Point(194, 12);
            this.btnReFill.Name = "btnReFill";
            this.btnReFill.Size = new System.Drawing.Size(342, 38);
            this.btnReFill.TabIndex = 4;
            this.btnReFill.Text = "Перезаполнить";
            this.btnReFill.UseVisualStyleBackColor = true;
            this.btnReFill.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 265);
            this.Controls.Add(this.btnReFill);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtOut1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox txtOut1;
        private RichTextBox txtOut;
        private Button btnGet;
        private RichTextBox txtInfo;
        private Button btnReFill;
    }
}