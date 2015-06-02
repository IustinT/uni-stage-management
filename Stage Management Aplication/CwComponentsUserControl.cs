using System;
using System . Collections . Generic;
using System . ComponentModel;
using System . Drawing;
using System . Data;
using System . Linq;
using System . Text;
using System . Threading . Tasks;
using System . Windows . Forms;

namespace Stage_Management_Aplication
{
    public partial class CwComponentsUserControl : UserControl
    {
        public CwComponentsUserControl()
        {
            InitializeComponent();
        }

        //event for Coursework Component Type ComboBox
        private void cwComponentTypeComboBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            //set the name of the Parent TabePage to the Coursework Component Type

            if ( this . Parent is TabPage )
                this . Parent . Text = componentTypeComboBox . SelectedItem . ToString();
        }

    }
}
