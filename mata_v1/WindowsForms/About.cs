using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mata_v1.WindowsForms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            string about = @"Wersja: 1.1
Ostatnia modyfikacja: 22.09.2018.
";
            tAbout.Text = about;
        }
    }
}
