

namespace prop_index
{
    namespace CAAbstractClasses
    {
        class Dept
        {
            int deptId; string deptName; double deptBudget = 15600;

            //Read-Write Property
            public int ID
            {
                set
                {
                    if(value <= 0)
                    {
                        deptId = 101;
                    }
                    else
                    {
                        deptId = value;
                    }
                    
                    for (int i = 20; i < 200; i++)
                    {

                    }
                }
                get
                {
                    return deptId;
                }
            }
            //Write-Only
            public string Name
            {
                set
                {
                    deptName = value;
                }
            }
            //Read-Only
            public double Budget
            {
                get
                {
                    return deptBudget;
                }
            }


            //public double DeptBudget()
            //{
            //    return deptBudget;
            //}
            //public void SetDeptID(int deptId)
            //{
            //    this.deptId = deptId;
            //}
            //public int GetDeptID()
            //{
            //    return deptId;
            //}
        }
        class Class1
        {
            static void Main(string[] args)
            {
                Dept obj = new Dept();
                obj.ID = 20;
                Console.WriteLine("Value of ID is: " + obj.ID);
                obj.Name = "Srikanth";
                //Console.WriteLine("Value of Name is: "+obj.Name);

                //obj.Budget = 23000;
                Console.WriteLine("Value of Budget is: " + obj.Budget);


                //Console.WriteLine(obj.DeptBudget());
                //obj.SetDeptID(101);
                //Console.WriteLine(obj.GetDeptID());
                Console.Read();
            }
        }
    }

}
