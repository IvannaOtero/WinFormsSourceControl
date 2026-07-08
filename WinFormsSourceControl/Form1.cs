namespace WinFormsSourceControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateAreaAndPerimeterBtn_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(lengthTxt.Text);
            int width = Convert.ToInt32(widthTxt.Text);

            int area = length * width;
            int perimeter = length * 2 + width * 2;

            areaTxt.Text = "Area is: " + area;
            perimeterTxt.Text = "Area is: " + perimeter; 

        }
    }
}
