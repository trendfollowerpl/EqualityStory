﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace equality
{
	[TestFixture]
	public class part2
	{
		private delegate void TestDelegate(string message);

		[Test]
		public void StringObject_Equal()
		{
			string s1 = "Ehsan Sajjad";
			string s2 = string.Copy(s1);

			Assert.That(s1.Equals((object)s2));
		}

		[Test]
		public void DelegateObject_Equal()
		{
			TestDelegate delegate1 = (string s) => { };
			TestDelegate delegate2 = (TestDelegate)delegate1.Clone();
			TestDelegate delegate3 = delegate1;

			Assert.That(delegate1.Equals((object)(delegate2)));
			Assert.That(delegate1.Equals((object)(delegate3)));
			Assert.That(delegate2.Equals((object)(delegate3)));
		}

		[Test]
		public void Tuple_Equal()
		{
			var population1 = new Tuple<string, int, int, int, int, int, int>(
						   "New York", 7891957, 7781984,
						   7894862, 7071639, 7322564, 8008278);
			var population2 = new Tuple<string, int, int, int, int, int, int>(
						   "New York", 7891957, 7781984,
						   7894862, 7071639, 7322564, 8008278);

			Assert.That(population1.Equals(population2));
			Assert.That((object)population1 != (object)population2);
		}
	}
}
