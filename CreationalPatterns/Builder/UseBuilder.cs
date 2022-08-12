using SharpDesign.CreationalPatterns.Builder.BestPractice;
using SharpDesign.CreationalPatterns.Builder.Implementation;

namespace SharpDesign.CreationalPatterns.Builder;

public class UseBuilder
{
    public void BuilderInAction()
    {
        var director = new Director();
        IBuilder car = new Car("BMW");
        IBuilder airplane = new AirPlane("some name ");

        //create the car
        director.CreateProduct(car);
        var product1 = car.GetVehicle();
        product1.Show();

        //create the airplane
        director.CreateProduct(airplane);
        var product2 = airplane.GetVehicle();
        product2.Show();

        //here is the best practice .. 

        var connection = SqlConnectionBuilder
            .CreateConnection()
            .UseOracleDb()
            .WithAddress("127.69.69.69")
            .WithUsername("MrAliSalehi")
            .WithPassword("STRONG_PASSWORD")
            .Build();

        Console.WriteLine(connection.ConnectionString);
    }
}