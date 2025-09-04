// formatting and manipulating strings
using System;
using System.Text;
var fullName = "Alice Wilkins ";
Console.WriteLine("Trim: '{0}'", fullName.Trim());
Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper());
Console.WriteLine("Substring: '{0}'", fullName.Substring(0, 5));
Console.WriteLine("Replace: '{0}'", fullName.Replace("Alice", "Bob"));
Console.WriteLine("Length: '{0}'", fullName.Length);
// composite formatting
var firstName = "Alice";
var lastName = "Wilkins";
var age = 25;
var message = string.Format("Name: {0} {1} (Age: {2})", firstName, lastName, age);
Console.WriteLine(message);
// interpolated strings
var message2 = $"Name: {firstName} {lastName} (Age: {age})";
Console.WriteLine(message2);
// verbatim strings
var filePath = @"C:\Projects\CSharpFundamentals\Part01_Fundamentals\07_Text_Processing\src";
Console.WriteLine(filePath);
// combining verbatim and interpolated strings
var filePath2 = $@"C:\Projects\{firstName}\{lastName}\src";
Console.WriteLine(filePath2);
// replacing substrings
var newMessage = message.Replace("Alice", "Bob").Replace("25", "30");
Console.WriteLine(newMessage);
// splitting strings
var names = "Alice,Bob,Charlie";
var nameList = names.Split(',');
foreach (var name in nameList)
{
    Console.WriteLine(name);
}
// joining strings
var joinedNames = string.Join(" & ", nameList);
Console.WriteLine(joinedNames);
// checking for substrings
var containsAlice = names.Contains("Alice");
Console.WriteLine("Contains 'Alice': {0}", containsAlice);
var startsWithA = names.StartsWith("A");
Console.WriteLine("Starts with 'A': {0}", startsWithA);
var endsWithE = names.EndsWith("e");
Console.WriteLine("Ends with 'e': {0}", endsWithE);
// formatting numbers in strings
var price = 1234.56;
var formattedPrice = string.Format("Price: {0:C}", price);  // Currency format
Console.WriteLine(formattedPrice);
var percentage = 0.856;
var formattedPercentage = string.Format("Completion: {0:P}", percentage);  // Percentage format
Console.WriteLine(formattedPercentage);
// multi-line strings with verbatim
var multiLine = @"This is a multi-line string.
It preserves whitespace and line breaks.
Useful for formatted text.";
Console.WriteLine(multiLine);
// isnull or empty checks
var emptyString = "";
Console.WriteLine("IsNullOrEmpty: {0}", string.IsNullOrEmpty(emptyString));
var nullString = (string)null;
Console.WriteLine("IsNullOrEmpty: {0}", string.IsNullOrEmpty(nullString));
// isnull or whitespace checks
var whitespaceString = "   ";
Console.WriteLine("IsNullOrWhiteSpace: {0}", string.IsNullOrWhiteSpace(whitespaceString));
Console.WriteLine("IsNullOrWhiteSpace: {0}", string.IsNullOrWhiteSpace(nullString));
// comparing strings
var str1 = "hello";
var str2 = "Hello";
Console.WriteLine("Equals (case-sensitive): {0}", str1.Equals(str2));
Console.WriteLine("Equals (case-insensitive): {0}", str1.Equals(str2, StringComparison.OrdinalIgnoreCase));
// using string.Join with arrays
var fruits = new[] { "Apple", "Banana", "Cherry" };
var fruitList = string.Join(", ", fruits);
Console.WriteLine("Fruits: {0}", fruitList);
// using StringBuilder for efficient string manipulation
var sb = new StringBuilder();
sb.Append("Hello");
sb.Append(" ");
sb.Append("World");
sb.Append("!");
Console.WriteLine(sb.ToString());
// clearing the StringBuilder
sb.Clear();
sb.Append("New content after clearing.");
Console.WriteLine(sb.ToString());
// numbers to strings with specific formats
var number = 12345.6789;
Console.WriteLine("Fixed-point: {0:F2}", number);  // 2 decimal places
Console.WriteLine("Exponential: {0:E}", number);   // Exponential format
Console.WriteLine("Hexadecimal: {0:X}", 255);      // Hex format for integers
// padding strings
var paddedString = fullName.PadLeft(20).PadRight(30, '-');
Console.WriteLine("Padded: '{0}'", paddedString);
// removing parts of a string
var removedString = fullName.Remove(5, 8); // Remove " Wilkins"
Console.WriteLine("Removed: '{0}'", removedString);
// inserting into a string
var insertedString = fullName.Insert(5, " Smith");
Console.WriteLine("Inserted: '{0}'", insertedString);
// comparing strings with CompareTo
var comparison = str1.CompareTo(str2);
Console.WriteLine("CompareTo result: {0}", comparison); // Negative if str1 < str2
// using string.Concat
var concatenated = string.Concat(firstName, " ", lastName);
Console.WriteLine("Concatenated: '{0}'", concatenated);
// using string.Copy (note: deprecated in .NET Core and later)
var copiedString = string.Copy(fullName);
Console.WriteLine("Copied: '{0}'", copiedString); // although not recommended for new code
// using string.Intern
var internedString = string.Intern(fullName);
Console.WriteLine("Interned: '{0}'", internedString);   // useful for memory optimization in certain scenarios
// using string.IsNullOrEmpty with user input simulation
string userInput = null; // Simulating no input
if (string.IsNullOrEmpty(userInput))
{
    Console.WriteLine("User input is empty or null.");
}
else
{
    Console.WriteLine("User input: '{0}'", userInput);
}   
// using string.IsNullOrWhiteSpace with user input simulation
userInput = "   "; // Simulating whitespace input
if (string.IsNullOrWhiteSpace(userInput))
{
    Console.WriteLine("User input is empty, null, or whitespace.");
}
else
{
    Console.WriteLine("User input: '{0}'", userInput);
}
// using string.Compare for culture-specific comparisons
var cultureComparison = string.Compare("straße", "strasse", StringComparison.CurrentCulture);
Console.WriteLine("Culture-specific comparison result: {0}", cultureComparison); // 0 if equal
// using string.Normalize for Unicode normalization
var normalizedString = "café".Normalize(NormalizationForm.FormC);
Console.WriteLine("Normalized: '{0}'", normalizedString);
// using string.Format with alignment
var alignedString = string.Format("|{0,10}|{1,-10}|", "Right", "Left");
Console.WriteLine("Aligned: '{0}'", alignedString);
// using string interpolation with expressions
var width = 10;
var height = 20;
var areaMessage = $"Area of rectangle: {width * height}";
Console.WriteLine(areaMessage); // Output: Area of rectangle: 200
// using string interpolation with formatting
var pi = 3.14159;
var piMessage = $"Value of Pi: {pi:F3}"; // 3 decimal places
Console.WriteLine(piMessage); // Output: Value of Pi: 3.142
// using string interpolation with conditional expressions
var isActive = true;
var statusMessage = $"Status: {(isActive ? "Active" : "Inactive")}";
Console.WriteLine(statusMessage); // Output: Status: Active
// using string interpolation with method calls
string ToUpperCase(string input) => input.ToUpper();
var upperMessage = $"Uppercase Name: {ToUpperCase(firstName)}";
Console.WriteLine(upperMessage); // Output: Uppercase Name: ALICE
// using string interpolation with indexing
var indexedMessage = $"First letter of first name: {firstName[0]}";
Console.WriteLine(indexedMessage); // Output: First letter of first name: A 
// using string interpolation with nested interpolations
var nestedMessage = $"Full Name: { $"{firstName} {lastName}" }";
Console.WriteLine(nestedMessage); // Output: Full Name: Alice Wilkins
// using string interpolation with date formatting
var currentDate = DateTime.Now;
var dateMessage = $"Current Date: {currentDate:MMMM dd, yyyy}";
Console.WriteLine(dateMessage); // Output: Current Date: [Current Month] [Day], [Year]
// using string interpolation with time formatting
var timeMessage = $"Current Time: {currentDate:HH:mm:ss}";
Console.WriteLine(timeMessage); // Output: Current Time: [Hour]:[Minute]:[Second]
// using string interpolation with currency formatting
var salary = 50000.75;
var salaryMessage = $"Salary: {salary:C}";
Console.WriteLine(salaryMessage); // Output: Salary: $50,000.75 (or relevant currency format)
// using string interpolation with percentage formatting
var completionRate = 0.85;
var completionMessage = $"Completion Rate: {completionRate:P}";
Console.WriteLine(completionMessage); // Output: Completion Rate: 85.00%
// strings to numbers with error handling
var numberString = "12345";
if (int.TryParse(numberString, out int parsedNumber))
{
    Console.WriteLine("Parsed Number: {0}", parsedNumber);
}
else
{
    Console.WriteLine("Failed to parse number.");
}
var invalidNumberString = "123abc";
if (int.TryParse(invalidNumberString, out parsedNumber))
{
    Console.WriteLine("Parsed Number: {0}", parsedNumber);
}
else
{
    Console.WriteLine("Failed to parse number.");
}
// using StringBuilder for complex string manipulations
var complexSb = new StringBuilder();
complexSb.AppendLine("Header");
for (int i = 1; i <= 5; i++)
{
    complexSb.AppendLine($"Item {i}");
}
complexSb.AppendLine("Footer");
Console.WriteLine(complexSb.ToString());
// using StringBuilder with AppendFormat
var formatSb = new StringBuilder();
formatSb.AppendFormat("Name: {0}, Age: {1}\n", firstName, age);
formatSb.AppendFormat("Price: {0:C}\n", price);
Console.WriteLine(formatSb.ToString()); // using StringBuilder with Insert
formatSb.Insert(0, "User Details:\n");
Console.WriteLine(formatSb.ToString());
// using StringBuilder with Replace
formatSb.Replace("Alice", "Bob"); // Replacing "Alice" with "Bob"
Console.WriteLine(formatSb.ToString());
// using StringBuilder with Remove
formatSb.Remove(0, 13); // Removing "User Details:\n"
Console.WriteLine(formatSb.ToString());
// using StringBuilder with Length property and Capacity
Console.WriteLine("StringBuilder Length: {0}", formatSb.Length);
Console.WriteLine("StringBuilder Capacity: {0}", formatSb.Capacity);
// ensuring capacity
formatSb.EnsureCapacity(100);
Console.WriteLine("StringBuilder Capacity after EnsureCapacity: {0}", formatSb.Capacity);
// using StringBuilder with Clear method
formatSb.Clear();
formatSb.Append("New content after clearing StringBuilder.");
Console.WriteLine(formatSb.ToString()); // Output: New content after clearing StringBuilder.
// using StringBuilder with chaining methods
var chainedSb = new StringBuilder()
    .Append("Chained ")
    .Append("StringBuilder ")
    .Append("Example.");
Console.WriteLine(chainedSb.ToString()); // Output: Chained StringBuilder Example.
// using StringBuilder with ToString overload
var finalString = chainedSb.ToString();
Console.WriteLine("Final String: '{0}'", finalString); // Output: Final String: 'Chained StringBuilder Example.'
// using StringBuilder with AppendLine in a loop
var loopSb = new StringBuilder();
for (int i = 1; i <= 3; i++)
{
    loopSb.AppendLine($"Line {i}");
}
Console.WriteLine(loopSb.ToString()); // Output: Line 1\nLine 2\nLine 3\n
// using StringBuilder with AppendFormat in a loop
var formatLoopSb = new StringBuilder();
for (int i = 1; i <= 3; i++)
{
    formatLoopSb.AppendFormat("Line {0}\n", i);
}
Console.WriteLine(formatLoopSb.ToString()); // Output: Line 1\nLine 2\nLine 3\n
// sumarising StringBuilder usage
var summarySb = new StringBuilder();
summarySb.AppendLine("StringBuilder Summary:");
summarySb.AppendLine("- Efficient for multiple modifications");
summarySb.AppendLine("- Supports appending, inserting, removing, and replacing");
summarySb.AppendLine("- Has properties for Length and Capacity");
summarySb.AppendLine("- Can be cleared and reused");
Console.WriteLine(summarySb.ToString());