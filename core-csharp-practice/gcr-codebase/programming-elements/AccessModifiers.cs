using System;

// PUBLIC class : accessible everywhere
public class BaseClass{
    // PRIVATE : only inside BaseClass
    private int privateValue = 10;

    // PROTECTED : BaseClass + DerivedClass
    protected int protectedValue = 20;

    // INTERNAL : same project
    internal int internalValue = 30;

    // PUBLIC : accessible everywhere
    public int publicValue = 40;

    // PUBLIC method to show private member
    public void PrivateMethod(){
        Console.WriteLine("Private Value: " + privateValue);
    }
}

// SUBCLASS
public class SubClass : BaseClass{
    public void ProtectedMethod(){
        Console.WriteLine("Protected Value: " + protectedValue);
    }
}

// MAIN CLASS
class AccessModifiers{
    public static void Main(string[] args){
        BaseClass obj = new BaseClass();

        // Accessible
        Console.WriteLine("Public Value: " + obj.publicValue);
        Console.WriteLine("Internal Value: " + obj.internalValue);

        // Private not accessible directly
        obj.PrivateMethod();
    }
}
