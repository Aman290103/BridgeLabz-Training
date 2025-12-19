class AllOperators
{
    public static void Main(string[] args)
    {
        int a = 10;
        int b = 3;

        // 1. Arithmetic Operators
        Console.WriteLine("Arithmetic Operators");
        Console.WriteLine("a + b = " + (a + b)); //Addition operator
        Console.WriteLine("a - b = " + (a - b)); //Subtaction operator
        Console.WriteLine("a * b = " + (a * b)); //Multiplication operator
        Console.WriteLine("a / b = " + (a / b)); // divison operator
        Console.WriteLine("a % b = " + (a % b)); // Modulus operator

        // 2. Relational / Comparison Operators
        Console.WriteLine("\nRelational Operators");
        Console.WriteLine("a == b : " + (a == b)); // Equal to operator
        Console.WriteLine("a != b : " + (a != b)); // not equal to operator
        Console.WriteLine("a > b  : " + (a > b));  // greater than operator
        Console.WriteLine("a < b  : " + (a < b));  // less than operator
        Console.WriteLine("a >= b : " + (a >= b)); // greater than equal to operator 
        Console.WriteLine("a <= b : " + (a <= b)); // less than equal to operator

        // 3. Logical Operators
        bool x = true;
        bool y = false;

        Console.WriteLine("\nLogical Operators");
        Console.WriteLine("x && y : " + (x && y)); // Logical AND Operator
        Console.WriteLine("x || y : " + (x || y)); // Logical OR operator
        Console.WriteLine("!x     : " + (!x));     // Logical Not operator

        // 4. Assignment Operators
        Console.WriteLine("\nAssignment Operators");
        int c = a;
        c += b;
        Console.WriteLine("c += b : " + c); // Addition Assignment operator
        c -= b;
        Console.WriteLine("c -= b : " + c); //Subtraction Assignment operator
        c *= b;
        Console.WriteLine("c *= b : " + c); // multiplication Assignment operator
        c /= b;
        Console.WriteLine("c /= b : " + c); // Divison Assignment operator
        c %= b;
        Console.WriteLine("c %= b : " + c); // Modulus Assignment operator

        // 5. Unary Operators
        Console.WriteLine("\nUnary Operators");
        Console.WriteLine("++a : " + (++a));  // Pre-increment operator
        Console.WriteLine("--b : " + (--b)); // pre-decrement operator
        Console.WriteLine("a++ : " + (a++)); // Post-increment operator
        Console.WriteLine("b-- : " + (b--)); // post-decrement operator

        // 6. Bitwise Operators
        int p = 5;  // 0101
        int q = 3;  // 0011

        Console.WriteLine("\nBitwise Operators");
        Console.WriteLine("p & q : " + (p & q)); // AND operator
        Console.WriteLine("p | q : " + (p | q)); // OR operator
        Console.WriteLine("p ^ q : " + (p ^ q)); // XOR operator
        Console.WriteLine("~p    : " + (~p));   //Complement operator
        Console.WriteLine("p << 1: " + (p << 1)); // Left Shift operator 
        Console.WriteLine("p >> 1: " + (p >> 1)); // Right shift operator

        // 7. Ternary Operator
        Console.WriteLine("\nTernary Operator");
        string result = (a > b) ? "a is greater" : "b is greater"; 
        Console.WriteLine(result);

        // 8. is Operators
        Console.WriteLine("\nType Operators");
        object obj = a;
        Console.WriteLine("obj is int : " + (obj is int));

    }
}
