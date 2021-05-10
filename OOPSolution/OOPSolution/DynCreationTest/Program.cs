using System;
using System.Reflection;

namespace DynCreationTest
{
    class Profile
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public void Print() { Console.WriteLine($"{Name}, {PhoneNumber}"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //일반적으로 객체생성 방식
            Profile profile1 = new Profile();
            profile1.Name = "박찬호";
            profile1.PhoneNumber = "010-9975-5511";
            profile1.Print();

            //리플렉션 객체생성
            Type type = typeof(Profile);
            object profile2 = Activator.CreateInstance(type);
            PropertyInfo name = type.GetProperty("Name");
            PropertyInfo PhoneNumber = type.GetProperty("PhoneNumber");
            name.SetValue(profile2, "류현진", null);
            PhoneNumber.SetValue(profile2, "010-9999-9999", null);

            MethodInfo print = type.GetMethod("Print");
            print.Invoke(profile2, null);
        }
    }
}
