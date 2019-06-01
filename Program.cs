/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Stack_and_the_Heap
{
    class Program
    {
        static void Main()
        {
            // A variable represents a storage location that has a modifiable value
            // A variable can be a local variable, parameter (value, ref, or out), field (instance or static), or array element.

            // The stack is a block of memory for storing local variables and parameters.
            // The stack logically grows and shrinks as a function is entered and exited.
            // The method (Factorial) is recursive, meaning it calls itself.
            // Each time the method (Factorial) enter, a new int is allocated to the stack.
            // Each time the method (Factorial) exits, the int is deallocated.

            // The heap is a block of memory in which objects (i.e., reference-type instances) reside.
            // Whenever a new object is created, it is allocated on the heap, and a reference to that object is returned.
            // During a program's execution, the heap starts filling up as new objects are created.
            // The runtime has a garbage collector that periodically deallocates objects from the heap, so your program does not run out of memory.
            // An object is eligible for deallocation as asoon as it's not referenced by anything that's itself "alive".
            StringBuilder ref1 = new StringBuilder("object1");
            Console.WriteLine(ref1);
            // The StringBuilder object referenced by ref1 is now eligible for GC (Garbage Collection).
            StringBuilder ref2 = new StringBuilder("object2");
            StringBuilder ref3 =ref2;
            // The StringBuilder object referenced by ref2 is NOT yet eligible for GC (Garbage Collection). 
            Console.WriteLine(ref3);    //object2
        }
        static int Factorial(int x)
        {
            if (x == 0) return 1;
            return x + Factorial(x - 1);
        }
    }
}
