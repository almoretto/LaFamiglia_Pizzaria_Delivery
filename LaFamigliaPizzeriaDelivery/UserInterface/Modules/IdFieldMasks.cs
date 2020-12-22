using System;
using System.Windows.Forms;

namespace UserInterface.Modules
{
    public static class IdFieldMasks
    {
        public static void MakeMask(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text.Trim() == string.Empty) { return; }

            //This line is responsible to create a mask like if id is 10 mask is 00010
            txt.Text = Int32.Parse(txt.Text).ToString("00000");
        }
        public static void UnMakeMask(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text.Trim() == string.Empty) { return; }

            //This line is responsible to remove the mask like 00010 converts to int.. 10 them to string without mask
            txt.Text = Convert.ToInt32(txt.Text.Trim()).ToString();
            txt.Focus(); //put the focus on the control
            txt.Select(0, txt.Text.Length); //select all the content of the control.
        }

        public static void OnlyNumericValues(object sender, KeyPressEventArgs k)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(k.KeyChar) && k.KeyChar != Convert.ToChar(Keys.Back))
            {
                k.Handled = true;
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
