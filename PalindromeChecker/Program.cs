/* 
 * Hackerrank Day 18: Queues and Stacks
 * 
 * Palindrome checker is case insensitive. 
 * 
 * 2016
*/

using System;
using System.Collections.Generic;



namespace PalindromeChecker
{
	class Solution
	{

		Stack<char> stack = new Stack<char>();
		Queue<char> queue = new Queue<char>();

		public void pushCharacter(char ch)
		{
			stack.Push(ch);
		}

		public void enqueueCharacter(char ch)
		{
			queue.Enqueue(ch);
		}

		public char popCharacter()
		{
			return stack.Pop();
		}

		public char dequeueCharacter()
		{
			return queue.Dequeue();
		}

		public static void Main(string[] args)
		{

			// read the string s.
			Console.WriteLine("Enter your word.");
			string s = Console.ReadLine();
			string s1 = s.ToLower();


			// create the Solution class object p.
			Solution obj = new Solution();

			// push/enqueue all the characters of string s to stack/queue.
			foreach (char c in s1)
			{
				obj.pushCharacter(c);
				obj.enqueueCharacter(c);
			}

			bool isPalindrome = true;

			// pop the top character from stack.
			// dequeue the first character from queue.
			// compare both the characters.
			for (int i = 0; i < s1.Length / 2; i++)
			{
				if (obj.popCharacter() != obj.dequeueCharacter())
				{
					isPalindrome = false;

					break;
				}
			}

			// print whether string s is palindrome or not.
			if (isPalindrome)
			{
				Console.Write("The word, {0}, is a palindrome.", s);
			}
			else
			{
				Console.Write("The word, {0}, is not a palindrome.", s);
			}

			Console.ReadKey();

		}
	}
}

