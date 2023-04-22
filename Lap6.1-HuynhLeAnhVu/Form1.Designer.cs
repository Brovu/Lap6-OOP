namespace Lap6._1_HuynhLeAnhVu
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
            this.lblnuma = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblnumb = new System.Windows.Forms.Label();
            this.lblres = new System.Windows.Forms.Label();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnuma
            // 
            this.lblnuma.AutoSize = true;
            this.lblnuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnuma.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblnuma.Location = new System.Drawing.Point(194, 73);
            this.lblnuma.Name = "lblnuma";
            this.lblnuma.Size = new System.Drawing.Size(105, 24);
            this.lblnuma.TabIndex = 0;
            this.lblnuma.Text = "Nhập số a";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(319, 73);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(134, 20);
            this.txtA.TabIndex = 3;
            this.txtA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(319, 111);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(134, 20);
            this.txtB.TabIndex = 4;
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(319, 154);
            this.txtRes.Name = "txtRes";
            this.txtRes.ReadOnly = true;
            this.txtRes.Size = new System.Drawing.Size(134, 20);
            this.txtRes.TabIndex = 5;
            // 
            // btnSum
            // 
            this.btnSum.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.btnSum.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSum.Location = new System.Drawing.Point(94, 213);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(39, 23);
            this.btnSum.TabIndex = 6;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnClose.Location = new System.Drawing.Point(511, 209);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 27);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(614, 60);
            this.label4.TabIndex = 12;
            this.label4.Text = "CÁC PHÉP TOÁN SỐ HỌC";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblnumb
            // 
            this.lblnumb.AutoSize = true;
            this.lblnumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumb.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblnumb.Location = new System.Drawing.Point(195, 111);
            this.lblnumb.Name = "lblnumb";
            this.lblnumb.Size = new System.Drawing.Size(106, 24);
            this.lblnumb.TabIndex = 13;
            this.lblnumb.Text = "Nhập số b";
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblres.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblres.Location = new System.Drawing.Point(195, 150);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(81, 24);
            this.lblres.TabIndex = 14;
            this.lblres.Text = "Kết quả";
            // 
            // btnChia
            // 
            this.btnChia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChia.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnChia.Location = new System.Drawing.Point(335, 213);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(39, 23);
            this.btnChia.TabIndex = 16;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClear.Location = new System.Drawing.Point(432, 213);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(39, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNhan.Location = new System.Drawing.Point(251, 213);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(39, 23);
            this.btnNhan.TabIndex = 18;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnTru
            // 
            this.btnTru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTru.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTru.Location = new System.Drawing.Point(169, 213);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(39, 23);
            this.btnTru.TabIndex = 19;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(614, 269);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.lblnumb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblnuma);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Tính Toán";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnuma;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblnumb;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnTru;
    }
}

