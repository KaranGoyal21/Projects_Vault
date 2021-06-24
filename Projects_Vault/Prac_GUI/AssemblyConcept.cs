using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssemblyConceptManageUser;

namespace Prac_GUI
{
    public partial class AssemblyConcept : Form
    {
        public AssemblyConcept()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (user.AuthenticateUser(textBox1.Text, textBox2.Text))
                MessageBox.Show(user.HelloUser(textBox1.Text));
            else
                MessageBox.Show("Invalid Username / Password");
        }
    }
}
