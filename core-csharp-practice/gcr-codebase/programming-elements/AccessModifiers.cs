using System;

// PUBLIC class : accessible everywhere
public class BaseClass{
    // PRIVATE : only inside BaseClass
    private int privateValue = 10;

    // PROTECTED : BaseClass + SubClass
    protected int protectedValue = 20;

    // INTERNAL : same project
    internal int internalValue = 30;

    // PUBLIC : accessible everywhere
    public int publicValue = 40;

    // PROTECTED INTERNAL : same project OR derived class
    protected internal int protectedInternalValue = 50;

    // PRIVATE PROTECTED : same class OR derived class (same project)
    private protected int privateProtectedValue = 60;

    // PUBLIC method to show private members
    public void PrivateMethod(){
        Console.WriteLine("Private Value: " + privateValue);
        Console.WriteLine("Private Protected Value: " + privateProtectedValue);
    }
}

// SUBCLASS
public class SubClass : BaseClass{
    public void ProtectedMethod(){
        Console.WriteLine("Protected Value: " + protectedValue);
        Console.WriteLine("Protected Internal Value: " + protectedInternalValue);
        Console.WriteLine("Private Protected Value: " + privateProtectedValue);
    }
}

// MAIN CLASS
class AccessModifiers{
    public static void Main(string[] args){
        BaseClass obj = new BaseClass();

        // Accessible
        Console.WriteLine("Public Value: " + obj.publicValue);
        Console.WriteLine("Internal Value: " + obj.internalValue);
        Console.WriteLine("Protected Internal Value: " + obj.protectedInternalValue);

        // Access private via public method
        obj.PrivateMethod();

        SubClass sub = new SubClass();
        sub.ProtectedMethod();

        
    }
}
