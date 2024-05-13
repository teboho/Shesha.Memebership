using FluentMigrator;
using Shesha.FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shesha.Memebership.Domain
{
    [Migration(20230513133050)]
    public class M20230513133050 : Migration
    {
        /// <summary>
        /// Code to exucute when the migration is run
        /// </summary>
        public override void Up()
        {
            Alter.Table("Core_Persons")
                .AddColumn("Mem_MembershipNumber").AsString().Nullable()
                .AddForeignKeyColumn("Mem_IdDocumentId", "Frwk_StoredFiles").Nullable()
                .AddColumn("Mem_MembershipStartDate").AsDateTime().Nullable()
                .AddColumn("Mem_MembershipEndDate").AsDateTime().Nullable()
                .AddColumn("Mem_MembershipStatusLkp").AsInt32().Nullable();
        }

        /// <summary>
        /// Code to exucute when the migration is rolled back
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}
