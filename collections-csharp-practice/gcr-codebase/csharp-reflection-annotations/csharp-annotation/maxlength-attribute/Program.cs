class Program{
    static void Main(){
        User u1 = new User("Aman"); // OK
        User u2 = new User("VeryLongUsername"); // Exception
    }
}