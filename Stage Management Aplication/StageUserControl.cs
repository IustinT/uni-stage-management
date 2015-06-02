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
    public partial class StageUserControl : UserControl
    {
        public StageUserControl()
        {
            InitializeComponent();
        }

        private void StagePageUserControl_Load( object sender, EventArgs e )
        {
        }

        private void stageNumberUpDown_ValueChanged( object sender, EventArgs e )
        {
            if ( this . Parent != null )
                this . Parent . Text = "Stage " + stageNumberUpDown . Value . ToString();

            ///if stage number is 3 then check the placement year checkBox
            ///otherwise uncheck the placement year checkBox

            if ( stageNumberUpDown . Value == 3 )
            {
                if ( placementYearCheckBox . Checked != true )

                    placementYearCheckBox . Checked = true;
            }
            else
            {
                if ( placementYearCheckBox . Checked == true )

                    placementYearCheckBox . Checked = false;
            }
        }

        private void placementYearCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            if ( placementYearCheckBox . Checked )
                modulesGroupBox . Enabled = false;
            else
                modulesGroupBox . Enabled = true;

        }
        // TOdo add code to hide module tabs
        //void HideModuleTabs()
        //{
        //    TabControl  modulesTabControl = stagesTabControl . SelectedTab . Controls . Find( "modulesTabControl", true ) . FirstOrDefault() as TabControl;

        //  //  foreach (TabPage tab in)
        //}
    }
}
