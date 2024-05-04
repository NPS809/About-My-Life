namespace AboutMyLife
{
    public partial class Form1 : Form
    {
        public static int cell_size = 10;

        public Form1()
        {
            InitializeComponent();
            Size = new Size(cell_size * 70 + 16, Size.Height);
            field.Size = new Size(field.Size.Width, 520);
            for (int i = 0; i < 3640; i++)
            {
                Panel pnl = new Panel();
                pnl.BorderStyle = BorderStyle.FixedSingle;
                pnl.Size = new Size(10, 10);
                pnl.Margin = new Padding(0);
                field.Controls.Add(pnl);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int age = Convert.ToInt32(textBox1.Text);
                if (age > 70) {
                    MessageBox.Show("Не больше 70, потому что комп говнище ебаное!!!");
                } else
                {
                    int weeks = age * 52;
                    int days = weeks * 7;
                    int hours = days * 24;
                    int minutes = hours * 60;
                    int seconds = minutes * 60;
                    foreach (Control ctrl in field.Controls)
                    {
                        ctrl.BackColor = Color.Transparent;
                    }
                    for (int i = 0; i < weeks; i++)
                    {
                        field.Controls[i].BackColor = Color.Green;
                    }
                    losted_time.Text = $"Потраченое время: \nЛет: {age} или\nНедель: {weeks} или\nДней: {days} или\nЧасов: {hours} или\nМинут: {minutes} или\nCекунд: {seconds}";
                }
                
            } catch {
                MessageBox.Show("Только цифры");
                textBox1.Text = "";
            } 
            
        }
    }
}
