namespace TextEncoding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Regular_Text = new System.Windows.Forms.TextBox();
            this.Encrypted_Text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Method = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exportToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptedTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plainTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptedTextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.plainTextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Regular_Text
            // 
            this.Regular_Text.Location = new System.Drawing.Point(12, 27);
            this.Regular_Text.Multiline = true;
            this.Regular_Text.Name = "Regular_Text";
            this.Regular_Text.Size = new System.Drawing.Size(648, 101);
            this.Regular_Text.TabIndex = 0;
            // 
            // Encrypted_Text
            // 
            this.Encrypted_Text.Location = new System.Drawing.Point(12, 196);
            this.Encrypted_Text.Multiline = true;
            this.Encrypted_Text.Name = "Encrypted_Text";
            this.Encrypted_Text.Size = new System.Drawing.Size(648, 109);
            this.Encrypted_Text.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(258, 159);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(106, 24);
            this.Password.TabIndex = 4;
            this.Password.Text = "password";
            // 
            // Method
            // 
            this.Method.FormattingEnabled = true;
            this.Method.Items.AddRange(new object[] {
            "Vigenere cipher",
            "Vernam cipher",
            "Transposition cipher"});
            this.Method.Location = new System.Drawing.Point(120, 160);
            this.Method.Name = "Method";
            this.Method.Size = new System.Drawing.Size(121, 21);
            this.Method.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "encrypting method";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(747, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToFileToolStripMenuItem,
            this.importFromFileToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // exportToFileToolStripMenuItem
            // 
            this.exportToFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptedTextToolStripMenuItem,
            this.plainTextToolStripMenuItem});
            this.exportToFileToolStripMenuItem.Name = "exportToFileToolStripMenuItem";
            this.exportToFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToFileToolStripMenuItem.Text = "Export to file";
            // 
            // encryptedTextToolStripMenuItem
            // 
            this.encryptedTextToolStripMenuItem.Name = "encryptedTextToolStripMenuItem";
            this.encryptedTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.encryptedTextToolStripMenuItem.Text = "Encrypted text";
            this.encryptedTextToolStripMenuItem.Click += new System.EventHandler(this.encryptedTextToolStripMenuItem_Click);
            // 
            // plainTextToolStripMenuItem
            // 
            this.plainTextToolStripMenuItem.Name = "plainTextToolStripMenuItem";
            this.plainTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.plainTextToolStripMenuItem.Text = "Plain text";
            this.plainTextToolStripMenuItem.Click += new System.EventHandler(this.plainTextToolStripMenuItem_Click);
            // 
            // importFromFileToolStripMenuItem
            // 
            this.importFromFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptedTextToolStripMenuItem1,
            this.plainTextToolStripMenuItem1});
            this.importFromFileToolStripMenuItem.Name = "importFromFileToolStripMenuItem";
            this.importFromFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importFromFileToolStripMenuItem.Text = "Import from File";
            // 
            // encryptedTextToolStripMenuItem1
            // 
            this.encryptedTextToolStripMenuItem1.Name = "encryptedTextToolStripMenuItem1";
            this.encryptedTextToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.encryptedTextToolStripMenuItem1.Text = "Encrypted text";
            this.encryptedTextToolStripMenuItem1.Click += new System.EventHandler(this.encryptedTextToolStripMenuItem1_Click);
            // 
            // plainTextToolStripMenuItem1
            // 
            this.plainTextToolStripMenuItem1.Name = "plainTextToolStripMenuItem1";
            this.plainTextToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.plainTextToolStripMenuItem1.Text = "Plain text";
            this.plainTextToolStripMenuItem1.Click += new System.EventHandler(this.plainTextToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 317);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Method);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Encrypted_Text);
            this.Controls.Add(this.Regular_Text);
            this.Name = "Form1";
            this.Text = "Encryptor3000";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Regular_Text;
        private System.Windows.Forms.TextBox Encrypted_Text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.ComboBox Method;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem exportToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptedTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plainTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptedTextToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem plainTextToolStripMenuItem1;
    }
}

