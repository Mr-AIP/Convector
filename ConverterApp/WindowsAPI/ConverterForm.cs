using PhysicValuesLib;

namespace WindowsAPI
{
    public partial class ConverterForm : Form
    {
        private ConverterManager _manager;

        public ConverterForm()
        {
            InitializeComponent();
            _manager = new ConverterManager();
        }

        private void ConverterFormLoad(object sender, EventArgs e)
        {
            ListOfValues.Items.AddRange(_manager.GetPhysicValuesList().ToArray());
            ListOfValues.SelectedIndex = 0;          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TransferFrom.Items.Clear();
            TransferTo.Items.Clear();
            TransferFrom.Items.AddRange(_manager.GetMeasureList(ListOfValues.SelectedItem.ToString()).ToArray());
            TransferTo.Items.AddRange(_manager.GetMeasureList(ListOfValues.SelectedItem.ToString()).ToArray());
            TransferFrom.SelectedIndex = 0;
            TransferTo.SelectedIndex = 0;
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(textBox1.Text);         // считали число
                string physicValue = ListOfValues.SelectedItem.ToString();
                string from = TransferFrom.SelectedItem.ToString();
                string to = TransferTo.SelectedItem.ToString();
                double result = _manager.GetConvertedValue(physicValue, value, from, to);
                textBox2.Text = result.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TransferFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TranfersTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}