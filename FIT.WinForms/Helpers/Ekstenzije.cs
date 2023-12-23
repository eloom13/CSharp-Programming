namespace FIT.WinForms.Helpers
{
    public static class Ekstenzije
    {
        public static bool IsSet(this string sadrzaj)
        {
            return !string.IsNullOrWhiteSpace(sadrzaj);
        }

        public static void UcitajPodatke<T>(this ComboBox comboBox, List<T> datasource,
            string displaymember = "Naziv", string valuMember = "Id")
        {
            comboBox.DataSource = datasource;
            comboBox.DisplayMember = displaymember;
            comboBox.ValueMember = valuMember;
        }
    }
}
