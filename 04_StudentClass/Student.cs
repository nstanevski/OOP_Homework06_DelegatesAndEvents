using System;

namespace _04_StudentClass
{

    public delegate void OnPropertyChangedEventHandler(Student sender, PropertyChangedEventArgs args);

    public class Student
    {
        private string name;
        private int age;

        public event OnPropertyChangedEventHandler PropertyChanged;
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("name", "Name cannot be null or empty");
                }
                if (this.name != value)
                {
                    if (this.PropertyChanged != null)
                    {
                        this.PropertyChanged(this, 
                            new PropertyChangedEventArgs("Name", this.name, value));
                    }
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("age", "Age cannot be null or empty");
                }
                if (this.age != value)
                {
                    if (this.PropertyChanged != null)
                    {
                        this.PropertyChanged(this,
                            new PropertyChangedEventArgs("Age", this.age.ToString(), value.ToString()));
                    }
                }
                this.age = value;
            }
        }
    }
}
