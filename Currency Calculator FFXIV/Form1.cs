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
            PopulateGearList();
            discipleComboBox.DataSource = new List<string> { "Magic", "War" };
        }

        private void PopulateGearList()
        {
            _gearList = new List<string>
            {
                "White Mage",
                "Red Mage"
            };
        }

        private void DiscipleComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            classLabel.Visible = true;
            classComboBox.Visible = true;
            classComboBox.DataSource = discipleComboBox.SelectedItem.Equals("Magic")
                ? new List<string> { "White Mage", "Scholar", "Astrologian" }
                : new List<string> { "Warrior", "Paladin", "Monk", "Dragoon", "Bard", "Black Mage", "Summoner", "Ninja", "Dark Knight", "Machinist", "Red Mage", "Samurai" };
        }
    }
}