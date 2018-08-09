namespace electron_poc.Models
{
    public class EmployeeModel
    {
        public string Name { get; set; }

        public string Position {get; set; }

        public EmployeeModel(string name, string position){
            Name = name;
            Position = position;
        }
    }
}