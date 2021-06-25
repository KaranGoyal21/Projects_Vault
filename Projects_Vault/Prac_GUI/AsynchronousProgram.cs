using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac_GUI
{
    /// <summary>
    /// Asynchronus programming Concept
    /// Async program of TPL is taken to another extent.
    /// Async and await keywords are used.
    /// </summary>

    public partial class AsynchronousProgram : Form
    {
        public AsynchronousProgram()
        {
            InitializeComponent();
        }

        static void BigTask()
        {
            Thread.Sleep(5000);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(new Action(BigTask));
            label1.Text = "Task Done...";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
