namespace Calculator
{
    public partial class Form1 : Form
    {
        private void SaveSetting()
        {
            Properties.Settings.Default.Location = this.Location;

            Properties.Settings.Default.Save();
        }
        private void LoadSetting()
        {
            this.Location = Properties.Settings.Default.Location;


        }
        public Form1()
        {
            InitializeComponent();
        }
        float data1, data2;
        string pheptinh;


        private void button15_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pheptinh = "cong";
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            hienthi1.Text = hienthi1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            hienthi1.Clear();
            hienthi2.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (pheptinh == "cong")
            {
                data2 = data1 + float.Parse(hienthi1.Text);
                hienthi2.Text = data1.ToString() + " + " + float.Parse(hienthi1.Text) + " = ";
                hienthi1.Text = data2.ToString();
            }
            if (pheptinh == "tru")
            {
                data2 = data1 - float.Parse(hienthi1.Text);
                hienthi2.Text = data1.ToString() + " - " + float.Parse(hienthi1.Text) + " = ";
                hienthi1.Text = data2.ToString();
            }
            if (pheptinh == "nhan")
            {
                data2 = data1 * float.Parse(hienthi1.Text);
                hienthi2.Text = data1.ToString() + " * " + float.Parse(hienthi1.Text) + " = ";
                hienthi1.Text = data2.ToString();
            }
            if (pheptinh == "chia")
            {
                if (float.Parse(hienthi1.Text) == 0)
                {
                    hienthi2.Text = data1.ToString() + " / " + float.Parse(hienthi1.Text) + " = ";
                    hienthi1.Text = "ERROR";
                }
                else
                {
                    data2 = data1 / float.Parse(hienthi1.Text);
                    hienthi2.Text = data1.ToString() + " / " + float.Parse(hienthi1.Text) + " = ";
                    hienthi1.Text = data2.ToString();
                }
            }
            if (pheptinh == "mod")
            {
                data2 = data1 % float.Parse(hienthi1.Text);
                hienthi2.Text = data1.ToString() + " % " + float.Parse(hienthi1.Text) + " = ";
                hienthi1.Text = data2.ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pheptinh = "tru";
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pheptinh = "nhan";
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();

        }

        private void button17_Click(object sender, EventArgs e)
        {


            pheptinh = "chia";
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            hienthi1.Text = "0";

            string f, s;

            f = Convert.ToString(data1);
            s = Convert.ToString(data2);

            f = "";
            s = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSetting();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSetting();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pheptinh = "mod";
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();

        }
    }
}
