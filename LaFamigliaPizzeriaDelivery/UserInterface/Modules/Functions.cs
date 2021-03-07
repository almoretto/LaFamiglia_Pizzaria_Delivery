using BusinessRules;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UserInterface.Modules
{
    public class Functions
    {
        public static object MdiParent { get; private set; }

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
                    line.BackColor = Color.Beige;
                }
            }
        }

        public static void SetSelectedFocus(TextBox textBox)
        {
            textBox.Focus();
            textBox.Select();
        }

        public static long? RemoveMaskFromMaskedFields(MaskedTextBox mTextBox)
        {
            mTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string mTextBoxContent = RemoveBlanks(mTextBox.Text);
            mTextBox.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            if (mTextBoxContent == string.Empty)
            {
                return null;
            }
            else
            {
                return Convert.ToInt64(mTextBoxContent);
            }
        }

        public static string RemoveBlanks(string strg)
        {
            return strg.Trim().Replace(" ", "");
        }

        public static bool OptimizeAll()
        {
            ProgramGeneralBus _pgBus = new ProgramGeneralBus();
            if (_pgBus.OptimizeAll())
            { return true; }
            else
            { return false; }
        }
    }
}
