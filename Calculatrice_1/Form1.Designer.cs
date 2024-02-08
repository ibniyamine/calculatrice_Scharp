namespace Calculatrice_1
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnAC = new ePOSOne.btnProduct.Button_WOC();
            totalText = new TextBox();
            btnPM = new ePOSOne.btnProduct.Button_WOC();
            btnPourcentage = new ePOSOne.btnProduct.Button_WOC();
            btnDivision = new ePOSOne.btnProduct.Button_WOC();
            btnEgale = new ePOSOne.btnProduct.Button_WOC();
            btnDifference = new ePOSOne.btnProduct.Button_WOC();
            btnMultiplication = new ePOSOne.btnProduct.Button_WOC();
            btnAddition = new ePOSOne.btnProduct.Button_WOC();
            btn7 = new ePOSOne.btnProduct.Button_WOC();
            btn8 = new ePOSOne.btnProduct.Button_WOC();
            btn9 = new ePOSOne.btnProduct.Button_WOC();
            btn4 = new ePOSOne.btnProduct.Button_WOC();
            btn5 = new ePOSOne.btnProduct.Button_WOC();
            btn6 = new ePOSOne.btnProduct.Button_WOC();
            btn1 = new ePOSOne.btnProduct.Button_WOC();
            btn2 = new ePOSOne.btnProduct.Button_WOC();
            btn3 = new ePOSOne.btnProduct.Button_WOC();
            btnVirgule = new ePOSOne.btnProduct.Button_WOC();
            btn0 = new ePOSOne.btnProduct.Button_WOC();
            SuspendLayout();
            // 
            // btnAC
            // 
            btnAC.BackColor = Color.Gray;
            btnAC.FlatAppearance.MouseOverBackColor = Color.Black;
            btnAC.FlatStyle = FlatStyle.Popup;
            btnAC.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAC.ForeColor = Color.Black;
            btnAC.Location = new Point(12, 144);
            btnAC.Name = "btnAC";
            btnAC.Size = new Size(68, 70);
            btnAC.TabIndex = 0;
            btnAC.Text = "AC";
            btnAC.UseVisualStyleBackColor = false;
            btnAC.Click += btnAC_Click;
            // 
            // totalText
            // 
            totalText.BackColor = SystemColors.MenuText;
            totalText.BorderStyle = BorderStyle.None;
            totalText.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalText.ForeColor = SystemColors.ControlLight;
            totalText.Location = new Point(1, 45);
            totalText.Multiline = true;
            totalText.Name = "totalText";
            totalText.Size = new Size(361, 85);
            totalText.TabIndex = 1;
            totalText.Text = "0";
            totalText.TextAlign = HorizontalAlignment.Right;
            // 
            // btnPM
            // 
            btnPM.BackColor = Color.Gray;
            btnPM.FlatStyle = FlatStyle.Popup;
            btnPM.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPM.Location = new Point(99, 144);
            btnPM.Name = "btnPM";
            btnPM.Size = new Size(68, 70);
            btnPM.TabIndex = 2;
            btnPM.Text = "+/-";
            btnPM.UseVisualStyleBackColor = false;
            btnPM.Click += btnPM_Click;
            // 
            // btnPourcentage
            // 
            btnPourcentage.BackColor = Color.Gray;
            btnPourcentage.FlatStyle = FlatStyle.Popup;
            btnPourcentage.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPourcentage.Location = new Point(186, 144);
            btnPourcentage.Name = "btnPourcentage";
            btnPourcentage.Size = new Size(71, 70);
            btnPourcentage.TabIndex = 3;
            btnPourcentage.Text = "%";
            btnPourcentage.UseVisualStyleBackColor = false;
            btnPourcentage.Click += btnPourcentage_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.FromArgb(255, 128, 0);
            btnDivision.FlatStyle = FlatStyle.Popup;
            btnDivision.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivision.Location = new Point(276, 144);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(71, 70);
            btnDivision.TabIndex = 4;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnEgale
            // 
            btnEgale.BackColor = Color.FromArgb(255, 128, 0);
            btnEgale.FlatStyle = FlatStyle.Flat;
            btnEgale.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEgale.Location = new Point(278, 460);
            btnEgale.Name = "btnEgale";
            btnEgale.Size = new Size(71, 70);
            btnEgale.TabIndex = 5;
            btnEgale.Text = "=";
            btnEgale.UseVisualStyleBackColor = false;
            btnEgale.Click += btnEgale_Click;
            // 
            // btnDifference
            // 
            btnDifference.BackColor = Color.FromArgb(255, 128, 0);
            btnDifference.FlatStyle = FlatStyle.Popup;
            btnDifference.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDifference.Location = new Point(278, 302);
            btnDifference.Name = "btnDifference";
            btnDifference.Size = new Size(71, 70);
            btnDifference.TabIndex = 6;
            btnDifference.Text = "-";
            btnDifference.UseVisualStyleBackColor = false;
            btnDifference.Click += btnDifference_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.BackColor = Color.FromArgb(255, 128, 0);
            btnMultiplication.FlatStyle = FlatStyle.Popup;
            btnMultiplication.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiplication.Location = new Point(278, 223);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(71, 70);
            btnMultiplication.TabIndex = 7;
            btnMultiplication.Text = "X";
            btnMultiplication.UseVisualStyleBackColor = false;
            btnMultiplication.Click += btnMultiplication_Click;
            // 
            // btnAddition
            // 
            btnAddition.BackColor = Color.FromArgb(255, 128, 0);
            btnAddition.FlatStyle = FlatStyle.Flat;
            btnAddition.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddition.Location = new Point(278, 381);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(71, 70);
            btnAddition.TabIndex = 8;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = false;
            btnAddition.Click += btnAddition_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(64, 64, 64);
            btn7.FlatStyle = FlatStyle.Popup;
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.ForeColor = Color.White;
            btn7.Location = new Point(12, 224);
            btn7.Name = "btn7";
            btn7.Size = new Size(68, 70);
            btn7.TabIndex = 17;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(64, 64, 64);
            btn8.FlatStyle = FlatStyle.Popup;
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.ForeColor = Color.White;
            btn8.Location = new Point(97, 223);
            btn8.Name = "btn8";
            btn8.Size = new Size(68, 70);
            btn8.TabIndex = 18;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(64, 64, 64);
            btn9.FlatStyle = FlatStyle.Popup;
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.ForeColor = Color.White;
            btn9.Location = new Point(186, 223);
            btn9.Name = "btn9";
            btn9.Size = new Size(68, 70);
            btn9.TabIndex = 19;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(64, 64, 64);
            btn4.FlatStyle = FlatStyle.Popup;
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.ForeColor = Color.White;
            btn4.Location = new Point(12, 304);
            btn4.Name = "btn4";
            btn4.Size = new Size(68, 70);
            btn4.TabIndex = 20;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(64, 64, 64);
            btn5.FlatStyle = FlatStyle.Popup;
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.ForeColor = Color.White;
            btn5.Location = new Point(97, 302);
            btn5.Name = "btn5";
            btn5.Size = new Size(68, 70);
            btn5.TabIndex = 21;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(64, 64, 64);
            btn6.FlatStyle = FlatStyle.Popup;
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(186, 302);
            btn6.Name = "btn6";
            btn6.Size = new Size(68, 70);
            btn6.TabIndex = 22;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(64, 64, 64);
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(12, 384);
            btn1.Name = "btn1";
            btn1.Size = new Size(68, 70);
            btn1.TabIndex = 23;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(64, 64, 64);
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(97, 381);
            btn2.Name = "btn2";
            btn2.Size = new Size(68, 70);
            btn2.TabIndex = 24;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(64, 64, 64);
            btn3.FlatStyle = FlatStyle.Popup;
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(189, 381);
            btn3.Name = "btn3";
            btn3.Size = new Size(68, 70);
            btn3.TabIndex = 25;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btnVirgule
            // 
            btnVirgule.BackColor = Color.FromArgb(64, 64, 64);
            btnVirgule.FlatStyle = FlatStyle.Popup;
            btnVirgule.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVirgule.ForeColor = Color.White;
            btnVirgule.Location = new Point(189, 460);
            btnVirgule.Name = "btnVirgule";
            btnVirgule.Size = new Size(68, 70);
            btnVirgule.TabIndex = 26;
            btnVirgule.Text = ",";
            btnVirgule.UseVisualStyleBackColor = false;
            btnVirgule.Click += btnVirgule_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(64, 64, 64);
            btn0.FlatStyle = FlatStyle.Popup;
            btn0.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.ForeColor = Color.White;
            btn0.Location = new Point(12, 463);
            btn0.Name = "btn0";
            btn0.Size = new Size(153, 65);
            btn0.TabIndex = 27;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(363, 554);
            Controls.Add(btn0);
            Controls.Add(btnVirgule);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnAddition);
            Controls.Add(btnMultiplication);
            Controls.Add(btnDifference);
            Controls.Add(btnEgale);
            Controls.Add(btnDivision);
            Controls.Add(btnPourcentage);
            Controls.Add(btnPM);
            Controls.Add(totalText);
            Controls.Add(btnAC);
            Name = "Form1";
            Text = "calculatrice";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ePOSOne.btnProduct.Button_WOC btnAC;
        private TextBox totalText;
        private ePOSOne.btnProduct.Button_WOC btnPM;
        private ePOSOne.btnProduct.Button_WOC btnPourcentage;
        private ePOSOne.btnProduct.Button_WOC btnDivision;
        private ePOSOne.btnProduct.Button_WOC btnEgale;
        private ePOSOne.btnProduct.Button_WOC btnDifference;
        private ePOSOne.btnProduct.Button_WOC btnMultiplication;
        private ePOSOne.btnProduct.Button_WOC btnAddition;
        private ePOSOne.btnProduct.Button_WOC btn7;
        private ePOSOne.btnProduct.Button_WOC btn8;
        private ePOSOne.btnProduct.Button_WOC btn9;
        private ePOSOne.btnProduct.Button_WOC btn4;
        private ePOSOne.btnProduct.Button_WOC btn5;
        private ePOSOne.btnProduct.Button_WOC btn6;
        private ePOSOne.btnProduct.Button_WOC btn1;
        private ePOSOne.btnProduct.Button_WOC btn2;
        private ePOSOne.btnProduct.Button_WOC btn3;
        private ePOSOne.btnProduct.Button_WOC btnVirgule;
        private ePOSOne.btnProduct.Button_WOC btn0;
    }
}
