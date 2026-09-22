namespace Task
{
    public class Person
    {
        public string Name { set; get; }
        virtual public int Age { get; set; }
        public virtual int Salary { get; set; }


        public Departement departement;

        public Person(string Name, int Age, int DepartementNum)
        {
            this.Name = Name;
            this.Age = Age;
            this.departement = (Departement)DepartementNum;
        }
        public override string ToString()
        {
            return $"Name = {Name} , Age = {Age} , Departement = {departement}";
        }
    }



}
