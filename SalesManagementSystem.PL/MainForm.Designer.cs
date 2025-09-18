namespace SalesManagementSystem.PL
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.ForeColor = Color.White;
            button1.Location = new Point(264, 257);
            button1.Name = "button1";
            button1.Size = new Size(110, 43);
            button1.TabIndex = 0;
            button1.Text = "الاصناف";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.ForeColor = Color.White;
            button2.Location = new Point(414, 255);
            button2.Name = "button2";
            button2.Size = new Size(110, 43);
            button2.TabIndex = 1;
            button2.Text = "المجموعات";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSlateGray;
            button3.ForeColor = Color.White;
            button3.Location = new Point(568, 257);
            button3.Name = "button3";
            button3.Size = new Size(110, 43);
            button3.TabIndex = 2;
            button3.Text = "فاتور البيع";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSlateGray;
            button4.ForeColor = Color.White;
            button4.Location = new Point(368, 346);
            button4.Name = "button4";
            button4.Size = new Size(187, 43);
            button4.TabIndex = 3;
            button4.Text = "تقارير المبيعات";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSlateGray;
            button5.ForeColor = Color.White;
            button5.Location = new Point(110, 257);
            button5.Name = "button5";
            button5.Size = new Size(110, 43);
            button5.TabIndex = 4;
            button5.Text = "الخزنة";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkSlateGray;
            button6.ForeColor = Color.White;
            button6.Location = new Point(724, 255);
            button6.Name = "button6";
            button6.Size = new Size(110, 43);
            button6.TabIndex = 5;
            button6.Text = "العملاء";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 604);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Droid Arabic Kufi", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}