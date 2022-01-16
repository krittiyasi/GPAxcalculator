namespace GPAxcalculator
{
    public partial class Form1 : Form
    {
        GPAcalculator oGPAcal = new GPAcalculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = this.textBoxGPA_input.Text;
            string name = this.textBoxName_input.Text;

            double dInput = Convert.ToDouble(input);
            oGPAcal.addGPA(dInput,name);

            double gpax = oGPAcal.getGPAX();
            textBoxGPX.Text = gpax.ToString();

            double Max = oGPAcal.getMax();
            textBoxMaxGPA.Text = Max.ToString();
            string Maxname = oGPAcal.getMaxName();
            textBoxMaxname.Text = Maxname.ToString();

            double Min = oGPAcal.getMin();
            textBoxMinGPA.Text = Min.ToString();
            string Minname = oGPAcal.getMinName();
            textBoxMinname.Text = Minname.ToString();

            textBoxGPA_input.Text = "";
            textBoxName_input.Text = "";
            textBoxALLDATA.Text = oGPAcal.getALLDATA();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxGPX.Text = "";
            textBoxGPA_input.Text = "";
            textBoxMaxGPA.Text = "";
            textBoxMinGPA.Text = "";
            textBoxALLDATA.Text = "";
            textBoxMaxname.Text = "";
            textBoxMinname.Text = "";
        }
    }
}