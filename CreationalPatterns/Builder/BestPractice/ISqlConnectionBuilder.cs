namespace SharpDesign.CreationalPatterns.Builder.BestPractice;

public interface ISqlConnectionBuilder
{
    public IAddressSelectionStage UseOracleDb();
    public IAddressSelectionStage UseSqLiteDb();
    public IAddressSelectionStage UseSqlServer();
}

public interface IAddressSelectionStage
{
    public IUsernameSelectionStage WithAddress(string address);

}
public interface IUsernameSelectionStage
{
    public IPasswordSelectionStage WithUsername(string userName);
}

public interface IPasswordSelectionStage
{
    public IBuildStage WithPassword(string password);

}

public interface IBuildStage
{
    public SqlConnection Build();
}

public class SqlConnection
{
    internal SqlConnection(string connectionString)
    {
        ConnectionString = connectionString;
    }

    public string ConnectionString { get; }
}