using System;

public class NullOperations
{
    public void PerformNullChecks()
    {
        // Declare a string variable and assign null
        string username = null;

        // --- Using Ternary Operator ---
        string result = (username == null) ? "Username is not available" : username;
        Console.WriteLine("Ternary Check: " + result);

        // --- Using Null-Coalescing Operator (??) ---
        string displayName = username ?? "Username is not available";
        Console.WriteLine("Null-Coalescing Check: " + displayName);

        // --- Using Null-Coalescing Assignment Operator (??=) ---
        username ??= "DefaultUser";
        Console.WriteLine("After Null-Coalescing Assignment: " + username);
    }
}
