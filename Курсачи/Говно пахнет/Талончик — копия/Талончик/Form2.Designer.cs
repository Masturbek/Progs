namespace Талончик
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonexit = new System.Windows.Forms.Button();
            this.Myzapis = new System.Windows.Forms.Button();
            this.buttonzapis = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelzapis = new System.Windows.Forms.Panel();
            this.message = new System.Windows.Forms.Label();
            this.dayTab1 = new Талончик.DayTab();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.namedoc = new System.Windows.Forms.ComboBox();
            this.specialitydoc = new System.Windows.Forms.ComboBox();
            this.panelassisant = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.assistant = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelzapis.SuspendLayout();
            this.panelassisant.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assistant)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 395);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(743, 30);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Запись к врачу";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Талончик.Properties.Resources.doc;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(743, 0);
            this.panel7.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.buttonexit);
            this.panel2.Controls.Add(this.Myzapis);
            this.panel2.Controls.Add(this.buttonzapis);
            this.panel2.Location = new System.Drawing.Point(21, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 395);
            this.panel2.TabIndex = 1;
            // 
            // buttonexit
            // 
            this.buttonexit.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.Location = new System.Drawing.Point(18, 274);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(103, 55);
            this.buttonexit.TabIndex = 2;
            this.buttonexit.Text = "Выход";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Myzapis
            // 
            this.Myzapis.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Myzapis.Location = new System.Drawing.Point(18, 170);
            this.Myzapis.Name = "Myzapis";
            this.Myzapis.Size = new System.Drawing.Size(103, 55);
            this.Myzapis.TabIndex = 1;
            this.Myzapis.Text = "Мои записи";
            this.Myzapis.UseVisualStyleBackColor = true;
            this.Myzapis.Click += new System.EventHandler(this.Myzapis_Click);
            // 
            // buttonzapis
            // 
            this.buttonzapis.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonzapis.Location = new System.Drawing.Point(18, 66);
            this.buttonzapis.Name = "buttonzapis";
            this.buttonzapis.Size = new System.Drawing.Size(103, 55);
            this.buttonzapis.TabIndex = 0;
            this.buttonzapis.Text = "Записаться";
            this.buttonzapis.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(161, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 395);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 383);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(743, 12);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.Controls.Add(this.panelzapis);
            this.panel6.Controls.Add(this.panelassisant);
            this.panel6.Controls.Add(this.assistant);
            this.panel6.Location = new System.Drawing.Point(177, 29);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(566, 354);
            this.panel6.TabIndex = 4;
            // 
            // panelzapis
            // 
            this.panelzapis.Controls.Add(this.message);
            this.panelzapis.Controls.Add(this.dayTab1);
            this.panelzapis.Controls.Add(this.label5);
            this.panelzapis.Controls.Add(this.label4);
            this.panelzapis.Controls.Add(this.dateTimePicker1);
            this.panelzapis.Controls.Add(this.namedoc);
            this.panelzapis.Controls.Add(this.specialitydoc);
            this.panelzapis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelzapis.Location = new System.Drawing.Point(0, 0);
            this.panelzapis.Name = "panelzapis";
            this.panelzapis.Size = new System.Drawing.Size(566, 354);
            this.panelzapis.TabIndex = 0;
            this.panelzapis.Visible = false;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.message.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.message.Location = new System.Drawing.Point(388, 110);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(175, 22);
            this.message.TabIndex = 7;
            this.message.Text = "У врача не рабочий день";
            this.message.Visible = false;
            // 
            // dayTab1
            // 
            this.dayTab1.Location = new System.Drawing.Point(422, 3);
            this.dayTab1.Name = "dayTab1";
            this.dayTab1.SelectedDay = "label";
            this.dayTab1.Size = new System.Drawing.Size(123, 338);
            this.dayTab1.TabIndex = 8;
            this.dayTab1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "ФИО Врача";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Специальность";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(264, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 23);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Visible = false;
            // 
            // namedoc
            // 
            this.namedoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.namedoc.Font = new System.Drawing.Font("Arial Narrow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namedoc.FormattingEnabled = true;
            this.namedoc.Location = new System.Drawing.Point(15, 110);
            this.namedoc.Name = "namedoc";
            this.namedoc.Size = new System.Drawing.Size(231, 24);
            this.namedoc.TabIndex = 1;
            // 
            // specialitydoc
            // 
            this.specialitydoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialitydoc.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialitydoc.FormattingEnabled = true;
            this.specialitydoc.Location = new System.Drawing.Point(15, 32);
            this.specialitydoc.Name = "specialitydoc";
            this.specialitydoc.Size = new System.Drawing.Size(231, 24);
            this.specialitydoc.TabIndex = 0;
            // 
            // panelassisant
            // 
            this.panelassisant.BackColor = System.Drawing.Color.Gainsboro;
            this.panelassisant.Controls.Add(this.tabControl1);
            this.panelassisant.Location = new System.Drawing.Point(15, 13);
            this.panelassisant.Name = "panelassisant";
            this.panelassisant.Size = new System.Drawing.Size(432, 287);
            this.panelassisant.TabIndex = 33;
            this.panelassisant.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.ItemSize = new System.Drawing.Size(20, 200);
            this.tabControl1.Location = new System.Drawing.Point(6, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(423, 269);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 11;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabControl1_DrawItem_1);
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
            this.tabPage1.Size = new System.Drawing.Size(215, 261);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Как записаться?";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 255);
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
            this.tabPage2.Size = new System.Drawing.Size(215, 261);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Мои записи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 255);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // assistant
            // 
            this.assistant.Image = global::Талончик.Properties.Resources.icons8_вопрос_48;
            this.assistant.Location = new System.Drawing.Point(5, 309);
            this.assistant.Name = "assistant";
            this.assistant.Size = new System.Drawing.Size(44, 39);
            this.assistant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.assistant.TabIndex = 14;
            this.assistant.TabStop = false;
            this.assistant.Click += new System.EventHandler(this.Assistant_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 395);
            this.ControlBox = false;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Талончик";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelzapis.ResumeLayout(false);
            this.panelzapis.PerformLayout();
            this.panelassisant.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assistant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button Myzapis;
        private System.Windows.Forms.Button buttonzapis;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelzapis;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox namedoc;
        private System.Windows.Forms.ComboBox specialitydoc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox assistant;
        private System.Windows.Forms.Panel panelassisant;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.FlowLayoutPanel Fpanel = new System.Windows.Forms.FlowLayoutPanel();
        private DayTab dayTab1;

    }
}