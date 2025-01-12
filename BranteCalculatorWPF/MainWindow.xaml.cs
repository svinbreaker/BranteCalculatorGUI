using BranteCalculator.Entities;
using BranteCalculator.Entities.Events;
using BulbulatorLocalization;
using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BranteCalculatorWPF
{
    public partial class MainWindow : Window
    {
        private static Localizer _localizer;
        private static MainViewModel _viewModel;
        
        public static Settings Settings { get; } = new ("English");

        public static Localizer Localizer
        {
            get
            {
                if (_localizer == null)
                {
                    _localizer = new Localizer(Directory.GetFiles($@"{ProjectPath}\Resources\Localization", "*.json").ToList());
                }
                return _localizer;
            }
        }
        
        private static string ProjectPath => AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\net8.0", "").Replace("-windows", "");

        public static MainViewModel ViewModel { get { if (_viewModel == null) { _viewModel = new MainViewModel(); } return _viewModel; } }

        Dictionary<Event, Decision> SavedDecisions = new Dictionary<Event, Decision>();


        public MainWindow()
        {
            InitializeComponent();
            InitializeLanguageMenu();
            DataContext = ViewModel;
            AddNextEvent();
        }

        public void AddNextEvent()
        {
            Event? nextEvent = GetNextEvent();
            if (nextEvent == null)
            {
                return;
            }

            ViewModel.Events.Add(nextEvent);

            if (SavedDecisions.ContainsKey(nextEvent))
            {
                Decision savedDecision = SavedDecisions[nextEvent];
                foreach(Decision decision in nextEvent.Decisions) 
                {
                    decision.UpdateAvailability();
                }

                if (savedDecision.IsAvailable)
                {
                    savedDecision.Select();
                    AddNextEvent();
                    return;
                }
                else
                {
                    savedDecision.IsChecked = false;
                }
            }
            //temp solution
            else if (nextEvent.SelectedDecision != null) 
            {
                nextEvent.SelectedDecision.IsChecked = false;
            }
                        
            ScrollToEnd();
        }

        public void Recalculate(Event changedEvent, Decision changedDecision, bool stopAt = false)
        {
            List<Event> selectedEvents = ViewModel.Events.ToList();
            List<Event> newList = new List<Event>();

            //reset data
            ViewModel.Reset();

            //set events before changedEvent
            int changedEventPosition = selectedEvents.IndexOf(changedEvent);
            for (int i = 0; i < changedEventPosition + 1; i++)
            {
                Event selectedEvent = selectedEvents[i];
                foreach (Decision decision in selectedEvent.Decisions)
                {
                    selectedEvent.HasPassed = false;
                    bool isAvailable = decision.IsAvailable;
                }
                newList.Add(selectedEvent);


                if (selectedEvent.SelectedDecision != null && (stopAt == false || selectedEvent != changedEvent))
                {
                    selectedEvent.SelectedDecision.Select();
                }
            }


            int lastAvailableCalculated = 0;
            bool addNextEvent = false;


            if (stopAt == false)
            {
                for (int i = changedEventPosition + 1; i < selectedEvents.Count; i++)
                {
                    Event selectedEvent = selectedEvents[i];

                    if (GetNextEvent() != selectedEvent)
                    {
                        lastAvailableCalculated = i;
                        addNextEvent = true;
                        break;
                    }

                    if (!selectedEvent.IsAvalaible)
                    {
                        lastAvailableCalculated = i;
                        addNextEvent = true;
                        break;
                    }



                    Decision? selectedDecision = selectedEvent.SelectedDecision;
                    if (selectedDecision == null)
                    {
                        newList.Add(selectedEvent);
                        lastAvailableCalculated = i;
                        break;
                    }

                    if (selectedDecision.IsAvailable)
                    {
                        newList.Add(selectedEvent);
                        selectedEvent.SelectedDecision.Select();
                    }
                    else
                    {
                        selectedEvent.SelectedDecision.IsChecked = false;
                        addNextEvent = true;
                        lastAvailableCalculated = i;
                        break;
                    };
                }
            }
            else
            {
                if (changedEvent.SelectedDecision != null)
                {
                    changedEvent.SelectedDecision.IsChecked = false;
                }
            }

            //Save selected decisions

            for (int i = lastAvailableCalculated; i < selectedEvents.Count; i++)
            {
                Event selectedEvent = selectedEvents[i];
                if (selectedEvent.SelectedDecision != null)
                {
                    SavedDecisions[selectedEvent] = selectedEvent.SelectedDecision;               
                }
            }

            //set
            ViewModel.Events = new Util.ItemsChangeObservableCollection<Event>(newList);

            if (addNextEvent)
            {
                AddNextEvent();
            }

        }



        private void ScrollToEnd()
        {
            ScrollViewer scrollViewer = GetScrollViewer(EventsListbox);
            if (scrollViewer != null)
            {
                scrollViewer.ScrollToEnd();
            }
        }

        private ScrollViewer GetScrollViewer(DependencyObject depObj)
        {
            if (depObj is ScrollViewer)
                return depObj as ScrollViewer;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
            {
                var child = VisualTreeHelper.GetChild(depObj, i);
                var result = GetScrollViewer(child);
                if (result != null)
                    return result;
            }
            return null;
        }


        public Event? GetNextEvent()
        {
            Event? optionalEvent = ViewModel.AllEvents.Where(e => !e.HasPassed && e.IsVariableTime && e.IsAvalaible).FirstOrDefault();
            if (optionalEvent != null)
            {
                return optionalEvent;
            }

            List<Event> linearEvents = ViewModel.AllEvents.Where(e => !e.HasPassed && !e.IsVariableTime).ToList();
            foreach (Event linearEvent in linearEvents)
            {
                if (!linearEvent.IsAvalaible)
                {
                    linearEvent.HasPassed = true;
                }
                else
                {
                    return linearEvent;
                }
            }
            return null;
        }

        private void EventsListbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedObject = EventsListbox.SelectedItem;
            if (selectedObject != null)
            {
                if (selectedObject is Event selectedEvent)
                {
                    if (selectedEvent.SelectedDecision != null)
                    {
                        Recalculate(selectedEvent, selectedEvent.SelectedDecision, true);
                    }
                }
            }
            EventsListbox.SelectedItem = null;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";
            saveFileDialog.Title = "Save text file";
            if (saveFileDialog.ShowDialog() == true)
            {
                StringBuilder builder = new StringBuilder();

                int eventNumber = 1;
                foreach (Event gameEvent in ViewModel.Events) 
                {
                    if (gameEvent.Decisions.Count > 1 && gameEvent.SelectedDecision != null) 
                    {
                        builder.Append(eventNumber);
                        builder.Append(". ");
                        builder.Append(gameEvent.LocalizedName);
                        builder.Append(": ");
                        builder.Append(gameEvent.SelectedDecision.LocalizedName);
                        builder.Append("\n");
                        eventNumber++;
                    }
                }
                string text = builder.ToString();

                File.WriteAllText(saveFileDialog.FileName, text);
                MessageBox.Show("File saved successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void InitializeLanguageMenu()
        {
            List<string> languages = Localizer.GetLanguages(); 
            foreach (string language in languages)
            {
                MenuItem languageItem = new MenuItem { Header = language };
                
                if (language == Settings.Locale)
                {
                    languageItem.IsChecked = true;
                }
                languageItem.Click += LanguageItem_Click; 
                LanguageMenu.Items.Add(languageItem); 
            }
        }

        
        private void LanguageItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem clickedItem = sender as MenuItem;

            foreach (MenuItem item in LanguageMenu.Items)
            {
                item.IsChecked = false;
            }

            clickedItem.IsChecked = true;
            Settings.Locale = clickedItem.Header.ToString();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e) 
        {
            SavedDecisions.Clear();
            MessageBox.Show("Saved decisions cleared successfully!");
        }
    }
}