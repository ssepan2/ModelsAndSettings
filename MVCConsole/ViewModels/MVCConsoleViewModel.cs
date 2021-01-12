using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Ssepan.Utility;
using Ssepan.Application;
using Ssepan.Io;
using MVCLibrary;

namespace MVCConsole
{
    /// <summary>
    /// Note: this class can subclass the base without type parameters.
    /// </summary>
    public class MVCConsoleViewModel :
        ConsoleViewModel<String, MVCSettings, MVCModel>
    {
        #region Declarations

        #region Commands
        //public ICommand FileNewCommand { get; private set; }
        //public ICommand FileOpenCommand { get; private set; }
        //public ICommand FileSaveCommand { get; private set; }
        //public ICommand FileSaveAsCommand { get; private set; }
        //public ICommand FilePrintCommand { get; private set; }
        //public ICommand FileExitCommand { get; private set; }
        //public ICommand EditCopyToClipboardCommand { get; private set; }
        //public ICommand EditPropertiesCommand { get; private set; }
        //public ICommand ViewPreviousMonthCommand { get; private set; }
        //public ICommand ViewPreviousWeekCommand { get; private set; }
        //public ICommand ViewNextWeekCommand { get; private set; }
        //public ICommand ViewNextMonthCommand { get; private set; }
        //public ICommand HelpAboutCommand { get; private set; }
        #endregion Commands
        #endregion Declarations

        #region Constructors
        public MVCConsoleViewModel() { }//Note: not called, but need to be present to compile--SJS

        public MVCConsoleViewModel
        (
            PropertyChangedEventHandler propertyChangedEventHandlerDelegate,
            Dictionary<String, String> actionIconImages
        ) :
            base(propertyChangedEventHandlerDelegate, actionIconImages)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
            }
        }
        #endregion Constructors

        #region Properties
        #endregion Properties

        #region Methods
        /// <summary>
        /// model specific, not generioc
        /// </summary>
        internal void DoSomething()
        {
            StatusMessage = String.Empty;
            ErrorMessage = String.Empty;
            MVCModel m = ModelController<MVCModel>.Model;

            try
            {
                StartProgressBar
                (
                    "Doing something...",
                    null,
                    null, //_actionIconImages["Xxx"],
                    true,
                    33
                );

                //ConsoleApplication.defaultOutputDelegate(String.Format("SomeBoolean: {0}", m.SomeBoolean.ToString()));

                ModelController<MVCModel>.Model.SomeBoolean = !ModelController<MVCModel>.Model.SomeBoolean;
                ModelController<MVCModel>.Model.SomeInt += 1;
                ModelController<MVCModel>.Model.SomeString = DateTime.Now.ToString();

                ModelController<MVCModel>.Model.SomeComponent.SomeOtherBoolean = !ModelController<MVCModel>.Model.SomeComponent.SomeOtherBoolean;
                ModelController<MVCModel>.Model.SomeComponent.SomeOtherInt += 1;
                ModelController<MVCModel>.Model.SomeComponent.SomeOtherString = DateTime.Now.ToString();


                ModelController<MVCModel>.Model.Refresh();
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);

                StopProgressBar(null, String.Format("{0}", ex.Message));
            }
            finally
            {
                StopProgressBar("\nDid something.");
            }
        }
        #endregion Methods

    }
}
