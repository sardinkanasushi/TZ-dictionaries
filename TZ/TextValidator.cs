using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TZ
{
    public static class TextValidator
    {
        public static void Validate(TextBox textBox)
        {
            try
            {
                textBox.Text = Correct(textBox.Text);
                textBox.SelectionStart = textBox.Text.Length;
            } 
            catch (Exception ex)
            {
            }
        }
        public static void Validate(RichTextBox textBox)
        {
            try
            {
                textBox.Text = Correct(textBox.Text);
                textBox.SelectionStart = textBox.Text.Length;
            }
            catch (Exception ex)
            {
            }
        }
        private static string Correct(String text)
        {
            return Regex.Replace(text, @"[^\w\ ()%$#@=]", "", RegexOptions.None, TimeSpan.FromSeconds(1.5));
        }
    }
}
