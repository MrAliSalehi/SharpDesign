namespace SharpDesign.StructuralPatterns.Facade.Implementation;

public enum PcUseCase
{
    GeneralPurpose,
    Game
}

public class PcBuilderFacade
{
    // ReSharper disable once MemberCanBeMadeStatic.Global
    public void BuildComputer(PcUseCase useCase)
    {
        var cpu = new Cpu();
        var motherboard = new Motherboard();
        switch (useCase)
        {
            case PcUseCase.GeneralPurpose:
                cpu.GetCpu("intel i7-9700");
                motherboard.GetMotherboard("hp-someModel");
                Console.WriteLine("you dont need gpu...");
                break;
            case PcUseCase.Game:
                var gpu = new Gpu();
                gpu.GetGpu("Nvidia rtx 3060");
                cpu.GetCpu("i9-11900");
                motherboard.GetMotherboard("asus z690");
                break;

            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}