using System;   
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
//using System.Threading.Tasks;
using Ssepan.Application;
using Ssepan.Utility;

namespace MVCLibrary
{
    /// <summary>
    /// run-time model; relies on settings
    /// </summary>
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class MVCModel :
        ModelBase
    {
        #region Declarations
        #endregion Declarations

        #region Constructors
        public MVCModel()
        {
            if (SettingsController<MVCSettings>.Settings == null)
            {
                SettingsController<MVCSettings>.New();
            }
            Debug.Assert(SettingsController<MVCSettings>.Settings != null, "SettingsController<MVCSettings>.Settings != null");
        }

        public MVCModel
        (
            Int32 someInt,
            Boolean someBoolean,
            String someString
        ) :
            this()
        {
            SomeInt = someInt;
            SomeBoolean = someBoolean;
            SomeString = someString;
        }
        #endregion Constructors

        #region IEquatable<IModel>
        /// <summary>
        /// Compare property values of two specified Model objects.
        /// </summary>
        /// <param name="anotherSettings"></param>
        /// <returns></returns>
        public override Boolean Equals(IModel other)
        {
            Boolean returnValue = default(Boolean);
            MVCModel otherModel = default(MVCModel);

            try
            {
                otherModel = other as MVCModel;

                if (this == otherModel)
                {
                    returnValue = true;
                }
                else
                {
                    if (!base.Equals(other))
                    {
                        returnValue = false;
                    }
                    else if (this.SomeInt != otherModel.SomeInt)
                    {
                        returnValue = false;
                    }
                    else if (this.SomeBoolean != otherModel.SomeBoolean)
                    {
                        returnValue = false;
                    }
                    else if (this.SomeString != otherModel.SomeString)
                    {
                        returnValue = false;
                    }
                    else
                    {
                        returnValue = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
                throw;
            }

            return returnValue;
        }
        #endregion IEquatable<IModel>

        #region Properties
        private String[] _Args = default(String[]);
        public String[] Args
        {
            get {  return _Args; }
            set 
            {
                _Args = value;
                OnPropertyChanged("Args");
            }
        }

        public MVCSettingsComponent SomeComponent
        {
            get { return SettingsController<MVCSettings>.Settings.SomeComponent; }
            set 
            {
                SettingsController<MVCSettings>.Settings.SomeComponent = value;
                OnPropertyChanged("SomeComponent");//for completeness; will rely on internal notifications
            }
        }

        public Int32 SomeInt
        {
            get { return SettingsController<MVCSettings>.Settings.SomeInt; }
            set 
            { 
                SettingsController<MVCSettings>.Settings.SomeInt = value;
                OnPropertyChanged("SomeOtherInt");
            }
        }

        public Boolean SomeBoolean
        {
            get { return SettingsController<MVCSettings>.Settings.SomeBoolean; }
            set 
            { 
                SettingsController<MVCSettings>.Settings.SomeBoolean = value;
                OnPropertyChanged("SomeBoolean");
            }
        }

        public String SomeString
        {
            get { return SettingsController<MVCSettings>.Settings.SomeString; }
            set 
            { 
                SettingsController<MVCSettings>.Settings.SomeString = value;
                OnPropertyChanged("SomeOtherString");
            }
        }
        #endregion Properties

        #region Methods
        #endregion Methods
    }
}
