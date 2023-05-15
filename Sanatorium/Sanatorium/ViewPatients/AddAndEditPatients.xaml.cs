using Sanatorium.Database;
using Sanatorium.ViewMenu;
using Sanatorium.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using System.Xml.Linq;

namespace Sanatorium.ViewPatients
{
    /// <summary>
    /// Логика взаимодействия для AddAndEditPatients.xaml
    /// </summary>
    public partial class AddAndEditPatients : Window
    {
      
         public static class D
        {
            public static String ArrivalText { get; set; }
            public static String  DepartureText { get; set; }

        }
        public AddAndEditPatients(Patient patient)
        {
            
            InitializeComponent();
          




            foreach (var item in App.Current.Windows)
            {
                if (item is Patients)
                {
                    Owner = (Window)item;
                }
            }

            if (patient is null)
            {
                var newPatient = new Patient();



                DataContext = newPatient;


            }
            else
            {
                DataContext = patient;
            }

        }

   

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {


            using (var db = new SanatoriumEntities1())
            {
                db.Patient.AddOrUpdate((DataContext as Patient));
                db.SaveChanges();
                ((Owner as Patients).DataContext as AppVM).LoadDate();
                Close();
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Vist_Click(object sender, RoutedEventArgs e)
        {
            var date = new DatePatients();
            date.Show();
            
        }
    }
}

