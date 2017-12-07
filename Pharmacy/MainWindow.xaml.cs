using Pharmacy.Views;
using PharmacyCourseProject.ViewModel;
using System;
using System.Collections.Generic;
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


namespace Pharmacy
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            PharmacologicalGroup database = new PharmacologicalGroup();
            DataContext = vm;
            MainContent.Content = search;
            Timer.Tick += new EventHandler(Timer_Click);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            DateTime d;
            d = DateTime.Now;
            label1.Content = d.Hour + " : " + d.Minute + " : " + d.Second;
        }

        SearchView search = new SearchView();
        AdminView admin = new AdminView();
        AdminAddView adminAdd = new AdminAddView();
        AnalogsView analogs = new AnalogsView();

        MainViewModel vm = new MainViewModel();


        private void Search_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainContent.Content = search;
            vm.Collaps();
        }
        private void Admin_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainContent.Content = admin;
            vm.Visible();            
        }



        private void Admin_add_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainContent.Content = adminAdd;
        }
        private void Admin_analogs_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainContent.Content = analogs;
        }
    }
}
