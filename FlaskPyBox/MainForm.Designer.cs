namespace FlaskPyBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox_Box = new System.Windows.Forms.PictureBox();
            this.timer_G = new System.Windows.Forms.Timer(this.components);
            this.pile2 = new System.Windows.Forms.PictureBox();
            this.pile1 = new System.Windows.Forms.PictureBox();
            this.button_start = new System.Windows.Forms.Button();
            this.pile3 = new System.Windows.Forms.PictureBox();
            this.pile4 = new System.Windows.Forms.PictureBox();
            this.label_Score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pile3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pile4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Box
            // 
            this.pictureBox_Box.BackColor = System.Drawing.Color.White;
            this.pictureBox_Box.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Box.BackgroundImage")));
            this.pictureBox_Box.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Box.InitialImage")));
            this.pictureBox_Box.Location = new System.Drawing.Point(12, 232);
            this.pictureBox_Box.Name = "pictureBox_Box";
            this.pictureBox_Box.Size = new System.Drawing.Size(101, 48);
            this.pictureBox_Box.TabIndex = 0;
            this.pictureBox_Box.TabStop = false;
            this.pictureBox_Box.Click += new System.EventHandler(this.pictureBox_Box_Click);
            // 
            // timer_G
            // 
            this.timer_G.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pile2
            // 
            this.pile2.BackColor = System.Drawing.SystemColors.Control;
            this.pile2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pile2.BackgroundImage")));
            this.pile2.Location = new System.Drawing.Point(368, -280);
            this.pile2.Name = "pile2";
            this.pile2.Size = new System.Drawing.Size(100, 350);
            this.pile2.TabIndex = 1;
            this.pile2.TabStop = false;
            // 
            // pile1
            // 
            this.pile1.BackColor = System.Drawing.SystemColors.Control;
            this.pile1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pile1.BackgroundImage")));
            this.pile1.Location = new System.Drawing.Point(521, 282);
            this.pile1.Name = "pile1";
            this.pile1.Size = new System.Drawing.Size(100, 250);
            this.pile1.TabIndex = 2;
            this.pile1.TabStop = false;
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_start.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(225, 198);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(184, 70);
            this.button_start.TabIndex = 3;
            this.button_start.TabStop = false;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            this.button_start.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_start_KeyDown);
            // 
            // pile3
            // 
            this.pile3.BackColor = System.Drawing.SystemColors.Control;
            this.pile3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pile3.BackgroundImage")));
            this.pile3.Location = new System.Drawing.Point(252, 377);
            this.pile3.Name = "pile3";
            this.pile3.Size = new System.Drawing.Size(100, 200);
            this.pile3.TabIndex = 4;
            this.pile3.TabStop = false;
            // 
            // pile4
            // 
            this.pile4.BackColor = System.Drawing.SystemColors.Control;
            this.pile4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pile4.BackgroundImage")));
            this.pile4.Location = new System.Drawing.Point(142, -197);
            this.pile4.Name = "pile4";
            this.pile4.Size = new System.Drawing.Size(100, 350);
            this.pile4.TabIndex = 5;
            this.pile4.TabStop = false;
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Score.ForeColor = System.Drawing.Color.Red;
            this.label_Score.Location = new System.Drawing.Point(12, 9);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(30, 34);
            this.label_Score.TabIndex = 6;
            this.label_Score.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 480);
            this.Controls.Add(this.label_Score);
            this.Controls.Add(this.pile4);
            this.Controls.Add(this.pile3);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.pile1);
            this.Controls.Add(this.pile2);
            this.Controls.Add(this.pictureBox_Box);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Space Craft";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pile3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pile4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Box;
        private System.Windows.Forms.Timer timer_G;
        private System.Windows.Forms.PictureBox pile2;
        private System.Windows.Forms.PictureBox pile1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.PictureBox pile3;
        private System.Windows.Forms.PictureBox pile4;
        private System.Windows.Forms.Label label_Score;
    }
}

