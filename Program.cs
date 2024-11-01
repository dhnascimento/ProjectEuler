using System;
using System.Linq;
using System.Reflection;

namespace ProjectEuler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please specify the problem number to run.");
                return;
            }

            string problemNumber = args[0];
            string className = $"ProjectEuler.Problems.Problem{problemNumber}";

            try
            {
                Type type = Assembly.GetExecutingAssembly().GetType(className);
                MethodInfo? method = type?.GetMethod("Main", BindingFlags.Public | BindingFlags.Static);
                method?.Invoke(null, new object[] { new string[] { } });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
