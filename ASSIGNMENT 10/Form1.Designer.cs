namespace assignment_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tbCalculator = new TabPage();
            groupBox3 = new GroupBox();
            btn_cube = new Button();
            btn_cos = new Button();
            btn_sin = new Button();
            btn_Pie = new Button();
            btn_underoot = new Button();
            btn_sqaure = new Button();
            btn_multiply = new Button();
            btn_divide = new Button();
            btn_minus = new Button();
            btn_plus = new Button();
            btn_result = new Button();
            btn_clear = new Button();
            groupBox2 = new GroupBox();
            Btn_plus_minus = new Button();
            btn_dot = new Button();
            btn_0 = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            rbdStandard = new RadioButton();
            RbdScientific = new RadioButton();
            groupBox1 = new GroupBox();
            rdbLight = new RadioButton();
            rdbDark = new RadioButton();
            txtvalue = new TextBox();
            tbAboutMe = new TabPage();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tbCalculator.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tbAboutMe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbCalculator);
            tabControl1.Controls.Add(tbAboutMe);
            tabControl1.Location = new Point(2, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(909, 615);
            tabControl1.TabIndex = 0;
            // 
            // tbCalculator
            // 
            tbCalculator.Controls.Add(groupBox3);
            tbCalculator.Controls.Add(groupBox2);
            tbCalculator.Controls.Add(rbdStandard);
            tbCalculator.Controls.Add(RbdScientific);
            tbCalculator.Controls.Add(groupBox1);
            tbCalculator.Controls.Add(txtvalue);
            tbCalculator.Font = new Font("Microsoft Sans Serif", 22.2F);
            tbCalculator.Location = new Point(4, 29);
            tbCalculator.Name = "tbCalculator";
            tbCalculator.Padding = new Padding(3);
            tbCalculator.Size = new Size(901, 582);
            tbCalculator.TabIndex = 0;
            tbCalculator.Text = "Calculator";
            tbCalculator.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_cube);
            groupBox3.Controls.Add(btn_cos);
            groupBox3.Controls.Add(btn_sin);
            groupBox3.Controls.Add(btn_Pie);
            groupBox3.Controls.Add(btn_underoot);
            groupBox3.Controls.Add(btn_sqaure);
            groupBox3.Controls.Add(btn_multiply);
            groupBox3.Controls.Add(btn_divide);
            groupBox3.Controls.Add(btn_minus);
            groupBox3.Controls.Add(btn_plus);
            groupBox3.Controls.Add(btn_result);
            groupBox3.Controls.Add(btn_clear);
            groupBox3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(458, 168);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(437, 391);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            // 
            // btn_cube
            // 
            btn_cube.BackColor = Color.Crimson;
            btn_cube.Location = new Point(354, 324);
            btn_cube.Name = "btn_cube";
            btn_cube.Size = new Size(74, 63);
            btn_cube.TabIndex = 11;
            btn_cube.Text = "x^3";
            btn_cube.UseVisualStyleBackColor = false;
            btn_cube.Visible = false;
            btn_cube.Click += btn_cube_Click;
            // 
            // btn_cos
            // 
            btn_cos.BackColor = Color.Crimson;
            btn_cos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cos.Location = new Point(354, 236);
            btn_cos.Name = "btn_cos";
            btn_cos.Size = new Size(74, 63);
            btn_cos.TabIndex = 10;
            btn_cos.Text = "cos (x)";
            btn_cos.UseVisualStyleBackColor = false;
            btn_cos.Visible = false;
            btn_cos.Click += btn_factorial_Click;
            // 
            // btn_sin
            // 
            btn_sin.BackColor = Color.Crimson;
            btn_sin.Cursor = Cursors.IBeam;
            btn_sin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_sin.Location = new Point(357, 138);
            btn_sin.Name = "btn_sin";
            btn_sin.Size = new Size(74, 63);
            btn_sin.TabIndex = 9;
            btn_sin.Text = "sin (x)";
            btn_sin.UseVisualStyleBackColor = false;
            btn_sin.Visible = false;
            btn_sin.Click += btn_square_Click;
            // 
            // btn_Pie
            // 
            btn_Pie.BackColor = Color.Crimson;
            btn_Pie.Location = new Point(354, 40);
            btn_Pie.Name = "btn_Pie";
            btn_Pie.Size = new Size(74, 63);
            btn_Pie.TabIndex = 8;
            btn_Pie.Text = "Pie";
            btn_Pie.UseVisualStyleBackColor = false;
            btn_Pie.Visible = false;
            btn_Pie.Click += btn_Pie_Click;
            // 
            // btn_underoot
            // 
            btn_underoot.BackColor = Color.RoyalBlue;
            btn_underoot.Location = new Point(141, 302);
            btn_underoot.Name = "btn_underoot";
            btn_underoot.Size = new Size(88, 83);
            btn_underoot.TabIndex = 7;
            btn_underoot.Text = "√ ";
            btn_underoot.UseVisualStyleBackColor = false;
            btn_underoot.Click += btn_underoot_Click;
            // 
            // btn_sqaure
            // 
            btn_sqaure.BackColor = Color.RoyalBlue;
            btn_sqaure.Location = new Point(28, 302);
            btn_sqaure.Name = "btn_sqaure";
            btn_sqaure.Size = new Size(88, 83);
            btn_sqaure.TabIndex = 6;
            btn_sqaure.Text = "x^2";
            btn_sqaure.UseVisualStyleBackColor = false;
            btn_sqaure.Click += btn_inverse_Click;
            // 
            // btn_multiply
            // 
            btn_multiply.BackColor = Color.RoyalBlue;
            btn_multiply.Location = new Point(28, 209);
            btn_multiply.Name = "btn_multiply";
            btn_multiply.Size = new Size(88, 83);
            btn_multiply.TabIndex = 5;
            btn_multiply.Text = "*";
            btn_multiply.UseVisualStyleBackColor = false;
            btn_multiply.Click += btn_multiply_Click;
            // 
            // btn_divide
            // 
            btn_divide.BackColor = Color.RoyalBlue;
            btn_divide.Location = new Point(141, 214);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(88, 83);
            btn_divide.TabIndex = 4;
            btn_divide.Text = "/";
            btn_divide.UseVisualStyleBackColor = false;
            btn_divide.Click += btn_divide_Click;
            // 
            // btn_minus
            // 
            btn_minus.BackColor = Color.RoyalBlue;
            btn_minus.Location = new Point(141, 122);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(88, 83);
            btn_minus.TabIndex = 3;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = false;
            btn_minus.Click += btn_minus_Click;
            // 
            // btn_plus
            // 
            btn_plus.BackColor = Color.RoyalBlue;
            btn_plus.Location = new Point(28, 120);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(88, 83);
            btn_plus.TabIndex = 2;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = false;
            btn_plus.Click += btn_plus_Click;
            // 
            // btn_result
            // 
            btn_result.BackColor = Color.PaleVioletRed;
            btn_result.Location = new Point(254, 120);
            btn_result.Name = "btn_result";
            btn_result.Size = new Size(94, 261);
            btn_result.TabIndex = 1;
            btn_result.Text = "=";
            btn_result.UseVisualStyleBackColor = false;
            btn_result.Click += btn_result_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.DarkOrange;
            btn_clear.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_clear.Location = new Point(19, 25);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(329, 91);
            btn_clear.TabIndex = 0;
            btn_clear.Text = "CLEAR";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Btn_plus_minus);
            groupBox2.Controls.Add(btn_dot);
            groupBox2.Controls.Add(btn_0);
            groupBox2.Controls.Add(btn_9);
            groupBox2.Controls.Add(btn_8);
            groupBox2.Controls.Add(btn_7);
            groupBox2.Controls.Add(btn_6);
            groupBox2.Controls.Add(btn_5);
            groupBox2.Controls.Add(btn_4);
            groupBox2.Controls.Add(btn_3);
            groupBox2.Controls.Add(btn_2);
            groupBox2.Controls.Add(btn_1);
            groupBox2.Location = new Point(33, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(376, 391);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // Btn_plus_minus
            // 
            Btn_plus_minus.BackColor = Color.Black;
            Btn_plus_minus.Font = new Font("Microsoft Sans Serif", 22.2F);
            Btn_plus_minus.ForeColor = SystemColors.ControlLightLight;
            Btn_plus_minus.Location = new Point(247, 308);
            Btn_plus_minus.Name = "Btn_plus_minus";
            Btn_plus_minus.Size = new Size(94, 72);
            Btn_plus_minus.TabIndex = 11;
            Btn_plus_minus.Text = "±";
            Btn_plus_minus.UseVisualStyleBackColor = false;
            Btn_plus_minus.Click += Btn_plus_minus_Click;
            // 
            // btn_dot
            // 
            btn_dot.BackColor = Color.Black;
            btn_dot.Font = new Font("Microsoft Sans Serif", 22.2F);
            btn_dot.ForeColor = SystemColors.ControlLightLight;
            btn_dot.Location = new Point(139, 311);
            btn_dot.Name = "btn_dot";
            btn_dot.Size = new Size(94, 69);
            btn_dot.TabIndex = 10;
            btn_dot.Text = ".";
            btn_dot.UseVisualStyleBackColor = false;
            btn_dot.Click += button11_Click;
            // 
            // btn_0
            // 
            btn_0.BackColor = Color.Black;
            btn_0.Font = new Font("Microsoft Sans Serif", 22.2F);
            btn_0.ForeColor = SystemColors.ControlLightLight;
            btn_0.Location = new Point(19, 308);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(104, 74);
            btn_0.TabIndex = 9;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = false;
            btn_0.Click += btn_0_Click;
            // 
            // btn_9
            // 
            btn_9.BackColor = Color.Black;
            btn_9.Font = new Font("Microsoft Sans Serif", 22.2F);
            btn_9.ForeColor = SystemColors.ControlLightLight;
            btn_9.Location = new Point(247, 37);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(94, 81);
            btn_9.TabIndex = 8;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = false;
            btn_9.Click += btn_9_Click;
            // 
            // btn_8
            // 
            btn_8.BackColor = Color.Black;
            btn_8.Font = new Font("Microsoft Sans Serif", 22.2F);
            btn_8.ForeColor = SystemColors.ControlLightLight;
            btn_8.Location = new Point(139, 37);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(94, 81);
            btn_8.TabIndex = 7;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = false;
            btn_8.Click += btn_8_Click;
            // 
            // btn_7
            // 
            btn_7.BackColor = Color.Black;
            btn_7.Font = new Font("Microsoft Sans Serif", 22.2F);
            btn_7.ForeColor = SystemColors.ControlLightLight;
            btn_7.Location = new Point(19, 37);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(94, 81);
            btn_7.TabIndex = 6;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = false;
            btn_7.Click += btn_7_Click;
            // 
            // btn_6
            // 
            btn_6.BackColor = Color.Black;
            btn_6.Font = new Font("Microsoft Sans Serif", 22.2F);
            btn_6.ForeColor = SystemColors.ControlLightLight;
            btn_6.Location = new Point(247, 130);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(94, 81);
            btn_6.TabIndex = 5;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = false;
            btn_6.Click += btn_6_Click;
            // 
            // btn_5
            // 
            btn_5.BackColor = Color.Black;
            btn_5.Font = new Font("Microsoft Sans Serif", 22.2F);
            btn_5.ForeColor = SystemColors.ControlLightLight;
            btn_5.Location = new Point(139, 130);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(94, 81);
            btn_5.TabIndex = 4;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = false;
            btn_5.Click += btn_5_Click;
            // 
            // btn_4
            // 
            btn_4.BackColor = Color.Black;
            btn_4.Font = new Font("Microsoft Sans Serif", 22.2F);
            btn_4.ForeColor = SystemColors.ControlLightLight;
            btn_4.Location = new Point(19, 130);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(94, 81);
            btn_4.TabIndex = 3;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = false;
            btn_4.Click += btn_4_Click;
            // 
            // btn_3
            // 
            btn_3.BackColor = Color.Black;
            btn_3.Font = new Font("Microsoft Sans Serif", 22.2F);
            btn_3.ForeColor = SystemColors.ControlLightLight;
            btn_3.Location = new Point(247, 221);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(94, 81);
            btn_3.TabIndex = 2;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = false;
            btn_3.Click += btn_3_Click;
            // 
            // btn_2
            // 
            btn_2.BackColor = Color.Black;
            btn_2.Font = new Font("Microsoft Sans Serif", 22.2F);
            btn_2.ForeColor = SystemColors.ControlLightLight;
            btn_2.Location = new Point(139, 224);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(94, 81);
            btn_2.TabIndex = 1;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = false;
            btn_2.Click += btn_2_Click;
            // 
            // btn_1
            // 
            btn_1.BackColor = Color.Black;
            btn_1.Font = new Font("Microsoft Sans Serif", 22.2F);
            btn_1.ForeColor = SystemColors.ControlLightLight;
            btn_1.Location = new Point(19, 221);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(94, 81);
            btn_1.TabIndex = 0;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = false;
            btn_1.Click += btn_1_Click;
            // 
            // rbdStandard
            // 
            rbdStandard.AutoSize = true;
            rbdStandard.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbdStandard.Location = new Point(234, 134);
            rbdStandard.Name = "rbdStandard";
            rbdStandard.Size = new Size(97, 24);
            rbdStandard.TabIndex = 5;
            rbdStandard.TabStop = true;
            rbdStandard.Text = "Standard";
            rbdStandard.UseVisualStyleBackColor = true;
            rbdStandard.CheckedChanged += rbdStandard_CheckedChanged;
            // 
            // RbdScientific
            // 
            RbdScientific.AutoSize = true;
            RbdScientific.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RbdScientific.Location = new Point(81, 134);
            RbdScientific.Name = "RbdScientific";
            RbdScientific.Size = new Size(99, 24);
            RbdScientific.TabIndex = 4;
            RbdScientific.TabStop = true;
            RbdScientific.Text = "Scientific";
            RbdScientific.UseVisualStyleBackColor = true;
            RbdScientific.CheckedChanged += RbdScientific_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbLight);
            groupBox1.Controls.Add(rdbDark);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(626, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(144, 47);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modes";
            // 
            // rdbLight
            // 
            rdbLight.AutoSize = true;
            rdbLight.Location = new Point(75, 17);
            rdbLight.Name = "rdbLight";
            rdbLight.Size = new Size(61, 24);
            rdbLight.TabIndex = 1;
            rdbLight.TabStop = true;
            rdbLight.Text = "light";
            rdbLight.UseVisualStyleBackColor = true;
            rdbLight.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdbDark
            // 
            rdbDark.AutoSize = true;
            rdbDark.Location = new Point(6, 17);
            rdbDark.Name = "rdbDark";
            rdbDark.Size = new Size(66, 24);
            rdbDark.TabIndex = 0;
            rdbDark.TabStop = true;
            rdbDark.Text = "Dark";
            rdbDark.UseVisualStyleBackColor = true;
            rdbDark.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // txtvalue
            // 
            txtvalue.BackColor = SystemColors.HighlightText;
            txtvalue.Font = new Font("Segoe UI Emoji", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtvalue.Location = new Point(25, 28);
            txtvalue.Name = "txtvalue";
            txtvalue.Size = new Size(842, 87);
            txtvalue.TabIndex = 0;
            txtvalue.TextAlign = HorizontalAlignment.Right;
            txtvalue.TextChanged += textBox1_TextChanged;
            // 
            // tbAboutMe
            // 
            tbAboutMe.BackColor = Color.RosyBrown;
            tbAboutMe.Controls.Add(pictureBox2);
            tbAboutMe.Controls.Add(textBox1);
            tbAboutMe.Controls.Add(pictureBox1);
            tbAboutMe.Location = new Point(4, 29);
            tbAboutMe.Name = "tbAboutMe";
            tbAboutMe.Padding = new Padding(3);
            tbAboutMe.Size = new Size(901, 582);
            tbAboutMe.TabIndex = 1;
            tbAboutMe.Text = "About Me";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.centennial_college_logo_vector;
            pictureBox2.Location = new Point(235, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(433, 131);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.RosyBrown;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Perpetua Titling MT", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(78, 447);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(796, 129);
            textBox1.TabIndex = 1;
            textBox1.Text = "Hi my name is Jasdish Singh and i recently turned 18 . I have quite a few hobbies like playing chess , going out with friends and many more . ";
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MeriPhoto;
            pictureBox1.Location = new Point(247, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 314);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 617);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "The Most Advanced Calculator";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tbCalculator.ResumeLayout(false);
            tbCalculator.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tbAboutMe.ResumeLayout(false);
            tbAboutMe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbCalculator;
        private TabPage tbAboutMe;
        private GroupBox groupBox1;
        private TextBox txtvalue;
        private RadioButton rbdStandard;
        private RadioButton RbdScientific;
        private GroupBox groupBox2;
        private Button Btn_plus_minus;
        private Button btn_dot;
        private Button btn_0;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_3;
        private Button btn_2;
        private Button btn_1;
        private GroupBox groupBox3;
        private Button btn_underoot;
        private Button btn_sqaure;
        private Button btn_multiply;
        private Button btn_divide;
        private Button btn_minus;
        private Button btn_plus;
        private Button btn_result;
        private Button btn_clear;
        private Button btn_cube;
        private Button btn_cos;
        private Button btn_sin;
        private Button btn_Pie;
        private RadioButton rdbLight;
        private RadioButton rdbDark;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
    }
}
