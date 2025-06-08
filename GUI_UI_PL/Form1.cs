using Bll_services;
using System.Security.Cryptography.X509Certificates;
using DTO_Common_enteties;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_UI_PL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Ariel", 26);
            label1.ForeColor = Color.AliceBlue;
            AllFoundplaces.ForeColor = Color.Black;
            Gimatry.ForeColor = Color.Black;
            Finds_Chumash.ForeColor = Color.Black;
            finds_word.ForeColor = Color.Black;
            finds_word.BackColor = Color.Beige;
            AllFoundplaces.BackColor = Color.Beige;
            Gimatry.BackColor = Color.Beige;
            Finds_Chumash.BackColor = Color.Beige;

            find_gimatry.ForeColor = Color.Red;
            Findlocations.ForeColor = Color.Red;
            look_for_word.ForeColor = Color.Red;
            look_for_in_Chumash.ForeColor = Color.Red;

        }




        private void Findlocations_Click(object sender, EventArgs e)
        {

            AllFoundplaces.DataSource = Bll_services.Class2.loc();

        }
        private void look_for_word_Click(object sender, EventArgs e)
        {
            finds_word.DataSource = Bll_services.Class2.find(textBox1.Text);
        }
        private void find_gimatry_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                Gimatry.DataSource = Bll_services.Class2.Gimatria(textBox4.Text);
            }
            else { Gimatry.DataSource = Bll_services.Class2.Gimatria(text.Text); }
        }


        private void look_for_in_Chumash_Click(object sender, EventArgs e)
        {
            Finds_Chumash.DataSource = Bll_services.Class2.Chumashfind(textBox1.Text, textBox2.Text, textBox5.Text);
        }




























        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        //JsonConvert

        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        private void label2_Click(object sender, EventArgs e)
        {
            //xxxxxxxxxxxxxxxxxxxxxxxx
        }
        private void Form1_Load(object sender, EventArgs e)

        {            //xxxxxxxxxxxxxxxxxxxxxxxx
        }

        private void Gimatry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AllFoundplaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            //xxxxxxxxxxxxxxxx
            AllFoundplaces.DataSource = Bll_services.Class2.loc();

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}