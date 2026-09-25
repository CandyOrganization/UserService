using FluentMigrator;

namespace DataAccess.Migrations;

[Migration(0)]
public class M0000_InitialMigration : Migration
{
    public override void Up()
    {
        Create.Table("users")
            .WithColumn("id").AsGuid().PrimaryKey().WithDefaultValue(RawSql.Insert("gen_random_uuid()"))
            .WithColumn("email").AsString().NotNullable().Unique()
            .WithColumn("hashed_password").AsString().NotNullable()
            .WithColumn("role").AsString().NotNullable()
            .WithColumn("employee_id").AsGuid().NotNullable();
    }

    public override void Down()
    {
        Delete.Table("users");
    }
}