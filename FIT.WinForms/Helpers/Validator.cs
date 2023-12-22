namespace FIT.WinForms.Helpers
{
    public class Validator
    {
        public static bool ProvjeriUnos(Control kontrola, ErrorProvider err, string name)
        {
            bool valid = true;

            if(kontrola is PictureBox && (kontrola as PictureBox).Image == null)
                valid = false;
            else if(kontrola is ComboBox && (kontrola as ComboBox).SelectedIndex < 0)
                valid = false;
            else if(kontrola is TextBox && !(kontrola as TextBox).Text.IsSet())
                valid = false;

            if(!valid)
            {
                err.SetError(kontrola, Resursi.Get(name));
                return false;
            }
            err.Clear();
            return true;
        }
    }
}
