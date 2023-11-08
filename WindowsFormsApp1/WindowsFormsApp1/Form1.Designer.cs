namespace WindowsFormsApp1
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
<<<<<<< namwlee
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
=======
            this.textBox_print = new System.Windows.Forms.TextBox();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_del = new System.Windows.Forms.Button();
            this.button_res = new System.Windows.Forms.Button();
            this.button_min = new System.Windows.Forms.Button();
            this.button_mul = new System.Windows.Forms.Button();
            this.button_rem = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_in_min = new System.Windows.Forms.Button();
            this.button_plu = new System.Windows.Forms.Button();
            this.button_ica = new System.Windows.Forms.Button();
            this.button_log = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_print
            // 
            this.textBox_print.Location = new System.Drawing.Point(12, 12);
            this.textBox_print.Multiline = true;
            this.textBox_print.Name = "textBox_print";
            this.textBox_print.ReadOnly = true;
            this.textBox_print.Size = new System.Drawing.Size(518, 207);
            this.textBox_print.TabIndex = 0;
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(12, 225);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(319, 299);
            this.textBox_input.TabIndex = 1;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(436, 225);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(94, 55);
            this.button_del.TabIndex = 3;
            this.button_del.Text = "DEL";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_res
            // 
            this.button_res.Location = new System.Drawing.Point(336, 225);
            this.button_res.Name = "button_res";
            this.button_res.Size = new System.Drawing.Size(94, 55);
            this.button_res.TabIndex = 5;
            this.button_res.Text = "C";
            this.button_res.UseVisualStyleBackColor = true;
            this.button_res.Click += new System.EventHandler(this.button_res_Click);
            // 
            // button_min
            // 
            this.button_min.Location = new System.Drawing.Point(336, 347);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(94, 55);
            this.button_min.TabIndex = 6;
            this.button_min.Text = "-";
            this.button_min.UseVisualStyleBackColor = true;
            // 
            // button_mul
            // 
            this.button_mul.Location = new System.Drawing.Point(436, 347);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(94, 55);
            this.button_mul.TabIndex = 7;
            this.button_mul.Text = "*";
            this.button_mul.UseVisualStyleBackColor = true;
            // 
            // button_rem
            // 
            this.button_rem.Location = new System.Drawing.Point(436, 408);
            this.button_rem.Name = "button_rem";
            this.button_rem.Size = new System.Drawing.Size(94, 55);
            this.button_rem.TabIndex = 8;
            this.button_rem.Text = "%";
            this.button_rem.UseVisualStyleBackColor = true;
            // 
            // button_div
            // 
            this.button_div.Location = new System.Drawing.Point(336, 408);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(94, 55);
            this.button_div.TabIndex = 9;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            // 
            // button_in_min
            // 
            this.button_in_min.Location = new System.Drawing.Point(336, 286);
            this.button_in_min.Name = "button_in_min";
            this.button_in_min.Size = new System.Drawing.Size(94, 55);
            this.button_in_min.TabIndex = 10;
            this.button_in_min.Text = "Add - / Del -";
            this.button_in_min.UseVisualStyleBackColor = true;
            // 
            // button_plu
            // 
            this.button_plu.Location = new System.Drawing.Point(436, 286);
            this.button_plu.Name = "button_plu";
            this.button_plu.Size = new System.Drawing.Size(94, 55);
            this.button_plu.TabIndex = 11;
            this.button_plu.Text = "+";
            this.button_plu.UseVisualStyleBackColor = true;
            // 
            // button_ica
            // 
            this.button_ica.Location = new System.Drawing.Point(436, 469);
            this.button_ica.Name = "button_ica";
            this.button_ica.Size = new System.Drawing.Size(94, 55);
            this.button_ica.TabIndex = 12;
            this.button_ica.Text = "=";
            this.button_ica.UseVisualStyleBackColor = true;
            // 
            // button_log
            // 
            this.button_log.Location = new System.Drawing.Point(336, 469);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(94, 55);
            this.button_log.TabIndex = 13;
            this.button_log.Text = "Log";
            this.button_log.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 539);
            this.Controls.Add(this.button_log);
            this.Controls.Add(this.button_ica);
            this.Controls.Add(this.button_plu);
            this.Controls.Add(this.button_in_min);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_rem);
            this.Controls.Add(this.button_mul);
            this.Controls.Add(this.button_min);
            this.Controls.Add(this.button_res);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.textBox_print);
            this.Name = "Form1";
>>>>>>> local
            this.Text = "Form1";
        }

        #endregion
<<<<<<< namwlee
=======

        private System.Windows.Forms.TextBox textBox_print;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_res;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button_mul;
        private System.Windows.Forms.Button button_rem;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_in_min;
        private System.Windows.Forms.Button button_plu;
        private System.Windows.Forms.Button button_ica;
        private System.Windows.Forms.Button button_log;
>>>>>>> local
    }
}

