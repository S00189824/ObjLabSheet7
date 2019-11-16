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

namespace Ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rng = new Random();
        ObservableCollection<Members> listofmembers;
        public MainWindow()
        {
            InitializeComponent();
            listofmembers = new ObservableCollection<Members>();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbxMemberType.ItemsSource = Members.MemberType;
        }

        private void btn_Addbutton_Click(object sender, RoutedEventArgs e)
        {


            listofmembers.Add(new Members(txbName.Text,Members.MemberType[cbxMemberType.SelectedIndex],new DateTime(rng.Next(2000, 2015), dxdate.SelectedDate.Value.Month,dxdate.SelectedDate.Value.Day)));

            lxbox.ItemsSource = listofmembers;

            txblkNumberOfMembers.Text = Members.numberofmembers.ToString();
        }
    }
}
