import java.util.HashSet;
import java.util.Scanner;

class Solution {

    // Method to check whether a number is a Happy Number
    public boolean isHappy(int n) {

        // HashSet to store numbers we have already seen
        // Helps in detecting cycles
        HashSet<Integer> set = new HashSet<>();

        // Continue until n becomes 1 (happy)
        // or we detect a cycle (not happy)
        while (n != 1 && !set.contains(n)) {
            set.add(n);                 // Store current number
            n = getSumOfSquares(n);     // Replace n with sum of squares of its digits
        }

        // If n becomes 1, it's a Happy Number
        return n == 1;
    }

    // Helper method to calculate sum of squares of digits
    public static int getSumOfSquares(int n) {
        int sum = 0;

        // Extract digits and calculate square sum
        while (n > 0) {
            int rem = n % 10;          // Get last digit
            sum += rem * rem;          // Add square of digit
            n /= 10;                   // Remove last digit
        }

        return sum;
    }
}

// Driver class
public class Main {
    public static void main(String[] args) {

        // Scanner for user input
        Scanner sc = new Scanner(System.in);

        // Input number
        System.out.print("Enter a number: ");
        int n = sc.nextInt();

        // Create Solution object
        Solution sol = new Solution();

        // Check if the number is happy
        boolean result = sol.isHappy(n);

        // Output result
        if (result) {
            System.out.println(n + " is a Happy Number 😊");
        } else {
            System.out.println(n + " is NOT a Happy Number 😞");
        }
    }
}
