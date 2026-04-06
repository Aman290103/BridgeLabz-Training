/*Sample Program 7: Hospital Management System
Create a Patient class with the following features:
static: 
A static variable HospitalName shared among all patients.
A static method GetTotalPatients() to count the total patients admitted.
this: 
Use this to initialize Name, Age, and Ailment in the constructor.
readonly: 
Use a readonly variable PatientID to uniquely identify each patient.
is operator: 
Check if an object is an instance of the Patient class before displaying its details.
*/

using System;

public class Patient{
    public static string HospitalName { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Ailment { get; set; }
    public readonly int PatientID;
    private static int totalPatients = 0;

    static Patient(){
        HospitalName = "General Hospital";
    }

    public Patient(string name, int age, string ailment){
        Name = name;
        Age = age;
        Ailment = ailment;
        PatientID = ++totalPatients;
    }

    public static int GetTotalPatients(){
        return totalPatients;
    }

    public static bool IsPatient(object obj){
        return obj is Patient;
    }

    public void DisplayDetails(){
        Console.WriteLine($"Patient ID: {PatientID}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Ailment: {Ailment}");
        Console.WriteLine($"Hospital: {HospitalName}");
        Console.WriteLine();
    }
}
public class HospitalManagementSystem{
      public static void Main(string[] args){
        Patient patient1 = new Patient("John Doe", 30, "Flu");
        Patient patient2 = new Patient("Jane Smith", 25, "Headache");

        Console.WriteLine($"Total Patients: {Patient.GetTotalPatients()}");

        if (Patient.IsPatient(patient1)){
            patient1.DisplayDetails();
        }

        if (Patient.IsPatient(patient2)){
            patient2.DisplayDetails();
        }
    }
}