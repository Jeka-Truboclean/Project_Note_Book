using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : MaterialForm
    {
        readonly static string TitlePath = @"C:\Users\Admin\source\repos\Project\To_Do_List\Title.txt";
        readonly static string DoPath = @"C:\Users\Admin\source\repos\Project\To_Do_List\Do.txt";
        public Form2()
        {
            InitializeComponent();
            Text = "Add Note";
        }

        private void btnBackToFirstForm_Click(object sender, EventArgs e)
        {
            File.AppendAllText(TitlePath, $"{addTitleTextBox.Text}\n");
            File.AppendAllText(DoPath, $"{addDoTextBox.Text}\n");
            this.Close();
        }
    }
}
