namespace _01_CustomLINQExtensionMethods
{
    public class Student
    {
        public Student(string name, int grade)
        {
            this.Name = name;
            this.Grade = grade;
        }

        public string Name { get; private set; }

        public int Grade { get; private set; }
    }
}
