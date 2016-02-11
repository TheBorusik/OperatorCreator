using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Windows;
using OperatorCreator.Repository.Models;

namespace OperatorCreator.Repository.Context
{

    public partial class JsonContext : DbContext
    {
        public JsonContext()
            : base("name=JsonContext")
        {
        }

        public virtual DbSet<DetailsMetadata> DetailsMetadatas { get; set; }
        public virtual DbSet<Enumeration> Enumerations { get; set; }
        public virtual DbSet<EnumerationValue> EnumerationValues { get; set; }
        public virtual DbSet<FieldsMetadata> FieldsMetadatas { get; set; }
        public virtual DbSet<FieldsVisibilityCombination> FieldsVisibilityCombinations { get; set; }
        public virtual DbSet<FieldsVisibilityFormula> FieldsVisibilityFormulas { get; set; }
        public virtual DbSet<FieldsVisibilityRule> FieldsVisibilityRules { get; set; }
        public virtual DbSet<Operator> Operators { get; set; }
        public virtual DbSet<OperatorType> OperatorTypes { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<PayrollCenter> PayrollCenters { get; set; }
        public virtual DbSet<PayrollCentersAccount> PayrollCentersAccounts { get; set; }
        public virtual DbSet<PayrollCentersMapping> PayrollCentersMappings { get; set; }
        public virtual DbSet<PropertyType> PropertyTypes { get; set; }
        public virtual DbSet<RecipientDetailsMetadata> RecipientDetailsMetadatas { get; set; }
        public virtual DbSet<Recipient> Recipients { get; set; }
        public virtual DbSet<Selector> Selectors { get; set; }
        public virtual DbSet<SelectorsMetadata> SelectorsMetadatas { get; set; }
        public virtual DbSet<SelectorValue> SelectorValues { get; set; }
        public virtual DbSet<ServiceRecipientCommission> ServiceRecipientCommissions { get; set; }
        public virtual DbSet<ServiceRecipientDetail> ServiceRecipientDetails { get; set; }
        public virtual DbSet<ServiceRecipient> ServiceRecipients { get; set; }
        public virtual DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetailsMetadata>()
                .HasMany(e => e.SelectorsMetadatas)
                .WithOptional(e => e.DetailsMetadata)
                .HasForeignKey(e => e.DetailMetadataId);

            modelBuilder.Entity<DetailsMetadata>()
                .HasMany(e => e.SelectorsMetadatas1)
                .WithOptional(e => e.DetailsMetadata1)
                .HasForeignKey(e => e.FormatedValueDetailsMetadataId);

            modelBuilder.Entity<Enumeration>()
                .HasMany(e => e.EnumerationValues)
                .WithRequired(e => e.Enumeration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Enumeration>()
                .HasMany(e => e.SelectorsMetadatas)
                .WithRequired(e => e.Enumeration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumerationValue>()
                .HasMany(e => e.FieldsVisibilityCombinations)
                .WithRequired(e => e.EnumerationValue)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumerationValue>()
                .HasMany(e => e.SelectorValues)
                .WithOptional(e => e.EnumerationValue)
                .HasForeignKey(e => e.ValueId);

            modelBuilder.Entity<FieldsVisibilityFormula>()
                .HasMany(e => e.FieldsVisibilityCombinations)
                .WithRequired(e => e.FieldsVisibilityFormula)
                .HasForeignKey(e => e.FormulaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FieldsVisibilityRule>()
                .HasMany(e => e.FieldsMetadatas)
                .WithOptional(e => e.FieldsVisibilityRule)
                .HasForeignKey(e => e.VisiblityRuleId);

            modelBuilder.Entity<FieldsVisibilityRule>()
                .HasMany(e => e.FieldsVisibilityCombinations)
                .WithRequired(e => e.FieldsVisibilityRule)
                .HasForeignKey(e => e.FieldVisibilityRuleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Operator>()
                .Property(e => e.MinAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Operator>()
                .Property(e => e.MaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Operator>()
                .Property(e => e.TypeOperator)
                .HasPrecision(4, 0);

            modelBuilder.Entity<Operator>()
                .HasMany(e => e.FieldsVisibilityRules)
                .WithRequired(e => e.Operator)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Operator>()
                .HasMany(e => e.Selectors)
                .WithRequired(e => e.Operator)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Operator>()
                .HasMany(e => e.SelectorsMetadatas)
                .WithRequired(e => e.Operator)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Operator>()
                .HasMany(e => e.Services)
                .WithRequired(e => e.Operator)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperatorType>()
                .Property(e => e.Id)
                .HasPrecision(4, 0);

            modelBuilder.Entity<OperatorType>()
                .Property(e => e.Discription)
                .IsUnicode(false);

            modelBuilder.Entity<PayrollCenter>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PayrollCenter>()
                .Property(e => e.Timestamp)
                .HasPrecision(0);

            modelBuilder.Entity<PayrollCenter>()
                .Property(e => e.Owner)
                .IsUnicode(false);

            modelBuilder.Entity<PayrollCenter>()
                .HasMany(e => e.PayrollCentersAccounts)
                .WithRequired(e => e.PayrollCenter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PayrollCentersAccount>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PayrollCentersAccount>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PayrollCentersAccount>()
                .Property(e => e.Timestamp)
                .HasPrecision(0);

            modelBuilder.Entity<Recipient>()
                .HasMany(e => e.RecipientDetailsMetadatas)
                .WithRequired(e => e.Recipient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Recipient>()
                .HasMany(e => e.ServiceRecipients)
                .WithRequired(e => e.Recipient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Selector>()
                .HasMany(e => e.SelectorValues)
                .WithRequired(e => e.Selector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SelectorsMetadata>()
                .HasMany(e => e.FieldsVisibilityCombinations)
                .WithRequired(e => e.SelectorsMetadata)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SelectorsMetadata>()
                .HasMany(e => e.SelectorValues)
                .WithRequired(e => e.SelectorsMetadata)
                .HasForeignKey(e => e.MetadataId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceRecipient>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ServiceRecipient>()
                .Property(e => e.MinAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ServiceRecipient>()
                .Property(e => e.MaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ServiceRecipient>()
                .Property(e => e.MinCommission)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceRecipient>()
                .Property(e => e.MaxCommission)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceRecipient>()
                .Property(e => e.MaxAmountAuth)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ServiceRecipient>()
                .HasMany(e => e.ServiceRecipientCommissions)
                .WithRequired(e => e.ServiceRecipient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceRecipient>()
                .HasMany(e => e.ServiceRecipientDetails)
                .WithRequired(e => e.ServiceRecipient)
                .HasForeignKey(e => e.ServiceRecipientId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.ServiceRecipients)
                .WithRequired(e => e.Service)
                .WillCascadeOnDelete(false);
        }


        public override int SaveChanges()
        {
           
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                var errors = new StringBuilder();

                foreach (var validationResult in e.EntityValidationErrors)
                {
                    var entityName = validationResult.Entry.Entity.GetType().Name;
                    foreach (var error in validationResult.ValidationErrors)
                    {
                        errors.AppendLine(entityName + "=>" + error.PropertyName + "=>" + error.ErrorMessage);
                    }
                }

                MessageBox.Show(errors.ToString());
                return 0;
            }
        }
    }
}
