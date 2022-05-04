namespace Entities
{
    public class Employee /*: IEntity*/
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }

        public virtual void Add(Employee employee)
        {
            Console.WriteLine(employee);
        }
    }
}