using Week4PracticeAbstraction;

internal class Program
{
    public static void Main(string[] args)
    {
        ProjectManager projectManager = new ProjectManager();           //Bir proje yöneticisi oluşturuldu ve görev metodu çağırıldı
        projectManager.Duty();

        Employess softwareDeveloper  = new SoftwareDeveloper();         //Çok biçimlilik
        softwareDeveloper.Duty();

        Employess salesRepresentative = new SalesRepresentative();
        salesRepresentative.Duty();
        


        


    }
}