
namespace chemaths
{
    partial class LevelWindow
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
            this.active_panel = new System.Windows.Forms.Panel();
            this.help_btn = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.output_box = new System.Windows.Forms.TextBox();
            this.input_box = new System.Windows.Forms.TextBox();
            this.check_btn = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.active_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.help_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // active_panel
            // 
            this.active_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.active_panel.Controls.Add(this.help_btn);
            this.active_panel.Controls.Add(this.close_btn);
            this.active_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.active_panel.Location = new System.Drawing.Point(0, 0);
            this.active_panel.Name = "active_panel";
            this.active_panel.Size = new System.Drawing.Size(951, 49);
            this.active_panel.TabIndex = 20;
            this.active_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.active_panel_MouseDown);
            // 
            // help_btn
            // 
            this.help_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help_btn.Image = global::chemaths.Properties.Resources.help;
            this.help_btn.Location = new System.Drawing.Point(12, 12);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(25, 25);
            this.help_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.help_btn.TabIndex = 14;
            this.help_btn.TabStop = false;
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Image = global::chemaths.Properties.Resources.close;
            this.close_btn.Location = new System.Drawing.Point(914, 12);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(25, 25);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 13;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // output_box
            // 
            this.output_box.Cursor = System.Windows.Forms.Cursors.Default;
            this.output_box.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.output_box.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.output_box.Location = new System.Drawing.Point(164, 187);
            this.output_box.Multiline = true;
            this.output_box.Name = "output_box";
            this.output_box.ReadOnly = true;
            this.output_box.Size = new System.Drawing.Size(611, 53);
            this.output_box.TabIndex = 22;
            this.output_box.TabStop = false;
            // 
            // input_box
            // 
            this.input_box.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_box.ForeColor = System.Drawing.Color.DimGray;
            this.input_box.Location = new System.Drawing.Point(164, 278);
            this.input_box.Multiline = true;
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(611, 53);
            this.input_box.TabIndex = 21;
            this.input_box.TabStop = false;
            // 
            // check_btn
            // 
            this.check_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_btn.Image = global::chemaths.Properties.Resources.clipboard;
            this.check_btn.Location = new System.Drawing.Point(379, 351);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(192, 132);
            this.check_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.check_btn.TabIndex = 23;
            this.check_btn.TabStop = false;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 22);
            this.button1.TabIndex = 25;
            this.button1.Text = "CONFIRM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(411, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "LEVEL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(490, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(26, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "CHOOSE YOUR LEVEL";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(29, 96);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(112, 20);
            this.numericUpDown1.TabIndex = 30;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(379, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(159, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 32;
            // 
            // LevelWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.output_box);
            this.Controls.Add(this.input_box);
            this.Controls.Add(this.active_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LevelWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.LevelWindow_Load);
            this.active_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.help_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel active_panel;
        private System.Windows.Forms.PictureBox help_btn;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.TextBox output_box;
        private System.Windows.Forms.TextBox input_box;
        private System.Windows.Forms.PictureBox check_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}