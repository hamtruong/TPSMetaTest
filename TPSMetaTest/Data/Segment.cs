using System;
using TPSMetaTest.Components;
using System.ComponentModel;

namespace TPSMetaTest.Data
{
    public class Segment : INotifyPropertyChanged
    {
        #region "Properties"
        private String mName;
        public String Name
        {
            get { return mName; }
            set
            {
                mName = value;
                OnPropertyChanged("LabelText");
            }
        }

        private UInt16 mLength;
        public UInt16 Length
        {
            get { return mLength; }
            set
            {
                mLength = value;
                OnPropertyChanged("LabelText");
            }
        }

        private DataDefinition.SegType mType;
        public DataDefinition.SegType Type
        {
            get { return mType; }
            set
            {
                mType = value;
                OnPropertyChanged("LabelText");
            }
        }

        public String LabelText
        {
            get
            {
                return "[" + this.Length + "] ("
                    + this.Type.ToString() + ") "
                    + this.Name.Substring(0, Math.Min(this.Name.Length, 20));
            }
        }
        #endregion

        public Segment()
        {
            this.Name = "Data segment";
            this.Length = 1;
            this.Type = DataDefinition.SegType.ASCII;
        }

        #region INotifyPropertyChanged メンバ

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
