public static class Prompt
{
    public static string ShowDialog(string text, string caption)
    {
        Form prompt = new Form()
        {
            Width = 300,
            Height = 150,
            MaximizeBox = false,
            MinimizeBox = false,
            MaximumSize = new Size(300, 150),
            MinimumSize = new Size(300, 150),
            FormBorderStyle = FormBorderStyle.FixedDialog,
            Text = caption,
            StartPosition = FormStartPosition.CenterScreen
        };
        Label textLabel = new Label() { Left = 40, Top = 10, Width = 300, Text = text };
        TextBox textBox = new TextBox() { Left = 40, Top = 40, Width = 200 };
        Button confirmation = new Button() { Text = "Ok", Left = 140, Width = 100, Top = 70, DialogResult = DialogResult.OK };
        confirmation.Click += (sender, e) => { prompt.Close(); };
        prompt.Controls.Add(textBox);
        prompt.Controls.Add(confirmation);
        prompt.Controls.Add(textLabel);
        prompt.AcceptButton = confirmation;

        return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
    }

}
