using SharpDesign.StructuralPatterns.Bridge.Implementation;
using SharpDesign.StructuralPatterns.Bridge.PathExample;

namespace SharpDesign.StructuralPatterns.Bridge;

public static class UseBridge
{
    public static void BridgeInAction()
    {
        var proDoc = new ProfessionalDoctor();
        var normalDoc = new NormalDoctor();
        
        var brainDoctor = new BrainDoctor(normalDoc,"BDoc1");
        brainDoctor.Details();
        //note that you cannot access this method if you explicitly declare it as HospitalDoctors. 
        brainDoctor.NeedMoreMoney();
        //but you can cast it ...
        ((BrainDoctor)brainDoctor).NeedMoreMoney();
        
        HospitalDoctors heartDoc = new HeartDoctor(normalDoc, "HDoc1");
        heartDoc.Details();
        
        HospitalDoctors brainDoctor2 = new BrainDoctor(proDoc,"PRO-BDoc1");
        brainDoctor2.Details();

        HospitalDoctors heartDoc2 = new HeartDoctor(proDoc, "PRO-HDoc1");
        heartDoc2.Details();
        
        //path example :

        Files saveLinux = new TextFile(new LinuxPath());
        saveLinux.SaveFile("some folder address here");
        
        Files saveTheIdiot = new TextFile(new WindowsPath());
        saveTheIdiot.SaveFile("some folder address here");
    }
}