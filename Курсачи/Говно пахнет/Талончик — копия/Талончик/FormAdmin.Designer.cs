namespace Талончик
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.buttonupdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.namedoc = new System.Windows.Forms.ComboBox();
            this.specialitydoc = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.monday = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tueday = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.wenday = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.thuday = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.friday = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.satday = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.exp = new System.Windows.Forms.NumericUpDown();
            this.Sspechial = new System.Windows.Forms.TextBox();
            this.Nname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonadddata = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exp)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonupdate
            // 
            this.buttonupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonupdate.Location = new System.Drawing.Point(3, 12);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(88, 44);
            this.buttonupdate.TabIndex = 18;
            this.buttonupdate.Text = "Обновить данные";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.ButtonUpdate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Врачи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Специальность";
            // 
            // namedoc
            // 
            this.namedoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.namedoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namedoc.FormattingEnabled = true;
            this.namedoc.Location = new System.Drawing.Point(4, 128);
            this.namedoc.Name = "namedoc";
            this.namedoc.Size = new System.Drawing.Size(241, 24);
            this.namedoc.TabIndex = 15;
            // 
            // specialitydoc
            // 
            this.specialitydoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialitydoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialitydoc.FormattingEnabled = true;
            this.specialitydoc.Location = new System.Drawing.Point(4, 33);
            this.specialitydoc.Name = "specialitydoc";
            this.specialitydoc.Size = new System.Drawing.Size(241, 24);
            this.specialitydoc.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 20);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonadddata);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tab);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.exp);
            this.panel2.Controls.Add(this.Sspechial);
            this.panel2.Controls.Add(this.Nname);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(274, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 419);
            this.panel2.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(66, 69);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Удалить";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Талончик.Properties.Resources.trash;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ButtonRemove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Специальность";
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Controls.Add(this.tabPage3);
            this.tab.Controls.Add(this.tabPage4);
            this.tab.Controls.Add(this.tabPage5);
            this.tab.Controls.Add(this.tabPage6);
            this.tab.Location = new System.Drawing.Point(130, 124);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(259, 290);
            this.tab.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.monday);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(251, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пн";
            // 
            // monday
            // 
            this.monday.Location = new System.Drawing.Point(70, 7);
            this.monday.Multiline = true;
            this.monday.Name = "monday";
            this.monday.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.monday.Size = new System.Drawing.Size(120, 250);
            this.monday.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.tueday);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(251, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вт";
            // 
            // tueday
            // 
            this.tueday.Location = new System.Drawing.Point(70, 7);
            this.tueday.Multiline = true;
            this.tueday.Name = "tueday";
            this.tueday.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tueday.Size = new System.Drawing.Size(120, 250);
            this.tueday.TabIndex = 16;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.wenday);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(251, 264);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ср";
            // 
            // wenday
            // 
            this.wenday.Location = new System.Drawing.Point(70, 7);
            this.wenday.Multiline = true;
            this.wenday.Name = "wenday";
            this.wenday.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.wenday.Size = new System.Drawing.Size(120, 250);
            this.wenday.TabIndex = 17;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.thuday);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(251, 264);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Чт";
            // 
            // thuday
            // 
            this.thuday.Location = new System.Drawing.Point(70, 7);
            this.thuday.Multiline = true;
            this.thuday.Name = "thuday";
            this.thuday.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.thuday.Size = new System.Drawing.Size(120, 250);
            this.thuday.TabIndex = 17;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.friday);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(251, 264);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Пт";
            // 
            // friday
            // 
            this.friday.Location = new System.Drawing.Point(70, 7);
            this.friday.Multiline = true;
            this.friday.Name = "friday";
            this.friday.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.friday.Size = new System.Drawing.Size(120, 250);
            this.friday.TabIndex = 17;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.Controls.Add(this.satday);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(251, 264);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Сб";
            // 
            // satday
            // 
            this.satday.Location = new System.Drawing.Point(70, 7);
            this.satday.Multiline = true;
            this.satday.Name = "satday";
            this.satday.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.satday.Size = new System.Drawing.Size(120, 250);
            this.satday.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Опыт работы";
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(17, 144);
            this.exp.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(51, 20);
            this.exp.TabIndex = 4;
            // 
            // Sspechial
            // 
            this.Sspechial.Location = new System.Drawing.Point(17, 86);
            this.Sspechial.MaxLength = 40;
            this.Sspechial.Name = "Sspechial";
            this.Sspechial.Size = new System.Drawing.Size(252, 20);
            this.Sspechial.TabIndex = 3;
            // 
            // Nname
            // 
            this.Nname.Location = new System.Drawing.Point(17, 27);
            this.Nname.MaxLength = 50;
            this.Nname.Name = "Nname";
            this.Nname.Size = new System.Drawing.Size(252, 20);
            this.Nname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "ФИО";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.namedoc);
            this.panel3.Controls.Add(this.specialitydoc);
            this.panel3.Location = new System.Drawing.Point(10, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 180);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(207, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(680, 440);
            this.panel4.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 51);
            this.button3.TabIndex = 26;
            this.button3.Text = "Выйти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(12, 224);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(179, 51);
            this.button_add.TabIndex = 25;
            this.button_add.Text = "Добавить врача";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 51);
            this.button1.TabIndex = 24;
            this.button1.Text = "Поиск врача";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonadddata
            // 
            this.buttonadddata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonadddata.Location = new System.Drawing.Point(14, 191);
            this.buttonadddata.Name = "buttonadddata";
            this.buttonadddata.Size = new System.Drawing.Size(88, 44);
            this.buttonadddata.TabIndex = 23;
            this.buttonadddata.Text = "Добавить данные";
            this.buttonadddata.UseVisualStyleBackColor = true;
            this.buttonadddata.Visible = false;
            this.buttonadddata.Click += new System.EventHandler(this.ButtonAdd);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonupdate);
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Location = new System.Drawing.Point(14, 248);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(101, 162);
            this.panel5.TabIndex = 20;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 476);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.Text = "Запись к врачу";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exp)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox namedoc;
        private System.Windows.Forms.ComboBox specialitydoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox monday;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tueday;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox wenday;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox thuday;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox friday;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox satday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown exp;
        private System.Windows.Forms.TextBox Sspechial;
        private System.Windows.Forms.TextBox Nname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonadddata;
        private System.Windows.Forms.Panel panel5;
    }
}