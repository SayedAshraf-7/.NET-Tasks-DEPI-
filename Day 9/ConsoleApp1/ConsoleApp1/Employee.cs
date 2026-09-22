namespace Task
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public clsDepartement Departement { get;set; }
        public Employee(int ID , string Name )
        {
            this.ID = ID;
            this.Name = Name;
        }
        public Employee(int ID , string Name , clsDepartement departement) : this(ID , Name) 
        {
            Departement = departement;
        }
        public override string ToString()
        {
            return $"Name: {Name} , ID: {ID}";
        }

        public override bool Equals(object? obj)
        {
            Employee emp = (Employee)obj; // 
            return (emp.Departement.ID == Departement.ID)
                && (emp.Departement.Name == Departement.Name);
        }

    }


}
