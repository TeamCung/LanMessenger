using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace WindowsFormsApp1
{
    public partial class ucContacts : UserControl
    {
        private static ucContacts _instance;
        public static ucContacts Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucContacts();
                }
                return _instance;
            }

        }

        public ucContacts()
        {
            InitializeComponent();
            AddUserToListContact();
        }

        // static value to access and create control
    

        void AddUserToListContact()
        {   
            for (int i =0; i < 15; i++)
            {  String strText = ("User " + i.ToString());
                BunifuFlatButton btnUser = new BunifuFlatButton();
                btnUser.Width = pnlContactList.Width-50;
                btnUser.Height = 50;
                btnUser.Text = strText;
                btnUser.BackColor = Color.FromArgb(26, 30, 41);
                btnUser.Normalcolor = Color.FromArgb(26, 30, 41);

                pnlContactList.Controls.Add(btnUser);
            }
          
        }
    }
}
