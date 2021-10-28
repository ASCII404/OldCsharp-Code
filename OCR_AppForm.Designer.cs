using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCR
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.button_LoadImages = new System.Windows.Forms.Button();
            this.button_ClearText = new System.Windows.Forms.Button();
            this.pictureBox_main = new System.Windows.Forms.PictureBox();
            this.listbox_LoadedItems = new System.Windows.Forms.ListBox();
            this.label_status = new System.Windows.Forms.Label();
            this.label_statusCheck = new System.Windows.Forms.Label();
            this.button_ClearList = new System.Windows.Forms.Button();
            this.button_applyOcr = new System.Windows.Forms.Button();
            this.label_OcrResult = new System.Windows.Forms.Label();
            this.textBox_Ocr = new System.Windows.Forms.TextBox();
            this.label_resultedText = new System.Windows.Forms.Label();
            this.button_Help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).BeginInit();
            this.SuspendLayout();
            // 
            // button_LoadImages
            // 
            this.button_LoadImages.Location = new System.Drawing.Point(22, 41);
            this.button_LoadImages.Name = "button_LoadImages";
            this.button_LoadImages.Size = new System.Drawing.Size(171, 28);
            this.button_LoadImages.TabIndex = 0;
            this.button_LoadImages.Text = "Load Images";
            this.button_LoadImages.UseVisualStyleBackColor = true;
            this.button_LoadImages.Click += new System.EventHandler(this.LoadImage_button_Click);
            // 
            // button_ClearText
            // 
            this.button_ClearText.Location = new System.Drawing.Point(22, 75);
            this.button_ClearText.Name = "button_ClearText";
            this.button_ClearText.Size = new System.Drawing.Size(171, 28);
            this.button_ClearText.TabIndex = 1;
            this.button_ClearText.Text = "Clear Text";
            this.button_ClearText.UseVisualStyleBackColor = true;
            this.button_ClearText.Click += new System.EventHandler(this.ClearText_Click);
            // 
            // pictureBox_main
            // 
            this.pictureBox_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_main.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_main.Image")));
            this.pictureBox_main.Location = new System.Drawing.Point(654, 12);
            this.pictureBox_main.Name = "pictureBox_main";
            this.pictureBox_main.Size = new System.Drawing.Size(363, 353);
            this.pictureBox_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_main.TabIndex = 2;
            this.pictureBox_main.TabStop = false;
            this.pictureBox_main.WaitOnLoad = true;
            this.pictureBox_main.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // listbox_LoadedItems
            // 
            this.listbox_LoadedItems.BackColor = System.Drawing.Color.White;
            this.listbox_LoadedItems.FormattingEnabled = true;
            this.listbox_LoadedItems.Location = new System.Drawing.Point(13, 119);
            this.listbox_LoadedItems.Name = "listbox_LoadedItems";
            this.listbox_LoadedItems.Size = new System.Drawing.Size(306, 186);
            this.listbox_LoadedItems.TabIndex = 3;
            this.listbox_LoadedItems.SelectedIndexChanged += new System.EventHandler(this.ListBox_LoadedItems_SelectedIndexChanged);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_status.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_status.Location = new System.Drawing.Point(10, 9);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(40, 13);
            this.label_status.TabIndex = 4;
            this.label_status.Text = "Status:";
            this.label_status.Click += new System.EventHandler(this.StatusLabel_Click);
            // 
            // label_statusCheck
            // 
            this.label_statusCheck.AutoSize = true;
            this.label_statusCheck.BackColor = System.Drawing.Color.Transparent;
            this.label_statusCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_statusCheck.ForeColor = System.Drawing.Color.Red;
            this.label_statusCheck.Location = new System.Drawing.Point(56, 9);
            this.label_statusCheck.Name = "label_statusCheck";
            this.label_statusCheck.Size = new System.Drawing.Size(89, 13);
            this.label_statusCheck.TabIndex = 5;
            this.label_statusCheck.Text = "Nothing Selected";
            this.label_statusCheck.Click += new System.EventHandler(this.StatusCheckLabel_Click);
            // 
            // button_ClearList
            // 
            this.button_ClearList.Enabled = false;
            this.button_ClearList.Location = new System.Drawing.Point(15, 324);
            this.button_ClearList.Name = "button_ClearList";
            this.button_ClearList.Size = new System.Drawing.Size(178, 29);
            this.button_ClearList.TabIndex = 6;
            this.button_ClearList.Text = "Clear list";
            this.button_ClearList.UseVisualStyleBackColor = true;
            this.button_ClearList.Click += new System.EventHandler(this.ClearList_Box_Click);
            // 
            // button_applyOcr
            // 
            this.button_applyOcr.Location = new System.Drawing.Point(211, 324);
            this.button_applyOcr.Name = "button_applyOcr";
            this.button_applyOcr.Size = new System.Drawing.Size(107, 28);
            this.button_applyOcr.TabIndex = 7;
            this.button_applyOcr.Text = "Apply_OCR";
            this.button_applyOcr.UseVisualStyleBackColor = true;
            this.button_applyOcr.Click += new System.EventHandler(this.ApplyOcr_Click);
            // 
            // label_OcrResult
            // 
            this.label_OcrResult.AutoSize = true;
            this.label_OcrResult.Location = new System.Drawing.Point(408, 30);
            this.label_OcrResult.Name = "label_OcrResult";
            this.label_OcrResult.Size = new System.Drawing.Size(0, 13);
            this.label_OcrResult.TabIndex = 8;
            // 
            // textBox_Ocr
            // 
            this.textBox_Ocr.Location = new System.Drawing.Point(349, 46);
            this.textBox_Ocr.Multiline = true;
            this.textBox_Ocr.Name = "textBox_Ocr";
            this.textBox_Ocr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Ocr.Size = new System.Drawing.Size(267, 319);
            this.textBox_Ocr.TabIndex = 9;
            // 
            // label_resultedText
            // 
            this.label_resultedText.AutoSize = true;
            this.label_resultedText.BackColor = System.Drawing.Color.Transparent;
            this.label_resultedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultedText.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_resultedText.Location = new System.Drawing.Point(427, 12);
            this.label_resultedText.Name = "label_resultedText";
            this.label_resultedText.Size = new System.Drawing.Size(108, 24);
            this.label_resultedText.TabIndex = 10;
            this.label_resultedText.Text = "OCR Result";
            this.label_resultedText.Click += new System.EventHandler(this.label_resultedText_Click);
            // 
            // button_Help
            // 
            this.button_Help.Location = new System.Drawing.Point(235, 41);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(83, 59);
            this.button_Help.TabIndex = 11;
            this.button_Help.Text = "HELP";
            this.button_Help.UseVisualStyleBackColor = true;
            this.button_Help.Click += new System.EventHandler(this.Button_Help_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1037, 377);
            this.Controls.Add(this.button_Help);
            this.Controls.Add(this.label_resultedText);
            this.Controls.Add(this.label_OcrResult);
            this.Controls.Add(this.textBox_Ocr);
            this.Controls.Add(this.button_applyOcr);
            this.Controls.Add(this.button_ClearList);
            this.Controls.Add(this.label_statusCheck);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.listbox_LoadedItems);
            this.Controls.Add(this.pictureBox_main);
            this.Controls.Add(this.button_ClearText);
            this.Controls.Add(this.button_LoadImages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OCR";
            this.Load += new System.EventHandler(this.MainForm);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_LoadImages;
        private System.Windows.Forms.Button button_ClearText;
        private System.Windows.Forms.PictureBox pictureBox_main;
        private ListBox listbox_LoadedItems;
        private Label label_status;
        private Label label_statusCheck;
        private Button button_ClearList;
        private Button button_applyOcr;
        private Label label_OcrResult;
        private TextBox textBox_Ocr;
        private Label label_resultedText;
        private Button button_Help;
    }
}

