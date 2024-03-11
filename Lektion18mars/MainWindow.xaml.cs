using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Lektion18mars
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ObservableCollection<Uppgifter> tasks = new ObservableCollection<Uppgifter>();
        public ObservableCollection<Uppgifter> Tasks
        {
            get { return tasks; }
            set
            {
                tasks = value;
                OnPropertyChanged(nameof(Tasks));
            }
        }

        private Uppgifter newTask;

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Uppgifter NewTask
        {
            get { return newTask; }
            set
            {
                newTask = value;
                OnPropertyChanged(nameof(NewTask));
            }
        }

        public string tid { get; set; } = DateTime.Now.ToString("HH,mm");
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(newTaskTextBox.Text))
            {
                Tasks.Add(new Uppgifter(newTaskTextBox.Text, alarmDatePicker.Text));
                newTaskTextBox.Clear();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Uppgifter selectedTask = (Uppgifter)taskListBox.SelectedItem;
            if (selectedTask != null)
            {
                Tasks.Remove(selectedTask);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}