// Jack Chavers
// MIS3013 HW3 Task 1 Time to burn calories

double totalBurned = 0.0;
int numOfMinutes = 0;
string message = "How many calories do you wish to burin in this workout session? ";
Console.Write(message);
string userInputStr = Console.ReadLine();
double goalCaloriesDbl = Convert.ToDouble(userInputStr);

while(totalBurned < goalCaloriesDbl)
{
    numOfMinutes++;
    totalBurned = totalBurned + 3.9;
    message = string.Format("After {1} minute(S), you have byurned {0:F2} calories", totalBurned, numOfMinutes);
}   Console.WriteLine(message);