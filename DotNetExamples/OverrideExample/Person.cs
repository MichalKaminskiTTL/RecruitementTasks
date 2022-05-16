namespace OverrideExample
{
    public class Person
    {
        public virtual void WhoAmI()
        {
            Console.WriteLine("I'm Person");
        }
    }

    public class PersonOverride : Person
    {
        public override void WhoAmI()
        {
            Console.WriteLine("I'm PersonOverride");
        }
    }

    public class PersonNew : Person
    {
        public new void WhoAmI()
        {
            Console.WriteLine("I'm PersonNew");
        }
    }
}
