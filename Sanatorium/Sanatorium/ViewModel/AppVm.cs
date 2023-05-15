using Sanatorium.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorium.ViewModel
{
    public class AppVM : BaseModel
    {

        private Patient _selectedPatients;
        public Patient SelectedPatients
        {
            get => _selectedPatients;
            set
            {
                _selectedPatients = value;
                OnPropertyChanged(nameof(SelectedPatients));
            }
        }

        private ObservableCollection<Patient> _patients;
        public ObservableCollection<Patient> Patients
        {
            get => _patients;
            set
            {
                _patients = value;
                OnPropertyChanged(nameof(Patients));
            }
        }

        public AppVM()
        {
            Initialine();
            LoadDate();
        }

        private void Initialine()
        {
            Patients = new ObservableCollection<Patient>();
        }

        public void LoadDate()
        {
            Patients.Clear();
            using (SanatoriumEntities1 context = new SanatoriumEntities1())
            {
                var _productList = context.Patient.ToList();
                _productList.ForEach(p => Patients.Add(p));
            }
        }
     
    }
}

