using AcademyApp.BL.Services.Concretes;

namespace AcademyApp.PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GroupService groupService= new GroupService();
            //foreach (var item in groupService.GetAllGroup())
            //{
            //    Console.WriteLine(item);
            //}
            //groupService.Add(
            //    new()
            //    {
            //        No = "G-005",
            //        Limit = 10
            //    }

            //    );
            //Console.WriteLine("oldu");
            //var group = groupService.GetGroupById(1);
            //Console.WriteLine(group);
        }
    }
}
