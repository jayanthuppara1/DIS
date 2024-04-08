// Check if input array is null or empty
if (nums == null || nums.Length == 0)
return new List<int>();

// Initialize variable to count the number of zeroes encountered
int zeroCount = 0;

// Iterate through the array
for (int i = 0; i < nums.Length; i++)
{
// If the current element is zero, increment zeroCount
if (nums[i] == 0)
{
zeroCount++;
}
// If the current element is non-zero and there were previously encountered zeroes
else if (zeroCount > 0)
{
// Move the non-zero element to the position of the last encountered zero
nums[i - zeroCount] = nums[i];
// Set the current position to zero
nums[i] = 0;
}
}

// Return the modified array
return nums;
}
catch (Exception)
{
// Catch any unexpected exceptions and rethrow them
throw;
}
}

// Question 3: 3Sum
// Self-Reflection: This problem enhanced my understanding of array manipulation and nested loops.
public static IList<IList<int>> ThreeSum(int[] nums)
{
// Sort the input array
Array.Sort(nums);
// Initialize a list to store the resulting triplets
List<IList<int>> result = new List<IList<int>>();

// Iterate through the array
for (int i = 0; i < nums.Length - 2; i++)
{
// Skip duplicate elements
if (i > 0 && nums[i] == nums[i - 1]) continue;

// Initialize pointers for two-sum subarray
int left = i + 1, right = nums.Length - 1;

// Loop until pointers meet
while (left < right)
{
// Calculate sum of current triplet
int sum = nums[i] + nums[left] + nums[right];

// If sum is zero, add triplet to result
if (sum == 0)
{
result.Add(new List<int> { nums[i], nums[left], nums[right] });
// Skip duplicates
while (left < right && nums[left] == nums[left + 1]) left++;
while (left < right && nums[right] == nums[right - 1]) right--;
left++;
right--;
}
// If sum is less than zero, move left pointer to increase sum
else if (sum < 0)
left++;
// If sum is greater than zero, move right pointer to decrease sum
else
right--;
}
}

// Return list of triplets
return result;
}


// Question 4: Max Consecutive Ones
// Self-Reflection: This task improved my understanding of loops and conditional statements.
public static int FindMaxConsecutiveOnes(int[] nums)
{
try
{
// Check if input array is null or empty
if (nums == null || nums.Length == 0)
return 0;

// Initialize variables to track the maximum count of consecutive ones and current count
int maxCount = 0;
int count = 0;

// Iterate through the array
foreach (var num in nums)
{
// If current element is 1, increment count and update maxCount if needed
if (num == 1)
{
count++;
maxCount = Math.Max(maxCount, count);
}
// If current element is not 1, reset count to 0
else
count = 0;
}
// Return the maximum count of consecutive ones
return maxCount;
}
catch (Exception)
{
// Catch any unexpected exceptions and rethrow them
throw;
}
}

// Question 5: Binary to Decimal Conversion
// Self-Reflection: This problem deepened my understanding of arithmetic operations.
public static int BinaryToDecimal(int binary)
{
try
{
// Initialize variable to store the decimal equivalent of the binary number
int decimalNumber = 0;
// Initialize base value for binary conversion
int baseValue = 1;

// Iterate until the binary number becomes 0
while (binary > 0)
{
// Extract the rightmost digit of the binary number
int remainder = binary % 10;

// Update the decimal number by adding the contribution of the current digit
decimalNumber += remainder * baseValue;

// Move to the next digit of the binary number by dividing by 10
binary /= 10;

// Update the base value for the next digit
baseValue *= 2;
}

// Return the decimal equivalent of the binary number
return decimalNumber;
}
catch (Exception)
{
// Catch any unexpected exceptions and rethrow them
throw;
}
}



// Question 6: Maximum Gap
// Self-Reflection: This exercise expanded my knowledge of array sorting and manipulation.
public static int MaximumGap(int[] nums)
{
try
{
// Check if input array is null or has less than 2 elements
if (nums == null || nums.Length < 2)
return 0;

// Sort the array in ascending order
Array.Sort(nums);

// Initialize variable to store the maximum gap
int maxGap = 0;

// Iterate through the sorted array to find the maximum gap between adjacent elements
for (int i = 0; i < nums.Length - 1; i++)
{
// Calculate the difference between the current and next element
int gap = nums[i + 1] - nums[i];

// Update maxGap if the difference between current and next element is greater
maxGap = Math.Max(maxGap, gap);
}

// Return the maximum gap found
return maxGap;
}
catch (Exception)
{
// Catch any unexpected exceptions and rethrow them
throw;
}
}


// Question 7: Largest Perimeter Triangle
// Self-Reflection: This task improved my understanding of loop structures and conditionals.
public static int LargestPerimeter(int[] nums)
{
try
{
// Check if input array is null or has less than 3 elements
if (nums == null || nums.Length < 3)
return 0;

// Sort the array in ascending order
Array.Sort(nums);

// Iterate through the sorted array starting from the largest elements
for (int i = nums.Length - 1; i >= 2; i--)
{
// Check if the sum of two smaller sides is greater than the largest side
if (nums[i - 2] + nums[i - 1] > nums[i])
// If the condition is satisfied, return the perimeter of the triangle
return nums[i - 2] + nums[i - 1] + nums[i];
}
// If no valid triangle found, return 0
return 0;
}
catch (Exception)
{
// Catch any unexpected exceptions and rethrow them


throw;
}
}

// Question 8: Remove Occurrences of a Substring
// Self-Reflection: This problem enhanced my understanding of string manipulation and indexing.
public static string RemoveOccurrences(string s, string part)
{
try
{
while (s.Contains(part))
{
int index = s.IndexOf(part);
s = s.Remove(index, part.Length);
}
return s;
}
catch (Exception)
{
throw;
}
}

/* Inbuilt Functions - Don't Change the below functions */
static string ConvertIListToNestedList(IList<IList<int>> input)
{
StringBuilder sb = new StringBuilder();

sb.Append("["); // Add the opening square bracket for the outer list

for (int i = 0; i < input.Count; i++)
{
IList<int> innerList = input[i];
sb.Append("[" + string.Join(",", innerList) + "]");

// Add a comma unless it's the last inner list
if (i < input.Count - 1)
{
sb.Append(",");
}
}

sb.Append("]"); // Add the closing square bracket for the outer list

return sb.ToString();
}

static string ConvertIListToArray(IList<int> input)
{
// Create an array to hold the strings in input
string[] strArray = new string[input.Count];

for (int i = 0; i < input.Count; i++)
{
strArray[i] = "" + input[i] + ""; // Enclose each string in double quotes
}

// Join the strings in strArray with commas and enclose them in square brackets
string result = "[" + string.Join(",", strArray) + "]";

return result;
}
}
}
