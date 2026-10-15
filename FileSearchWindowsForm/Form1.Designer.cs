namespace FileSearchWindowsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textDir = new TextBox();
            searchBtn = new Button();
            fileList = new ListBox();
            SuspendLayout();
            // 
            // textDir
            // 
            textDir.Location = new Point(31, 43);
            textDir.Name = "textDir";
            textDir.Size = new Size(237, 31);
            textDir.TabIndex = 0;
            textDir.Text = "FileSearch";
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(326, 38);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(153, 36);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Search Now";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // fileList
            // 
            fileList.FormattingEnabled = true;
            fileList.Location = new Point(31, 93);
            fileList.Name = "fileList";
            fileList.Size = new Size(448, 354);
            fileList.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 557);
            Controls.Add(fileList);
            Controls.Add(searchBtn);
            Controls.Add(textDir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textDir;
        private Button searchBtn;
        private ListBox fileList;
    }
}
