namespace Hotel
{
    partial class sige
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sige));
            this.label1 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.tbcont = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updage = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.updquantity = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.lbldisc = new System.Windows.Forms.Label();
            this.lbldue = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbpayment = new System.Windows.Forms.TextBox();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rbEcon = new System.Windows.Forms.RadioButton();
            this.rbDeluxe = new System.Windows.Forms.RadioButton();
            this.rbExe = new System.Windows.Forms.RadioButton();
            this.gbtype = new System.Windows.Forms.GroupBox();
            this.rbsenior = new System.Windows.Forms.RadioButton();
            this.rbpwd = new System.Windows.Forms.RadioButton();
            this.rbstudent = new System.Windows.Forms.RadioButton();
            this.rbreg = new System.Windows.Forms.RadioButton();
            this.gbdisc = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.updage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updquantity)).BeginInit();
            this.gbtype.SuspendLayout();
            this.gbdisc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOTEL";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tbname
            // 
            this.tbname.AccessibleName = "tb1";
            this.tbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(219, 56);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(206, 29);
            this.tbname.TabIndex = 1;
            this.tbname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbname1_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(66, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "CALCULATE";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(111, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "NAME:";
            // 
            // tbcont
            // 
            this.tbcont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcont.Location = new System.Drawing.Point(219, 98);
            this.tbcont.Name = "tbcont";
            this.tbcont.Size = new System.Drawing.Size(206, 29);
            this.tbcont.TabIndex = 4;
            this.tbcont.TextChanged += new System.EventHandler(this.tbcont_TextChanged);
            this.tbcont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "CONTACT NO.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "AGE:";
            // 
            // updage
            // 
            this.updage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updage.Location = new System.Drawing.Point(219, 139);
            this.updage.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.updage.Name = "updage";
            this.updage.Size = new System.Drawing.Size(120, 29);
            this.updage.TabIndex = 7;
            this.updage.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.updage.ValueChanged += new System.EventHandler(this.updage_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "PAX :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // updquantity
            // 
            this.updquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updquantity.Location = new System.Drawing.Point(219, 181);
            this.updquantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updquantity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.updquantity.Name = "updquantity";
            this.updquantity.Size = new System.Drawing.Size(120, 29);
            this.updquantity.TabIndex = 9;
            this.updquantity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total Amount";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Total Discount";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Amount Due";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblamount
            // 
            this.lblamount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblamount.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.Location = new System.Drawing.Point(29, 72);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(202, 28);
            this.lblamount.TabIndex = 16;
            this.lblamount.Text = "                                       ";
            this.lblamount.TextChanged += new System.EventHandler(this.lblamount_TextChanged);
            this.lblamount.Click += new System.EventHandler(this.lblamount_Click);
            // 
            // lbldisc
            // 
            this.lbldisc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldisc.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisc.Location = new System.Drawing.Point(29, 154);
            this.lbldisc.Name = "lbldisc";
            this.lbldisc.Size = new System.Drawing.Size(202, 28);
            this.lbldisc.TabIndex = 16;
            this.lbldisc.Text = "                                       ";
            this.lbldisc.TextChanged += new System.EventHandler(this.lbldisc_TextChanged);
            this.lbldisc.Click += new System.EventHandler(this.lbldisc_Click);
            // 
            // lbldue
            // 
            this.lbldue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldue.Location = new System.Drawing.Point(29, 236);
            this.lbldue.Name = "lbldue";
            this.lbldue.Size = new System.Drawing.Size(202, 28);
            this.lbldue.TabIndex = 16;
            this.lbldue.Text = "                                       ";
            this.lbldue.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(35, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Enter Payment";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // tbpayment
            // 
            this.tbpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpayment.Location = new System.Drawing.Point(29, 308);
            this.tbpayment.Name = "tbpayment";
            this.tbpayment.Size = new System.Drawing.Size(202, 26);
            this.tbpayment.TabIndex = 25;
            this.tbpayment.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.tbpayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStandard.Location = new System.Drawing.Point(26, 57);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(149, 23);
            this.rbStandard.TabIndex = 10;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "Standard (₱400)";
            this.rbStandard.UseVisualStyleBackColor = true;
            this.rbStandard.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ebrima", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 40);
            this.label6.TabIndex = 11;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // rbEcon
            // 
            this.rbEcon.AutoSize = true;
            this.rbEcon.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEcon.Location = new System.Drawing.Point(26, 99);
            this.rbEcon.Name = "rbEcon";
            this.rbEcon.Size = new System.Drawing.Size(151, 23);
            this.rbEcon.TabIndex = 17;
            this.rbEcon.TabStop = true;
            this.rbEcon.Text = "Economy (₱300)";
            this.rbEcon.UseVisualStyleBackColor = true;
            this.rbEcon.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // rbDeluxe
            // 
            this.rbDeluxe.AutoSize = true;
            this.rbDeluxe.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeluxe.Location = new System.Drawing.Point(26, 137);
            this.rbDeluxe.Name = "rbDeluxe";
            this.rbDeluxe.Size = new System.Drawing.Size(133, 23);
            this.rbDeluxe.TabIndex = 18;
            this.rbDeluxe.TabStop = true;
            this.rbDeluxe.Text = "Deluxe (₱800)";
            this.rbDeluxe.UseVisualStyleBackColor = true;
            this.rbDeluxe.CheckedChanged += new System.EventHandler(this.r_CheckedChanged);
            // 
            // rbExe
            // 
            this.rbExe.AutoSize = true;
            this.rbExe.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExe.Location = new System.Drawing.Point(26, 178);
            this.rbExe.Name = "rbExe";
            this.rbExe.Size = new System.Drawing.Size(166, 23);
            this.rbExe.TabIndex = 19;
            this.rbExe.TabStop = true;
            this.rbExe.Text = "Executive (₱1,000)";
            this.rbExe.UseVisualStyleBackColor = true;
            this.rbExe.CheckedChanged += new System.EventHandler(this.rbjewel_CheckedChanged);
            // 
            // gbtype
            // 
            this.gbtype.Controls.Add(this.rbExe);
            this.gbtype.Controls.Add(this.rbDeluxe);
            this.gbtype.Controls.Add(this.rbEcon);
            this.gbtype.Controls.Add(this.label6);
            this.gbtype.Controls.Add(this.rbStandard);
            this.gbtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtype.Location = new System.Drawing.Point(33, 296);
            this.gbtype.Name = "gbtype";
            this.gbtype.Size = new System.Drawing.Size(231, 268);
            this.gbtype.TabIndex = 31;
            this.gbtype.TabStop = false;
            this.gbtype.Text = "TYPE";
            this.gbtype.Enter += new System.EventHandler(this.gbtype_Enter);
            // 
            // rbsenior
            // 
            this.rbsenior.AutoSize = true;
            this.rbsenior.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbsenior.Location = new System.Drawing.Point(27, 174);
            this.rbsenior.Name = "rbsenior";
            this.rbsenior.Size = new System.Drawing.Size(178, 23);
            this.rbsenior.TabIndex = 29;
            this.rbsenior.TabStop = true;
            this.rbsenior.Text = "Senior Citizen (25%)";
            this.rbsenior.UseVisualStyleBackColor = true;
            this.rbsenior.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // rbpwd
            // 
            this.rbpwd.AutoSize = true;
            this.rbpwd.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbpwd.Location = new System.Drawing.Point(27, 138);
            this.rbpwd.Name = "rbpwd";
            this.rbpwd.Size = new System.Drawing.Size(113, 23);
            this.rbpwd.TabIndex = 28;
            this.rbpwd.TabStop = true;
            this.rbpwd.Text = "PWD (20%)";
            this.rbpwd.UseVisualStyleBackColor = true;
            this.rbpwd.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // rbstudent
            // 
            this.rbstudent.AutoSize = true;
            this.rbstudent.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbstudent.Location = new System.Drawing.Point(27, 99);
            this.rbstudent.Name = "rbstudent";
            this.rbstudent.Size = new System.Drawing.Size(135, 23);
            this.rbstudent.TabIndex = 27;
            this.rbstudent.TabStop = true;
            this.rbstudent.Text = "Student (10%)";
            this.rbstudent.UseVisualStyleBackColor = true;
            this.rbstudent.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rbreg
            // 
            this.rbreg.AutoSize = true;
            this.rbreg.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbreg.Location = new System.Drawing.Point(27, 60);
            this.rbreg.Name = "rbreg";
            this.rbreg.Size = new System.Drawing.Size(85, 23);
            this.rbreg.TabIndex = 21;
            this.rbreg.TabStop = true;
            this.rbreg.Text = "Regular";
            this.rbreg.UseVisualStyleBackColor = true;
            this.rbreg.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // gbdisc
            // 
            this.gbdisc.Controls.Add(this.rbsenior);
            this.gbdisc.Controls.Add(this.rbpwd);
            this.gbdisc.Controls.Add(this.rbstudent);
            this.gbdisc.Controls.Add(this.rbreg);
            this.gbdisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdisc.Location = new System.Drawing.Point(280, 296);
            this.gbdisc.Name = "gbdisc";
            this.gbdisc.Size = new System.Drawing.Size(230, 268);
            this.gbdisc.TabIndex = 32;
            this.gbdisc.TabStop = false;
            this.gbdisc.Text = "DISCOUNT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbpayment);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lbldue);
            this.groupBox1.Controls.Add(this.lbldisc);
            this.groupBox1.Controls.Add(this.lblamount);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(530, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 447);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BILLING";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.updquantity);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.updage);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbcont);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbname);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 228);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INFORMATION";
            // 
            // sige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 613);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbdisc);
            this.Controls.Add(this.gbtype);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sige";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel ni Chaeyoung";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updquantity)).EndInit();
            this.gbtype.ResumeLayout(false);
            this.gbtype.PerformLayout();
            this.gbdisc.ResumeLayout(false);
            this.gbdisc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox tbcont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown updage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown updquantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Label lbldisc;
        private System.Windows.Forms.Label lbldue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbpayment;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbEcon;
        private System.Windows.Forms.RadioButton rbDeluxe;
        private System.Windows.Forms.RadioButton rbExe;
        private System.Windows.Forms.GroupBox gbtype;
        private System.Windows.Forms.RadioButton rbsenior;
        private System.Windows.Forms.RadioButton rbpwd;
        private System.Windows.Forms.RadioButton rbstudent;
        private System.Windows.Forms.RadioButton rbreg;
        private System.Windows.Forms.GroupBox gbdisc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

