
namespace SPZLAB6
{
    partial class FreeRoom
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
            this.MonthCbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FreeRoomBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MonthCbx
            // 
            this.MonthCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MonthCbx.FormattingEnabled = true;
            this.MonthCbx.Items.AddRange(new object[] {
            "Июнь",
            "Июль",
            "Август",
            "Декабрь",
            "Январь",
            "Февраль"});
            this.MonthCbx.Location = new System.Drawing.Point(179, 41);
            this.MonthCbx.Name = "MonthCbx";
            this.MonthCbx.Size = new System.Drawing.Size(180, 28);
            this.MonthCbx.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Выбрать месяц:";
            // 
            // FreeRoomBtn
            // 
            this.FreeRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FreeRoomBtn.Location = new System.Drawing.Point(119, 103);
            this.FreeRoomBtn.Name = "FreeRoomBtn";
            this.FreeRoomBtn.Size = new System.Drawing.Size(126, 41);
            this.FreeRoomBtn.TabIndex = 10;
            this.FreeRoomBtn.Text = "Освободить";
            this.FreeRoomBtn.UseVisualStyleBackColor = true;
            this.FreeRoomBtn.Click += new System.EventHandler(this.FreeRoomBtn_Click);
            // 
            // FreeRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 180);
            this.Controls.Add(this.FreeRoomBtn);
            this.Controls.Add(this.MonthCbx);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FreeRoom";
            this.Text = "FreeRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MonthCbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FreeRoomBtn;
    }
}