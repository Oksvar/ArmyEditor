using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyEditor.Models
{
   public class Troopercs : ObservableObject
    {
        private string _type;
        public string Type 
        { get => _type;
          set => SetProperty(ref _type, value);
        }
        private int _power;
        public int Power 
        {
            get => _power;
            set => SetProperty(ref _power, value); 
        }
        private int _speed;
        public int Speed 
        {
            get => _speed;
            set => SetProperty(ref _speed, value);
        }
    }
}
