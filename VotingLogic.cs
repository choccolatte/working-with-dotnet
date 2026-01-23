using System;

int votingAge = 18;
int lastAgeToVote = 120;

Console.Write("Enter your age: ");
int personAge = Convert.ToInt32(Console.ReadLine());

if (personAge >= votingAge && personAge <= lastAgeToVote) Console.WriteLine("Eligible to vote!");
else Console.WriteLine("Not eligible to vote!");