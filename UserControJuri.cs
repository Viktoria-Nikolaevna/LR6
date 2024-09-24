using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ЛР6.DBCon;

namespace ЛР6
{
    public partial class _UserControJuri : UserControl
    {
        public _UserControJuri()
        {
            InitializeComponent();
        }
        public void Fill(User user, int number)
        {
            labelName.Text = "Жюри - " + number.ToString();
            userBindingSource.DataSource = user;
        }
    }
}
