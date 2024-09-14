namespace cnv
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.metru1 = new System.Windows.Forms.ComboBox();
            this.metru2 = new System.Windows.Forms.ComboBox();
            this.unit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(150, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 45);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(479, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 45);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(356, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "CONVERT";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metru1
            // 
            this.metru1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metru1.FormattingEnabled = true;
            this.metru1.Location = new System.Drawing.Point(150, 212);
            this.metru1.Name = "metru1";
            this.metru1.Size = new System.Drawing.Size(180, 24);
            this.metru1.TabIndex = 3;
            this.metru1.SelectedIndexChanged += new System.EventHandler(this.metru1_SelectedIndexChanged);
            // 
            // metru2
            // 
            this.metru2.FormattingEnabled = true;
            this.metru2.Items.AddRange(new object[] {
            "Millimeter (mm)",
            "Centimeter (cm) ",
            "Decimeter (dm) ",
            "Decameter (dam) ",
            "Hectometer (hm)",
            "Kilometer (km)"});
            this.metru2.Location = new System.Drawing.Point(479, 212);
            this.metru2.Name = "metru2";
            this.metru2.Size = new System.Drawing.Size(180, 24);
            this.metru2.TabIndex = 4;
            this.metru2.SelectedIndexChanged += new System.EventHandler(this.metru2_SelectedIndexChanged);
            // 
            // unit
            // 
            this.unit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.unit.FormattingEnabled = true;
            this.unit.Items.AddRange(new object[] {
            "Length",
            "Weight",
            "Volume"});
            this.unit.Location = new System.Drawing.Point(362, 42);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(100, 24);
            this.unit.TabIndex = 5;
            this.unit.SelectedIndexChanged += new System.EventHandler(this.unit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "SELECT UNIT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.metru2);
            this.Controls.Add(this.metru1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox metru1;
        private System.Windows.Forms.ComboBox metru2;
        private System.Windows.Forms.ComboBox unit;
        private System.Windows.Forms.Label label1;
    }
}

