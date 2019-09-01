using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTimer
{
    public partial class IDEntry : Form
    {
        public IDEntry()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text.Length > 3)
            {
                Program.ParticipantIdentifier = IDTextBox.Text;
                this.Close();
            }
        }
    }
}
