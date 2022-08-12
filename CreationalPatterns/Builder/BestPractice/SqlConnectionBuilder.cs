namespace SharpDesign.CreationalPatterns.Builder.BestPractice;

internal class SqlConnectionBuilder :
    ISqlConnectionBuilder,
    IUsernameSelectionStage,
    IAddressSelectionStage,
    IPasswordSelectionStage,
    IBuildStage
{
    private SqlConnectionBuilder() { }

    public static ISqlConnectionBuilder CreateConnection() => new SqlConnectionBuilder();

    private string _dbType = "none";
    private string _address = "0.0.0.0";
    private string _userName = "root";
    private string _password = "toor";



    public IAddressSelectionStage UseOracleDb()
    {
        _dbType = "Oracle-db";
        return this;
    }

    public IAddressSelectionStage UseSqLiteDb()
    {
        _dbType = "Sql-lite-db";
        return this;
    }

    public IAddressSelectionStage UseSqlServer()
    {
        _dbType = "sql-server";
        return this;
    }

    public IPasswordSelectionStage WithUsername(string userName)
    {
        _userName = userName;
        return this;
    }

    public IUsernameSelectionStage WithAddress(string address)
    {
        _address = address;
        return this;
    }

    public IBuildStage WithPassword(string password)
    {
        _password = password;
        return this;
    }

    public SqlConnection Build()
    {
        return new SqlConnection($"database is : {_dbType} in address :{_address} with UserName : {_userName} and password:{_password}");
    }
}