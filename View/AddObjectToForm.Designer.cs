namespace View
{
    partial class AddObjectToForm
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBoxParam1 = new System.Windows.Forms.TextBox();
            this.textBoxParam2 = new System.Windows.Forms.TextBox();
            this.labelParam1 = new System.Windows.Forms.Label();
            this.labelParam2 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCRD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(52, 66);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(207, 28);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Почасовая оплата";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(52, 117);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(294, 28);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Оплата по окладу и ставке";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // textBoxParam1
            // 
            this.textBoxParam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxParam1.Location = new System.Drawing.Point(304, 246);
            this.textBoxParam1.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxParam1.Name = "textBoxParam1";
            this.textBoxParam1.Size = new System.Drawing.Size(196, 29);
            this.textBoxParam1.TabIndex = 3;
            // 
            // textBoxParam2
            // 
            this.textBoxParam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxParam2.Location = new System.Drawing.Point(304, 298);
            this.textBoxParam2.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxParam2.Name = "textBoxParam2";
            this.textBoxParam2.Size = new System.Drawing.Size(196, 29);
            this.textBoxParam2.TabIndex = 4;
            // 
            // labelParam1
            // 
            this.labelParam1.AutoSize = true;
            this.labelParam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParam1.Location = new System.Drawing.Point(54, 251);
            this.labelParam1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelParam1.Name = "labelParam1";
            this.labelParam1.Size = new System.Drawing.Size(226, 24);
            this.labelParam1.TabIndex = 6;
            this.labelParam1.Text = "***************************";
            // 
            // labelParam2
            // 
            this.labelParam2.AutoSize = true;
            this.labelParam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParam2.Location = new System.Drawing.Point(54, 303);
            this.labelParam2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelParam2.Name = "labelParam2";
            this.labelParam2.Size = new System.Drawing.Size(226, 24);
            this.labelParam2.TabIndex = 7;
            this.labelParam2.Text = "***************************";
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Location = new System.Drawing.Point(330, 339);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(6);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(170, 45);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Tomato;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(330, 434);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(170, 45);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonCRD
            // 
            this.buttonCRD.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonCRD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCRD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCRD.Location = new System.Drawing.Point(330, 189);
            this.buttonCRD.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCRD.Name = "buttonCRD";
            this.buttonCRD.Size = new System.Drawing.Size(170, 45);
            this.buttonCRD.TabIndex = 11;
            this.buttonCRD.Text = "Заполнить";
            this.buttonCRD.UseVisualStyleBackColor = false;
            this.buttonCRD.Click += new System.EventHandler(this.ButtonCRD_Click);
            // 
            // AddObjectToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(542, 494);
            this.Controls.Add(this.buttonCRD);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelParam2);
            this.Controls.Add(this.labelParam1);
            this.Controls.Add(this.textBoxParam2);
            this.Controls.Add(this.textBoxParam1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "AddObjectToForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить объект";
            this.Shown += new System.EventHandler(this.AddObjectToForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBoxParam1;
        private System.Windows.Forms.TextBox textBoxParam2;
        private System.Windows.Forms.Label labelParam1;
        private System.Windows.Forms.Label labelParam2;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCRD;
    }
}