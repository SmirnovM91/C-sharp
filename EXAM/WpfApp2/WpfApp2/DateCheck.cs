using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class DateCheck: INotifyPropertyChanged
    {
        private Boolean _iswas;
        public DateTime Date { get; set; }
        public Employee Employee { get; set; }
   
        public Boolean isWas
        {
            get
            {
                return _iswas;
            }
            set
            {
                if (Date.Date <= DateTime.Now.Date)
                {
                    _iswas = value;
                    if (PropertyChanged != null)
                    {
                        DataService.SaveToFileChecks();
                    }
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
