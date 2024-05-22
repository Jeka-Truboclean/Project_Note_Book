using MaterialSkin.Controls;
using System;
using System.IO;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Project
{

    public partial class Form1 : MaterialForm
    {
        readonly static string TitlePath = @"C:\Users\Admin\source\repos\Project\To_Do_List\Title.txt";
        readonly static string DoPath = @"C:\Users\Admin\source\repos\Project\To_Do_List\Do.txt";

        static string[] Title = File.ReadAllLines(TitlePath);
        static string[] Do = File.ReadAllLines(DoPath);
        public Form1()
        {
            InitializeComponent();
            Text = "Note Book";
            titleComboBox.Items.AddRange(Title);
        }

        private void btnOpenSecondForm_Click(object sender, EventArgs e)
        {
            Form2 addForm = new Form2();
            this.Hide();
            addForm.ShowDialog();
            this.Show();
            Do = File.ReadAllLines(DoPath);
            Title = File.ReadAllLines(TitlePath);
            titleComboBox.Items.Clear();
            titleComboBox.Items.AddRange(Title);
        }

        private void titleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bodyTextBox.Text = Do[titleComboBox.SelectedIndex];
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (titleComboBox.Items.Count == 1)
            {
                MessageBox.Show("You cant delete last note!");
            }
            else
            {
                string[] lines = File.ReadAllLines(TitlePath);
                string[] lines2 = File.ReadAllLines(DoPath);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i] == titleComboBox.Text)
                    {
                        lines[i] = null;
                        lines2[i] = null;
                        break;
                    }
                }
                File.Delete(TitlePath);
                File.Delete(DoPath);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i] != null)
                    {
                        File.AppendAllText(DoPath, $"{lines2[i]}\n");
                        File.AppendAllText(TitlePath, $"{lines[i]}\n");
                    }
                }
                Do = File.ReadAllLines(DoPath);
                Title = File.ReadAllLines(TitlePath);
                titleComboBox.Items.Clear();
                titleComboBox.Items.AddRange(Title);
            }
        }
    }
}
