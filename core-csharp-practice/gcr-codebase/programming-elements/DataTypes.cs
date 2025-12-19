
class DataTypes{
	public static void Main(string[] args){
		int number = 5;
		float  floatNum = 3.5f;
		double doubleNum = 5.88888;
		char ch = 'A';
		long longNum = 20920983;
		short shortNum = 45;
		bool boolean = true;
		
		Console.WriteLine(number);
		Console.WriteLine(floatNum);
		Console.WriteLine(doubleNum);
		Console.WriteLine(ch);
		Console.WriteLine(longNum);
		Console.WriteLine(shortNum);

            // now Typecasting int to float, double, short, long

            float floatNumber = Convert.ToSingle(number);
            double doubleNumber = Convert.ToDouble(number);
            short shortNumber = Convert.ToInt16(number);
            long longNumber = Convert.ToInt64(number);
           
           

            Console.WriteLine("int to float :"+floatNumber);
            Console.WriteLine("int to double :"+doubleNumber);
            Console.WriteLine("int to short :"+shortNumber);
            Console.WriteLine("int to long :"+longNumber);
            
            

            // now typecasting float to int, double, short, long

            int intNumber = Convert.ToInt32(floatNum);
            double doubleNumber1 = Convert.ToDouble(floatNum);
            short shortNumber1 = Convert.ToInt16(floatNum);
            long longNumber1 = Convert.ToInt64(floatNum);

            Console.WriteLine("float to int :"+intNumber);
            Console.WriteLine("float to double :"+doubleNumber1);
            Console.WriteLine("float to short :"+shortNumber1);
            Console.WriteLine("float to long :"+longNumber1);

            // now typecasting double to int, float, short, long

            int intNumber1 = Convert.ToInt32(doubleNum);
            float floatNumber2 = Convert.ToSingle(doubleNum);
            short shortNumber2 = Convert.ToInt16(doubleNum);
            long longNumber2 = Convert.ToInt64(doubleNum);
            
            Console.WriteLine("double to int :"+intNumber1);
            Console.WriteLine("double to float:"+floatNumber2);
            Console.WriteLine("double to short :"+shortNumber2);
            Console.WriteLine("double to long :"+longNumber2);

            // now typecasting long to int, float, double, short

            int intNumber2 = Convert.ToInt32(longNum);
            float floatNumber3 = Convert.ToSingle(longNum);
            double doubleNumber3 = Convert.ToDouble(longNum);
            short shortNumber3 = Convert.ToInt16(longNum);

            Console.WriteLine("long to int :"+intNumber2);
            Console.WriteLine("long to float :"+floatNumber3);
            Console.WriteLine("long to double :"+doubleNumber3);
            Console.WriteLine("long to short:" +shortNumber3);

            // now typecasting short to int, float, double, long

            int intNumber3 = Convert.ToInt32(shortNum);
            float floatNumber4 = Convert.ToSingle(shortNum);
            double doubleNumber4 = Convert.ToDouble(shortNum);
            long longNumber4 = Convert.ToInt64(shortNum);

            Console.WriteLine("short to int :"+intNumber3);
            Console.WriteLine("short to float :"+floatNumber4);
            Console.WriteLine("short to double :"+doubleNumber4);
            Console.WriteLine("short to long :" +longNumber4);

		
            
	}
}