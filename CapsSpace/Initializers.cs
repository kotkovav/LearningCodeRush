﻿using System;
using System.Linq;

namespace CapsModifier
{
	public class Initializers
	{
		//`![Enable Rich Comments to see embedded images](CapsSpace) Caps+Space to create and decompose initializers.

		public void CreateTestCustomer1()
		{
			//`                  ![](ArrowDown) Caps+Space to Convert to an Initializer: 
			Customer andrew = new Customer();
			andrew.FirstName = "Andrew";
			andrew.LastName = "Fuller";
			andrew.Age = 48;
			andrew.Ready();
		}

		public void CreateTestCustomer2()
		{
			//`                  ![](ArrowDown) Caps+Space to Decompose this Initializer: 
			Customer jackson = new Customer() { 
													FirstName = "Jackson", 
													LastName = "Grand", 
													Age = 35 };
			jackson.Ready();
		}
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:InlineTemp.cs) << Inline Temp and more...
}

