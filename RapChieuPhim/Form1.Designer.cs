namespace Sudoku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Create_Matrix = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_check = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 485);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // Create_Matrix
            // 
            this.Create_Matrix.BackColor = System.Drawing.Color.LightSalmon;
            this.Create_Matrix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create_Matrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create_Matrix.Location = new System.Drawing.Point(613, 454);
            this.Create_Matrix.Name = "Create_Matrix";
            this.Create_Matrix.Size = new System.Drawing.Size(247, 45);
            this.Create_Matrix.TabIndex = 1;
            this.Create_Matrix.Text = "Create";
            this.Create_Matrix.UseVisualStyleBackColor = false;
            this.Create_Matrix.Click += new System.EventHandler(this.Create_Matrix_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(613, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button_check
            // 
            this.button_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_check.Location = new System.Drawing.Point(613, 401);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(247, 45);
            this.button_check.TabIndex = 5;
            this.button_check.Text = "Check";
            this.button_check.UseVisualStyleBackColor = false;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Location = new System.Drawing.Point(613, 291);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(247, 92);
            this.button_exit.TabIndex = 6;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(866, 506);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Create_Matrix);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Create_Matrix;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Button button_exit;
    }
}

