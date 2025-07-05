namespace AcademyApp.BL.Exceptions
{
    public class EntityDuplicateNameException:Exception
    {
        public EntityDuplicateNameException() : base()
        {
        }

        public EntityDuplicateNameException(string message) : base(message)
        {
        }
    }
}
