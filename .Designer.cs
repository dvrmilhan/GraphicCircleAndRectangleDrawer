namespace Assignment2
{
    partial class RectangleForm
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
            this.rectanglepictureBox1 = new System.Windows.Forms.PictureBox();
            this.rectanglelabel1 = new System.Windows.Forms.Label();
            this.rectanglebutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rectanglepictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rectanglepictureBox1
            // 
            this.rectanglepictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rectanglepictureBox1.Location = new System.Drawing.Point(16, 17);
            this.rectanglepictureBox1.Name = "rectanglepictureBox1";
            this.rectanglepictureBox1.Size = new System.Drawing.Size(533, 295);
            this.rectanglepictureBox1.TabIndex = 0;
            this.rectanglepictureBox1.TabStop = false;
            this.rectanglepictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.rectanglepictureBox1_Paint);
            this.rectanglepictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectanglepictureBox1_MouseClick);
            this.rectanglepictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rectanglepictureBox1_MouseDown);
            this.rectanglepictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rectanglepictureBox1_MouseMove);
            // 
            // rectanglelabel1
            // 
            this.rectanglelabel1.AutoSize = true;
            this.rectanglelabel1.Location = new System.Drawing.Point(158, 346);
            this.rectanglelabel1.Name = "rectanglelabel1";
            this.rectanglelabel1.Size = new System.Drawing.Size(189, 20);
            this.rectanglelabel1.TabIndex = 1;
            this.rectanglelabel1.Text = "Area  :  0      Perimeter :  0";
            // 
            // rectanglebutton1
            // 
            this.rectanglebutton1.Location = new System.Drawing.Point(12, 336);
            this.rectanglebutton1.Name = "rectanglebutton1";
            this.rectanglebutton1.Size = new System.Drawing.Size(110, 37);
            this.rectanglebutton1.TabIndex = 2;
            this.rectanglebutton1.Text = "Calculate";
            this.rectanglebutton1.UseVisualStyleBackColor = true;
            this.rectanglebutton1.Click += new System.EventHandler(this.rectanglebutton1_Click);
            // 
            // RectangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 406);
            this.Controls.Add(this.rectanglebutton1);
            this.Controls.Add(this.rectanglelabel1);
            this.Controls.Add(this.rectanglepictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "RectangleForm";
            this.Text = "RectangleForm";
            
            ((System.ComponentModel.ISupportInitialize)(this.rectanglepictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rectanglepictureBox1;
        private System.Windows.Forms.Label rectanglelabel1;
        private System.Windows.Forms.Button rectanglebutton1;
    }
}