namespace Талончик
{
    partial class Buttonchik
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textbutton = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.textbutton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 43);
            this.panel1.TabIndex = 0;
            // 
            // textbutton
            // 
            this.textbutton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.textbutton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbutton.Location = new System.Drawing.Point(0, 0);
            this.textbutton.Name = "textbutton";
            this.textbutton.Size = new System.Drawing.Size(75, 43);
            this.textbutton.TabIndex = 0;
            this.textbutton.Text = "textbutton";
            this.textbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textbutton.Click += new System.EventHandler(this.textbutton_Click);
            this.textbutton.MouseEnter += new System.EventHandler(this.textbutton_MouseEnter);
            this.textbutton.MouseLeave += new System.EventHandler(this.textbutton_MouseLeave);
            // 
            // Buttonchik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "Buttonchik";
            this.Size = new System.Drawing.Size(79, 47);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label textbutton;
    }
}
