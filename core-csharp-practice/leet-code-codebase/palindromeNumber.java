import java.util.Scanner;

class Solution {
    public boolean isPalindrome(int x) {

        // Negative numbers are not palindromes
        // Numbers ending with 0 (but not 0 itself) cannot be palindromes
        if (x < 0 || (x % 10 == 0 && x != 0)) {
            return false;
        }

        // This variable will store the reversed second half of the number
        int revnum = 0;

        // Reverse digits until revnum becomes greater than or equal to x
        while (x > revnum) {
            // Add the last digit of x to revnum
            revnum = revnum * 10 + x % 10;

            // Remove the last digit from x
            x = x / 10;
        }

        // Check for palindrome (handles both even and odd digit counts)
        return (x == revnum || x == revnum / 10);
    }
}

public class Main {
    public static void main(String[] args) {

        // Create Scanner object to take input from user
        Scanner sc = new Scanner(System.in);

        // Read integer input
        System.out.print("Enter a number: ");
        int x = sc.nextInt();

        // Create Solution object
        Solution sol = new Solution();

        // Call isPalindrome method and store result
        boolean result = sol.isPalindrome(x);

        // Print the result
        if (result) {
            System.out.println(x + " is a Palindrome.");
        } else {
            System.out.println(x + " is NOT a Palindrome.");
        }
    }
}
