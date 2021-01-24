
namespace Example1
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
            this.btnListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOgrenciNoList = new System.Windows.Forms.Button();
            this.tctOgrenciNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(304, 53);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(347, 30);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Tümünü Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(304, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 452);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnOgrenciNoList
            // 
            this.btnOgrenciNoList.Location = new System.Drawing.Point(304, 89);
            this.btnOgrenciNoList.Name = "btnOgrenciNoList";
            this.btnOgrenciNoList.Size = new System.Drawing.Size(251, 23);
            this.btnOgrenciNoList.TabIndex = 2;
            this.btnOgrenciNoList.Text = "Öğrenci numarasına Göre Listele";
            this.btnOgrenciNoList.UseVisualStyleBackColor = true;
            this.btnOgrenciNoList.Click += new System.EventHandler(this.btnOgrenciNoList_Click);
            // 
            // tctOgrenciNo
            // 
            this.tctOgrenciNo.Location = new System.Drawing.Point(561, 92);
            this.tctOgrenciNo.Name = "tctOgrenciNo";
            this.tctOgrenciNo.Size = new System.Drawing.Size(90, 20);
            this.tctOgrenciNo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 652);
            this.Controls.Add(this.tctOgrenciNo);
            this.Controls.Add(this.btnOgrenciNoList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListele);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOgrenciNoList;
        private System.Windows.Forms.TextBox tctOgrenciNo;
    }
}

