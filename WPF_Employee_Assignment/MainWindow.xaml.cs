using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;


namespace WPF_Employee_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       static int count = 6;
        List<Employee> _listEmployees = new List<Employee> {
        new Employee { Id=1, Name="Tony", City="Pune", Salary=10000, IsActive="No"},
        new Employee { Id=2, Name="Steve", City="Mumbai", Salary=20000, IsActive="No"},
        new Employee { Id=3, Name="Thor", City="Solapur", Salary=30000, IsActive="Yes"},
        new Employee { Id=4, Name="Barton", City="Thane", Salary=20000, IsActive="Yes"},
        new Employee { Id=5, Name="Bruce", City="Ahamadnagar", Salary=10000, IsActive="Yes"},
        new Employee { Id=6, Name="Natasha", City="Pune", Salary=12000, IsActive="No"},
            };
        public MainWindow()
        {
            InitializeComponent();

            //saveEmp.Click = SaveEmployee_Click();

            EmpData.ItemsSource = GetAllEmployee();

        }



        IEnumerable<Employee> GetAllEmployee()
        {

            return _listEmployees;
        }

        private void SaveEmployee_Click(object sender, RoutedEventArgs e)
        {
            count++;

            Employee emp = new Employee
            {
                Id = count,
                Name = Name.Text,
                City = city.Text,
                Salary = Convert.ToDouble(salary.Text),
                IsActive = status.Text
            };

            _listEmployees.Add(emp);
            EmpData.ItemsSource = GetAllEmployee();
        }


        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public string City { get; set; }

            public double Salary { get; set; }

            public string IsActive { get; set; }
        }

       
    }
}
