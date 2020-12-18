//#define USE_CONFIG_FILEPATH

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Ssepan.Application;
using Ssepan.Io;
using Ssepan.Utility;
using MVCLibrary;
using MVCLibrary.Properties;

namespace MVCForms
{
    /// <summary>
    /// This is the View.
    /// </summary>
    public partial class MVCView :
        Form,
        INotifyPropertyChanged
    {
        #region Declarations
        protected Boolean disposed;
        
        private Boolean _ValueChangedProgrammatically;
        
        //cancellation hook
        Action cancelDelegate = null;
        protected MVCViewModel ViewModel = default(MVCViewModel);
        #endregion Declarations

        #region Constructors
        public MVCView()
        { 
            try
            {
                InitializeComponent();

                ////(re)define default output delegate
                //ConsoleApplication.defaultOutputDelegate = ConsoleApplication.messageBoxWrapperOutputDelegate;

                //subscribe to view's notifications
                this.PropertyChanged += ModelPropertyChangedEventHandlerDelegate;

                InitViewModel();

                BindSizeAndLocation();
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
            }
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="args"></param>
        //public MVCView(String[] args) 
        //{
        //}
        #endregion Constructors

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(String propertyName)
        {
            try
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
            catch (Exception ex)
            {
                ViewModel.ErrorMessage = ex.Message;
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);

                throw;
            }
        }
        #endregion INotifyPropertyChanged

        #region PropertyChangedEventHandlerDelegates
        /// <summary>
        /// Note: handle model property changes manually.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ModelPropertyChangedEventHandlerDelegate
        (
            Object sender,
            PropertyChangedEventArgs e
        )
        {
            try
            {
                if (e.PropertyName == "IsChanged")
                {
                    //ConsoleApplication.defaultOutputDelegate(String.Format("{0}", e.PropertyName));
                    ApplySettings();
                }
                //Status Bar
                else if (e.PropertyName == "ActionIconIsVisible")
                {
                    StatusBarActionIcon.Visible = (ViewModel.ActionIconIsVisible);
                }
                else if (e.PropertyName == "ActionIconImage")
                {
                    StatusBarActionIcon.Image = (ViewModel != null ? ViewModel.ActionIconImage : (Image)null);
                }
                else if (e.PropertyName == "StatusMessage")
                {
                    //replace default action by setting control property
                    StatusBarStatusMessage.Text = ViewModel.StatusMessage;
                    //e = new PropertyChangedEventArgs(e.PropertyName + ".handled");

                    //ConsoleApplication.defaultOutputDelegate(String.Format("{0}", StatusMessage));
                }
                else if (e.PropertyName == "ErrorMessage")
                {
                    //replace default action by setting control property
                    StatusBarErrorMessage.Text = ViewModel.ErrorMessage;
                    //e = new PropertyChangedEventArgs(e.PropertyName + ".handled");

                    //ConsoleApplication.defaultOutputDelegate(String.Format("{0}", ErrorMessage));
                }
                else if (e.PropertyName == "CustomMessage")
                {
                    //replace default action by setting control property
                    StatusBarCustomMessage.Text = ViewModel.CustomMessage;
                    //e = new PropertyChangedEventArgs(e.PropertyName + ".handled");

                    //ConsoleApplication.defaultOutputDelegate(String.Format("{0}", ErrorMessage));
                }
                else if (e.PropertyName == "ErrorMessageToolTipText")
                {
                    StatusBarErrorMessage.ToolTipText = ViewModel.ErrorMessageToolTipText;
                }
                else if (e.PropertyName == "ProgressBarValue")
                {
                    StatusBarProgressBar.Value = ViewModel.ProgressBarValue;
                }
                else if (e.PropertyName == "ProgressBarMaximum")
                {
                    StatusBarProgressBar.Maximum = ViewModel.ProgressBarMaximum;
                }
                else if (e.PropertyName == "ProgressBarMinimum")
                {
                    StatusBarProgressBar.Minimum = ViewModel.ProgressBarMinimum;
                }
                else if (e.PropertyName == "ProgressBarStep")
                {
                    StatusBarProgressBar.Step = ViewModel.ProgressBarStep;
                }
                else if (e.PropertyName == "ProgressBarIsMarquee")
                {
                    StatusBarProgressBar.Style = (ViewModel.ProgressBarIsMarquee ? ProgressBarStyle.Marquee : ProgressBarStyle.Blocks);
                }
                else if (e.PropertyName == "ProgressBarIsVisible")
                {
                    StatusBarProgressBar.Visible = (ViewModel.ProgressBarIsVisible);
                }
                else if (e.PropertyName == "DirtyIconIsVisible")
                {
                    StatusBarDirtyMessage.Visible = (ViewModel.DirtyIconIsVisible);
                }
                else if (e.PropertyName == "DirtyIconImage")
                {
                    StatusBarDirtyMessage.Image = ViewModel.DirtyIconImage;
                }
                //use if properties cannot be databound
                //else if (e.PropertyName == "SomeInt")
                //{
                //    //SettingsController<MVCSettings>.Settings.
                //    ModelController<MVCModel>.Model.IsChanged = true;
                //}
                //else if (e.PropertyName == "SomeBoolean")
                //{
                //    //SettingsController<MVCSettings>.Settings.
                //    ModelController<MVCModel>.Model.IsChanged = true;
                //}
                //else if (e.PropertyName == "SomeString")
                //{
                //    //SettingsController<MVCSettings>.Settings.
                //    ModelController<MVCModel>.Model.IsChanged = true;
                //}
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
            }
        }

        /// <summary>
        /// Note: handle settings property changes manually.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void SettingsPropertyChangedEventHandlerDelegate
        (
            Object sender,
            PropertyChangedEventArgs e
        )
        {
            try
            {
                if (e.PropertyName == "Dirty")
                {
                    //apply settings that don't have databindings
                    ViewModel.DirtyIconIsVisible = (SettingsController<MVCSettings>.Settings.Dirty);
                }
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
            }
        }
        #endregion PropertyChangedEventHandlerDelegates

        #region Properties
        private String _ViewName = Program.APP_NAME;
        public String ViewName
        {
            get { return _ViewName; }
            set
            {
                _ViewName = value;
                OnPropertyChanged("ViewName");
            }
        }
        #endregion Properties

        #region Events
        #region Form Events
        /// <summary>
        /// Process Form key presses.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override Boolean ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Boolean returnValue = default(Boolean);
            try
            {
                // Implement the Escape / Cancel keystroke
                if (keyData == Keys.Cancel || keyData == Keys.Escape)
                {
                    //if a long-running cancellable-action has registered 
                    //an escapable-event, trigger it
                    InvokeActionCancel();

                    // This keystroke was handled, 
                    //don't pass to the control with the focus
                    returnValue = true;
                }
                else
                {
                    returnValue = base.ProcessCmdKey(ref msg, keyData);
                }

            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
            }
            return returnValue;
        }

        private void View_Load(Object sender, EventArgs e)
        {
            try
            {
                ViewModel.StatusMessage = String.Format("{0} starting...", ViewName);
                    
                ViewModel.StatusMessage = String.Format("{0} started.", ViewName);

                _Run();
            }
            catch (Exception ex)
            {
                ViewModel.ErrorMessage = ex.Message;
                ViewModel.StatusMessage = String.Empty;

                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
            }
        }

        private void View_FormClosing(Object sender, FormClosingEventArgs e)
        {
            try
            {
                ViewModel.StatusMessage = String.Format("{0} completing...", ViewName);
                
                DisposeSettings();

                ViewModel.StatusMessage = String.Format("{0} completed.", ViewName);
            }
            catch (Exception ex)
            {
                ViewModel.ErrorMessage = ex.Message.ToString();
                ViewModel.StatusMessage = "";

                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
            }
            finally
            {
                ViewModel = null;
            }
        }
        #endregion Form Events

        #region Menu Events
        private void menuFileNew_Click(Object sender, EventArgs e)
        {
            ViewModel.FileNew();
        }

        private void menuFileOpen_Click(Object sender, EventArgs e)
        {
            ViewModel.FileOpen();
        }

        private void menuFileSave_Click(Object sender, EventArgs e)
        {
            ViewModel.FileSave();
        }

        private void menuFileSaveAs_Click(Object sender, EventArgs e)
        {
            ViewModel.FileSaveAs();
        }

        private void menuFileExit_Click(Object sender, EventArgs e)
        {
            ViewModel.FileExit();
        }

        private void menuEditProperties_Click(Object sender, EventArgs e)
        {
            ViewModel.EditProperties();
        }

        private void menuEditCopyToClipboard_Click(Object sender, EventArgs e)
        {
            ViewModel.EditCopy();
        }

        private void menuHelpAbout_Click(Object sender, EventArgs e)
        {
            ViewModel.HelpAbout<AssemblyInfo>();
        }
        #endregion Menu Events

        #region Control Events
        private void cmdRun_Click(Object sender, EventArgs e)
        {
            ViewModel.DoSomething();
            //ViewModel.CustomMessage = "blah";//done in DoSomething
        }
        #endregion Control Events
        #endregion Events

        #region Methods
        #region FormAppBase
        protected void InitViewModel()
        {
            try
            {
                //subscribe view to model notifications
                ModelController<MVCModel>.Model.PropertyChanged += ModelPropertyChangedEventHandlerDelegate;
                //subscribe view to settings notifications
                SettingsController<MVCSettings>.DefaultHandler = SettingsPropertyChangedEventHandlerDelegate;

                FileDialogInfo settingsFileDialogInfo =
                    new FileDialogInfo
                    (
                        SettingsController<MVCSettings>.FILE_NEW,
                        null,
                        null,
                        MVCSettings.FileTypeExtension,
                        MVCSettings.FileTypeDescription,
                        MVCSettings.FileTypeName,
                        new String[] 
                    { 
                        "XML files (*.xml)|*.xml", 
                        "All files (*.*)|*.*" 
                    },
                        false,
                        default(Environment.SpecialFolder),
                        Environment.GetFolderPath(Environment.SpecialFolder.Personal).WithTrailingSeparator()
                    );

                //set dialog caption
                settingsFileDialogInfo.Title = this.Text;

                //class to handle standard behaviors
                ViewModelController<Bitmap, MVCViewModel>.New
                (
                    ViewName,
                    new MVCViewModel
                    (
                        this.ModelPropertyChangedEventHandlerDelegate,
                        new Dictionary<String, Bitmap>() 
                        { 
                            { "New", Resources.New }, 
                            { "Save", Resources.Save },
                            { "Open", Resources.Open },
                            { "Print", Resources.Print },
                            { "Copy", Resources.Copy },
                            { "Properties", Resources.Properties }
                        },
                        settingsFileDialogInfo
                    )
                );
                ViewModel = ViewModelController<Bitmap, MVCViewModel>.ViewModel[ViewName];

                BindFormUi();

                //Init config parameters
                if (!LoadParameters())
                {
                    throw new Exception(String.Format("Unable to load config file parameter(s)."));
                }

                //DEBUG:filename coming in is being converted/passed as DOS 8.3 format equivalent
                //Load
                if ((SettingsController<MVCSettings>.FilePath == null) || (SettingsController<MVCSettings>.Filename == SettingsController<MVCSettings>.FILE_NEW))
                {
                    //NEW
                    ViewModel.FileNew();
                }
                else
                {
                    //OPEN
                    ViewModel.FileOpen(false);
                }

#if debug
            //debug view
            menuEditProperties_Click(sender, e);
#endif

                //Display dirty state
                ModelController<MVCModel>.Model.Refresh();
            }
            catch (Exception ex)
            {
                if (ViewModel != null)
                {
                    ViewModel.ErrorMessage = ex.Message;
                }
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
            }
        }

        protected void DisposeSettings()
        {
            //save user and application settings 
            Properties.Settings.Default.Save();

            if (SettingsController<MVCSettings>.Settings.Dirty)
            {
                //prompt before saving
                DialogResult dialogResult = MessageBox.Show("Save changes?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        {
                            //SAVE
                            ViewModel.FileSave();

                            break;
                        }
                    case DialogResult.No:
                        {
                            break;
                        }
                    default:
                        {
                            throw new InvalidEnumArgumentException();
                        }
                }
            }

            //unsubscribe from model notifications
            ModelController<MVCModel>.Model.PropertyChanged -= ModelPropertyChangedEventHandlerDelegate;
        }

        protected void _Run()
        {
            //MessageBox.Show("running", "MVC", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        #endregion FormAppBase

        #region Utility
        /// <summary>
        /// Bind static Model controls to Model Controller
        /// </summary>
        private void BindFormUi()
        {
            try
            {
                //Form

                //Controls
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
                throw;
            }
        }

        /// <summary>
        /// Bind Model controls to Model Controller
        /// </summary>
        private void BindModelUi()
        {
            try
            {
                BindField<TextBox, MVCModel>(txtSomeInt, ModelController<MVCModel>.Model, "SomeInt");
                BindField<TextBox, MVCModel>(txtSomeString, ModelController<MVCModel>.Model, "SomeString");
                BindField<CheckBox, MVCModel>(chkSomeBoolean, ModelController<MVCModel>.Model, "SomeBoolean", "Checked");

                BindField<TextBox, MVCModel>(txtSomeOtherInt, ModelController<MVCModel>.Model, "SomeComponent.SomeOtherInt");
                BindField<TextBox, MVCModel>(txtSomeOtherString, ModelController<MVCModel>.Model, "SomeComponent.SomeOtherString");
                BindField<CheckBox, MVCModel>(chkSomeOtherBoolean, ModelController<MVCModel>.Model, "SomeComponent.SomeOtherBoolean", "Checked");
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
                throw;
            }
        }

        private void BindField<TControl, TModel>
        (
            TControl fieldControl,
            TModel model,
            String modelPropertyName,
            String controlPropertyName = "Text",
            Boolean formattingEnabled = false,
            DataSourceUpdateMode dataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged,
            Boolean reBind = true
        )
            where TControl : Control
        {
            try
            {
                fieldControl.DataBindings.Clear();
                if (reBind)
                {
                    fieldControl.DataBindings.Add(controlPropertyName, model, modelPropertyName, formattingEnabled, dataSourceUpdateMode);
                }
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
            }
        }

        /// <summary>
        /// Apply Settings to viewer.
        /// </summary>
        private void ApplySettings()
        {
            try
            {
                _ValueChangedProgrammatically = true;

                //apply settings that have databindings
                BindModelUi();

                //apply settings that shouldn't use databindings

                //apply settings that can't use databindings
                Text = Path.GetFileName(SettingsController<MVCSettings>.Filename) + " - " + ViewName;

                //apply settings that don't have databindings
                ViewModel.DirtyIconIsVisible = (SettingsController<MVCSettings>.Settings.Dirty);

                _ValueChangedProgrammatically = false;
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
                throw;
            }
        }

        /// <summary>
        /// Set function button and menu to enable value, and cancel button to opposite.
        /// For now, do only disabling here and leave enabling based on biz logic 
        ///  to be triggered by refresh?
        /// </summary>
        /// <param name="functionButton"></param>
        /// <param name="functionMenu"></param>
        /// <param name="cancelButton"></param>
        /// <param name="enable"></param>
        private void SetFunctionControlsEnable
        (
            Button functionButton,
            ToolStripButton functionToolbarButton,
            ToolStripMenuItem functionMenu,
            Button cancelButton,
            Boolean enable
        )
        {
            try
            {
                //stand-alone button
                if (functionButton != null)
                {
                    functionButton.Enabled = enable;
                }

                //toolbar button
                if (functionToolbarButton != null)
                {
                    functionToolbarButton.Enabled = enable;
                }

                //menu item
                if (functionMenu != null)
                {
                    functionMenu.Enabled = enable;
                }

                //stand-alone cancel button
                if (cancelButton != null)
                {
                    cancelButton.Enabled = !enable;
                }
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
            }
        }

        /// <summary>
        /// Invoke any delegate that has been registered 
        ///  to cancel a long-running background process.
        /// </summary>
        private void InvokeActionCancel()
        {
            try
            {
                //execute cancellation hook
                if (cancelDelegate != null)
                {
                    cancelDelegate();
                }
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
            }
        }

        /// <summary>
        /// Load from app config; override with command line if present
        /// </summary>
        /// <returns></returns>
        private Boolean LoadParameters()
        {
            Boolean returnValue = default(Boolean);
#if USE_CONFIG_FILEPATH
            String _settingsFilename = default(String);
#endif

            try
            {
                if ((Program.Filename != null) && (Program.Filename != SettingsController<MVCSettings>.FILE_NEW))
                {
                    //got filename from command line
                    //DEBUG:filename coming in is being converted/passed as DOS 8.3 format equivalent
                    if (!RegistryAccess.ValidateFileAssociation(Application.ExecutablePath, "." + MVCSettings.FileTypeExtension))
                    {
                        throw new ApplicationException(String.Format("Settings filename not associated: '{0}'.\nCheck filename on command line.", Program.Filename));
                    }
                    //it passed; use value from command line
                }
                else
                {
#if USE_CONFIG_FILEPATH
                    //get filename from app.config
                    if (!Configuration.ReadString("SettingsFilename", out _settingsFilename))
                    {
                        throw new ApplicationException(String.Format("Unable to load SettingsFilename: {0}", "SettingsFilename"));
                    }
                    if ((_settingsFilename == null) || (_settingsFilename == SettingsController<MVCSettings>.FILE_NEW))
                    {
                        throw new ApplicationException(String.Format("Settings filename not set: '{0}'.\nCheck SettingsFilename in app config file.", _settingsFilename));
                    }
                    //use with the supplied path
                    SettingsController<MVCSettings>.Filename = _settingsFilename;

                    if (Path.GetDirectoryName(_settingsFilename) == String.Empty)
                    {
                        //supply default path if missing
                        SettingsController<MVCSettings>.Pathname = Environment.GetFolderPath(Environment.SpecialFolder.Personal).WithTrailingSeparator();
                    }
#endif
                }

                returnValue = true;
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
                //throw;
            }
            return returnValue;
        }

        private void BindSizeAndLocation()
        {
            //Note:Size must be done after InitializeComponent(); do Location this way as well.--SJS
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::MVCForms.Properties.Settings.Default, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ClientSize", global::MVCForms.Properties.Settings.Default, "Size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ClientSize = global::MVCForms.Properties.Settings.Default.Size;
            this.Location = global::MVCForms.Properties.Settings.Default.Location;
        }
        #endregion Utility
        #endregion Methods
    }
}
