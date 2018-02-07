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
    public partial class MainWindow : Form
    {
        private List<string> _gearList;

        public MainWindow()
        {
            InitializeComponent();
            PopulateLists();
            discipleComboBox.DataSource = new List<string> { "Magic", "War" };
        }

        private void PopulateLists()
        {
            PopulateGearList();
            PopulateItemLevelList();
        }

        private void PopulateGearList()
        {
            _gearList = new List<string>
            {
                "White Mage",
                "Red Mage"
            };
        }

        private void PopulateItemLevelList()
        {
            iLvComboBox.DataSource = new List<string> { "iLv 350", "iLv 360", "iLv 370" };
        }

        private void DiscipleComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            classComboBox.DataSource = discipleComboBox.SelectedItem.Equals("Magic")
                ? new List<string> { "White Mage", "Scholar", "Astrologian" }
                : new List<string> { "Warrior", "Paladin", "Monk", "Dragoon", "Bard", "Black Mage", "Summoner", "Ninja", "Dark Knight", "Machinist", "Red Mage", "Samurai" };
        }

        private void iLvComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (iLvComboBox.SelectedItem.Equals("iLv 370"))
            {
                gearSetOptionComboBox.Enabled = true;
                gearSetOptionComboBox.DataSource = new List<string> { "Dai-Ryumyaku", "Diamond" };
            }
            else
            {
                gearSetOptionComboBox.Enabled = false;
            }
        }
    }
}