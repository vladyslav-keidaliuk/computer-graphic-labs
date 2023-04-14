using System.ComponentModel;

namespace CompGraphic
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Transfer_button = new System.Windows.Forms.Button();
            this.X_transfer_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Y_transfer_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.angle_rotate_textbox = new System.Windows.Forms.TextBox();
            this.Rotate_button = new System.Windows.Forms.Button();
            this.Stretch_Compress_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.X_strech_compress_textbox = new System.Windows.Forms.TextBox();
            this.Y_strech_compress_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Scale_textbox = new System.Windows.Forms.TextBox();
            this.Scale_button = new System.Windows.Forms.Button();
            this.MirrorOX_button = new System.Windows.Forms.Button();
            this.Mirror_OY_button = new System.Windows.Forms.Button();
            this.Rotate_Transfer_Scale_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(11, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 999);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1010, 916);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сброс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Transfer_button
            // 
            this.Transfer_button.Location = new System.Drawing.Point(1137, 786);
            this.Transfer_button.Name = "Transfer_button";
            this.Transfer_button.Size = new System.Drawing.Size(149, 52);
            this.Transfer_button.TabIndex = 2;
            this.Transfer_button.Text = "Перенести";
            this.Transfer_button.UseVisualStyleBackColor = true;
            this.Transfer_button.Click += new System.EventHandler(this.Transfer_button_Click);
            // 
            // X_transfer_textbox
            // 
            this.X_transfer_textbox.Location = new System.Drawing.Point(1010, 801);
            this.X_transfer_textbox.Name = "X_transfer_textbox";
            this.X_transfer_textbox.Size = new System.Drawing.Size(43, 22);
            this.X_transfer_textbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1019, 781);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Y_transfer_textbox
            // 
            this.Y_transfer_textbox.Location = new System.Drawing.Point(1070, 801);
            this.Y_transfer_textbox.Name = "Y_transfer_textbox";
            this.Y_transfer_textbox.Size = new System.Drawing.Size(43, 22);
            this.Y_transfer_textbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1079, 781);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y";
            // 
            // angle_rotate_textbox
            // 
            this.angle_rotate_textbox.Location = new System.Drawing.Point(1010, 719);
            this.angle_rotate_textbox.Name = "angle_rotate_textbox";
            this.angle_rotate_textbox.Size = new System.Drawing.Size(43, 22);
            this.angle_rotate_textbox.TabIndex = 7;
            // 
            // Rotate_button
            // 
            this.Rotate_button.Location = new System.Drawing.Point(1079, 704);
            this.Rotate_button.Name = "Rotate_button";
            this.Rotate_button.Size = new System.Drawing.Size(207, 52);
            this.Rotate_button.TabIndex = 8;
            this.Rotate_button.Text = "Повернуть на _ градусов";
            this.Rotate_button.UseVisualStyleBackColor = true;
            this.Rotate_button.Click += new System.EventHandler(this.Rotate_button_Click);
            // 
            // Stretch_Compress_button
            // 
            this.Stretch_Compress_button.Location = new System.Drawing.Point(1137, 642);
            this.Stretch_Compress_button.Name = "Stretch_Compress_button";
            this.Stretch_Compress_button.Size = new System.Drawing.Size(149, 45);
            this.Stretch_Compress_button.TabIndex = 9;
            this.Stretch_Compress_button.Text = "Растянуть/Сжать";
            this.Stretch_Compress_button.UseVisualStyleBackColor = true;
            this.Stretch_Compress_button.Click += new System.EventHandler(this.Stretch_Compress_button_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1019, 630);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "X";
            // 
            // X_strech_compress_textbox
            // 
            this.X_strech_compress_textbox.Location = new System.Drawing.Point(1010, 653);
            this.X_strech_compress_textbox.Name = "X_strech_compress_textbox";
            this.X_strech_compress_textbox.Size = new System.Drawing.Size(43, 22);
            this.X_strech_compress_textbox.TabIndex = 11;
            // 
            // Y_strech_compress_textbox
            // 
            this.Y_strech_compress_textbox.Location = new System.Drawing.Point(1070, 653);
            this.Y_strech_compress_textbox.Name = "Y_strech_compress_textbox";
            this.Y_strech_compress_textbox.Size = new System.Drawing.Size(43, 22);
            this.Y_strech_compress_textbox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1079, 630);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Y";
            // 
            // Scale_textbox
            // 
            this.Scale_textbox.Location = new System.Drawing.Point(1010, 577);
            this.Scale_textbox.Name = "Scale_textbox";
            this.Scale_textbox.Size = new System.Drawing.Size(43, 22);
            this.Scale_textbox.TabIndex = 14;
            // 
            // Scale_button
            // 
            this.Scale_button.Location = new System.Drawing.Point(1098, 566);
            this.Scale_button.Name = "Scale_button";
            this.Scale_button.Size = new System.Drawing.Size(188, 45);
            this.Scale_button.TabIndex = 15;
            this.Scale_button.Text = "Изменить масштаб";
            this.Scale_button.UseVisualStyleBackColor = true;
            this.Scale_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // MirrorOX_button
            // 
            this.MirrorOX_button.Location = new System.Drawing.Point(1130, 427);
            this.MirrorOX_button.Name = "MirrorOX_button";
            this.MirrorOX_button.Size = new System.Drawing.Size(156, 48);
            this.MirrorOX_button.TabIndex = 16;
            this.MirrorOX_button.Text = "Отразить по ОХ";
            this.MirrorOX_button.UseVisualStyleBackColor = true;
            this.MirrorOX_button.Click += new System.EventHandler(this.MirrorOX_button_Click);
            // 
            // Mirror_OY_button
            // 
            this.Mirror_OY_button.Location = new System.Drawing.Point(1130, 481);
            this.Mirror_OY_button.Name = "Mirror_OY_button";
            this.Mirror_OY_button.Size = new System.Drawing.Size(156, 48);
            this.Mirror_OY_button.TabIndex = 17;
            this.Mirror_OY_button.Text = "Отразить по ОУ";
            this.Mirror_OY_button.UseVisualStyleBackColor = true;
            this.Mirror_OY_button.Click += new System.EventHandler(this.Mirror_OY_button_Click);
            // 
            // Rotate_Transfer_Scale_button
            // 
            this.Rotate_Transfer_Scale_button.Location = new System.Drawing.Point(1010, 856);
            this.Rotate_Transfer_Scale_button.Name = "Rotate_Transfer_Scale_button";
            this.Rotate_Transfer_Scale_button.Size = new System.Drawing.Size(276, 44);
            this.Rotate_Transfer_Scale_button.TabIndex = 18;
            this.Rotate_Transfer_Scale_button.Text = "Поворот на 45 градусов + перенести на 100,100 и 2х зум";
            this.Rotate_Transfer_Scale_button.UseVisualStyleBackColor = true;
            this.Rotate_Transfer_Scale_button.Click += new System.EventHandler(this.Rotate_Transfer_Scale_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 1021);
            this.Controls.Add(this.Rotate_Transfer_Scale_button);
            this.Controls.Add(this.Mirror_OY_button);
            this.Controls.Add(this.MirrorOX_button);
            this.Controls.Add(this.Scale_button);
            this.Controls.Add(this.Scale_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Y_strech_compress_textbox);
            this.Controls.Add(this.X_strech_compress_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Stretch_Compress_button);
            this.Controls.Add(this.Rotate_button);
            this.Controls.Add(this.angle_rotate_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Y_transfer_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.X_transfer_textbox);
            this.Controls.Add(this.Transfer_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button Rotate_Transfer_Scale_button;

        private System.Windows.Forms.Button Mirror_OY_button;

        private System.Windows.Forms.Button MirrorOX_button;

        private System.Windows.Forms.TextBox Scale_textbox;
        private System.Windows.Forms.Button Scale_button;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox X_strech_compress_textbox;
        private System.Windows.Forms.TextBox Y_strech_compress_textbox;

        private System.Windows.Forms.Button Stretch_Compress_button;

        private System.Windows.Forms.TextBox angle_rotate_textbox;
        private System.Windows.Forms.Button Rotate_button;

        private System.Windows.Forms.TextBox Y_transfer_textbox;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox X_transfer_textbox;

        private System.Windows.Forms.Button Transfer_button;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}