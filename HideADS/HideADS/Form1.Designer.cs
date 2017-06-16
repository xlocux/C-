namespace HideADS
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
            this.rtbin = new System.Windows.Forms.RichTextBox();
            this.btarget = new System.Windows.Forms.Button();
            this.bhide = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.tbtar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbout = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.benum = new System.Windows.Forms.Button();
            this.bdel = new System.Windows.Forms.Button();
            this.bclear = new System.Windows.Forms.Button();
            this.tbads = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rtbin
            // 
            this.rtbin.Location = new System.Drawing.Point(12, 73);
            this.rtbin.Name = "rtbin";
            this.rtbin.Size = new System.Drawing.Size(723, 160);
            this.rtbin.TabIndex = 9;
            this.rtbin.Text = "";
            // 
            // btarget
            // 
            this.btarget.Location = new System.Drawing.Point(12, 10);
            this.btarget.Name = "btarget";
            this.btarget.Size = new System.Drawing.Size(75, 23);
            this.btarget.TabIndex = 1;
            this.btarget.Text = "Target";
            this.btarget.UseVisualStyleBackColor = true;
            this.btarget.Click += new System.EventHandler(this.btarget_Click);
            // 
            // bhide
            // 
            this.bhide.Location = new System.Drawing.Point(490, 38);
            this.bhide.Name = "bhide";
            this.bhide.Size = new System.Drawing.Size(75, 23);
            this.bhide.TabIndex = 6;
            this.bhide.Text = "Write";
            this.bhide.UseVisualStyleBackColor = true;
            this.bhide.Click += new System.EventHandler(this.bhide_Click);
            // 
            // tbtar
            // 
            this.tbtar.Location = new System.Drawing.Point(93, 12);
            this.tbtar.Name = "tbtar";
            this.tbtar.Size = new System.Drawing.Size(642, 20);
            this.tbtar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ADS NAME:";
            // 
            // rtbout
            // 
            this.rtbout.Location = new System.Drawing.Point(12, 247);
            this.rtbout.Name = "rtbout";
            this.rtbout.ReadOnly = true;
            this.rtbout.Size = new System.Drawing.Size(723, 342);
            this.rtbout.TabIndex = 10;
            this.rtbout.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Read";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // benum
            // 
            this.benum.Location = new System.Drawing.Point(325, 38);
            this.benum.Name = "benum";
            this.benum.Size = new System.Drawing.Size(75, 23);
            this.benum.TabIndex = 4;
            this.benum.Text = "Enumerate ADS";
            this.benum.UseVisualStyleBackColor = true;
            this.benum.Click += new System.EventHandler(this.benum_Click);
            // 
            // bdel
            // 
            this.bdel.Location = new System.Drawing.Point(575, 38);
            this.bdel.Name = "bdel";
            this.bdel.Size = new System.Drawing.Size(75, 23);
            this.bdel.TabIndex = 7;
            this.bdel.Text = "Delete";
            this.bdel.UseVisualStyleBackColor = true;
            this.bdel.Click += new System.EventHandler(this.bdel_Click);
            // 
            // bclear
            // 
            this.bclear.Location = new System.Drawing.Point(660, 38);
            this.bclear.Name = "bclear";
            this.bclear.Size = new System.Drawing.Size(75, 23);
            this.bclear.TabIndex = 8;
            this.bclear.Text = "Clear";
            this.bclear.UseVisualStyleBackColor = true;
            this.bclear.Click += new System.EventHandler(this.bclear_Click);
            // 
            // tbads
            // 
            this.tbads.FormattingEnabled = true;
            this.tbads.Location = new System.Drawing.Point(93, 38);
            this.tbads.Name = "tbads";
            this.tbads.Size = new System.Drawing.Size(226, 21);
            this.tbads.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 601);
            this.Controls.Add(this.tbads);
            this.Controls.Add(this.bclear);
            this.Controls.Add(this.bdel);
            this.Controls.Add(this.benum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbtar);
            this.Controls.Add(this.bhide);
            this.Controls.Add(this.btarget);
            this.Controls.Add(this.rtbin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HideADS                                                                          " +
    "                                                                                " +
    "                 Locu 2016";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbin;
        private System.Windows.Forms.Button btarget;
        private System.Windows.Forms.Button bhide;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.TextBox tbtar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button benum;
        private System.Windows.Forms.Button bdel;
        private System.Windows.Forms.Button bclear;
        private System.Windows.Forms.ComboBox tbads;
    }
}

