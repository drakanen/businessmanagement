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
using System.Windows.Shapes;

namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for NewAccount.xaml
    /// </summary>
    public partial class NewAccount : Window
    {
        Employee em = new Employee();
        Controller con = new Controller(Environment.CurrentDirectory + "/books.txt");
        MainWindow parentForm;
        Login parentForm2;
        public NewAccount(MainWindow window)
        {
            InitializeComponent();
            parentForm = window;
            this.DataContext = em;
        }

        public NewAccount(Login log)
        {
            InitializeComponent();
            parentForm2 = log;
            this.DataContext = em;
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            em.username = txtUsername.Text;
            em.password = txtPassword.Password;
            em.firstName = txtFirstname.Text;
            em.lastName = txtLastname.Text;
            em.position = txtPosition.Text;
            em.department = txtDepartment.Text;
            em.idNumber = txtIDNumber.Text;
            em.numberOfWriteups = "0";
            if (chbxAdmin.IsChecked == true)
                em.isAdmin = true;
            else
                em.isAdmin = false;
            con.AddEmployee(em);
            con.SaveToFile();
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
