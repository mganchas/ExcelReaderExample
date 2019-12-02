namespace WinFormsApp1
{
    using System.ComponentModel;

    partial class Form1
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
            this.btn_read_excel = new System.Windows.Forms.Button();
            this.txt_file_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listbox_results = new System.Windows.Forms.ListBox();
            // 
            // btn_read_excel
            // 
            this.btn_read_excel.Location = new System.Drawing.Point(258, 36);
            this.btn_read_excel.Name = "btn_read_excel";
            this.btn_read_excel.Size = new System.Drawing.Size(75, 23);
            this.btn_read_excel.TabIndex = 0;
            this.btn_read_excel.Text = "Read excel";
            this.btn_read_excel.UseVisualStyleBackColor = true;
            this.btn_read_excel.Click += new System.EventHandler(this.btn_read_excel_Click);
            // 
            // txt_file_path
            // 
            this.txt_file_path.Location = new System.Drawing.Point(11, 36);
            this.txt_file_path.Name = "txt_file_path";
            this.txt_file_path.Size = new System.Drawing.Size(241, 23);
            this.txt_file_path.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "File path";
            // 
            // listbox_results
            // 
            this.listbox_results.FormattingEnabled = true;
            this.listbox_results.ItemHeight = 15;
            this.listbox_results.Location = new System.Drawing.Point(11, 65);
            this.listbox_results.Name = "listbox_results";
            this.listbox_results.Size = new System.Drawing.Size(322, 334);
            this.listbox_results.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.listbox_results);
            this.Controls.Add(this.txt_file_path);
            this.Controls.Add(this.btn_read_excel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";

        }

        #endregion

        private System.Windows.Forms.Button btn_read_excel;
        private System.Windows.Forms.TextBox txt_file_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listbox_results;
    }
}