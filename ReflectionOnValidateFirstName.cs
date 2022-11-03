using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day22ReflectionsUserRegistration
{
    internal class ReflectionOnValidateFirstName
    {
        public static void ReflectionTest()
        {
            Type type = Type.GetType("Day22ReflectionsUserRegistration.UC1ValidateFirstName");
            Console.WriteLine("Full Name :{0}", type.FullName);
            Console.WriteLine("Class name is : {0}", type.Name);
            Console.WriteLine("Methods in customerInfo class");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }

        }
    }
}
