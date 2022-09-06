using SharpDesign.StructuralPatterns.Facade.Implementation;

namespace SharpDesign.StructuralPatterns.Facade;

public static class UseFacade
{
    public static void FacadeInAction()
    {
        //without facade

        new Gpu().GetGpu("nvidia rtx 1050");
        new Cpu().GetCpu("intel i3-10300");
        new Motherboard().GetMotherboard("msi-xx");
        
        
        //with facade

        var pcFacade = new PcBuilderFacade();
        //build for gaming
        pcFacade.BuildComputer(PcUseCase.Game);
        
        //build for General Purpose
        pcFacade.BuildComputer(PcUseCase.GeneralPurpose);
        
    }
}