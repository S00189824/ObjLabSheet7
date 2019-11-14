using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabSheet7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Expenses> expense;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Expenses ex1 = new Expenses("travel",30.99m, new DateTime(2019, 09, 10));
            //Expenses ex2 = new Expenses( "Entertainment",64.99m, new DateTime(2019, 01, 18));
            //Expenses ex3 = new Expenses("Office", 40.99m,new DateTime(2019, 11, 22));

            //List<Expenses> expenses = new List<Expenses>();
            expense = new ObservableCollection<Expenses>();
            expense.Add(Expenses.GerneratorRandomExpense());
            expense.Add(Expenses.GerneratorRandomExpense());
            expense.Add(Expenses.GerneratorRandomExpense());

            _txListExpenses.ItemsSource = expense;
        }

        private void txbtnAdd_Click(object sender, RoutedEventArgs e)
        {

            
            expense.Add(Expenses.GerneratorRandomExpense());

            txblkTotal.Text = Expenses.totalexpense.ToString();

        }
    }
}
