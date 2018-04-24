using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace equality
{
	class Person
	{
		public string Name { get; set; }
	}

	[TestFixture]
	public class part1
	{
		[Test]
		public void TwoPrimitivesComparision()
		{
			Assert.That(3 < 4);
		}

		[Test]
		public void ReferenceEquality()
		{
			Person p1 = new Person();
			p1.Name = "Ehsan Sajjad";

			Person p2 = new Person();
			p2.Name = "Ehsan Sajjad";

			Assert.That(!p1.Equals(p2));//reference equality
			Assert.That(p1 != p2);////reference equality
		}

		[Test]
		public void StringCopy()
		{
			string s1 = "Ehsan Sajjad";
			string s2 = string.Copy(s1);

			Assert.That(s1 == s2);
			Assert.That(s1.GetHashCode() == s2.GetHashCode());
		}

		[Test]
		public void primitivesCastedToObject()
		{
			int num1 = 2, num2 = 2;

			Assert.That((object)num1 != (object)num2); //reference type
		}

		[Test]
		public void primitivesCastedToIComparableInterface()
		{
			int num1 = 2, num2 = 2;
			Assert.That((IComparable<int>)num1 != (IComparable<int>)num2);
		}
	}
}
