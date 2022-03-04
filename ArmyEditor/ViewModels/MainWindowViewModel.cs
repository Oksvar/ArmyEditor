using ArmyEditor.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyEditor.ViewModels
{
   public class MainWindowViewModel : ObservableRecipient
    {
        public ObservableCollection<Troopercs> Barracks { get; set; }
        public ObservableCollection<Troopercs> Army { get; set; }

        private Troopercs _selectedItemFromBarracks;

        public Troopercs SelectedItemFromBarracks 
        {
            get => _selectedItemFromBarracks;
            set 
            {
                SetProperty(ref _selectedItemFromBarracks, value);
                AddArmyCommand.NotifyCanExecuteChanged();
            } 
        }
        private Troopercs _selectedItemFromArmy;

        public Troopercs SelectedItemFromArmy 
        {
            get => _selectedItemFromArmy;
            set 
            {
                SetProperty(ref _selectedItemFromArmy, value);

                RemoveFromArmyCommand.NotifyCanExecuteChanged();
            } 
        }

        public RelayCommand AddArmyCommand { get; set; }
        public RelayCommand RemoveFromArmyCommand { get; set; }

        public MainWindowViewModel() 
        {
            Barracks = new ObservableCollection<Troopercs>
            {
                new Troopercs
                {
                    Type = "marine",
                    Power = 5,
                    Speed = 5
                },
                new Troopercs
                {
                    Type = "sniper",
                    Power = 8,
                    Speed = 3
                },
                new Troopercs
                {
                    Type = "Pilot",
                    Power = 5,
                    Speed = 8
                },
                new Troopercs
                {
                    Type = "Engineer",
                    Power = 1,
                    Speed = 7
                },
                new Troopercs
                {
                    Type = "Infentry",
                    Power = 5,
                    Speed = 7
                },

            };
            Army = new ObservableCollection<Troopercs>();

            AddArmyCommand = new RelayCommand(() => 
            {
                Army.Add(SelectedItemFromBarracks);
                SelectedItemFromBarracks = null;
            }
            ,()=> SelectedItemFromBarracks !=null);
            RemoveFromArmyCommand = new RelayCommand(() => Army.Remove(SelectedItemFromArmy),()=> SelectedItemFromArmy != null);
        }
    }
}
