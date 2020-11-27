namespace Assignment2
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radiuslabel = new System.Windows.Forms.Label();
            this.edge1label = new System.Windows.Forms.Label();
            this.edge2label = new System.Windows.Forms.Label();
            this.radiustextbox = new System.Windows.Forms.TextBox();
            this.edge1textbox = new System.Windows.Forms.TextBox();
            this.edge2textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 129);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Redirect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select",
            "Rectangle",
            "Circle"});
            this.comboBox1.Location = new System.Drawing.Point(87, 73);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // radiuslabel
            // 
            this.radiuslabel.AutoSize = true;
            this.radiuslabel.Location = new System.Drawing.Point(83, 205);
            this.radiuslabel.Name = "radiuslabel";
            this.radiuslabel.Size = new System.Drawing.Size(67, 20);
            this.radiuslabel.TabIndex = 2;
            this.radiuslabel.Text = "Radius :";
            this.radiuslabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // edge1label
            // 
            this.edge1label.AutoSize = true;
            this.edge1label.Location = new System.Drawing.Point(83, 256);
            this.edge1label.Name = "edge1label";
            this.edge1label.Size = new System.Drawing.Size(64, 20);
            this.edge1label.TabIndex = 3;
            this.edge1label.Text = "Edge1 :";
            // 
            // edge2label
            // 
            this.edge2label.AutoSize = true;
            this.edge2label.Location = new System.Drawing.Point(83, 307);
            this.edge2label.Name = "edge2label";
            this.edge2label.Size = new System.Drawing.Size(64, 20);
            this.edge2label.TabIndex = 4;
            this.edge2label.Text = "Edge2 :";
            this.edge2label.Click += new System.EventHandler(this.label3_Click);
            // 
            // radiustextbox
            // 
            this.radiustextbox.Location = new System.Drawing.Point(214, 205);
            this.radiustextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radiustextbox.Name = "radiustextbox";
            this.radiustextbox.Size = new System.Drawing.Size(112, 26);
            this.radiustextbox.TabIndex = 5;
            // 
            // edge1textbox
            // 
            this.edge1textbox.Location = new System.Drawing.Point(216, 250);
            this.edge1textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edge1textbox.Name = "edge1textbox";
            this.edge1textbox.Size = new System.Drawing.Size(112, 26);
            this.edge1textbox.TabIndex = 6;
            this.edge1textbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // edge2textbox
            // 
            this.edge2textbox.Location = new System.Drawing.Point(216, 301);
            this.edge2textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edge2textbox.Name = "edge2textbox";
            this.edge2textbox.Size = new System.Drawing.Size(112, 26);
            this.edge2textbox.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 410);
            this.Controls.Add(this.edge2textbox);
            this.Controls.Add(this.edge1textbox);
            this.Controls.Add(this.radiustextbox);
            this.Controls.Add(this.edge2label);
            this.Controls.Add(this.edge1label);
            this.Controls.Add(this.radiuslabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label radiuslabel;
        public System.Windows.Forms.Label edge1label;
        public System.Windows.Forms.Label edge2label;
        public System.Windows.Forms.TextBox radiustextbox;
        public System.Windows.Forms.TextBox edge1textbox;
        public System.Windows.Forms.TextBox edge2textbox;
    }
}

