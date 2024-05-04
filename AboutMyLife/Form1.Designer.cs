namespace AboutMyLife
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
            field = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            losted_time = new Label();
            SuspendLayout();
            // 
            // field
            // 
            field.AutoScroll = true;
            field.Dock = DockStyle.Bottom;
            field.Location = new Point(0, 126);
            field.Name = "field";
            field.Size = new Size(852, 520);
            field.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 10);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 2;
            label1.Text = "- Неделя";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 4;
            label2.Text = "Введите ваш возраст";
            // 
            // button1
            // 
            button1.Location = new Point(118, 85);
            button1.Name = "button1";
            button1.Size = new Size(211, 23);
            button1.TabIndex = 5;
            button1.Text = "Вычислить потраченное время";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // losted_time
            // 
            losted_time.AutoSize = true;
            losted_time.Location = new Point(341, 9);
            losted_time.Name = "losted_time";
            losted_time.Size = new Size(0, 15);
            losted_time.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 646);
            Controls.Add(losted_time);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(field);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Калькулятор времени твоей бессмысленной жизни";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel field;
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Label losted_time;
    }
}
