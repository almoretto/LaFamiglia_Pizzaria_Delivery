using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace UserInterface.Modules
{
    public static class MonetaryMask
    {
        public static void MakeMask(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text.Trim() == string.Empty)
            {
                txt.Text = "0,00";
                UnMakeMask(sender, e);
                return;
            }
            //This line is responsible to create a mask like if price is 100 mask is R$100,00
            txt.Text = double.Parse(txt.Text).ToString("C2", CultureInfo.CurrentCulture);
        }
        
        public static void UnMakeMask(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text.Trim() == string.Empty) { return; }

            //This line is responsible to remove the mask like 00010 converts to int.. 10 them to string without mask
            txt.Text = txt.Text.Replace("R$", "").Trim(); // remove currency symbol
            txt.Focus(); //put the focus on the control
            txt.Select(0, txt.Text.Length); //select all the content of the control.
        }

        public static void OnlyNumericValues(object sender, KeyPressEventArgs k)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(k.KeyChar) && k.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (k.KeyChar == ',') { k.Handled = txt.Text.Contains(','); }
                else { k.Handled = true; }
            }
        }
        
        public static void AplyEvents(TextBox txt)
        {
            //This three lines concatenates the static method to those events of the TextBox
            txt.Enter += UnMakeMask;
            txt.Leave += MakeMask;
            txt.KeyPress += OnlyNumericValues;
        }
    }
}
