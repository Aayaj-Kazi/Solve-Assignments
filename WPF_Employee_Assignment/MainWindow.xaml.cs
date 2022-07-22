using Newtonsoft.Json;
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
using WPF_Employee_Assignment.Model;

namespace WPF_Employee_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HttpClient client = new HttpClient();

        static int  count =6;

        public MainWindow()
        {
            client.BaseAddress = new Uri("https://localhost:44379/Employee/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );

            InitializeComponent();

            GetAllEmployee();

        }

        private async void GetAllEmployee()
        {
            
            var response = await client.GetStringAsync("GetAllEmployee");
            var employeeDetails = JsonConvert.DeserializeObject<List<Employee>>(response);
            EmpData.DataContext = employeeDetails;
        }

        private async void SaveEmployee(Employee employee)
        {
            await client.PostAsJsonAsync("AddEmployee", employee);
            GetAllEmployee();
        }


       

        private void SaveEmployee_Click(object sender, RoutedEventArgs e)
        {
            
                count++;

                var emp = new Employee()
                {
                    Id = count,
                    Name = Name.Text,
                    City = city.Text,
                    Salary = Convert.ToDouble(salary.Text),
                    //IsActive = status.Text
                };
            SaveEmployee(emp);
            
        }
        




    }
}
