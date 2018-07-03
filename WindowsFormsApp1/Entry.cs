using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English
{
    public partial class Entry : UserControl
    {
        private static Entry _instance;

        public static Entry Instance
        {
            get
            {
                if(_instance == null )
                {
                    _instance = new Entry();
                }
                return _instance;
            }
        }


        public Entry()
        {
            InitializeComponent();
        }

        private void tmCover_Tick(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Enter_Exit;
            tmCover.Enabled = false;
            btnEnter.Visible = true;
            btnExit.Visible = true;
        }

        private void Entry_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Cover_Ecology;
            tmCover.Enabled = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
