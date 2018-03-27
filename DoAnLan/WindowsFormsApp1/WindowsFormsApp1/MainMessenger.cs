using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{    
    public partial class MainMessenger : Form
    {
        public static UserControl ucInstance;
        public MainMessenger()
        {
            InitializeComponent();
            // set panel
            //pnlMainTop.Height = 0;
            //pnlMainRight.Width = 0;
            
            AddUserControl(pnlMainRight, ucChatRoom.Instance);
            AddUserControl(pnlMainMiddle, ucMessage.Instance);
            AddUserControl(pnlMainLeftContent, ucContacts.Instance);
            AddUserControl(pnlMainTop, ucContactBar.Instance);
            AddUserControl(pnlMainMiddle, ucContactHandle.Instance);
        }

        //Add control function
        private void AddUserControl(Panel panel, UserControl control)
        {                          
                if (!panel.Controls.Contains(control))
                {                    
                    panel.Controls.Add(control);
                    control.Dock = DockStyle.Fill;
                    control.BringToFront();
                }
                else
                {
                    control.BringToFront();
                }          
           
        }

        // Handle Header Bar
        private void MainClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainClose_MouseHover(object sender, EventArgs e)
        {
            MainClose.BackColor = Color.Red;
            MainClose.ForeColor = Color.White;
        }

        private void MainClose_MouseLeave(object sender, EventArgs e)
        {            
            MainClose.BackColor = Color.FromArgb(255, 125, 0);
        }

       
    }
}
