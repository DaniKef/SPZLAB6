
namespace SPZLAB6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IsHolidayCbx = new System.Windows.Forms.CheckBox();
            this.RoomsLbx = new System.Windows.Forms.ListBox();
            this.BookBtn = new System.Windows.Forms.Button();
            this.FreeRoomBtn = new System.Windows.Forms.Button();
            this.SaveToXMLBtn = new System.Windows.Forms.Button();
            this.XMLTextTbx = new System.Windows.Forms.TextBox();
            this.ShowXMLBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сезоны отпусков:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(160, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Лето, Зима";
            // 
            // IsHolidayCbx
            // 
            this.IsHolidayCbx.AutoSize = true;
            this.IsHolidayCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsHolidayCbx.Location = new System.Drawing.Point(54, 43);
            this.IsHolidayCbx.Name = "IsHolidayCbx";
            this.IsHolidayCbx.Size = new System.Drawing.Size(146, 24);
            this.IsHolidayCbx.TabIndex = 3;
            this.IsHolidayCbx.Text = "Сейчас отпуск?";
            this.IsHolidayCbx.UseVisualStyleBackColor = true;
            // 
            // RoomsLbx
            // 
            this.RoomsLbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomsLbx.FormattingEnabled = true;
            this.RoomsLbx.ItemHeight = 20;
            this.RoomsLbx.Location = new System.Drawing.Point(16, 96);
            this.RoomsLbx.Name = "RoomsLbx";
            this.RoomsLbx.Size = new System.Drawing.Size(490, 324);
            this.RoomsLbx.TabIndex = 4;
            // 
            // BookBtn
            // 
            this.BookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookBtn.Location = new System.Drawing.Point(512, 193);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(119, 35);
            this.BookBtn.TabIndex = 5;
            this.BookBtn.Text = "Записаться";
            this.BookBtn.UseVisualStyleBackColor = true;
            this.BookBtn.Click += new System.EventHandler(this.BookBtn_Click);
            // 
            // FreeRoomBtn
            // 
            this.FreeRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FreeRoomBtn.Location = new System.Drawing.Point(512, 268);
            this.FreeRoomBtn.Name = "FreeRoomBtn";
            this.FreeRoomBtn.Size = new System.Drawing.Size(119, 35);
            this.FreeRoomBtn.TabIndex = 6;
            this.FreeRoomBtn.Text = "Освободить";
            this.FreeRoomBtn.UseVisualStyleBackColor = true;
            this.FreeRoomBtn.Click += new System.EventHandler(this.FreeRoomBtn_Click);
            // 
            // SaveToXMLBtn
            // 
            this.SaveToXMLBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveToXMLBtn.Location = new System.Drawing.Point(512, 12);
            this.SaveToXMLBtn.Name = "SaveToXMLBtn";
            this.SaveToXMLBtn.Size = new System.Drawing.Size(119, 58);
            this.SaveToXMLBtn.TabIndex = 7;
            this.SaveToXMLBtn.Text = "Сохранить отчет в XML";
            this.SaveToXMLBtn.UseVisualStyleBackColor = true;
            this.SaveToXMLBtn.Click += new System.EventHandler(this.SaveToXMLBtn_Click);
            // 
            // XMLTextTbx
            // 
            this.XMLTextTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XMLTextTbx.Location = new System.Drawing.Point(657, 9);
            this.XMLTextTbx.Multiline = true;
            this.XMLTextTbx.Name = "XMLTextTbx";
            this.XMLTextTbx.ReadOnly = true;
            this.XMLTextTbx.Size = new System.Drawing.Size(301, 327);
            this.XMLTextTbx.TabIndex = 8;
            // 
            // ShowXMLBtn
            // 
            this.ShowXMLBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowXMLBtn.Location = new System.Drawing.Point(741, 361);
            this.ShowXMLBtn.Name = "ShowXMLBtn";
            this.ShowXMLBtn.Size = new System.Drawing.Size(145, 59);
            this.ShowXMLBtn.TabIndex = 9;
            this.ShowXMLBtn.Text = "Просмотреть XML";
            this.ShowXMLBtn.UseVisualStyleBackColor = true;
            this.ShowXMLBtn.Click += new System.EventHandler(this.ShowXMLBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.ShowXMLBtn);
            this.Controls.Add(this.XMLTextTbx);
            this.Controls.Add(this.SaveToXMLBtn);
            this.Controls.Add(this.FreeRoomBtn);
            this.Controls.Add(this.BookBtn);
            this.Controls.Add(this.RoomsLbx);
            this.Controls.Add(this.IsHolidayCbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox IsHolidayCbx;
        private System.Windows.Forms.ListBox RoomsLbx;
        private System.Windows.Forms.Button BookBtn;
        private System.Windows.Forms.Button FreeRoomBtn;
        private System.Windows.Forms.Button SaveToXMLBtn;
        private System.Windows.Forms.TextBox XMLTextTbx;
        private System.Windows.Forms.Button ShowXMLBtn;
    }
}

