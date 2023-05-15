using Sanatorium.Database;
using Sanatorium.ViewMenu;
using Sanatorium.ViewModel;
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

namespace Sanatorium.ViewPatients
{
    /// <summary>
    /// Логика взаимодействия для Patients.xaml
    /// </summary>
    public partial class Patients : Window
    {
        public Patients()
        {
            InitializeComponent();
            DataContext = new AppVM();
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddAndEditPatients(null);
            addWindow.Show();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new SanatoriumEntities1())
                {
                    var idForDelete = (DataContext as AppVM).SelectedPatients.PatientId;

                    var objectForDelete = db.Patient.FirstOrDefault(x => x.PatientId == idForDelete);

                    db.Patient.Remove(objectForDelete);

                    db.SaveChanges();

                    (DataContext as AppVM).LoadDate();
                }
            }
            catch
            {

            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var editwindow = new AddAndEditPatients((DataContext as AppVM).SelectedPatients);

            editwindow.Show();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            var back = new UserPageWindow();
            back.Show();
            this.Close();
        }
    }
}
