namespace VacanciesAPP
{
     class Program
    {
        struct Struct{ 
            public int foo;
        
        }
        public  void Main(String[] args)
        {
            Struct struct1;
            struct1.foo = 5;

            Struct struct2= struct1;
            struct2.foo = 10;

            Console.WriteLine(struct1.foo);

        }
    }
}
