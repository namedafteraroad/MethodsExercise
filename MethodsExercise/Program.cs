namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {


            //MATH ANSWERS

            Console.WriteLine("MATH ANSWERS:");
            Console.WriteLine("____________________________________");


            int addAns = Add(12, 4);
            Console.WriteLine(addAns);

            int subAns = Sub(12, 4);
            Console.WriteLine(subAns);

            int multiAns = Multi(12, 4);
            Console.WriteLine(multiAns);

            int divAns = Div(12, 4);
            Console.WriteLine(divAns);

            int modAns = Mod(12, 4);
            Console.WriteLine(modAns);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //PARAMS answers and testing

            Console.WriteLine("PARAMS ANSWERS:");
            Console.WriteLine("____________________________________");


            int paraAns1 = ParaAdd(2, 4);
            Console.WriteLine(paraAns1);

            int paraAns2 = ParaAdd(2, 4, 6);
            Console.WriteLine(paraAns2);

            int paraAns3 = ParaAdd(1, 1, 1, 1, 1);
            Console.WriteLine(paraAns3);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("A short story about a new visitor to the secret underwater city of Rapture:");
            Console.WriteLine("____________________________________");

            //A story using methods

            Console.WriteLine("Hello and welcome to Rapture.");
            Console.WriteLine("May I have you name so that we can begin the check in process?");
            string name = Console.ReadLine();
            Console.WriteLine($"Wonderful! {name} you are most welcome and we have been expecting you.");
            Console.WriteLine("How many in your party?");
            string party = Console.ReadLine();
            Console.WriteLine($"{party}. Very good.");
            Console.WriteLine("Please tell me the color you were assigned in your packet");
            string color = Console.ReadLine();
            Console.WriteLine($"{color}. Hmm. Ok. Just let me confirm this.");
            Console.WriteLine("I'm sorry the color you have told me does not match our records.");
            Console.WriteLine("Tell me what animal was displayed on your ticket");
            string animal = Console.ReadLine();
            Console.WriteLine($"{animal}. Ok. This is odd");
            Console.WriteLine($"Tell me {name}, how did you get here. We are deep underwater and only have one way in or out.");
            Console.WriteLine("On second thought. no do not waste your breath. You'll need it soon enough.");
            Console.WriteLine("Incident resolved, incident numbers below:");





        }

        
        //FIVE METHODS
        
        
        
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int c, int d)
        {
            return c - d;
        }
        public static int Multi(int e, int f)
        {
            return e * f;
        }
        public static int Div(int g, int h)
        {
            return g / h;
        }
        public static int Mod(int i, int j)
        {
            return i % j;
        }

        //Params

        public static int ParaAdd(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }




    }
}
