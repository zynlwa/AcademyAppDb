using AcademyApp.BL.Services.Concretes;

namespace AcademyApp.PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GroupService groupService= new GroupService();
            foreach (var item in groupService.GetAllGroup())
            {
                Console.WriteLine(item);
            }
        }
    }
}
