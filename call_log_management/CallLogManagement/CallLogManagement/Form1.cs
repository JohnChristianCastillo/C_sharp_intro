namespace CallLogManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox1, "Please enter the name");
            }
            else if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox4, "Please enter the phone number");
            }
            else
            {
                Connection conn = new Connection();
                conn.data_send(@"INSERT INTO CallDetails
         (Name, FatherName, Address, MobileNumber, Date, Time, Duration, Notes, Status)
VALUES ('"+textBox1.Text+"','"+textBox2.Text+ "','"+textBox4.Text+ "','"+textBox3.Text+ "','"+comboBox1.SelectedItem as string+ "'," +
"'"+dateTimePicker1.Value+ "','"+textBox7.Text + "','"+textBox6.Text+ "','"+textBox5.Text+"')");

                clear_entries();
                MessageBox.Show("Saved Sucesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // clear data fields
        void clear_entries()
        {
            // get first item value in combo box

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox6.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "")
                {
                    textBox2.Focus();
                }
                else
                {
                    MessageBox.Show("Please enter the name");
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox4.Text != "")
                {
                    textBox3.Focus();
                }
                else
                {
                    MessageBox.Show("Please enter the phone number");
                }
            }
        }
    }
}