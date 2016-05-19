using System;
using System.Windows.Forms;

namespace CipherCryptanalysisTool
{
    public partial class Info : Form
    {
        public bool UpDown = true; //Up
        public int count = 0;

        public Info()
        {
            InitializeComponent();

            
        }

        private void Info_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.10;
        }
    }
}
