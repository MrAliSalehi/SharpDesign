using SharpDesign.StructuralPatterns.Bridge.Implementation;

namespace SharpDesign.StructuralPatterns.Bridge;

public static class UseBridge
{
    public static void BridgeInAction()
    {
        var proDoc = new ProfessionalDoctor();
        var normalDoc = new NormalDoctor();
        
        HospitalDoctors brainDoctor = new BrainDoctor(normalDoc,"BDoc1");
        brainDoctor.Details();

        HospitalDoctors heartDoc = new HeartDoctor(normalDoc, "HDoc1");
        heartDoc.Details();
        
        
        HospitalDoctors brainDoctor2 = new BrainDoctor(proDoc,"PRO-BDoc1");
        brainDoctor2.Details();

        HospitalDoctors heartDoc2 = new HeartDoctor(proDoc, "PRO-HDoc1");
        heartDoc2.Details();
    }
}