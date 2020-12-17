using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using MVCLibrary;
using Ssepan.Application;
using Ssepan.Application.WinConsole;
using Ssepan.Application.Patterns;
using Ssepan.Utility;

namespace MVCForms
{
    static class Program
    {
        #region Declarations
        public const String APP_NAME = "MVCView";
        #endregion Declarations

        #region INotifyPropertyChanged
        public static event PropertyChangedEventHandler PropertyChanged;
        public static void OnPropertyChanged(String propertyName)
        {
            try
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(null, new PropertyChangedEventArgs(propertyName));
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
        public static void ModelPropertyChangedEventHandlerDelegate
        (
            Object sender,
            PropertyChangedEventArgs e
        )
        {
            try
            {
                if (e.PropertyName == "Filename")
                {
                    ConsoleApplication.defaultOutputDelegate(String.Format("{0}", Filename));
                }
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
            }
        }
        #endregion ModelPropertyChangedEventHandlerDelegate

        #region Properties
        private static String _Filename = default(String);
        public static String Filename
        {
            get { return _Filename; }
            set
            {
                _Filename = value;
                OnPropertyChanged("Filename");
            }
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args"></param>
        /// <returns>Int32</returns>
        [STAThread]
        static Int32 Main(String[] args)
        {
            //default to fail code
            Int32 returnValue = -1;

            try
            {
                //define default output delegate
                ConsoleApplication.defaultOutputDelegate = ConsoleApplication.messageBoxWrapperOutputDelegate;

                //subscribe to notifications
                PropertyChanged += ModelPropertyChangedEventHandlerDelegate;

                //load, parse, run switches
                DoSwitches(args);

                InitModelAndSettings();
                ModelController<MVCModel>.Model.Args = args;

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new MVCView(/*args*/));
                SingleInstanceController<MVCView> controller = new SingleInstanceController<MVCView>();
                controller.Run(args); //Note: Rather than passing args to the form, they are set in the model above.--SJS

                //return success code
                returnValue = 0;
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
            }
            return returnValue;
        }

        #region FormAppBase
        /// <summary>
        /// Note: switches are processed before Model or Settings are accessed.
        /// </summary>
        /// <param name="args"></param>
        static void DoSwitches(String[] args)
        {
            //define supported switches
            // -t -f:"filename" -h
            ConsoleApplication.DoCommandLineSwitches
            (
                args,
                new CommandLineSwitch[]  
                { 
                    new CommandLineSwitch("f", "f filename; overrides app.config", true, f),
                    //new CommandLineSwitch("H", "H invokes the Help command.", false, ConsoleApplication.Help)//may already be loaded
                }
            );
        }

        static void InitModelAndSettings()
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
        #endregion FormAppBase

        #region CommandLineSwitch Action Delegates
        /// <summary>
        /// Validate and set selected settings.
        /// Instance of an action conforming to delegate Action<T>, where T is String.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="outputDelegate"></param>
        static void f(String value, Action<String> outputDelegate)
        {
            try
            {
#if debug
                outputDelegate(String.Format("s{0}\t{1}", ConsoleApplication.CommandLineSwitchValueSeparator, value));
#endif

                //validate settings file path
                if (!System.IO.File.Exists(value))
                {
                    throw new ArgumentException(String.Format("Invalid settings file path: '{0}'", value));
                }
                Filename = value;
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
                throw;
            }
        }
        #endregion CommandLineSwitch Action Delegates
        #endregion Methods
    }
}
