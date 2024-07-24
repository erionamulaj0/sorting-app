namespace sorting_app
{
    public partial class Form1 : Form
    {
        public int num1;
        public int num2;
        public int num3;
        public int num4;
        public int num5;
        public int num6;
        public int num7;
        public int num8;
        int[] array = new int[8];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            num2= int.Parse(textBox2.Text);
            num3= int.Parse(textBox3.Text);
            num4= int.Parse(textBox4.Text);
            num5= int.Parse(textBox5.Text);
            num6= int.Parse(textBox6.Text);
            num7= int.Parse(textBox7.Text);
            num8= int.Parse(textBox8.Text);
            array = new int[] { num1, num2, num3, num4, num5, num6, num7, num8 };

            for(int i = 1; i< array.Length; i++)
            {
                var key = array[i];
                int j = i - 1;

                while(j >= 0 && array[j] > key) 
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                    array[j + 1] = key;
                }
            }

            string sorted_array = string.Join(",", array);
            label3.Text = sorted_array;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            array = new int[8];
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            label3.Text = "";
        }
    }
}