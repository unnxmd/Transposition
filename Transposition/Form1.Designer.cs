﻿namespace Transposition
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
            this.listBoxEncrypt = new System.Windows.Forms.ListBox();
            this.listBoxDecrypt = new System.Windows.Forms.ListBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxEncrypt
            // 
            this.listBoxEncrypt.AllowDrop = true;
            this.listBoxEncrypt.FormattingEnabled = true;
            this.listBoxEncrypt.ItemHeight = 16;
            this.listBoxEncrypt.Location = new System.Drawing.Point(13, 13);
            this.listBoxEncrypt.Name = "listBoxEncrypt";
            this.listBoxEncrypt.Size = new System.Drawing.Size(358, 244);
            this.listBoxEncrypt.TabIndex = 0;
            this.listBoxEncrypt.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxEncrypt_DragDrop);
            this.listBoxEncrypt.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            // 
            // listBoxDecrypt
            // 
            this.listBoxDecrypt.AllowDrop = true;
            this.listBoxDecrypt.FormattingEnabled = true;
            this.listBoxDecrypt.ItemHeight = 16;
            this.listBoxDecrypt.Location = new System.Drawing.Point(391, 12);
            this.listBoxDecrypt.Name = "listBoxDecrypt";
            this.listBoxDecrypt.Size = new System.Drawing.Size(358, 244);
            this.listBoxDecrypt.TabIndex = 1;
            this.listBoxDecrypt.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxDecrypt_DragDrop);
            this.listBoxDecrypt.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(13, 264);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(358, 26);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            this.buttonEncrypt.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(391, 261);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(358, 26);
            this.buttonDecrypt.TabIndex = 3;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 299);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.listBoxDecrypt);
            this.Controls.Add(this.listBoxEncrypt);
            this.Name = "Form1";
            this.Text = "Transposition";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEncrypt;
        private System.Windows.Forms.ListBox listBoxDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
    }
}

