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

namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller con = new Controller(Environment.CurrentDirectory + "/books.txt");
        Employee em = new Employee();
        public MainWindow(bool admin)
        {
            InitializeComponent();
            if (!admin)
            {
                btnEdit.Visibility = Visibility.Hidden;
                btnAddEmployee.Visibility = Visibility.Hidden;
                btnRemoveEmployee.Visibility = Visibility.Hidden;
                chkbxAdmin.Visibility = Visibility.Hidden;
                lblAdmin.Visibility = Visibility.Hidden;
                lblUsername.Visibility = Visibility.Hidden;
                lblPassword.Visibility = Visibility.Hidden;
                txtUsername.Visibility = Visibility.Hidden;
                txtPassword.Visibility = Visibility.Hidden;
            }
            lstEmployees.ItemsSource = con.GetAllEmployees();
            this.DataContext = em;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if ((string) btnEdit.Content == "Edit employee")
            {
                txtFirstname.IsEnabled = true;
                txtLastname.IsEnabled = true;
                txtIdnumber.IsEnabled = true;
                txtPosition.IsEnabled = true;
                txtDepartment.IsEnabled = true;
                txtUsername.IsEnabled = true;
                txtPassword.IsEnabled = true;
                txtNumberofwriteups.IsEnabled = true;
                chkbxAdmin.IsEnabled = true;
                btnEdit.Content = "Stop editing";
            }
            else
            {
                txtFirstname.IsEnabled = false;
                txtLastname.IsEnabled = false;
                txtIdnumber.IsEnabled = false;
                txtPosition.IsEnabled = false;
                txtDepartment.IsEnabled = false;
                txtUsername.IsEnabled = false;
                txtPassword.IsEnabled = false;
                txtNumberofwriteups.IsEnabled = false;
                chkbxAdmin.IsEnabled = false;
                btnEdit.Content = "Edit employee";
                Employee em = (Employee)lstEmployees.SelectedItem;
                Employee em2 = new BusinessManagement.Employee();
                em2.firstName = txtFirstname.Text;
                em2.lastName = txtLastname.Text;
                em2.idNumber = txtIdnumber.Text;
                em2.position = txtPosition.Text;
                em2.department = txtDepartment.Text;
                em2.username = txtUsername.Text;
                em2.password = txtPassword.Text;
                em2.numberOfWriteups = txtNumberofwriteups.Text;
                em2.isAdmin = (bool) chkbxAdmin.IsChecked;
                con.RemoveEmployee(em);
                con.AddEmployee(em2);
                con.SaveToFile();
                updateList();
            }
        }

        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            NewAccount na = new NewAccount(this);
            na.ShowDialog();
            updateList();
        }

        private void btnRemoveEmployee_Click(object sender, RoutedEventArgs e)
        {
            Employee em = (Employee) lstEmployees.SelectedItem;
            con.RemoveEmployee(em);
            con.SaveToFile();
            updateList();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            lstEmployees.SelectedItem = con.FindEmployee(txtSearch.Text);
        }

        private void lstEmployeesBox(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Employee em = (Employee)lstEmployees.SelectedItem;
                txtFirstname.Text = em.firstName;
                txtLastname.Text = em.lastName;
                txtIdnumber.Text = em.idNumber;
                txtPosition.Text = em.position;
                txtDepartment.Text = em.department;
                txtNumberofwriteups.Text = em.numberOfWriteups;
                txtUsername.Text = em.username;
                txtPassword.Text = em.password;
                chkbxAdmin.IsChecked = em.isAdmin;
            }
            catch (NullReferenceException)
            {

            }
        }

        private void updateList()
        {
            lstEmployees.ItemsSource = null;
            lstEmployees.ItemsSource = con.GetAllEmployees();
        }
    }
}
