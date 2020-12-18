#define USE_CONFIG_FILEPATH
#define USE_CUSTOM_VIEWMODEL

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using Ssepan.Application;
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
                this.PropertyChanged += ModelPropertyChangedEventHandlerDelegate;

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
                    this.PropertyChanged -= ModelPropertyChangedEventHandlerDelegate;
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
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);

                throw;
            }
        }
        #endregion INotifyPropertyChanged

        #region ModelPropertyChangedEventHandlerDelegate
        /// <summary>
        /// Note: property changes update UI manually.
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
        #endregion ModelPropertyChangedEventHandlerDelegate

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
                //subscribe to notifications
                ModelController<MVCModel>.Model.PropertyChanged += ModelPropertyChangedEventHandlerDelegate;
                //subscribe view to settings notifications
                SettingsController<MVCSettings>.DefaultHandler = SettingsPropertyChangedEventHandlerDelegate;
            
                //class to handle standard behaviors
#if USE_CUSTOM_VIEWMODEL
                ViewModelController<String, MVCConsoleViewModel>.New
#else
//                ViewModelController<String, ConsoleViewModel<String, MVCSettings, MVCModel>>.New
#endif
(
                    ViewName,
#if USE_CUSTOM_VIEWMODEL
                    new MVCConsoleViewModel
#else
//                    new ConsoleViewModel<String, MVCSettings, MVCModel>
#endif
                    (
                        this.ModelPropertyChangedEventHandlerDelegate,
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
                ViewModel = 
#if USE_CUSTOM_VIEWMODEL
                    ViewModelController<String, MVCConsoleViewModel>.ViewModel[ViewName];
#else
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
            ModelController<MVCModel>.Model.PropertyChanged -= ModelPropertyChangedEventHandlerDelegate;
        }
        
        public Int32 _Main()
        {
            Int32 returnValue = -1; //default to fail code

            try
            {
                ViewModel.StatusMessage = String.Format("{0} starting...", ViewName);

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

            //ModelController<MVCModel>.Model.SomeBoolean = !ModelController<MVCModel>.Model.SomeBoolean;
            //ModelController<MVCModel>.Model.SomeInt += 1;
            //ModelController<MVCModel>.Model.SomeString = DateTime.Now.ToString();

            ////SettingsController<MVCSettings>.Settings.SomeBoolean = true;
            ////SettingsController<MVCSettings>.Settings.SomeInt += 1;
            ////SettingsController<MVCSettings>.Settings.SomeString = "test";
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
