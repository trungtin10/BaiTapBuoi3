﻿namespace WindowsFormsApp1
{
    partial class Form2
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
            this.lblmsnv = new System.Windows.Forms.Label();
            this.lblfullname = new System.Windows.Forms.Label();
            this.lblluongcb = new System.Windows.Forms.Label();
            this.txtmsnv = new System.Windows.Forms.TextBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.txtluongcb = new System.Windows.Forms.TextBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmsnv
            // 
            this.lblmsnv.AutoSize = true;
            this.lblmsnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblmsnv.Location = new System.Drawing.Point(43, 41);
            this.lblmsnv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmsnv.Name = "lblmsnv";
            this.lblmsnv.Size = new System.Drawing.Size(82, 26);
            this.lblmsnv.TabIndex = 0;
            this.lblmsnv.Text = "MSNV:";
            // 
            // lblfullname
            // 
            this.lblfullname.AutoSize = true;
            this.lblfullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblfullname.Location = new System.Drawing.Point(43, 79);
            this.lblfullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(182, 26);
            this.lblfullname.TabIndex = 1;
            this.lblfullname.Text = "Họ tên nhân viên:";
            // 
            // lblluongcb
            // 
            this.lblluongcb.AutoSize = true;
            this.lblluongcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblluongcb.Location = new System.Drawing.Point(43, 125);
            this.lblluongcb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblluongcb.Name = "lblluongcb";
            this.lblluongcb.Size = new System.Drawing.Size(109, 26);
            this.lblluongcb.TabIndex = 2;
            this.lblluongcb.Text = "Lương CB";
            // 
            // txtmsnv
            // 
            this.txtmsnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmsnv.Location = new System.Drawing.Point(229, 35);
            this.txtmsnv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmsnv.Name = "txtmsnv";
            this.txtmsnv.Size = new System.Drawing.Size(142, 32);
            this.txtmsnv.TabIndex = 3;
            // 
            // txtfullname
            // 
            this.txtfullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtfullname.Location = new System.Drawing.Point(229, 79);
            this.txtfullname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(291, 32);
            this.txtfullname.TabIndex = 4;
            // 
            // txtluongcb
            // 
            this.txtluongcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtluongcb.Location = new System.Drawing.Point(229, 119);
            this.txtluongcb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtluongcb.Name = "txtluongcb";
            this.txtluongcb.Size = new System.Drawing.Size(142, 32);
            this.txtluongcb.TabIndex = 5;
            // 
            // btnDongY
            // 
            this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDongY.Location = new System.Drawing.Point(229, 184);
            this.btnDongY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(114, 37);
            this.btnDongY.TabIndex = 6;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBoQua.Location = new System.Drawing.Point(360, 184);
            this.btnBoQua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(112, 37);
            this.btnBoQua.TabIndex = 7;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 278);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtluongcb);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.txtmsnv);
            this.Controls.Add(this.lblluongcb);
            this.Controls.Add(this.lblfullname);
            this.Controls.Add(this.lblmsnv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmsnv;
        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.Label lblluongcb;
        private System.Windows.Forms.TextBox txtmsnv;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.TextBox txtluongcb;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnBoQua;
    }
}