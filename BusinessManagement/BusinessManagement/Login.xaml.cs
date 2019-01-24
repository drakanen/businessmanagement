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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        Controller con = new Controller(Environment.CurrentDirectory + "/books.txt");
        public Login()
        {
            InitializeComponent();
            if (con.isEmpty() == true)
            {
                NewAccount na = new NewAccount(this);
                na.ShowDialog();
                con.GetAllEmployees();
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (con.isEmpty() == false)
            {
                List<Employee> employees = con.GetAllEmployees();
                foreach (Employee em in employees)
                {
                    if (em.username == txtUsername.Text)
                    {
                        if (em.password == txtPassword.Password)
                        {
                            MainWindow mw = new MainWindow(em.isAdmin);
                            Close();
                            mw.ShowDialog();
                        }
                        else
                            lblIncorrect.Visibility = Visibility.Visible;
                    }
                    else
                        lblIncorrect.Visibility = Visibility.Visible;
                }
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
