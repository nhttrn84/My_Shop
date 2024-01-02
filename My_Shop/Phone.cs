using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Shop
{
    public class Phone : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Image {  get; set; }
        public string Manufacturer { get; set; }
        public string Price { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
