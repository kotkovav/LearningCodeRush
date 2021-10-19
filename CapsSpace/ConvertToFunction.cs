﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace CapsModifier
{
	//`![Enable Rich Comments to see embedded images](CapsSpace) Caps+Space (on the return keyword) to convert a proc to a function.

	
	public class ConvertToFunction
	{
		//`         ![](LookHere) Look here when you try the next one.
		internal void GetSquare(double value)
		{//`  ![](ArrowDown) Caps+Space to convert this procedure to a function.
			return Math.Pow(value, 2);
		}
	}



	//! ICustomerFactory is an interface...
	public interface ICustomerFactory
	{
		//`![](LookHere) Look here when you try the next one.
		void CreateCustomerLists(string key);
	}


	public partial class CustomerFactory : ICustomerFactory
	{
		//! CreateCustomerLists is from ICustomerFactory...
		public void CreateCustomerLists(string key)
		{
			List<Customer> customerList = new List<Customer>();
			customerLists.Add(key, customerList);

			//`  ![](ArrowDown)  Press Caps+Space to convert this proc to a function.
			return customerLists[key];
		}

		

		//`![](BtnMoreLikeThis;crcommand:OpenFile:FlattenConditionals.cs) << Flatten Conditionals and more...
	}
}
