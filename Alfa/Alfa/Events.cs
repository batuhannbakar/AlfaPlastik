using System.Windows.Forms;

namespace Alfa
{
    public class Events
    {
        public void StringBlock(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void IntBlock(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void StringIntBlock(KeyPressEventArgs e)
        {
            StringBlock(e);
            IntBlock(e);
        }
    }
}