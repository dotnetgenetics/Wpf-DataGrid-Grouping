using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Data;

namespace WpfDataGridGrouping
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Employee> empData = new ObservableCollection<Employee>()
            {
                new Employee{Name="Greg",Contact="0001",EmailID="greg@mail.com",Country="Philippines"},
                new Employee{Name="Mich",Contact="0002",EmailID="Mich@mail.com",Country="Philippines"},
                new Employee{Name="Mel",Contact="0003",EmailID="Mel@mail.com",Country="USA"},
                new Employee{Name="James",Contact="0004",EmailID="James@mail.com",Country="USA"},
                new Employee{Name="Yosi",Contact="0005",EmailID="Yosi@mail.com",Country="Japan"},
                new Employee{Name="Hiro",Contact="0006",EmailID="Yosi@mail.com",Country="Japan"},
            };

            ListCollectionView collection = new ListCollectionView(empData);
            collection.GroupDescriptions.Add(new PropertyGroupDescription("Country"));
            dgData.ItemsSource = collection;
        }
    }
}