

namespace prop_index
{
    class Student
    {
        int stdId; string stdName; double marks;
        private string[] courses = new string[3];
        //Indexer
        //public object this[int index]
        //{
        //    set
        //    {
        //        if (index == 0)
        //            stdId = Convert.ToInt32(value);
        //        if (index == 1)
        //            stdName = Convert.ToString(value);
        //        if (index == 2)
        //            marks = Convert.ToDouble(value);
        //    }
        //    get
        //    {
        //        if (index == 0)
        //            return stdId;
        //        if (index == 1)
        //            return stdName;
        //        if (index == 2)
        //            return marks;
        //        return null;
        //    }
        //}

        public string this[int index]
        {
            set
            {
                courses[index] = value;
            }
            get
            {
                return courses[index];
            }
        }
    }
    class Class3
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1[0] = "C#.Net";
            s1[1] = "ASP.Net Core";
            s1[2] = "Web API";
            //s1[3] = "Entity Framework";
            Console.WriteLine(s1[0] + " " + s1[1] + " " + s1[2]);

            //Console.WriteLine("Enter Student Details: ");
            //s1[0] = Console.ReadLine();
            //s1[1] = Console.ReadLine();
            //s1[2] = Console.ReadLine();
            //Console.WriteLine("Student ID is: " + s1[0]);
            //Console.WriteLine("Student Name is: " + s1[1]);
            //Console.WriteLine("Student Marks is: " + s1[2]);
            Console.Read();
        }
    }

}
