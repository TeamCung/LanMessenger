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
    public partial class ucContactHandle : UserControl
    {
        private static ucContactHandle _instance;
        public static ucContactHandle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucContactHandle();
                }
                return _instance;
            }

        }
        public ucContactHandle()
        {
            InitializeComponent();
        }
    }
}
