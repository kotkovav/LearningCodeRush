﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace CapsModifier
{
	public abstract class CapsF
	{
		//`![Enable Rich Comments to see embedded images](CapsF)

		/* 
		 Caps+F lets you Flatten conditionals, work with For and Foreach loops, 
		 and convert void procs to Functions.
		 
		 
		 Use Caps+F to:
		
				* Convert to Function
				* Declare Fields
				* Introduce Format Item
				* ForEach to For (and back)
				* Format Selection
				* Move Type to File
				* Use String.Format
				* Widen Scope (Promote to Field)
		
			*/


		//`![](ShiftCapsF)
		/*

		 Combine with the Shift key (Shift+Caps+F) to: 

				* Rename Type to Match File
				* ForEach to Linq
				
			 
		 Examples follow in the source code below.

		 Arrows (![](ArrowDown)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.

		*/

		public abstract void Start();
		public abstract void ReadData();
		public abstract void Draw();
		public abstract void FinishDrawing();
		public abstract void DoMoreWork();




		public class GreetingsSender
		{
			private const int minAuthorizationsNeeded = 5;

			public void Start(int authorizationCount, bool allSystemsReady)
			{
				//` ![](ArrowDown)  Press Caps+F to declare "readyToLaunch" as a field (arrows & Enter pick location)
				readyToLaunch = authorizationCount >= minAuthorizationsNeeded && allSystemsReady;
			}




			//  Select the text "Mark" below ![](ArrowDown) and press Caps+F to introduce a format item.
			public string Message => "Hello Mark!";
		}




		public bool MyBinaryOperator(bool a, bool b)
		{
			//`![](ArrowDown) Press Caps+F to flatten this conditional.
			if (a && !b)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		void NestedMethod(bool okayToStart, bool okayToReadData, bool okayToDraw)
		{
			// Flatten Conditional can make a deeply nested method flatter.

			//`![](ArrowDown) Press Caps+F to flatten this conditional.
			if (okayToStart)
			{
				Start();


				//`![](ArrowDown) Flatten this conditional too.
				if (okayToReadData)
				{
					ReadData();


					//`![](ArrowDown) And flatten this.
					if (okayToDraw)
					{
						Draw();
						DoMoreWork();
						FinishDrawing();
					}
				}
			}
		}




		void ConcatLongerThan(List<string> strings, int minLength)
		{
			string result = string.Empty;

			//`![](ArrowDown) Press Caps+F to convert this foreach into a for loop:
			foreach (string str in strings)
				if (str.Length > minLength)
					result += $"{str};";
		}




		internal List<int> GetOdd(List<int> numberList)
		{
			List<int> results = new List<int>();

			//`![](ArrowDown) Press Caps+F to convert this for-loop into a foreach:
			for (int i = 0; i < numberList.Count; i++)
				if (numberList[i] % 2 == 0)
					results.Add(numberList[i]);

			return results;
		}

		public int callCount;
		bool trackingResults;
		public int negativeCount;
		public int positiveCount;


		//`![](ArrowDown) Press Num Plus (or Ctrl W) to select this method, then Caps+F to format the selection:
		public int CalculateIt(int factor, int multiplier)
		{
var resultValue=multiplier*factor   ;
                                       			callCount  ++; 
			
			if(  trackingResults  )
										{
																if(resultValue<0)
negativeCount     ++            ;
																else                         if(resultValue>0)
														positiveCount     ++            ;
																																			}

			                         return                                    resultValue                       ;
		}
	}




	//`![](ArrowDown) Press Caps+F to move this type to its own file (and then use Escape or Alt+End to get back):
	public class Automobile
	{
		public string Model { get; set; }
		public int Year { get; set; }
		public Guid ID { get; set; }
		public Automobile()
		{

		}
	}



	public static class MathEx
	{
		public static void ShowMultiplicationTable(int numColumns = 10, int numRows = 10)
		{
			for (int column = 1; column < numColumns; column++)
				for (int row = 1; row < numRows; row++)
				{
					int result = column * row;


					//`                   ![](ArrowDown) Press Caps+F to replace this string concatenation with a String.Format call:
					Console.WriteLine(column + " * " + row + " = " + result);
				}
		}
	}


	public class SiteLoader
	{
		public void SetUrl(string url)
		{

			//`        ![](ArrowDown) Press Caps+F to turn "completeUrl" into a field variable (arrows & Enter pick location):
			string completeUrl = string.Format("http://{0}", url);



			if (!IsValid(completeUrl))
				throw new Exception($"\"{completeUrl}\" has errors!");
		}

		bool IsValid(string completeUrl)
		{
			throw new NotImplementedException();
		}
	}


	//`++Great Work!
	/* 
	 You used Caps+F to declare Fields, convert void procs into Functions, 
	 introduce Format items, Flatten conditionals, convert between ForEach 
	 statements and For loops, Format the selection, move types to Files, 
	 use string.Format, and promote local variables to Fields.

 ![](NextLesson;crcommand:OpenFile:ShiftCapsF.cs)

 */

}