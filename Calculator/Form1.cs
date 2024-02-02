namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("error message") ;
        }

        private void sumbutton_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0;
                if (!string.IsNullOrEmpty(firsttextBox.Text)) ;
                {
                    a = Convert.ToInt16(firsttextBox.Text);
                    
                }

                int b = 0;
                if (!string.IsNullOrEmpty(secondtextBox.Text)) ;
                {
                   b = Convert.ToInt16(secondtextBox.Text);
                }
                
                rusultshow.Text = (a + b).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0;
                if (!string.IsNullOrEmpty(firsttextBox.Text))
                {
                    a = Convert.ToInt32(firsttextBox.Text);
                }

                int b = 0;
                if (!string.IsNullOrEmpty(secondtextBox.Text))
                {
                    b = Convert.ToInt32(secondtextBox.Text);
                }

                rusultshow.Text = (a - b).ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            }




        }

        
    }
}