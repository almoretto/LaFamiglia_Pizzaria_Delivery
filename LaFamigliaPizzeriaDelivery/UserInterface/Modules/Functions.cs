using System.Drawing;
using System.Windows.Forms;

namespace UserInterface.Modules
{
    public class Functions
    {
        public static void ListViewColor(ListView list)
        {
            foreach (ListViewItem line in list.Items)
            {
                if (line.Index % 2 == 0)
                {
                    line.BackColor = Color.White;
                }
                else
                {
                    line.BackColor = Color.Linen;
                }
            }
        }

        public static void SetSelectedFocus(TextBox textBox)
        {
            textBox.Focus();
            textBox.Select();
        }
    }
}
