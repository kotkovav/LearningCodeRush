﻿using System;
using System.Linq;

namespace CapsModifier
{
	public class CapsQ
	{
		//`![Enable Rich Comments to see embedded images](CapsQ)

		/*
		 Use Caps+Q to declare constants.
			 
		 Examples follow in the source code below.

		 Arrows (![](ArrowDown)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.

		 And when declaring a constant, use the target picker to tell 
		 CodeRush where you want to put the new constant.

		 ![](BtnTargetPicker;crcommand:OpenFile:TargetPicker.cs)  << Learn about the Target Picker.

		*/

		public static string GetRelativePath(string str)
		{
			int parentFolderIndex = str.IndexOf(@"\wwwroot\GameDev\Assets\");
			if (parentFolderIndex >= 0)//`             Caps+Q ![](ArrowDown) to declare a constant.
				return str.Substring(parentFolderIndex + @"\wwwroot\GameDev\Assets\".Length);
			return null;
		}



		public double Circumference(double radius)
		{
			return 6.283185307179586476925286766559 * radius;
		}

		public double AreaCircle(double radius)
		{
			//           ![](LookHere) Look here when you try the next one.
			return 6.283185307179586476925286766559 * radius * radius / 2;
		}

		public double VolumeSphere(double radius)
		{//`             Caps+Q ![](ArrowDown) to declare a constant (name it Tau).
			return 2/3 * 6.283185307179586476925286766559 * radius * radius * radius;
		}
	}



	//`++Great Work!

	/* 
	 You used Caps+Q to declare constants. Nice!

	 ![](NextLesson;crcommand:OpenFile:CapsR.cs)  << Caps+R to Reorder parameters...

	 */
}
