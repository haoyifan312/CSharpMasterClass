using DataBinding.Data;
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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>
        { 
            new Person{Name="Yifan", Age=36},
            new Person{Name="April", Age=39},
            new Person{Name="Amy", Age=11},
            new Person{Name="Daniel", Age=3},
        };

        public MainWindow()
        {
            InitializeComponent();

            ListBoxPeople.ItemsSource = People;
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            var selected = ListBoxPeople.SelectedItems;
            foreach (var item in selected)
            {
                var person = (Person)item;
                MessageBox.Show(person.Name);
            }
        }
    }
}