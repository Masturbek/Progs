namespace Талончик
{
    partial class DayTab
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
            this.daylabel = new System.Windows.Forms.Label();
            this.daypanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // daylabel
            // 
            this.daylabel.AutoSize = true;
            this.daylabel.Location = new System.Drawing.Point(3, 14);
            this.daylabel.Name = "daylabel";
            this.daylabel.Size = new System.Drawing.Size(29, 13);
            this.daylabel.TabIndex = 0;
            this.daylabel.Text = "label";
            // 
            // daypanel
            // 
            this.daypanel.AutoScroll = true;
            this.daypanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.daypanel.Location = new System.Drawing.Point(3, 30);
            this.daypanel.Name = "daypanel";
            this.daypanel.Size = new System.Drawing.Size(113, 295);
            this.daypanel.TabIndex = 1;
            // 
            // DayTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.daypanel);
            this.Controls.Add(this.daylabel);
            this.Name = "DayTab";
            this.Size = new System.Drawing.Size(119, 328);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label daylabel;
        private System.Windows.Forms.FlowLayoutPanel daypanel;
    }
}
