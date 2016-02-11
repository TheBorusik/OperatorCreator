using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows;
using Caliburn.Micro;
using DevExpress.XtraPrinting.Native;
using OperatorCreator.Repository.Context;
using OperatorCreator.Repository.Models;

namespace OperatorCreator.ViewModels
{

    public class FieldsViewModel : Screen
    {

        public BindableCollection<DetailsMetadata> DetailsMetadatas { get; set; }

        public BindableCollection<PropertyType> PropertyTypes { get; set; }

        public BindableCollection<Page> Pages { get; set; }

        public BindableCollection<FieldsMetadata> FieldsMetadatas { get; set; }

        public BindableCollection<FieldVisibility> FieldVisibilitys { get; set; } 

        public int OperatorId { get; set; }

        public string OperatorName { get; set; }

        public FieldsViewModel(IList<PropertyType> propertyTypes,IList<DetailsMetadata> detailsMetadatas,IList<Page> pages  )
        {
            PropertyTypes = new BindableCollection<PropertyType>(propertyTypes);
            DetailsMetadatas = new BindableCollection<DetailsMetadata>(detailsMetadatas);
            Pages = new BindableCollection<Page>(pages);
            FieldVisibilitys = new BindableCollection<FieldVisibility>(FieldVisibility.GetValues());
        }

 

        public void Save()
        {
            try
            {
                using (var db = new JsonContext())
                {
                    FieldsMetadatas.ToList()
                                   .ForEach(field =>
                                                {
                                                    field.OperatorId = OperatorId;
                                                    db.FieldsMetadatas.AddOrUpdate(e => e.FieldMetadataId , field);
                                                });

                    var result=db.SaveChanges();

                    if (result==1)
                    {
                        TryClose(true);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Какая то ошибочка : {ex.Message} {ex.StackTrace}");
            }
        }

        public void Cancel()
        {
            TryClose(false);
        }

        public void Add()
        {
            TryClose(false);
        }

        public void Delete()
        {
            TryClose(false);
        }
    }

}