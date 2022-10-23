namespace View
{
    partial class SearchForm
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
            this.labelParam1 = new System.Windows.Forms.Label();
            this.textBoxParam1 = new System.Windows.Forms.TextBox();
            this.buttonRunSearch1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelParam2 = new System.Windows.Forms.Label();
            this.textBoxParam2 = new System.Windows.Forms.TextBox();
            this.buttonRunSearch2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelParam1
            // 
            this.labelParam1.AutoSize = true;
            this.labelParam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParam1.Location = new System.Drawing.Point(24, 22);
            this.labelParam1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelParam1.Name = "labelParam1";
            this.labelParam1.Size = new System.Drawing.Size(29, 24);
            this.labelParam1.TabIndex = 8;
            this.labelParam1.Text = "S:";
            // 
            // textBoxParam1
            // 
            this.textBoxParam1.Location = new System.Drawing.Point(28, 52);
            this.textBoxParam1.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxParam1.Name = "textBoxParam1";
            this.textBoxParam1.Size = new System.Drawing.Size(196, 29);
            this.textBoxParam1.TabIndex = 7;
            // 
            // buttonRunSearch1
            // 
            this.buttonRunSearch1.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonRunSearch1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRunSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRunSearch1.Location = new System.Drawing.Point(94, 93);
            this.buttonRunSearch1.Margin = new System.Windows.Forms.Padding(6);
            this.buttonRunSearch1.Name = "buttonRunSearch1";
            this.buttonRunSearch1.Size = new System.Drawing.Size(130, 40);
            this.buttonRunSearch1.TabIndex = 10;
            this.buttonRunSearch1.Text = "Найти";
            this.buttonRunSearch1.UseVisualStyleBackColor = false;
            this.buttonRunSearch1.Click += new System.EventHandler(this.ButtonRunSearch1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(244, 22);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(324, 284);
            this.listBox1.TabIndex = 11;
            // 
            // labelParam2
            // 
            this.labelParam2.AutoSize = true;
            this.labelParam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParam2.Location = new System.Drawing.Point(32, 177);
            this.labelParam2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelParam2.Name = "labelParam2";
            this.labelParam2.Size = new System.Drawing.Size(21, 24);
            this.labelParam2.TabIndex = 12;
            this.labelParam2.Text = "I:";
            // 
            // textBoxParam2
            // 
            this.textBoxParam2.Location = new System.Drawing.Point(36, 207);
            this.textBoxParam2.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxParam2.Name = "textBoxParam2";
            this.textBoxParam2.Size = new System.Drawing.Size(196, 29);
            this.textBoxParam2.TabIndex = 13;
            // 
            // buttonRunSearch2
            // 
            this.buttonRunSearch2.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonRunSearch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRunSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRunSearch2.Location = new System.Drawing.Point(102, 248);
            this.buttonRunSearch2.Margin = new System.Windows.Forms.Padding(6);
            this.buttonRunSearch2.Name = "buttonRunSearch2";
            this.buttonRunSearch2.Size = new System.Drawing.Size(130, 40);
            this.buttonRunSearch2.TabIndex = 14;
            this.buttonRunSearch2.Text = "Найти";
            this.buttonRunSearch2.UseVisualStyleBackColor = false;
            this.buttonRunSearch2.Click += new System.EventHandler(this.ButtonRunSearch2_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 337);
            this.Controls.Add(this.buttonRunSearch2);
            this.Controls.Add(this.textBoxParam2);
            this.Controls.Add(this.labelParam2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonRunSearch1);
            this.Controls.Add(this.labelParam1);
            this.Controls.Add(this.textBoxParam1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск объекта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelParam1;
        private System.Windows.Forms.TextBox textBoxParam1;
        private System.Windows.Forms.Button buttonRunSearch1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelParam2;
        private System.Windows.Forms.TextBox textBoxParam2;
        private System.Windows.Forms.Button buttonRunSearch2;
    }
}