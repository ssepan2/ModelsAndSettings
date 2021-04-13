#define USE_CONFIG_FILEPATH
#define USE_CUSTOM_VIEWMODEL
//#define DEBUG_MODEL_PROPERTYCHANGED
//#define DEBUG_SETTINGS_PROPERTYCHANGED

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Ssepan.Application;
using Ssepan.Application.MVC;
using Ssepan.Application.WinConsole;
using Ssepan.Io;
using Ssepan.Utility;
using MVCLibrary;

namespace MVCConsole
{
    public class ConsoleView :
        INotifyPropertyChanged
    {
        #region Declarations
        protected Boolean disposed;
#if USE_CUSTOM_VIEWMODEL
        protected MVCConsoleViewModel ViewModel =
            default(MVCConsoleViewModel);
#else
        protected ConsoleViewModel<String, MVCSettings, MVCModel> ViewModel = 
            default(ConsoleViewModel<String, MVCSettings, MVCModel>);
#endif
        private static Boolean _ValueChangedProgrammatically;
        #endregion Declarations

        #region Constructors
        public ConsoleView()
        {
            try
            {
                ////(re)define default output delegate
                //ConsoleApplication.defaultOutputDelegate = ConsoleApplication.writeLineWrapperOutputDelegate;

                //subscribe to notifications
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged += PropertyChangedEventHandlerDelegate;
                }

                InitViewModel();
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
            }
        }
        #endregion Constructors

        #region IDisposable
        ~ConsoleView()
        {
            Dispose(false);
        }

        public virtual void Dispose()
        {
            // dispose of the managed and unmanaged resources
            Dispose(true);

            // tell the GC that the Finalize process no longer needs
            // to be run for this object.
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposeManagedResources)
        {
            // process only if mananged and unmanaged resources have
            // not been disposed of.
            if (!this.disposed)
            {
                //Resources not disposed
                if (disposeManagedResources)
                {
                    // dispose managed resources
                    //unsubscribe from model notifications
                    if (this.PropertyChanged != null)
                    {
                        this.PropertyChanged -= PropertyChangedEventHandlerDelegate;
                    }
                }
                // dispose unmanaged resources
                disposed = true;
            }
            else
            {
                //Resources already disposed
            }
        }
        #endregion IDisposable

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

        #region PropertyChangedEventHandlerDelegate
        /// <summary>
        /// Note: model property changes update UI manually.
        /// Note: handle settings property changes manually.
        /// Note: because settings properties are a subset of the model 
        ///  (every settings property should be in the model, 
        ///  but not every model property is persisted to settings)
        ///  it is decided that for now the settigns handler will 
        ///  invoke the model handler as well.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void PropertyChangedEventHandlerDelegate
        (
            Object sender,
            PropertyChangedEventArgs e
        )
        {
            try
            {
#region Model
                if (e.PropertyName == "IsChanged")
                {
                    //ConsoleApplication.defaultOutputDelegate(String.Format("{0}", e.PropertyName));
                    ApplySettings();
                }
                else if (e.PropertyName == "Progress")
                {
                    ConsoleApplication.defaultOutputDelegate(String.Format("{0}", Progress));
                }
                if (e.PropertyName == "StatusMessage")
                {
                    ConsoleApplication.defaultOutputDelegate(String.Format("{0}", ViewModel.StatusMessage));
                    e = new PropertyChangedEventArgs(e.PropertyName + ".handled");
                }
                else if (e.PropertyName == "ErrorMessage")
                {
                    ConsoleApplication.defaultOutputDelegate(String.Format("{0}", ViewModel.ErrorMessage));
                    e = new PropertyChangedEventArgs(e.PropertyName + ".handled");
                }
                //Note: not databound, so handle event
                else if (e.PropertyName == "SomeInt")
                {
                    ConsoleApplication.defaultOutputDelegate(String.Format("SomeInt: {0}", ModelController<MVCModel>.Model.SomeInt));
                }
                else if (e.PropertyName == "SomeBoolean")
                {
                    ConsoleApplication.defaultOutputDelegate(String.Format("SomeBoolean: {0}", ModelController<MVCModel>.Model.SomeBoolean));
                }
                else if (e.PropertyName == "SomeString")
                {
                    ConsoleApplication.defaultOutputDelegate(String.Format("SomeString: {0}", ModelController<MVCModel>.Model.SomeString));
                }
                else if (e.PropertyName == "SomeOtherInt")
                {
                    ConsoleApplication.defaultOutputDelegate(String.Format("SomeOtherInt: {0}", ModelController<MVCModel>.Model.SomeComponent.SomeOtherInt));
                }
                else if (e.PropertyName == "SomeOtherBoolean")
                {
                    ConsoleApplication.defaultOutputDelegate(String.Format("SomeOtherBoolean: {0}", ModelController<MVCModel>.Model.SomeComponent.SomeOtherBoolean));
                }
                else if (e.PropertyName == "SomeOtherString")
                {
                    ConsoleApplication.defaultOutputDelegate(String.Format("SomeOtherString: {0}", ModelController<MVCModel>.Model.SomeComponent.SomeOtherString));
                }
                else if (e.PropertyName == "SomeComponent")
                {
                    ConsoleApplication.defaultOutputDelegate(String.Format("SomeComponent: {0},{1},{2}", ModelController<MVCModel>.Model.SomeComponent.SomeOtherInt, ModelController<MVCModel>.Model.SomeComponent.SomeOtherBoolean, ModelController<MVCModel>.Model.SomeComponent.SomeOtherString));
                }
                else if (e.PropertyName == "StillAnotherInt")
                {
                    ConsoleApplication.defaultOutputDelegate(String.Format("StillAnotherInt: {0}", ModelController<MVCModel>.Model.StillAnotherComponent.StillAnotherInt));
                }
                else if (e.PropertyName == "StillAnotherBoolean")
                {
                    ConsoleApplication.defaultOutputDelegate(String.Format("StillAnotherBoolean: {0}", ModelController<MVCModel>.Model.StillAnotherComponent.StillAnotherBoolean));
                }
                else if (e.PropertyName == "StillAnotherString")
                {
                    ConsoleApplication.defaultOutputDelegate(String.Format("StillAnotherString: {0}", ModelController<MVCModel>.Model.StillAnotherComponent.StillAnotherString));
                }
                else if (e.PropertyName == "StillAnotherComponent")
                {
                    ConsoleApplication.defaultOutputDelegate(String.Format("StillAnotherComponent: {0},{1},{2}", ModelController<MVCModel>.Model.StillAnotherComponent.StillAnotherInt, ModelController<MVCModel>.Model.StillAnotherComponent.StillAnotherBoolean, ModelController<MVCModel>.Model.StillAnotherComponent.StillAnotherString));
                }
                else 
                {
                    #if DEBUG_MODEL_PROPERTYCHANGED
                        ConsoleApplication.defaultOutputDelegate(String.Format("e.PropertyName: {0}", e.PropertyName));
                    #endif
                }
#endregion Model

#region Settings
                if (e.PropertyName == "Dirty")
                {
                    //apply settings that don't have databindings
                    ViewModel.DirtyIconIsVisible = (SettingsController<MVCSettings>.Settings.Dirty);
                }
                else
                {
#if DEBUG_SETTINGS_PROPERTYCHANGED
                    ConsoleApplication.defaultOutputDelegate(String.Format("e.PropertyName: {0}", e.PropertyName));
#endif
                }
#endregion Settings
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
            }
        }
#endregion PropertyChangedEventHandlerDelegate

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

        private Int32 _Progress = default(Int32);
        public Int32 Progress
        {
            get { return _Progress; }
            set
            {
                _Progress = value;
                OnPropertyChanged("Progress");
            }
        }
#endregion Properties

#region Methods
#region ConsoleAppBase
        protected void InitViewModel()
        {
            try
            {
                //tell controller how model should notify view about non-persisted properties AND including model properties that may be part of settings
                ModelController<MVCModel>.DefaultHandler = PropertyChangedEventHandlerDelegate;
                
                //tell controller how settings should notify view about persisted properties
                SettingsController<MVCSettings>.DefaultHandler = PropertyChangedEventHandlerDelegate;
                
                InitModelAndSettings();

#if USE_CUSTOM_VIEWMODEL
                //class to handle standard behaviors
                ViewModelController<String, MVCConsoleViewModel>.New
                (
                    ViewName,
                    new MVCConsoleViewModel
                    (
                        this.PropertyChangedEventHandlerDelegate,
                        new Dictionary<String, String>()
                        {
                            { "New", "New" },
                            { "Save", "Save" },
                            { "Open", "Open" },
                            { "Print", "Print" },
                            { "Copy", "Copy" },
                            { "Properties", "Properties" }
                        }
                    )
                );

                //select a viewmodel by view name
                ViewModel =
                    ViewModelController<String, MVCConsoleViewModel>.ViewModel[ViewName];
#else
                //class to handle standard behaviors
                ViewModelController<String, ConsoleViewModel<String, MVCSettings, MVCModel>>.New
                (
                    ViewName,
                    new ConsoleViewModel<String, MVCSettings, MVCModel>
                    (
                        this.PropertyChangedEventHandlerDelegate,
                        new Dictionary<String, String>() 
                        { 
                            { "New", "New" }, 
                            { "Save", "Save" },
                            { "Open", "Open" },
                            { "Print", "Print" },
                            { "Copy", "Copy" },
                            { "Properties", "Properties" }
                        }
                    )
                );
                
                //select a viewmodel by view name
                ViewModel = 
                    ViewModelController<String, ConsoleViewModel<String, MVCSettings, MVCModel>>.ViewModel[ViewName];
#endif

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
                    ViewModel.FileOpen();
                }
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

        protected void InitModelAndSettings()
        {
            //create Settings before first use by Model
            if (SettingsController<MVCSettings>.Settings == null)
            {
                SettingsController<MVCSettings>.New();
            }
            //Model properties rely on Settings, so don't call Refresh before this is run.
            if (ModelController<MVCModel>.Model == null)
            {
                ModelController<MVCModel>.New();
            }
        }

        protected void DisposeSettings()
        {

            //save user and application settings 
            //Properties.Settings.Default.Save();

            if (SettingsController<MVCSettings>.Settings.Dirty)
            {
                //SAVE
                ViewModel.FileSave();
            }

            //unsubscribe from model notifications
            ModelController<MVCModel>.Model.PropertyChanged -= PropertyChangedEventHandlerDelegate;
        }
        
        public Int32 _Main()
        {
            Int32 returnValue = -1; //default to fail code

            try
            {
                ViewModel.StatusMessage = String.Format("{0} starting...", ViewName);

                //init settigns
                
                ViewModel.StatusMessage = String.Format("{0} started.", ViewName);

                _Run();

                ViewModel.StatusMessage = String.Format("{0} completing...", ViewName);

                DisposeSettings();

                ViewModel.StatusMessage = String.Format("{0} completed.", ViewName);

                //return success code
                returnValue = 0;
            }
            catch (Exception ex)
            {
                ViewModel.ErrorMessage = String.Format("{0} did NOT complete: '{1}'", ViewName, ViewModel.ErrorMessage);
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
            }
            finally 
            {
                ViewModel = null;
            }
            return returnValue;
        }

        protected void _Run()
        {
            ViewModel.DoSomething();

        }
#endregion ConsoleAppBase
        
#region Utility
        /// <summary>
        /// Apply Settings to viewer.
        /// </summary>
        private void ApplySettings()
        {
            try
            {
                _ValueChangedProgrammatically = true;

                //apply settings that have databindings
                //BindModelUi();

                //apply settings that shouldn't use databindings

                //apply settings that can't use databindings
                Console.Title = Path.GetFileName(SettingsController<MVCSettings>.Filename) + " - " + ViewName;

                //apply settings that don't have databindings
                //ViewModel.StatusBarDirtyMessage.Visible = (SettingsController<Settings>.Settings.Dirty);

                _ValueChangedProgrammatically = false;
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
                throw;
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
#endregion Utility
#endregion Methods
    }
}
