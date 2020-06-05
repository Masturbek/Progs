namespace Талончик
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelinput = new System.Windows.Forms.Panel();
            this.passwordclient = new Талончик.NewTextBox();
            this.loginclient = new Талончик.NewTextBox();
            this.assistant = new System.Windows.Forms.PictureBox();
            this.notregist = new System.Windows.Forms.Label();
            this.buttonenter = new System.Windows.Forms.Button();
            this.checkpassword = new System.Windows.Forms.CheckBox();
            this.phoneclient = new System.Windows.Forms.MaskedTextBox();
            this.helppassword = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.helpsurname = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.buttonregistration = new System.Windows.Forms.Button();
            this.regcheckpassword = new System.Windows.Forms.CheckBox();
            this.snilsclient = new System.Windows.Forms.MaskedTextBox();
            this.levelofdifficulty = new System.Windows.Forms.ProgressBar();
            this.panelassisant = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.regpasswordclient = new Талончик.NewTextBox();
            this.surnameclient = new Талончик.NewTextBox();
            this.nameclient = new Талончик.NewTextBox();
            this.panel1.SuspendLayout();
            this.panelinput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assistant)).BeginInit();
            this.panelassisant.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вход";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 356);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(368, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 356);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 394);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 23);
            this.panel4.TabIndex = 3;
            // 
            // panelinput
            // 
            this.panelinput.BackColor = System.Drawing.Color.LightGray;
            this.panelinput.Controls.Add(this.passwordclient);
            this.panelinput.Controls.Add(this.loginclient);
            this.panelinput.Controls.Add(this.assistant);
            this.panelinput.Controls.Add(this.notregist);
            this.panelinput.Controls.Add(this.buttonenter);
            this.panelinput.Controls.Add(this.checkpassword);
            this.panelinput.Location = new System.Drawing.Point(0, 38);
            this.panelinput.Name = "panelinput";
            this.panelinput.Size = new System.Drawing.Size(380, 356);
            this.panelinput.TabIndex = 4;
            // 
            // passwordclient
            // 
            this.passwordclient.AutoSize = true;
            this.passwordclient.BackColor = System.Drawing.Color.Transparent;
            this.passwordclient.CurrentText = "Введите пароль";
            this.passwordclient.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.passwordclient.IsPassword = true;
            this.passwordclient.Location = new System.Drawing.Point(81, 109);
            this.passwordclient.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.passwordclient.MaxLength = 25;
            this.passwordclient.Name = "passwordclient";
            this.passwordclient.PasswordVisible = false;
            this.passwordclient.SelectionStart = 0;
            this.passwordclient.Size = new System.Drawing.Size(231, 27);
            this.passwordclient.StandartText = "Введите пароль";
            this.passwordclient.TabIndex = 15;
            // 
            // loginclient
            // 
            this.loginclient.AutoSize = true;
            this.loginclient.BackColor = System.Drawing.Color.Transparent;
            this.loginclient.CurrentText = "Введите номер телефона или СНИЛС";
            this.loginclient.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.loginclient.IsPassword = false;
            this.loginclient.Location = new System.Drawing.Point(81, 51);
            this.loginclient.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.loginclient.MaxLength = 11;
            this.loginclient.Name = "loginclient";
            this.loginclient.PasswordVisible = false;
            this.loginclient.SelectionStart = 0;
            this.loginclient.Size = new System.Drawing.Size(231, 27);
            this.loginclient.StandartText = "Введите номер телефона или СНИЛС";
            this.loginclient.TabIndex = 14;
            // 
            // assistant
            // 
            this.assistant.Image = global::Талончик.Properties.Resources.icons8_вопрос_48;
            this.assistant.Location = new System.Drawing.Point(18, 307);
            this.assistant.Name = "assistant";
            this.assistant.Size = new System.Drawing.Size(44, 39);
            this.assistant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.assistant.TabIndex = 13;
            this.assistant.TabStop = false;
            this.assistant.Click += new System.EventHandler(this.Assistant_Click_1);
            // 
            // notregist
            // 
            this.notregist.AutoSize = true;
            this.notregist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notregist.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notregist.Location = new System.Drawing.Point(98, 196);
            this.notregist.Name = "notregist";
            this.notregist.Size = new System.Drawing.Size(184, 15);
            this.notregist.TabIndex = 12;
            this.notregist.Text = "* Еще не зарегистрированы ?";
            this.notregist.Click += new System.EventHandler(this.NotRegister_Click);
            // 
            // buttonenter
            // 
            this.buttonenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonenter.Location = new System.Drawing.Point(139, 247);
            this.buttonenter.Name = "buttonenter";
            this.buttonenter.Size = new System.Drawing.Size(102, 46);
            this.buttonenter.TabIndex = 11;
            this.buttonenter.Text = "Войти";
            this.buttonenter.UseVisualStyleBackColor = true;
            this.buttonenter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // checkpassword
            // 
            this.checkpassword.AutoSize = true;
            this.checkpassword.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkpassword.Location = new System.Drawing.Point(84, 139);
            this.checkpassword.Name = "checkpassword";
            this.checkpassword.Size = new System.Drawing.Size(112, 18);
            this.checkpassword.TabIndex = 10;
            this.checkpassword.Text = "Показать пароль";
            this.checkpassword.UseVisualStyleBackColor = true;
            this.checkpassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // phoneclient
            // 
            this.phoneclient.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneclient.ForeColor = System.Drawing.Color.Black;
            this.phoneclient.Location = new System.Drawing.Point(93, 169);
            this.phoneclient.Mask = "(999) 000-0000";
            this.phoneclient.Name = "phoneclient";
            this.phoneclient.Size = new System.Drawing.Size(180, 24);
            this.phoneclient.TabIndex = 29;
            this.phoneclient.TabStop = false;
            // 
            // helppassword
            // 
            this.helppassword.AutoSize = true;
            this.helppassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helppassword.Location = new System.Drawing.Point(102, 247);
            this.helppassword.Name = "helppassword";
            this.helppassword.Size = new System.Drawing.Size(66, 15);
            this.helppassword.TabIndex = 27;
            this.helppassword.Text = " Сложность";
            this.helppassword.Visible = false;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l2.Location = new System.Drawing.Point(89, 101);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(0, 15);
            this.l2.TabIndex = 25;
            // 
            // helpsurname
            // 
            this.helpsurname.AutoSize = true;
            this.helpsurname.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpsurname.Location = new System.Drawing.Point(89, 50);
            this.helpsurname.Name = "helpsurname";
            this.helpsurname.Size = new System.Drawing.Size(0, 15);
            this.helpsurname.TabIndex = 24;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(18, 345);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(54, 20);
            this.back.TabIndex = 23;
            this.back.Text = "Назад";
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // buttonregistration
            // 
            this.buttonregistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonregistration.Location = new System.Drawing.Point(128, 337);
            this.buttonregistration.Name = "buttonregistration";
            this.buttonregistration.Size = new System.Drawing.Size(234, 35);
            this.buttonregistration.TabIndex = 22;
            this.buttonregistration.Text = "Зарегистрироваться";
            this.buttonregistration.UseVisualStyleBackColor = true;
            this.buttonregistration.Click += new System.EventHandler(this.ButtonRegistration_Click);
            // 
            // regcheckpassword
            // 
            this.regcheckpassword.AutoSize = true;
            this.regcheckpassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regcheckpassword.Location = new System.Drawing.Point(94, 300);
            this.regcheckpassword.Name = "regcheckpassword";
            this.regcheckpassword.Size = new System.Drawing.Size(112, 19);
            this.regcheckpassword.TabIndex = 21;
            this.regcheckpassword.Text = "Показать пароль";
            this.regcheckpassword.UseVisualStyleBackColor = true;
            this.regcheckpassword.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // snilsclient
            // 
            this.snilsclient.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.snilsclient.ForeColor = System.Drawing.Color.Black;
            this.snilsclient.Location = new System.Drawing.Point(93, 218);
            this.snilsclient.Mask = "000-000-000-00";
            this.snilsclient.Name = "snilsclient";
            this.snilsclient.Size = new System.Drawing.Size(180, 24);
            this.snilsclient.TabIndex = 30;
            this.snilsclient.TabStop = false;
            // 
            // levelofdifficulty
            // 
            this.levelofdifficulty.BackColor = System.Drawing.Color.GhostWhite;
            this.levelofdifficulty.ForeColor = System.Drawing.SystemColors.Control;
            this.levelofdifficulty.Location = new System.Drawing.Point(174, 252);
            this.levelofdifficulty.Maximum = 40;
            this.levelofdifficulty.Name = "levelofdifficulty";
            this.levelofdifficulty.Size = new System.Drawing.Size(99, 10);
            this.levelofdifficulty.TabIndex = 31;
            // 
            // panelassisant
            // 
            this.panelassisant.BackColor = System.Drawing.Color.LightGray;
            this.panelassisant.Controls.Add(this.tabControl1);
            this.panelassisant.Location = new System.Drawing.Point(0, 38);
            this.panelassisant.Name = "panelassisant";
            this.panelassisant.Size = new System.Drawing.Size(380, 304);
            this.panelassisant.TabIndex = 0;
            this.panelassisant.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.ItemSize = new System.Drawing.Size(20, 200);
            this.tabControl1.Location = new System.Drawing.Point(18, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(344, 281);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 11;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(204, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(136, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "О приложении";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 267);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(204, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(136, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Как зарегистрироваться?";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 267);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(204, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(136, 273);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "О разработчике";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 273);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // regpasswordclient
            // 
            this.regpasswordclient.AutoSize = true;
            this.regpasswordclient.BackColor = System.Drawing.Color.Transparent;
            this.regpasswordclient.CurrentText = "Введите пароль";
            this.regpasswordclient.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.regpasswordclient.IsPassword = true;
            this.regpasswordclient.Location = new System.Drawing.Point(92, 267);
            this.regpasswordclient.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.regpasswordclient.MaxLength = 25;
            this.regpasswordclient.Name = "regpasswordclient";
            this.regpasswordclient.PasswordVisible = false;
            this.regpasswordclient.SelectionStart = 0;
            this.regpasswordclient.Size = new System.Drawing.Size(181, 24);
            this.regpasswordclient.StandartText = "Введите пароль";
            this.regpasswordclient.TabIndex = 34;
            // 
            // surnameclient
            // 
            this.surnameclient.AutoSize = true;
            this.surnameclient.BackColor = System.Drawing.Color.Transparent;
            this.surnameclient.CurrentText = "Введите вашу фамилию";
            this.surnameclient.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.surnameclient.IsPassword = false;
            this.surnameclient.Location = new System.Drawing.Point(92, 71);
            this.surnameclient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surnameclient.MaxLength = 20;
            this.surnameclient.Name = "surnameclient";
            this.surnameclient.PasswordVisible = false;
            this.surnameclient.SelectionStart = 0;
            this.surnameclient.Size = new System.Drawing.Size(181, 24);
            this.surnameclient.StandartText = "Введите вашу фамилию";
            this.surnameclient.TabIndex = 33;
            // 
            // nameclient
            // 
            this.nameclient.AutoSize = true;
            this.nameclient.BackColor = System.Drawing.Color.Transparent;
            this.nameclient.CurrentText = "Введите ваше имя";
            this.nameclient.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.nameclient.IsPassword = false;
            this.nameclient.Location = new System.Drawing.Point(92, 120);
            this.nameclient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameclient.MaxLength = 20;
            this.nameclient.Name = "nameclient";
            this.nameclient.PasswordVisible = false;
            this.nameclient.SelectionStart = 0;
            this.nameclient.Size = new System.Drawing.Size(181, 24);
            this.nameclient.StandartText = "Введите ваше имя";
            this.nameclient.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(380, 417);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelassisant);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelinput);
            this.Controls.Add(this.buttonregistration);
            this.Controls.Add(this.back);
            this.Controls.Add(this.regpasswordclient);
            this.Controls.Add(this.surnameclient);
            this.Controls.Add(this.nameclient);
            this.Controls.Add(this.phoneclient);
            this.Controls.Add(this.helppassword);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.helpsurname);
            this.Controls.Add(this.regcheckpassword);
            this.Controls.Add(this.snilsclient);
            this.Controls.Add(this.levelofdifficulty);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запись к врачу";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelinput.ResumeLayout(false);
            this.panelinput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assistant)).EndInit();
            this.panelassisant.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelinput;
        private System.Windows.Forms.Label notregist;
        private System.Windows.Forms.Button buttonenter;
        private System.Windows.Forms.CheckBox checkpassword;
        private System.Windows.Forms.MaskedTextBox phoneclient;
        private System.Windows.Forms.Label helppassword;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label helpsurname;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Button buttonregistration;
        private System.Windows.Forms.CheckBox regcheckpassword;
        private System.Windows.Forms.MaskedTextBox snilsclient;
        private System.Windows.Forms.ProgressBar levelofdifficulty;
        private System.Windows.Forms.PictureBox assistant;
        private System.Windows.Forms.Panel panelassisant;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private NewTextBox loginclient;
        private NewTextBox passwordclient;
        private NewTextBox nameclient;
        private NewTextBox surnameclient;
        private NewTextBox regpasswordclient;
    }
}

