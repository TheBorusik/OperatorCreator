using System;
using System.ComponentModel;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Data;
using System.Windows.Forms;
using Caliburn.Micro;
using DevExpress.XtraPrinting.Native;
using OperatorCreator.Repository.Context;
using OperatorCreator.Repository.Models;

namespace OperatorCreator.ViewModels {

    public class MainViewModel : PropertyChangedBase ,IShell
    {
        private ICollectionView operators;

        private Operator selectedOperator;

        private string operatorFilterString;

        private string nameFilterString;

        private FieldsViewModel fieldsViewModel;

        public FieldsViewModel FieldsViewModel
        {
            get
            {
                return fieldsViewModel;
            }
            set
            {
                if (Equals(value , fieldsViewModel)) return;
                fieldsViewModel = value;
                NotifyOfPropertyChange(() => FieldsViewModel);
            }
        }

        public ICollectionView Operators
        {
            get
            {
                return operators;
            }
            set
            {
                if (Equals(value , operators)) return;
                operators = value;
                NotifyOfPropertyChange(() => Operators);
            }
        }

        public Operator SelectedOperator
        {
            get
            {
                return selectedOperator;
            }
            set
            {
                if (Equals(value , selectedOperator)) return;
                selectedOperator = value;
                NotifyOfPropertyChange(() => SelectedOperator);
            }
        }

        public string OperatorFilterString
        {
            get
            {
                return operatorFilterString;
            }
            set
            {
                if (value == operatorFilterString) return;
                operatorFilterString = value;
                NotifyOfPropertyChange(() => OperatorFilterString);
                FilterCollection();
            }
        }

        public string NameFilterString
        {
            get
            {
                return nameFilterString;
            }
            set
            {
                if (value == nameFilterString) return;
                nameFilterString = value;
                NotifyOfPropertyChange(() => NameFilterString);
                FilterCollection();
            }
        }

        public void FilterCollection()
        {
            Operators?.Refresh();
        }

        public IWindowManager WindowManager { get; set; }

        public MainViewModel( IWindowManager windowManager)
        {
            WindowManager = windowManager;

            using (var db = new JsonContext())
            {
                Operators = CollectionViewSource.GetDefaultView(db.Operators.ToList());
                FieldsViewModel = new FieldsViewModel(db.PropertyTypes.ToList() , db.DetailsMetadatas.ToList() , db.Pages.ToList());


                OperatorFilterString = string.Empty;
                NameFilterString = string.Empty;
                operators.Filter = Filter;
            }
        }

        private bool Filter(object op)
        {
            try
            {
                return ((Operator)op).Name.ToLower().Contains(NameFilterString.ToLower()) && ((Operator)op).OperatorId.ToString().StartsWith(OperatorFilterString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Filter error ^ {ex.Message} {ex.StackTrace}");
                return false;
            }
        }

        public void ViewFields()
        {
            using (var db = new JsonContext())
            {
                var files = db.FieldsMetadatas.Where(x => x.OperatorId == SelectedOperator.OperatorId).ToList();


                FieldsViewModel.FieldsMetadatas=new BindableCollection<FieldsMetadata>(files);
                FieldsViewModel.OperatorId = SelectedOperator.OperatorId;
                FieldsViewModel.OperatorName = SelectedOperator.Name;

                if (WindowManager.ShowDialog(FieldsViewModel) == true)
                {
                  
                }

            }

        }

        public void ViewServices()
        {
            MessageBox.Show(@"ViewServices");
            }

        public void ViewCommissions()
        {
            MessageBox.Show(@"ViewCommssions");
        }
    }
}