using System;
using Xunit;

namespace vasAndDataTypes
{
    public class VariablesandDataTypes
    {
        [Fact]
        public void SomeofTheBuiltInTypes()
        {
            //type identifier
            int age;
            age = 22;
            Int32 yourAge;
            decimal yourPay = 33.22M;

            bool isAwake = false;
        }

        string thingy = "tacos";
        [Fact]
        public void ImplicitlyTypedLocalVariables()
        {
            // c# 3.0
            Assert.Equal("tacos", thingy);

            var pay = 32.50M;
        }

        [Fact]
        public void ValueTypes()
        {
            //structs
            int age = 52;
            DateTime myBirthday = new DateTime(1969, 4, 20);
            string myName = "Jeff";

            age = DoubleIt(age);

            var Rover = new Dog();
            DoSomething(Rover);
            Assert.Equal("Fido", Rover.Name);
        }

        [Fact]
        public void usingRefAndOut()
        {
            int y = 50;
            DoubleItRef(ref y);
            Assert.Equal(100, y);

            GimmeSomething(out int p);
            Assert.Equal(42, p);
        }

        public int DoubleItRef(ref int et)
        {
            return et + et;
        }

        public int DoubleIt(int et)
        {
            return et + et;
        }

        void GimmeSomething(out int z)
        {
            z = 42;
        }



        public void DoSomething(Dog d)
        {
            d.Name = "Fido";
        }

        
    }
    public class Dog
    {
        public string Name;
    }
}
