using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCodePractice
{
    public class QuestionSolution
    {
        public void PresAbs()
        {
            int present = 1;
            Random random = new Random();
            int AttenCheck = random.Next(0, 9);
            if (AttenCheck == present)
            {
                Console.WriteLine("Emp is Present");
            }
            else { Console.WriteLine("Emp is not Present"); }
        }
        public void PresAbs1()
        {
            string name = "Nitish Mehta";
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Replace("Mehta","Kumar"));
        }
        // Is it possible to storte n number of list in different type of single genericlist? 
        // -- yes , By creating a list of list object.
        public void listoflist()
        {
            List<List<object>> list = new List<List<object>>();
            List<object> list1 = new List<object>();
            list1.Add(96382);
            list1.Add(280224);
            list1.Add(1809);
            list1.Add(3618);
            List<object> list2 = new List<object>();
            list2.Add("Nitish");
            list2.Add("Mehta");
            list2.Add("Bangalore");
            list2.Add("Karnataka");

            list.Add(list1);
            list.Add(list2);
            foreach (List<object> objectlist in list)
            {
                foreach (object obj in objectlist)
                {
                    Console.WriteLine(obj);
                }
            }
        }
        // Can an object class have a constructor ? if so what is the use ?
        public void abstractclass()
        {

        }
    }  
    public abstract class Customer
    {
        public Customer()
        {
            this._id = Guid.NewGuid();
        }
        private Guid _id;
        public Guid ID 
        { 
            get
            {
                return this._id;
            }
        }
    }
    public class CorporateCustomer : Customer
    {
        public CorporateCustomer()
        {

        }

    }
    public class SavingCustomer : Customer
    {
        public SavingCustomer()
        {

        }

    }
}
