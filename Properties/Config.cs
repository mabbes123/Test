internal static class Config
{
    public static List<string> logins = new List<string>();
    public static void readLogins(string path)
    {
        logins.Clear();
        logins.AddRange(System.IO.File.ReadAllLines(path));
    }

    public static void writeLogins(string path)
    {
        System.IO.File.WriteAllLines(path, logins);
    }

    public static Color main_theme_color = Color.FromArgb(35, 85, 157);
}

