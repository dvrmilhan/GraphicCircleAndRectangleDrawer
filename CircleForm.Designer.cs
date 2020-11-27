namespace Assignment2
{
    partial class CircleForm
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
            this.circlebutton = new System.Windows.Forms.Button();
            this.circlelabel = new System.Windows.Forms.Label();
            this.circlepictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.circlepictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // circlebutton
            // 
            this.circlebutton.Location = new System.Drawing.Point(38, 342);
            this.circlebutton.Name = "circlebutton";
            this.circlebutton.Size = new System.Drawing.Size(111, 37);
            this.circlebutton.TabIndex = 5;
            this.circlebutton.Text = "Calculate";
            this.circlebutton.UseVisualStyleBackColor = true;
            this.circlebutton.Click += new System.EventHandler(this.circlebutton_Click);
            // 
            // circlelabel
            // 
            this.circlelabel.AutoSize = true;
            this.circlelabel.Location = new System.Drawing.Point(181, 350);
            this.circlelabel.Name = "circlelabel";
            this.circlelabel.Size = new System.Drawing.Size(189, 20);
            this.circlelabel.TabIndex = 4;
            this.circlelabel.Text = "Area  :  0      Perimeter :  0";
            // 
            // circlepictureBox
            // 
            this.circlepictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.circlepictureBox.Location = new System.Drawing.Point(12, 12);
            this.circlepictureBox.Name = "circlepictureBox";
            this.circlepictureBox.Size = new System.Drawing.Size(540, 294);
            this.circlepictureBox.TabIndex = 3;
            this.circlepictureBox.TabStop = false;
            this.circlepictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.circlepictureBox_Paint);
            this.circlepictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.circlepictureBox_MouseClick);
            this.circlepictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.circlepictureBox_MouseDown);
            this.circlepictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.circlepictureBox_MouseMove);
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 405);
            this.Controls.Add(this.circlebutton);
            this.Controls.Add(this.circlelabel);
            this.Controls.Add(this.circlepictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "CircleForm";
            this.Text = "CircleForm";
            ((System.ComponentModel.ISupportInitialize)(this.circlepictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button circlebutton;
        private System.Windows.Forms.Label circlelabel;
        private System.Windows.Forms.PictureBox circlepictureBox;
    }
}