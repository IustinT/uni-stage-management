using System;
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
    public partial class AddRecords : Form
    {
        #region Variables Declaration
        string fileName;

        // variables used when dealing with Stages
        UserControl stageUserControl;
        TextBox programNameText;

        NumericUpDown stageNumber;
        CheckBox placementYear;



        //variables used when dealing with modules
        UserControl moduleUserControl;
        TabControl modulesTabControl;

        TextBox moduleName;
        TextBox moduleCode;
        ComboBox moduleCredits;
        ComboBox moduleTerm;

        NumericUpDown courseworkWeighting;
        NumericUpDown examWeight;
        NumericUpDown examMark;


        //variables for the Coursework Components
        /// cwComponentsUserControl = short for coursework Components User Control
        UserControl cwComponentsUserControl;
        TabControl cwComponentsTabControl;

        TextBox componentName;
        ComboBox componentType;
        NumericUpDown componentWeighting;
        NumericUpDown componentMark;


        // used to decide if the form starts in "edit records mode" or not
        //
        //in "edit records mode" the form will load and display 
        //all the records so the user can edit or delete the records
        //
        bool ModeEditRecords = false;

        //control variables
        int maximumModules = 8; // TODO max modules?

        // variables needed for the MessageBox
        string message;
        string caption;
        MessageBoxButtons buttons;
        DialogResult messageBox;

        #endregion

        #region Constructors

        public AddRecords()
        {
            InitializeComponent();
        }


        /// <summary>
        /// </summary>
        /// <param name="file">The name of a file where to load the record from</param>
        /// <param name="startInEditMode">When this is true, the form will load the records to be edited</param>
        public AddRecords( string file, bool startInEditMode = false )
        {
            InitializeComponent();

            fileName = file;

            if ( startInEditMode )
                ModeEditRecords = startInEditMode;
            else
                AddStageTab();
        }


        private void AddRecords_Shown( object sender, EventArgs e )
        {
            if ( ModeEditRecords )
                PopulateFormWithStages();
        }
        #endregion

        #region Buttons Click Events

        private void addStageBtn_Click( object sender, EventArgs e )
        {
            AddStageTab();
        }

        private void removeStageBtn_Click( object sender, EventArgs e )
        {
            RemoveStageTab();
        }

        private void addModuleBtn_Click( object sender, EventArgs e )
        {
            AddModuleTab();
        }

        private void removeModuleBtn_Click( object sender, EventArgs e )
        {
            RemoveModuleTab();
        }

        private void saveStagesBtn_Click( object sender, EventArgs e )
        {
            ExtractDataFromForm();
        }
        #endregion

        #region Add / Remove Tab Pages (for Stage, Module, Cw components)

        /// <summary>
        /// Adds a new TabPage with a StageUserControl to the stages Tab Control (on the form)
        /// </summary>
        void AddStageTab()
        {
            TabPage newTabPage;

            if ( stagesTabControl . TabCount < 4 )
            {
                stageUserControl = new StageUserControl();
                stageUserControl . Dock = DockStyle . Fill;

                newTabPage = new TabPage( "New Stage" );
                newTabPage . Controls . Add( stageUserControl );

                stagesTabControl . TabPages . Add( newTabPage );
            }
        }// End AddStageTab()


        /// <summary>
        /// Removes the displayed Stage together with all its modules
        /// and coursework components from the form
        /// </summary>
        void RemoveStageTab()
        {
            message = "You are about to delete this Stage."
                       + Environment . NewLine + "Are you sure ?";

            caption = "Delete the open Stage";
            buttons = MessageBoxButtons . YesNo;

            if ( stagesTabControl != null && stagesTabControl . SelectedTab != null )
            {
                messageBox = MessageBox . Show( message,
                         caption, buttons, MessageBoxIcon . Warning );

                //if the user decides to remove the currently opened Stage
                if ( messageBox == DialogResult . Yes )

                    // Removes the displayed tab
                    stagesTabControl . SelectedTab . Dispose();
            }

            if ( stagesTabControl . TabCount == 0 )
                AddStageTab();

        }// End RemoveStageTab ()

        /// <summary>
        /// add a new (Module) tabPage to the modulesTabControl inside StagePageUserControl (inside stagesTabControl)
        /// </summary>
        void AddModuleTab()
        {
            UserControl moduleUserControl;
            TabPage newTabPage;

            // find the modulesTabControl inside the Selected Stage TabPage
            modulesTabControl = stagesTabControl . SelectedTab . Controls . Find( "modulesTabControl", true ) . FirstOrDefault() as TabControl;

            if ( modulesTabControl != null && modulesTabControl . TabCount < maximumModules )
            {
                moduleUserControl = new ModuleUserControl();
                moduleUserControl . Dock = DockStyle . Fill;

                newTabPage = new TabPage( "New Module" );
                newTabPage . Controls . Add( moduleUserControl );

                modulesTabControl . TabPages . Add( newTabPage );
            }
        }


        /// <summary>
        /// Removes the displayed Module and its coursework components from the form
        /// </summary>
        void RemoveModuleTab()
        {
            modulesTabControl = stagesTabControl . SelectedTab . Controls . Find( "modulesTabControl", true ) . FirstOrDefault() as TabControl;

            message = "You are about to delete this Module."
                     + Environment . NewLine + "Are you sure ?";

            caption = "Delete the displayed Module";
            buttons = MessageBoxButtons . YesNo;

            if ( modulesTabControl == null || modulesTabControl . SelectedTab == null )
                return;

            messageBox = MessageBox . Show(  message,
                 caption, buttons, MessageBoxIcon . Warning );

            if ( messageBox == DialogResult . Yes )
                modulesTabControl . SelectedTab . Dispose();

            if ( modulesTabControl . TabCount == 0 )
                AddModuleTab();
        }

        #endregion

        #region Extract data from Form

        /// <summary>
        /// Begins the extraction of the new data from the form
        /// </summary>
        void ExtractDataFromForm()
        {
            Xml_Root_Class xmlRoot = new Xml_Root_Class();
            Parse_Xml_Records xmlFile = new Parse_Xml_Records();
            Stage stage;

            int tabIndex;

            foreach ( TabPage tab in stagesTabControl . TabPages )
            {
                tabIndex = stagesTabControl . TabPages . IndexOf( tab );
                stageUserControl = tab . Controls [0] as UserControl;

                stage = ExtractStage( stageUserControl, tabIndex );

                //if ExtractStage returns a null stage, then an error has been found
                if ( stage == null )
                {
                    //Set focus on the TabPage where the error is found
                    stagesTabControl . SelectedTab = tab;
                    return;
                }
                else
                    xmlRoot . Stages . Add( stage );
            }

            //Add all the records to the xml file
            xmlFile . SerializeXmlRoot( xmlRoot, fileName );
        }


        /// <summary>
        /// Extracts all stage details from the form. 
        /// It then calls <c>Extract Modules</c>
        /// </summary>
        /// <param name="stageUserControl">The stageUserControl inside every Stage TabPage. 
        /// <para />
        /// It holds all the controls that have the stage data (i.e. stage name, stage number)
        /// </param>
        /// <param name="tabIndex"></param>
        /// <returns>Returns a stage ready to be added to the  xml Root
        /// <para />
        /// If a validation error is found, then returns null
        /// </returns>
        Stage ExtractStage( UserControl stageUserControl, int tabIndex )
        {
            Stage stage = new Stage();
            String programName;

            //find the Program Name on the user control
            programNameText = FindControl( stageUserControl, "programNameTextBox" ) as TextBox;
            programName = programNameText . Text;

            //check if the program name is not empty
            if ( ValidateName( programName, "Stage", tabIndex ) == false )
                return null;

            //find the stage number
            stageNumber = FindControl( stageUserControl, "stageNumberUpDown" ) as NumericUpDown;

            stage . ProgrameName = programNameText . Text;
            stage . Number = (int) stageNumber . Value;

            placementYear = FindControl( stageUserControl, "placementYearCheckBox" ) as CheckBox;

            if ( placementYear . Checked == true )
                stage . Modules = null;
            else
            {
                modulesTabControl = FindControl( stageUserControl, "modulesTabControl" ) as TabControl;
                ExtractModuleDetails( modulesTabControl, stage );
            }

            return stage;
        }


        /// <summary>
        /// Extracts all the module details from the form and then calls to "ExtractCourseworkComponents"
        /// </summary>
        /// <param name="modulesTabControl"></param>
        /// <param name="stage">The stage to which the module will be added</param>
        void ExtractModuleDetails( TabControl modulesTabControl, Stage stage )
        {
            Module module;
            int tabIndex;

            ///each modulesTabControl tabPage has a moduleUserControl that holds the fields for a module (i.e. module name, module code)
            foreach ( TabPage tab in modulesTabControl . TabPages )
            {
                module = new Module();
                tabIndex = modulesTabControl . TabPages . IndexOf( tab );

                moduleUserControl = tab . Controls [0] as UserControl;

                Find_Controls_On_Module_UserControl();

                //validate the Module Code
                if ( !ValidateName( moduleCode . Text, "Module Code", tabIndex ) )
                    return;

                module . Code = moduleCode . Text;

                //validate the Module Name
                if ( !ValidateName( moduleName . Text, "Module", tabIndex ) )
                    return;

                module . Name = moduleName . Text;
                module . Credits = Convert . ToInt32( moduleCredits . SelectedItem );
                module . Term = moduleTerm . SelectedItem . ToString();

                if ( module . Credits > 0 )
                {
                    module . Assessment . Coursework . Weighting = courseworkWeighting . Value;

                    module . Assessment . Exam . Weighting = examWeight . Value;
                    module . Assessment . Exam . Mark = examMark . Value;

                    /// extract the data about the coursework components
                    /// the moduleUserControl holds the cwComponentsTabControl (Tab Control) and it holds the data about the components 
                    cwComponentsTabControl = FindControl( moduleUserControl, "cwComponentsTabControl" ) as TabControl;

                    ExtractCourseworkComponents( cwComponentsTabControl, module );
                }
                else
                    module . Assessment = null;

                stage . Modules . Add( module );
            }  // end foreach

        }// End ExtractModuleDetails ()


        /// <summary>
        /// Extracts the coursework components details from the form, creates new <c> Coursework_component </c> (s) and adds them to the module parameter
        /// </summary>
        /// <param name="cwComponentsTabControl">The TabControl that holds the cwComponentsTabControl</param>
        /// 
        /// <param name="module">The module where to add the Coursework Components</param>
        /// 
        void ExtractCourseworkComponents( TabControl cwComponentsTabControl, Module module )
        {
            Component component;
            int tabIndex;

            ///First validate the data of the components
            ValidateCourseworkComponents( cwComponentsTabControl );

            foreach ( TabPage tab in cwComponentsTabControl . TabPages )
            {
                tabIndex = cwComponentsTabControl . TabPages . IndexOf( tab );
                component = new Component();

                ///Each tabPage holds a coursework Component User Control
                cwComponentsUserControl = tab . Controls [0] as UserControl;

                Find_Controls_On_CwComponent_UserControl( cwComponentsUserControl );

                component . Name = componentName . Text;
                component . Type = componentType . SelectedItem . ToString();
                component . Weighting = componentWeighting . Value;
                component . Mark = componentMark . Value;

                module . Assessment . Coursework . Components . Add( component );
            }

        } // End ExtractCourseworkComponents ()

        #endregion

        #region Begin Populating the form

        /// <summary>
        /// Adds Tab Pages with the details of the Modules to a Tab Control
        /// </summary>
        /// <param name="stage"></param>
        /// <param name="modulesTabControl">The Tab Control where to add the Tab Pages</param>
        /// 
        void AddModulesOnForm( List<Module> Modules, TabControl modulesTabControl )
        {
            int tabIndex =0;

            foreach ( Module module in Modules )
            {
                modulesTabControl . SelectedIndex = tabIndex;

                // find the module User Control in each TabPage
                moduleUserControl = modulesTabControl . SelectedTab . Controls [0] as UserControl;

                // Find the fields (Controls) where to add the module's details
                Find_Controls_On_Module_UserControl();

                // Add the module details to the fields
                Populate_Controls_With_Module_Data( module );

                if ( module . Credits > 0 )
                {
                    cwComponentsTabControl = FindControl( moduleUserControl, "cwComponentsTabControl" ) as TabControl;

                    //write the coursework components on the form 
                    AddCourseworkComponentsOnForm(
                        module . Assessment . Coursework . Components,
                        cwComponentsTabControl );
                }

                // Add more Tab Pages if needed
                if ( modulesTabControl . TabCount < Modules . Count )
                    AddModuleTab();

                tabIndex += 1;
            }

            //set focus on the first tab page
            modulesTabControl . SelectedIndex = 0;

        }// end AddModulesOnForm ()


        /// <summary>
        /// Adds Tab Pages with the details of the Coursework components to a Tab Control
        /// </summary>
        /// <param name="Components">A Coursework_Component List</param>
        /// <param name="cwComponentsTabControl">The Tab Control where to add the Tab Pages</param>
        void AddCourseworkComponentsOnForm( List<Component> Components, TabControl cwComponentsTabControl )
        {
            int tabIndex = 0;

            if ( cwComponentsTabControl . TabCount == 0 )
                cwComponentsTabControl . TabPages . Add( new ModuleUserControl() . ComponentTabPage() );

            foreach ( Component component in Components )
            {
                //iterate through the tab pages
                cwComponentsTabControl . SelectedIndex = tabIndex;

                ///Each tabPage holds a coursework Component User Control
                cwComponentsUserControl = cwComponentsTabControl . SelectedTab . Controls [0] as UserControl;

                Find_Controls_On_CwComponent_UserControl( cwComponentsUserControl );

                Populate_Controls_With_Component_Data( component );

                if ( cwComponentsTabControl . TabCount < Components . Count )
                    cwComponentsTabControl . TabPages . Add( new ModuleUserControl() . ComponentTabPage() );

                tabIndex += 1;
            }

            //set focus on the first tab page
            cwComponentsTabControl . SelectedIndex = 0;

        } //end AddCourseworkComponentsOnForm ()

        #endregion

        #region Populate Controls With Data

        /// <summary>
        /// Insert the module's details on the controls (module's name, term ...)
        /// </summary>
        /// <param name="module"></param>
        void Populate_Controls_With_Module_Data( Module module )
        {
            // Add the module details to the fields

            moduleName . Text = module . Name;
            moduleCode . Text = module . Code;

            //set the Combo Box to display the module credits
            switch ( module . Credits )
            {
                case 0:
                    moduleCredits . SelectedIndex = 0;
                    break;
                case 10:
                    moduleCredits . SelectedIndex = 1;
                    break;
                case 20:
                    moduleCredits . SelectedIndex = 2;
                    break;
            }

            //set the Combo Box to display the module Term
            switch ( module . Term )
            {
                case "AY":
                    moduleTerm . SelectedIndex = 0;
                    break;
                case "T1":
                    moduleTerm . SelectedIndex = 1;
                    break;
                case "T2":
                    moduleTerm . SelectedIndex = 2;
                    break;
            }

            if ( module . Credits > 0 )
            {
                courseworkWeighting . Value = module . Assessment . Coursework . Weighting;
                examWeight . Value = module . Assessment . Exam . Weighting;
                examMark . Value = module . Assessment . Exam . Mark;
            }
        }


        /// <summary>
        /// Insert the Cw Component details on the controls (component's name, type ...)
        /// </summary>
        /// <param name="component"></param>
        void Populate_Controls_With_Component_Data( Component component )
        {
            componentName . Text = component . Name;
            componentType . Text = component . Type;

            componentWeighting . Value = component . Weighting;
            componentMark . Value = component . Mark;
        }

        #endregion Populate Controls With Data

        #region Find Controls On User Components

        /// <summary>
        /// 
        /// </summary>
        void PopulateFormWithStages()
        {
            TabControl modulesTabControl;
            Xml_Root_Class xmlRoot = new Parse_Xml_Records() . DeserialiseXmlRoot( fileName );

            UserControl stageUserControl;

            int tabIndex=0;

            if ( stagesTabControl . TabCount == 0 )
                AddStageTab();

            foreach ( Stage stage in xmlRoot . Stages )
            {
                stagesTabControl . SelectedIndex = tabIndex;

                stageUserControl = stagesTabControl . SelectedTab . Controls [0] as UserControl;

                Find_Controls_On_Stage_UserControl();

                programNameText . Text = stage . ProgrameName;
                stageNumber . Value = stage . Number;
                // todo   placementYear.Checked = stage.

                modulesTabControl = FindControl( stageUserControl, "modulesTabControl" ) as TabControl;


                AddModulesOnForm( stage . Modules, modulesTabControl );

                if ( stagesTabControl . TabCount < xmlRoot . Stages . Count )
                    AddStageTab();
                tabIndex += 1;
            }

            //set focus on the first tab page
            stagesTabControl . SelectedIndex = 0;
        }

        void Find_Controls_On_Stage_UserControl()
        {
            programNameText = FindControl( stageUserControl, "programNameTextBox" ) as TextBox;
            stageNumber = FindControl( stageUserControl, "stageNumberUpDown" ) as NumericUpDown;
            placementYear = FindControl( stageUserControl, "placementYearCheckBox" ) as CheckBox;
        }

        void Find_Controls_On_Module_UserControl()
        {
            moduleName = FindControl( moduleUserControl, "moduleNameTextBox" ) as TextBox;
            moduleCode = FindControl( moduleUserControl, "moduleCodeTextBox" ) as TextBox;

            moduleCredits = FindControl( moduleUserControl, "moduleCreditsComboBox" ) as ComboBox;
            moduleTerm = FindControl( moduleUserControl, "moduleTermComboBox" ) as ComboBox;

            courseworkWeighting = FindControl( moduleUserControl, "courseworkWeightUpDown" ) as NumericUpDown;
            examWeight = FindControl( moduleUserControl, "examWeightUpDown" ) as NumericUpDown;
            examMark = FindControl( moduleUserControl, "examMarkUpDown" ) as NumericUpDown;
        }


        void Find_Controls_On_CwComponent_UserControl( UserControl moduleUserControl )
        {
            componentName = FindControl( cwComponentsUserControl, "componentNameTextBox" ) as TextBox;
            componentType = FindControl( cwComponentsUserControl, "componentTypeComboBox" ) as ComboBox;

            componentWeighting = FindControl( cwComponentsUserControl, "componentWeightingUpDown" ) as NumericUpDown;
            componentMark = FindControl( cwComponentsUserControl, "componentMarkUpDown" ) as NumericUpDown;
        }

        /// <summary>
        /// Finds a Control inside a User Control
        /// </summary>
        /// <param name="userControl">The user control where to find the control</param>
        /// 
        /// <param name="controlName">The name (id) of the control to be found</param>
        /// 
        /// <returns>Returns the found control</returns>
        /// 
        Control FindControl( UserControl userControl, string controlName )
        {
            Control control;
            control = userControl . Controls . Find( controlName, true ) . FirstOrDefault();

            return control;
        }

        #endregion Find Controls On User Components

        #region Validation

        /// <summary>
        /// Checks if the Component Name is empty or if it contains only spaces 
        /// <para />
        /// Also checks if the total Weighting of the components equals 1 
        /// </summary>
        /// <param name="cwComponentsTabControl">The Coursework Components User Control</param>
        /// 
        /// <returns>Returns true if all the Names and Weightings are valid</returns>
        /// 
        Boolean ValidateCourseworkComponents( TabControl cwComponentsTabControl )
        {
            TextBox componentName;
            NumericUpDown componentWeighting;

            int tabIndex;
            //the total weighting of the components
            decimal totalWeighting = 0;

            //each TabPage has a "cwComponentsControl" user control 
            foreach ( TabPage tab in cwComponentsTabControl . TabPages )
            {
                //the "cwComponentsControl" contains the details of the Coursework Component
                UserControl cwComponentsUserControl = tab . Controls [0] as UserControl;

                tabIndex = cwComponentsTabControl . TabPages . IndexOf( tab );

                //find the Component's Name on the user control
                componentName = FindControl( cwComponentsUserControl, "componentNameTextBox" ) as TextBox;

                //find the Component's  Weighting on the user control
                componentWeighting = FindControl( cwComponentsUserControl, "componentWeightingUpDown" ) as NumericUpDown;

                //Sum the weighting of each component
                totalWeighting += componentWeighting . Value;

                //check the name of the component
                if ( ValidateName( componentName . Text, "Component", tabIndex ) == false )
                {
                    // -the Name is not valid-
                    //Set focus on the TabPage where the error is found
                    cwComponentsTabControl . SelectedTab = tab;
                    return false;
                }
            } //end foreach

            ///When all the Names are valid
            ///Check the total Weighting of the Coursework Components
            if ( totalWeighting != 1 )
            {
                message = "The weighting of all Coursework components should equal 1.0"
                    + Environment . NewLine +
                    "The current weighting is " + totalWeighting . ToString();

                MessageBox . Show( message );
                return false;
            }

            //no error has been found, return true
            return true;

        } // End ValidateCourseworkComponents()



        /// <summary>
        /// Checks if a name (string) is not empty or contains only spaces
        /// <para />
        /// Displays an Message Box if the text is not valid
        /// </summary>
        /// <param name="text">Text to be checked</param>
        /// 
        /// <param name="component">One of Stage or Module or Component</param>
        /// 
        /// <param name="tabIndex">Index of a tab (will be displayed in the Message Box )</param>
        /// 
        /// <returns>Returns True if no error is found.</returns>
        /// 
        Boolean ValidateName( string text, string component, int tabIndex )
        {
            string typeOfComponent;

            switch ( component )
            {
                case "Stage":
                    typeOfComponent = "Stage Name";
                    break;
                case "Module":
                    typeOfComponent = "Module Name";
                    break;
                case "Module Code":
                    typeOfComponent = "Module Code";
                    break;
                default:
                    typeOfComponent = "Name";
                    break;
            }

            if ( text . Replace( " ", "" ) != "" )
                return true;
            else
            {
                //Add 1 to tabIndex because it starts from 0
                tabIndex += 1;
                message = "Invalid " + typeOfComponent + " for the " + component + " in tab " + tabIndex . ToString();
                MessageBox . Show( message );
            }

            return false;
        } // End ValidateName ()
        #endregion
    }
}

