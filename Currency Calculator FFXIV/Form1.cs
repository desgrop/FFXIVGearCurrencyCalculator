using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Calculator_FFXIV
{
    public partial class mainWindow : Form
    {
        private List<string> gearList;

        public mainWindow()
        {
            InitializeComponent();
            gearList = new List<string>();
        }

        private void populateGearList()
        {
        }
    }
}