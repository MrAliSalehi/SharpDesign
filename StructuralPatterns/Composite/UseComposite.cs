using SharpDesign.StructuralPatterns.Composite.Implementation;

namespace SharpDesign.StructuralPatterns.Composite;

public static class UseComposite
{
    public static void CompositeInAction()
    {
        var emp1 = new Employee("Akbar Agha","Devs","good dev");
        var emp2 = new Employee("Linus torvalds","Devs","Just a junior dev");
        var worker1 = new Worker("Amir tataloo","Workers","useless");

        var composeObj = new CompositeObject("Ali", "Devs", "Best dev ever");
        
        composeObj.Add(emp1);
        composeObj.Add(emp2);
        composeObj.Add(worker1);

        composeObj.PrintInfo();
    }
}