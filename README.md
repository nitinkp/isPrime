README:

Steps to run and IDE:

1) Used Visual Studio Code and C# dotnet compiler from Microsoft.
2) Create a new dotnet console by typing the command "dotnet new console" in terminal. After successful creation, type "dotnet run" to execute and provide a positive integer.

Steps followed:

1) First, asked the user to provide a positive integer to check whether it is a prime.
2) Stored the input number into an integer variable.
3) Execution goes to the isPrime() function where we are returning false initially if the number is either 0 or 1.
4) Then calculating the square root of the number to loop until that root.
5) Applying a for loop starting from 2 to check whether it is divisible by the numbers in between or not.
6) Returning true or false based on the divisibility.
7) In main function, printing the output of the bool function.

Optimizations:

1) Instead of looping through the (input number)/2, I am only looping through it's square root as it can be sufficient to check for the prime hence decreasing the compile time.

2) Have searched along many optimization tricks and codes to only use them as reference, but they are for numbers far exceeding the integer range or finding primes within a range with speed. I came to a conclusion to not include any of those as it is increasing the complexity unnecesorrily and we can find whether the number is prime or not in rather simple steps with efficient speed and memory. Hence, I have tried to complete the code in as lesser lines as possible.