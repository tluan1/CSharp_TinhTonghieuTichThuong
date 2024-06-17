namespace CSharp_Tinhtong
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblketqua = new System.Windows.Forms.Label();
            this.btntong = new System.Windows.Forms.Button();
            this.btntich = new System.Windows.Forms.Button();
            this.btnhieu = new System.Windows.Forms.Button();
            this.btnthuong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(58, 47);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(29, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Số 1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(58, 91);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(29, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Số 2";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(126, 44);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(126, 84);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Location = new System.Drawing.Point(58, 142);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(44, 13);
            this.lblketqua.TabIndex = 5;
            this.lblketqua.Text = "Kết quả";
            // 
            // btntong
            // 
            this.btntong.Location = new System.Drawing.Point(21, 182);
            this.btntong.Name = "btntong";
            this.btntong.Size = new System.Drawing.Size(120, 44);
            this.btntong.TabIndex = 6;
            this.btntong.Text = "Tính tổng";
            this.btntong.UseVisualStyleBackColor = true;
            // 
            // btntich
            // 
            this.btntich.Location = new System.Drawing.Point(295, 182);
            this.btntich.Name = "btntich";
            this.btntich.Size = new System.Drawing.Size(120, 44);
            this.btntich.TabIndex = 7;
            this.btntich.Text = "Tính tích";
            this.btntich.UseVisualStyleBackColor = true;
            // 
            // btnhieu
            // 
            this.btnhieu.Location = new System.Drawing.Point(159, 182);
            this.btnhieu.Name = "btnhieu";
            this.btnhieu.Size = new System.Drawing.Size(120, 44);
            this.btnhieu.TabIndex = 8;
            this.btnhieu.Text = "Tính hiệu";
            this.btnhieu.UseVisualStyleBackColor = true;
            // 
            // btnthuong
            // 
            this.btnthuong.Location = new System.Drawing.Point(431, 182);
            this.btnthuong.Name = "btnthuong";
            this.btnthuong.Size = new System.Drawing.Size(120, 44);
            this.btnthuong.TabIndex = 9;
            this.btnthuong.Text = "Tính thương";
            this.btnthuong.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 307);
            this.Controls.Add(this.btnthuong);
            this.Controls.Add(this.btnhieu);
            this.Controls.Add(this.btntich);
            this.Controls.Add(this.btntong);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "chương trình tính tổng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSo1;
        private System.Windows.Forms.Button btnTinhtong;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.Label lblso2;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btnTinhthuong;
        private System.Windows.Forms.Button btnTinhtich;
        private System.Windows.Forms.Button btnTinhhieu;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.Button btntong;
        private System.Windows.Forms.Button btntich;
        private System.Windows.Forms.Button btnhieu;
        private System.Windows.Forms.Button btnthuong;
    }
}

