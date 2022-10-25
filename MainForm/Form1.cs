using Countries;

namespace MainForm
{
    public partial class Form1 : Form
    {

        private CountryRepository _countryRepository = new CountryRepository();
        private BindingSource _tableBindingSource = new BindingSource();
        public Form1()
        {


        }
    }
}
