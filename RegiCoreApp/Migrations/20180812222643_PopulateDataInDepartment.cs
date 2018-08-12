using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using Microsoft.Data.OData.Query.SemanticAst;

namespace RegiCoreApp.Migrations
{
    public partial class PopulateDataInDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.Sql(@"

        INSERT INTO DEPARTMENT(name) VaLUES('CSE')
        INSERT INTO DEPARTMENT(name) VaLUES('EEE')
        INSERT INTO DEPARTMENT(name) VaLUES('BBA')
        INSERT INTO DEPARTMENT(name) VaLUES('TEX')
        INSERT INTO DEPARTMENT(name) VaLUES('LAW')

");          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        TRUNCATE TABLE DEPARTMENT

");
        }
    }
}
