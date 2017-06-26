namespace register
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.btLogin = new System.Windows.Forms.Button();
			this.login = new System.Windows.Forms.TextBox();
			this.btReg = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.statusTex = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btLogin
			// 
			this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btLogin.Location = new System.Drawing.Point(203, 132);
			this.btLogin.Name = "btLogin";
			this.btLogin.Size = new System.Drawing.Size(146, 35);
			this.btLogin.TabIndex = 2;
			this.btLogin.Text = "Войти";
			this.btLogin.UseVisualStyleBackColor = true;
			this.btLogin.Click += new System.EventHandler(this.login_Click);
			// 
			// login
			// 
			this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.login.Location = new System.Drawing.Point(95, 33);
			this.login.Name = "login";
			this.login.Size = new System.Drawing.Size(257, 22);
			this.login.TabIndex = 0;
			// 
			// btReg
			// 
			this.btReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btReg.Location = new System.Drawing.Point(26, 132);
			this.btReg.Name = "btReg";
			this.btReg.Size = new System.Drawing.Size(166, 35);
			this.btReg.TabIndex = 3;
			this.btReg.Text = "Зарегистрироваться";
			this.btReg.UseVisualStyleBackColor = true;
			this.btReg.Click += new System.EventHandler(this.btReg_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(23, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Логин";
			// 
			// password
			// 
			this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.password.Location = new System.Drawing.Point(95, 68);
			this.password.Name = "password";
			this.password.PasswordChar = '*';
			this.password.Size = new System.Drawing.Size(257, 22);
			this.password.TabIndex = 1;
			this.password.Click += new System.EventHandler(this.password_Click);
			this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(23, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Пароль";
			// 
			// statusTex
			// 
			this.statusTex.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.statusTex.Location = new System.Drawing.Point(95, 102);
			this.statusTex.Name = "statusTex";
			this.statusTex.ReadOnly = true;
			this.statusTex.Size = new System.Drawing.Size(257, 13);
			this.statusTex.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.BackgroundImage = global::register.Properties.Resources._12_eye_1595;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(315, 69);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(37, 20);
			this.button1.TabIndex = 5;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(365, 194);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.statusTex);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btReg);
			this.Controls.Add(this.password);
			this.Controls.Add(this.login);
			this.Controls.Add(this.btLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "Вход";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button btReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox statusTex;
		private System.Windows.Forms.Button button1;
    }
}

