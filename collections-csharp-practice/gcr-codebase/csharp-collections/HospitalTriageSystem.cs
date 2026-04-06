/* Hospital Triage System
Simulate a hospital triage system using a PriorityQueue where patients with higher severity are treated first.
Example:
Patients: [ ("John", 3), ("Alice", 5), ("Bob", 2) ]
Order: Alice, John, Bob
*/

using System;
using System.Collections.Generic;
class HospitalTriageSystem{
    static void Main(){
        // Element: Patient Name, Priority: -Severity
        PriorityQueue<string, int> pq = new PriorityQueue<string, int>();
        Console.Write("Enter number of patients: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++){
            Console.Write("Enter patient name: ");
            string name = Console.ReadLine();
            Console.Write("Enter severity level: ");
            int severity = Convert.ToUInt32(Console.ReadLine());
            pq.Enqueue(name, -severity);
        }
        Console.WriteLine("\nTreatment Order:");
        while (pq.Count > 0){
            Console.WriteLine(pq.Dequeue());
        }
    }
}