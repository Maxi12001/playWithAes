namespace softLockTask
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
            this._ofbd = new System.Windows.Forms.Button();
            this._enc = new System.Windows.Forms.Button();
            this._dec = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.ext = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.Label();
            this.directory = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ofbd
            // 
            this._ofbd.Location = new System.Drawing.Point(176, 174);
            this._ofbd.Name = "_ofbd";
            this._ofbd.Size = new System.Drawing.Size(87, 26);
            this._ofbd.TabIndex = 0;
            this._ofbd.Text = "Select File";
            this._ofbd.UseVisualStyleBackColor = true;
            this._ofbd.Click += new System.EventHandler(this._ofbd_Click);
            // 
            // _enc
            // 
            this._enc.Location = new System.Drawing.Point(52, 39);
            this._enc.Name = "_enc";
            this._enc.Size = new System.Drawing.Size(75, 23);
            this._enc.TabIndex = 2;
            this._enc.Text = "Encrypt";
            this._enc.UseVisualStyleBackColor = true;
            this._enc.Click += new System.EventHandler(this._enc_Click);
            // 
            // _dec
            // 
            this._dec.Location = new System.Drawing.Point(52, 68);
            this._dec.Name = "_dec";
            this._dec.Size = new System.Drawing.Size(75, 23);
            this._dec.TabIndex = 3;
            this._dec.Text = "Decrypt";
            this._dec.UseVisualStyleBackColor = true;
            this._dec.Click += new System.EventHandler(this._dec_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this._ofbd);
            this.groupBox1.Location = new System.Drawing.Point(74, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 206);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "select File";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.size);
            this.groupBox2.Controls.Add(this.ext);
            this.groupBox2.Controls.Add(this.Fname);
            this.groupBox2.Controls.Add(this.directory);
            this.groupBox2.Location = new System.Drawing.Point(30, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Extension:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "File Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Directory:";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(91, 104);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(20, 17);
            this.size.TabIndex = 5;
            this.size.Text = "...";
            // 
            // ext
            // 
            this.ext.AutoSize = true;
            this.ext.Location = new System.Drawing.Point(91, 76);
            this.ext.Name = "ext";
            this.ext.Size = new System.Drawing.Size(20, 17);
            this.ext.TabIndex = 4;
            this.ext.Text = "...";
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Location = new System.Drawing.Point(91, 46);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(20, 17);
            this.Fname.TabIndex = 3;
            this.Fname.Text = "...";
            // 
            // directory
            // 
            this.directory.AutoSize = true;
            this.directory.Location = new System.Drawing.Point(91, 20);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(20, 17);
            this.directory.TabIndex = 2;
            this.directory.Text = "...";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._dec);
            this.groupBox3.Controls.Add(this._enc);
            this.groupBox3.Location = new System.Drawing.Point(198, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 115);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chose Action";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 359);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _ofbd;
        private System.Windows.Forms.Button _enc;
        private System.Windows.Forms.Button _dec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Label ext;
        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.Label directory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

