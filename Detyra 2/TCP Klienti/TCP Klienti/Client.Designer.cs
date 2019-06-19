namespace TCP_Klienti_Eduard
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.BWchatLog = new System.ComponentModel.BackgroundWorker();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPorti = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReceiveAnswer = new System.Windows.Forms.TextBox();
            this.grbRegjistrimi = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPaga = new System.Windows.Forms.TextBox();
            this.txtTitulli = new System.Windows.Forms.TextBox();
            this.txtEmriMbiemri = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPaga = new System.Windows.Forms.Label();
            this.lblTitulli = new System.Windows.Forms.Label();
            this.lblEmriMbiemri = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.txtUserName1 = new System.Windows.Forms.TextBox();
            this.lblPassword1 = new System.Windows.Forms.Label();
            this.lblUserName1 = new System.Windows.Forms.Label();
            this.grbRegjistrimi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnect.BackgroundImage")));
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(453, 11);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(112, 34);
            this.btnConnect.TabIndex = 21;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtIP.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtIP.Location = new System.Drawing.Point(114, 15);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(145, 26);
            this.txtIP.TabIndex = 20;
            this.txtIP.Text = "127.0.0.1";
            // 
            // txtPorti
            // 
            this.txtPorti.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPorti.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPorti.Location = new System.Drawing.Point(325, 15);
            this.txtPorti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPorti.Name = "txtPorti";
            this.txtPorti.Size = new System.Drawing.Size(100, 26);
            this.txtPorti.TabIndex = 17;
            this.txtPorti.Text = "7000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(270, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Porti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(21, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "IP Adresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(21, 506);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Përgjegja nga SERVERI";
            // 
            // txtReceiveAnswer
            // 
            this.txtReceiveAnswer.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtReceiveAnswer.ForeColor = System.Drawing.Color.White;
            this.txtReceiveAnswer.Location = new System.Drawing.Point(26, 531);
            this.txtReceiveAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReceiveAnswer.Multiline = true;
            this.txtReceiveAnswer.Name = "txtReceiveAnswer";
            this.txtReceiveAnswer.Size = new System.Drawing.Size(890, 103);
            this.txtReceiveAnswer.TabIndex = 15;
            // 
            // grbRegjistrimi
            // 
            this.grbRegjistrimi.BackColor = System.Drawing.Color.Transparent;
            this.grbRegjistrimi.Controls.Add(this.btnSave);
            this.grbRegjistrimi.Controls.Add(this.txtPassword);
            this.grbRegjistrimi.Controls.Add(this.txtUserName);
            this.grbRegjistrimi.Controls.Add(this.txtEmail);
            this.grbRegjistrimi.Controls.Add(this.txtPaga);
            this.grbRegjistrimi.Controls.Add(this.txtTitulli);
            this.grbRegjistrimi.Controls.Add(this.txtEmriMbiemri);
            this.grbRegjistrimi.Controls.Add(this.lblPassword);
            this.grbRegjistrimi.Controls.Add(this.lblEmail);
            this.grbRegjistrimi.Controls.Add(this.lblPaga);
            this.grbRegjistrimi.Controls.Add(this.lblTitulli);
            this.grbRegjistrimi.Controls.Add(this.lblEmriMbiemri);
            this.grbRegjistrimi.Controls.Add(this.lblUserName);
            this.grbRegjistrimi.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.grbRegjistrimi.Location = new System.Drawing.Point(26, 105);
            this.grbRegjistrimi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbRegjistrimi.Name = "grbRegjistrimi";
            this.grbRegjistrimi.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbRegjistrimi.Size = new System.Drawing.Size(450, 388);
            this.grbRegjistrimi.TabIndex = 22;
            this.grbRegjistrimi.TabStop = false;
            this.grbRegjistrimi.Text = "Regjistrimi i mësimdhënësit";
            this.grbRegjistrimi.Enter += new System.EventHandler(this.GrbRegjistrimi_Enter);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(306, 331);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Ruaje";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(125, 278);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(292, 26);
            this.txtPassword.TabIndex = 39;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(125, 231);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(292, 26);
            this.txtUserName.TabIndex = 38;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(125, 185);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 26);
            this.txtEmail.TabIndex = 37;
            // 
            // txtPaga
            // 
            this.txtPaga.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPaga.ForeColor = System.Drawing.Color.White;
            this.txtPaga.Location = new System.Drawing.Point(125, 139);
            this.txtPaga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPaga.Name = "txtPaga";
            this.txtPaga.Size = new System.Drawing.Size(292, 26);
            this.txtPaga.TabIndex = 36;
            this.txtPaga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaga_KeyPress);
            // 
            // txtTitulli
            // 
            this.txtTitulli.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTitulli.ForeColor = System.Drawing.Color.White;
            this.txtTitulli.Location = new System.Drawing.Point(125, 92);
            this.txtTitulli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitulli.Name = "txtTitulli";
            this.txtTitulli.Size = new System.Drawing.Size(292, 26);
            this.txtTitulli.TabIndex = 35;
            // 
            // txtEmriMbiemri
            // 
            this.txtEmriMbiemri.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEmriMbiemri.ForeColor = System.Drawing.Color.White;
            this.txtEmriMbiemri.Location = new System.Drawing.Point(125, 46);
            this.txtEmriMbiemri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmriMbiemri.Name = "txtEmriMbiemri";
            this.txtEmriMbiemri.Size = new System.Drawing.Size(292, 26);
            this.txtEmriMbiemri.TabIndex = 34;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPassword.Location = new System.Drawing.Point(30, 285);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 33;
            this.lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEmail.Location = new System.Drawing.Point(9, 186);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(105, 20);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Email adresa:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPaga
            // 
            this.lblPaga.AutoSize = true;
            this.lblPaga.BackColor = System.Drawing.Color.Transparent;
            this.lblPaga.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPaga.Location = new System.Drawing.Point(62, 140);
            this.lblPaga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaga.Name = "lblPaga";
            this.lblPaga.Size = new System.Drawing.Size(50, 20);
            this.lblPaga.TabIndex = 31;
            this.lblPaga.Text = "Paga:";
            this.lblPaga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitulli
            // 
            this.lblTitulli.AutoSize = true;
            this.lblTitulli.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulli.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitulli.Location = new System.Drawing.Point(62, 94);
            this.lblTitulli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulli.Name = "lblTitulli";
            this.lblTitulli.Size = new System.Drawing.Size(48, 20);
            this.lblTitulli.TabIndex = 30;
            this.lblTitulli.Text = "Titulli:";
            this.lblTitulli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmriMbiemri
            // 
            this.lblEmriMbiemri.AutoSize = true;
            this.lblEmriMbiemri.BackColor = System.Drawing.Color.Transparent;
            this.lblEmriMbiemri.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEmriMbiemri.Location = new System.Drawing.Point(10, 48);
            this.lblEmriMbiemri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmriMbiemri.Name = "lblEmriMbiemri";
            this.lblEmriMbiemri.Size = new System.Drawing.Size(104, 20);
            this.lblEmriMbiemri.TabIndex = 29;
            this.lblEmriMbiemri.Text = "Emri Mbiemri:";
            this.lblEmriMbiemri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUserName.Location = new System.Drawing.Point(19, 232);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(93, 20);
            this.lblUserName.TabIndex = 28;
            this.lblUserName.Text = "User Name:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnLogin);
            this.groupBox2.Controls.Add(this.txtPassword1);
            this.groupBox2.Controls.Add(this.txtUserName1);
            this.groupBox2.Controls.Add(this.lblPassword1);
            this.groupBox2.Controls.Add(this.lblUserName1);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Location = new System.Drawing.Point(485, 105);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(431, 388);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Authentifikimi";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(292, 331);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 35);
            this.btnLogin.TabIndex = 45;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword1
            // 
            this.txtPassword1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPassword1.ForeColor = System.Drawing.Color.White;
            this.txtPassword1.Location = new System.Drawing.Point(112, 208);
            this.txtPassword1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.PasswordChar = '*';
            this.txtPassword1.Size = new System.Drawing.Size(292, 26);
            this.txtPassword1.TabIndex = 44;
            // 
            // txtUserName1
            // 
            this.txtUserName1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtUserName1.ForeColor = System.Drawing.Color.White;
            this.txtUserName1.Location = new System.Drawing.Point(112, 161);
            this.txtUserName1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName1.Name = "txtUserName1";
            this.txtUserName1.Size = new System.Drawing.Size(292, 26);
            this.txtUserName1.TabIndex = 43;
            // 
            // lblPassword1
            // 
            this.lblPassword1.AutoSize = true;
            this.lblPassword1.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPassword1.Location = new System.Drawing.Point(19, 212);
            this.lblPassword1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword1.Name = "lblPassword1";
            this.lblPassword1.Size = new System.Drawing.Size(82, 20);
            this.lblPassword1.TabIndex = 42;
            this.lblPassword1.Text = "Password:";
            // 
            // lblUserName1
            // 
            this.lblUserName1.AutoSize = true;
            this.lblUserName1.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUserName1.Location = new System.Drawing.Point(9, 166);
            this.lblUserName1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName1.Name = "lblUserName1";
            this.lblUserName1.Size = new System.Drawing.Size(93, 20);
            this.lblUserName1.TabIndex = 41;
            this.lblUserName1.Text = "User Name:";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 649);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbRegjistrimi);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtPorti);
            this.Controls.Add(this.txtReceiveAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIEK-TCP Klienti";
            this.grbRegjistrimi.ResumeLayout(false);
            this.grbRegjistrimi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BWchatLog;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPorti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReceiveAnswer;
        private System.Windows.Forms.GroupBox grbRegjistrimi;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPaga;
        private System.Windows.Forms.TextBox txtTitulli;
        private System.Windows.Forms.TextBox txtEmriMbiemri;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPaga;
        private System.Windows.Forms.Label lblTitulli;
        private System.Windows.Forms.Label lblEmriMbiemri;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox txtUserName1;
        private System.Windows.Forms.Label lblPassword1;
        private System.Windows.Forms.Label lblUserName1;


    }
}

