using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ucContactBar : UserControl
    {
        private static ucContactBar _instance;
        public static ucContactBar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucContactBar();
                }
                return _instance;
            }

        }
        public ucContactBar()
        {
            InitializeComponent();
        }
    }
}
