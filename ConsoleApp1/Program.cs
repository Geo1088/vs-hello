using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print a help message with -h or --help
            if (args.Contains("-h") || args.Contains("--help"))
            {
                Console.WriteLine("Usage: hello [-i] [name]");
                Console.WriteLine("Options:");
                Console.WriteLine("    -h, --help   Display this help text");
                Console.WriteLine("    -i           Prompt for a name interactively; ignore any name");
                Console.WriteLine("                 provided via command line arguments");
                Console.WriteLine("    name         The name of the person to say hello to");
                return;
            }

            // Read the name of the person from the command line args
            string name;
            if (args.Length > 0) {
                if (args[0] == "-i") // TODO: proper flag parsing rather than relying on position
                {
                    // The -i flag means we get the name of the person to greet interactively
                    name = GetNameInteractively();
                } else
                {
                    // No leading -i means we interpret the passed arguments as the whole name
                    name = string.Join(" ", args);
                }
            } else
            {
                // If we have no command line args, use the default "Hello, World!" message
                name = "World";
            }

            // Print the greeting to the console
            Console.WriteLine("Hello, " + name + "!");
        }

        /**
         * Gets a name interactively by prompting the user.
         */
        private static string GetNameInteractively()
        {
            string name = "";
            while (name == "") // TODO: perform checks to make sure the string isn't all whitespace, etc.
            {
                Console.Write("Who to greet? ");
                name = Console.ReadLine().Trim();
            }
            return name;
        }
    }
}
