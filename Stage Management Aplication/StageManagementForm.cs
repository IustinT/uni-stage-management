using System;
using System . Configuration;
using System . Collections;
using System . Collections . Generic;
using System . ComponentModel;
using System . Data;
using System . Drawing;
using System . Linq;
using System . Text;
using System . Threading . Tasks;
using System . Windows . Forms;

namespace Stage_Management_Aplication
{
    public partial class StageManagementForm : Form
    {
        AplicationSettings settings = new AplicationSettings();
        Xml_Root_Class xmlRoot;// = new Xml_Root_Class();

        Stage stage;
        Module module;
        string fileName;

        public StageManagementForm()
        {
            InitializeComponent();
        }

        private void StageManagementForm_Shown( object sender, EventArgs e )
        {
            Start();
        }


        private void Start()
        {
            Parse_Xml_Records recordsFile = new Parse_Xml_Records();

            //try to open the file used last time
            string historyFileName = settings . RecordsFile;

            xmlRoot = new Xml_Root_Class();
            if ( recordsFile . CheckFile( historyFileName ) )

                fileName = settings . RecordsFile;
            else
                OpenFileDialog();

            ///if a history-file is found or if the user selects a file
            if ( fileName != null )

                if ( recordsFile . CheckFile( fileName ) )
                {
                    xmlRoot = new Parse_Xml_Records() . DeserialiseXmlRoot( fileName );

                    Update_Stage_ListBox();

                }
                else
                    MessageBox . Show( "The selected file is not valid", "File Error",
                        MessageBoxButtons . OK, MessageBoxIcon . Exclamation );
        }


        private void OpenFileDialog()
        {
            if ( openFileDialog . ShowDialog() == DialogResult . OK )
            {
                fileName = openFileDialog . FileName;
                settings . RecordsFile = fileName;
                settings . Save();
            }
            else
                MessageBox . Show( "Please select a file with your records", "File Error",
                    MessageBoxButtons . OK, MessageBoxIcon . Error );
        }

        /// <summary>
        /// Display a list of stages in a ListBox
        /// </summary>
        private void Update_Stage_ListBox()
        {
            //todo how to display the stage number ?
            stagesListBox . DataSource = xmlRoot . Stages;
            stagesListBox . DisplayMember = "Number";
        }

        private void UpdateModulesListBox()
        {
            modulesListBox . DataSource = stage . Modules;
            modulesListBox . DisplayMember = "Code";
        }

        /// <summary>
        /// Updates the Coursework Components List
        /// </summary>
        private void Update_Coursework_Components_ListBox()
        {
            //Set the ListBox dataSource to display the coursework elements of the currently selected module 
            courseworkElementsListBox . DataSource = module . Assessment . Coursework . Components;

            courseworkElementsListBox . DisplayMember = "Name";
        }

        private void DisplayModuleDetailsOnForm()
        {
            Coursework coursework = module . Assessment . Coursework;
            Exam exam = module . Assessment . Exam;

            moduleNameLabel . Text = module . Name;

            courseworkWeightLabel . Text = "Coursework Weighting: " + ( coursework . Weighting * 100 ) . ToString() + " %";
            courseworkMarkLabel . Text = "Coursework Mark: " + coursework . Mark . ToString();

            examWeightLabel . Text = "Exam Weighting: " + ( exam . Weighting * 100 ) . ToString() + " %";

            // display the exam mark only if the module has an exam
            if ( module . Assessment . Exam . Weighting > 0 )
                examMarkLabel . Text = "Exam Mark: " + module . Assessment . Exam . Mark . ToString();
            else
                examMarkLabel . Text = String . Empty;

            moduleTermLabel . Text = "Module Term: " + module . Term;
            moduleCreditsLabel . Text = "Module Credits: " + module . Credits . ToString();
            moduleMarkLabel . Text = "Module Mark: " + module . OverallModuleMark . ToString();
        }


        private void modulesListBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            module = stage . Modules . ElementAt( modulesListBox . SelectedIndex );

            DisplayModuleDetailsOnForm();

            Update_Coursework_Components_ListBox();
        }

        private void courseworkElementsListBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            Module module = null;
            Component component;

            //check if the stage is a placement year
            if ( stage . Modules . Count == 0 )
                return;

            module = stage . Modules . ElementAt( modulesListBox . SelectedIndex );

            component = module . Assessment . Coursework . Components . ElementAt( courseworkElementsListBox . SelectedIndex );

            componentType . Text = "Type: " + component . Type;
            componentMark . Text = "Mark: " + component . Mark . ToString();
            componentWeighting . Text = "Weighting: " + ( component . Weighting * 100 ) . ToString() + " %";

        }

        private void stagesListBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            stage = xmlRoot . Stages . ElementAt( stagesListBox . SelectedIndex );
            programTitleLabel . Text = stage . ProgrameName;
            programStageLabel . Text = "Stage: " + stage . Number . ToString();

            UpdateModulesListBox();
        }


        private void editRecordsButton_Click( object sender, EventArgs e )
        {
            AddRecords addRecordsForm = new AddRecords( fileName, true );
            addRecordsForm . Show();

            // this . FindForm() . Visible = false;
        }

        private void openFileToolStripMenuItem_Click( object sender, EventArgs e )
        {
            OpenFileDialog();
        }
    }
}
