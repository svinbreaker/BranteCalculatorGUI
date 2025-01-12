using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BranteCalculatorWPF.Entities;

namespace BranteCalculatorWPF
{
    using BranteCalculator.Entities;
    using BranteCalculator.Entities.Characters;
    using BranteCalculator.Entities.Events;
    using BranteCalculator.Entities.Stats;
    using BranteCalculatorWPF.Util;
    using System.Collections.ObjectModel;
    using System.ComponentModel;

    public class MainViewModel : INotifyPropertyChanged
    {
        private Storage _storage;

        private ItemsChangeObservableCollection<Event> _events;
        public ItemsChangeObservableCollection<Event> Events
        {
            get => _events;
            set
            {
                _events = value;
                OnPropertyChanged(nameof(Events));
            }
        }

        private ItemsChangeObservableCollection<Character> _characters;
        public ItemsChangeObservableCollection<Character> Characters
        {
            get => _characters;
            set
            {
                _characters = value;
                OnPropertyChanged(nameof(Characters));
            }
        }

        private ItemsChangeObservableCollection<Stat> _lifetimeStats;
        public ItemsChangeObservableCollection<Stat> LifetimeStats
        {
            get => _lifetimeStats;
            set
            {
                _lifetimeStats = value;
                OnPropertyChanged(nameof(LifetimeStats));
            }
        }

        private ItemsChangeObservableCollection<Stat> _adultStats;
        public ItemsChangeObservableCollection<Stat> AdultStats
        {
            get => _adultStats;
            set
            {
                _adultStats = value;
                OnPropertyChanged(nameof(AdultStats));
            }
        }

        private ItemsChangeObservableCollection<Stat> _childhoodStats;
        public ItemsChangeObservableCollection<Stat> ChildhoodStats
        {
            get => _childhoodStats;
            set
            {
                _childhoodStats = value;
                OnPropertyChanged(nameof(ChildhoodStats));
            }
        }

        private ItemsChangeObservableCollection<Stat> _adolescenceStats;
        public ItemsChangeObservableCollection<Stat> AdolescenceStats
        {
            get => _adolescenceStats;
            set
            {
                _adolescenceStats = value;
                OnPropertyChanged(nameof(AdolescenceStats));
            }
        }

        private ItemsChangeObservableCollection<Stat> _familyStats;
        public ItemsChangeObservableCollection<Stat> FamilyStats
        {
            get => _familyStats;
            set
            {
                _familyStats = value;
                OnPropertyChanged(nameof(FamilyStats));
            }
        }

        private ItemsChangeObservableCollection<Stat> _provinceStats;
        public ItemsChangeObservableCollection<Stat> ProvinceStats
        {
            get => _provinceStats;
            set
            {
                _provinceStats = value;
                OnPropertyChanged(nameof(ProvinceStats));
            }
        }

        private ItemsChangeObservableCollection<Stat> _occupationStats;
        public ItemsChangeObservableCollection<Stat> OccupationStats
        {
            get => _occupationStats;
            set
            {
                _occupationStats = value;
                OnPropertyChanged(nameof(OccupationStats));
            }
        }

        private ItemsChangeObservableCollection<Stat> _revoltStats;
        public ItemsChangeObservableCollection<Stat> RevoltStats
        {
            get => _revoltStats;
            set
            {
                _revoltStats = value;
                OnPropertyChanged(nameof(RevoltStats));
            }
        }

        private ItemsChangeObservableCollection<Flag> _flags;
        public ItemsChangeObservableCollection<Flag> Flags
        {
            get => _flags;
            set
            {
                _flags = value;
                OnPropertyChanged(nameof(Flags));
            }
        }

        private ItemsChangeObservableCollection<Event> _allEvents;
        public ItemsChangeObservableCollection<Event> AllEvents
        {
            get => _allEvents;
            set
            {
                _allEvents = value;
                OnPropertyChanged(nameof(AllEvents));
            }
        }

        private ItemsChangeObservableCollection<Flag> _allFlags;
        public ItemsChangeObservableCollection<Flag> AllFlags
        {
            get => _allFlags;
            set
            {
                _allFlags = value;
                OnPropertyChanged(nameof(AllFlags));
            }
        }

        public MainViewModel()
        {
            _storage = Storage.Instance;
            Events = new ItemsChangeObservableCollection<Event>();
            Reset();
        }

        public void Reset() 
        {
            _storage.Reset();
            Events = new ItemsChangeObservableCollection<Event>();
            Characters = new ItemsChangeObservableCollection<Character>(_storage.Characters);
            LifetimeStats = new ItemsChangeObservableCollection<Stat>(_storage.LifetimeStats);
            AdultStats = new ItemsChangeObservableCollection<Stat>(_storage.AdultStats);
            ChildhoodStats = new ItemsChangeObservableCollection<Stat>(_storage.ChildhoodStats);
            AdolescenceStats = new ItemsChangeObservableCollection<Stat>(_storage.AdolescenceStats);
            OccupationStats = new ItemsChangeObservableCollection<Stat>(_storage.OccupationStats);
            RevoltStats = new ItemsChangeObservableCollection<Stat>(_storage.RevoltStats);
            FamilyStats = new ItemsChangeObservableCollection<Stat>(_storage.FamilyStats);
            ProvinceStats = new ItemsChangeObservableCollection<Stat>(_storage.ProvinceStats);
            Flags = new ItemsChangeObservableCollection<Flag>();

            AllEvents = new ItemsChangeObservableCollection<Event>(_storage.Events);
            AllFlags = new ItemsChangeObservableCollection<Flag>(_storage.Flags);
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
