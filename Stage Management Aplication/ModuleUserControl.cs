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
    public partial class ModuleUserControl : UserControl
    {

        CwComponentsUserControl cwComponent;
        TabPage newTabPage;

        // variables needed for the MessageBox
        string message;
        string caption;
        MessageBoxButtons buttons;
        DialogResult messageBox;


        public ModuleUserControl()
        {
            InitializeComponent();
        }


        private void ModuleUserControl_Load( object sender, EventArgs e )
        {
            moduleCreditsComboBox_SelectedIndexChanged( null, null );
        }

        private void courseworkWeightUpDown_ValueChanged( object sender, EventArgs e )
        {
            examWeightUpDown . Value = 1 - courseworkWeightUpDown . Value;
        }

        private void examWeightUpDown_ValueChanged( object sender, EventArgs e )
        {
            int moduleCredits = Convert . ToInt32( moduleCreditsComboBox . SelectedItem );

            // change the Coursework Weighting only if the module is assessed
            if ( moduleCredits > 0 )
                courseworkWeightUpDown . Value = 1 - examWeightUpDown . Value;


            //if the Exam Weighting is 0 (no exam) then set the Exam Mark to 0 and disable the control
            if ( examWeightUpDown . Value == 0 )
            {
                examMarkUpDown . Value = 0;
                examMarkUpDown . Enabled = false;
            }
            else
                examMarkUpDown . Enabled = true;
        }


        private void moduleCodeTextBox_TextChanged( object sender, EventArgs e )
        {
            ///set the name of the TabPage in the Modules TabControl

            /// this . Parent is the module Page UserControl
            /// and this . Parent . Parent is the TabPage

            if ( moduleCodeTextBox . Parent . Parent is TabPage )

                if ( moduleCodeTextBox . Text . Replace( " ", "" ) == "" )

                    moduleCodeTextBox . Parent . Parent . Text = "New Module";
                else
                    moduleCodeTextBox . Parent . Parent . Text = moduleCodeTextBox . Text;

        }

        //Click event for the "Remove this Component" button
        private void removeCwComponent_Click( object sender, EventArgs e )
        {
            RemoveComponentTabPage();
        }

        private void addCwComponentBtn_Click( object sender, EventArgs e )
        {
            AddNewComponentTabPage();
        }

        /// <summary>
        /// Adds a new TabPage to the Tab Control that 
        /// holds the Coursework Components - cwComponentsTabControl
        /// </summary>
        void AddNewComponentTabPage()
        {
            if ( cwComponentsTabControl . TabCount < 4 )
            {
                cwComponentsTabControl . TabPages . Add( ComponentTabPage() );
            }
        }


        /// <summary>
        /// Returns a new TabPage that holds a new Coursework Component UserControl
        /// </summary>
        /// <returns></returns>
        public TabPage ComponentTabPage()
        {
            cwComponent = new CwComponentsUserControl();
            cwComponent . Dock = DockStyle . Fill;

            newTabPage = new TabPage( "New Component" );
            newTabPage . Controls . Add( cwComponent );

            return newTabPage;
        }


        /// <summary>
        /// Removes the displayed TabPage from the Tab Control that 
        /// 
        /// holds the Coursework Components - cwComponentsTabControl
        /// </summary>
        void RemoveComponentTabPage()
        {
            message = "You are about to delete this Coursework Component."
                      + Environment . NewLine + "Are you sure ?";

            caption = "Delete the Coursework Component";
            buttons = MessageBoxButtons . YesNo;

            if ( cwComponentsTabControl . SelectedTab != null )
            {
                messageBox = MessageBox . Show( message,
                         caption, buttons, MessageBoxIcon . Warning );

                //if the user decides to remove the currently displayed Coursework Component
                if ( messageBox == DialogResult . Yes )

                    // Remove the displayed tabPage
                    cwComponentsTabControl . SelectedTab . Dispose();

                // The coursework must have at least one component
                if ( cwComponentsTabControl . TabCount == 0 )
                    AddNewComponentTabPage();

            }
        }// end remove Component TabPage ()

        private void moduleCreditsComboBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            int moduleCredits = Convert . ToInt32( moduleCreditsComboBox . SelectedItem );

            if ( moduleCredits == 0 )
            {
                cwComponentsGroupBox . Enabled = false;

                courseworkWeightUpDown . Value = 0;
                courseworkWeightUpDown . Enabled = false;

                examWeightUpDown . Value = 0;   //This will set the exam mark to 0 and will disable it as well               
                examWeightUpDown . Enabled = false;
            }
            else
            {
                cwComponentsGroupBox . Enabled = true;

                courseworkWeightUpDown . Enabled = true;
                courseworkWeightUpDown . Value = 1;

                examWeightUpDown . Enabled = true;
            }
        }
    }
}
