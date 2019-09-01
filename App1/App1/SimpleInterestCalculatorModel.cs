using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App1
{
    public class SimpleInterestCalculatorModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _Prinipal_Amount;
        public string Prinipal_Amount
        {
            get
            {
                return this._Prinipal_Amount;
            }
            set { this._Prinipal_Amount = value;this.OnPropertyChanged("Prinipal_Amount"); }
        }
        private string _Rate;
        public string Rate
        {
            get { return this._Rate; }
            set { this._Rate = value;this.OnPropertyChanged("Rate"); }
        }
        private string _Time;
        public string Time
        {
            get { return this._Time; }
            set { this._Time = value;this.OnPropertyChanged("Time"); }
        }
        private string _CalculatedValue;
        public string CalculatedValue
        {
            get { return this._CalculatedValue; }
            set { this._CalculatedValue = value;this.OnPropertyChanged("CalculatedValue"); }
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
