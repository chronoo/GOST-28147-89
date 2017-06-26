namespace register
{
    partial class Comparator
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
			this.openFile1 = new System.Windows.Forms.Button();
			this.filePath1 = new System.Windows.Forms.TextBox();
			this.radioFile1 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.filePath2 = new System.Windows.Forms.TextBox();
			this.radioFile2 = new System.Windows.Forms.RadioButton();
			this.editor = new System.Windows.Forms.RichTextBox();
			this.saveBut = new System.Windows.Forms.Button();
			this.compareBut = new System.Windows.Forms.Button();
			this.hashFile1 = new System.Windows.Forms.TextBox();
			this.hashFile2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			this.label2 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFile1
			// 
			this.openFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.openFile1.Location = new System.Drawing.Point(21, 23);
			this.openFile1.Name = "openFile1";
			this.openFile1.Size = new System.Drawing.Size(115, 23);
			this.openFile1.TabIndex = 0;
			this.openFile1.Text = "Первый файл";
			this.openFile1.UseVisualStyleBackColor = true;
			this.openFile1.Click += new System.EventHandler(this.openFile1_Click);
			// 
			// filePath1
			// 
			this.filePath1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.filePath1.BackColor = System.Drawing.SystemColors.Window;
			this.filePath1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.filePath1.Location = new System.Drawing.Point(155, 25);
			this.filePath1.Name = "filePath1";
			this.filePath1.ReadOnly = true;
			this.filePath1.Size = new System.Drawing.Size(440, 22);
			this.filePath1.TabIndex = 1;
			// 
			// radioFile1
			// 
			this.radioFile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.radioFile1.AutoSize = true;
			this.radioFile1.Checked = true;
			this.radioFile1.Location = new System.Drawing.Point(613, 28);
			this.radioFile1.Name = "radioFile1";
			this.radioFile1.Size = new System.Drawing.Size(14, 13);
			this.radioFile1.TabIndex = 2;
			this.radioFile1.TabStop = true;
			this.radioFile1.UseVisualStyleBackColor = true;
			this.radioFile1.CheckedChanged += new System.EventHandler(this.radioFile1_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(21, 62);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Второй файл";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// filePath2
			// 
			this.filePath2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.filePath2.BackColor = System.Drawing.SystemColors.Window;
			this.filePath2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.filePath2.Location = new System.Drawing.Point(155, 64);
			this.filePath2.Name = "filePath2";
			this.filePath2.ReadOnly = true;
			this.filePath2.Size = new System.Drawing.Size(440, 22);
			this.filePath2.TabIndex = 1;
			// 
			// radioFile2
			// 
			this.radioFile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.radioFile2.AutoSize = true;
			this.radioFile2.Location = new System.Drawing.Point(613, 67);
			this.radioFile2.Name = "radioFile2";
			this.radioFile2.Size = new System.Drawing.Size(14, 13);
			this.radioFile2.TabIndex = 2;
			this.radioFile2.UseVisualStyleBackColor = true;
			// 
			// editor
			// 
			this.editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.editor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.editor.Location = new System.Drawing.Point(21, 110);
			this.editor.Name = "editor";
			this.editor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.editor.Size = new System.Drawing.Size(606, 166);
			this.editor.TabIndex = 2;
			this.editor.Text = "";
			// 
			// saveBut
			// 
			this.saveBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.saveBut.Location = new System.Drawing.Point(444, 291);
			this.saveBut.Name = "saveBut";
			this.saveBut.Size = new System.Drawing.Size(88, 23);
			this.saveBut.TabIndex = 3;
			this.saveBut.Text = "Сохранить";
			this.saveBut.UseVisualStyleBackColor = true;
			this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
			// 
			// compareBut
			// 
			this.compareBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.compareBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.compareBut.Location = new System.Drawing.Point(538, 291);
			this.compareBut.Name = "compareBut";
			this.compareBut.Size = new System.Drawing.Size(89, 23);
			this.compareBut.TabIndex = 4;
			this.compareBut.Text = "Сравнить";
			this.compareBut.UseVisualStyleBackColor = true;
			this.compareBut.Click += new System.EventHandler(this.compareBut_Click);
			// 
			// hashFile1
			// 
			this.hashFile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.hashFile1.BackColor = System.Drawing.SystemColors.Window;
			this.hashFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.hashFile1.Location = new System.Drawing.Point(506, 330);
			this.hashFile1.Name = "hashFile1";
			this.hashFile1.ReadOnly = true;
			this.hashFile1.Size = new System.Drawing.Size(121, 22);
			this.hashFile1.TabIndex = 1;
			this.hashFile1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// hashFile2
			// 
			this.hashFile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.hashFile2.BackColor = System.Drawing.SystemColors.Window;
			this.hashFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.hashFile2.Location = new System.Drawing.Point(506, 369);
			this.hashFile2.Name = "hashFile2";
			this.hashFile2.ReadOnly = true;
			this.hashFile2.Size = new System.Drawing.Size(121, 22);
			this.hashFile2.TabIndex = 1;
			this.hashFile2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(294, 333);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(206, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Имитовставка первого файла";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.InitialDirectory = "D:\\prog\\gost";
			// 
			// openFileDialog2
			// 
			this.openFileDialog2.InitialDirectory = "D:\\prog\\gost";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(295, 372);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(205, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Имитовставка второго файла";
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(15, 27);
			this.trackBar1.Maximum = 32;
			this.trackBar1.Minimum = 1;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(163, 45);
			this.trackBar1.TabIndex = 6;
			this.trackBar1.Value = 32;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(82, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 18);
			this.label3.TabIndex = 7;
			this.label3.Text = "32";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(157, 65);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(22, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "32";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(18, 65);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(15, 16);
			this.label6.TabIndex = 8;
			this.label6.Text = "1";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.trackBar1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(21, 298);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(206, 93);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Размер имитовставки (бит)";
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(342, 291);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(96, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "Тест";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Comparator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(653, 409);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.editor);
			this.Controls.Add(this.radioFile2);
			this.Controls.Add(this.radioFile1);
			this.Controls.Add(this.hashFile2);
			this.Controls.Add(this.filePath2);
			this.Controls.Add(this.hashFile1);
			this.Controls.Add(this.filePath1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.compareBut);
			this.Controls.Add(this.saveBut);
			this.Controls.Add(this.openFile1);
			this.Name = "Comparator";
			this.Text = "Сравнение";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Comparator_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFile1;
        private System.Windows.Forms.TextBox filePath1;
        private System.Windows.Forms.RadioButton radioFile1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox filePath2;
        private System.Windows.Forms.RadioButton radioFile2;
        private System.Windows.Forms.RichTextBox editor;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.Button compareBut;
        private System.Windows.Forms.TextBox hashFile1;
        private System.Windows.Forms.TextBox hashFile2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button2;
    }
}