using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac_GUI
{
    public partial class RegularExpression : Form
    {
        public RegularExpression()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(txt_Pattern.Text);//^[a-zA-Z0-9]{3,20}@[a-zA-Z]{3,10}(com|co.in|co.au)$
            bool result = reg.IsMatch(txt_Text.Text);
            lbl_result.Text = result.ToString();
        }
    }
}
