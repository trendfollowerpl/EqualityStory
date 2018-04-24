using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using equality.TestObjects;
using NUnit.Framework;

namespace equality
{

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
			var p1 = new Person();
			p1.Name = "Ehsan Sajjad";

			var p2 = new Person();
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
		public void PrimitivesCastedToObject()
		{
			int num1 = 2, num2 = 2;

			Assert.That((object)num1 != (object)num2); //reference type
		}

		[Test]
		public void PrimitivesCastedToIComparableInterface()
		{
			int num1 = 2, num2 = 2;
			Assert.That((IComparable<int>)num1 != (IComparable<int>)num2);
		}

		[Test]
		public void StringCaseInsensitiveEquality()
		{
			string s1 = "EQUALITY";
			string s2 = "equality";

			Assert.That(s1 != s2);
			Assert.That(s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
		}

		[Test]
		public void FloatEquality_roundingErrors()
		{
			float num1 = 2.999999999999999f;
			float num2 = 3.000000000000000f;

			Assert.That(num1 == num2);
		}

		[Test]
		public void FloatEquality2_roundingErrors()
		{
			float num1 = 2.999999999999999f;
			float num2 = 0.000000000000001f;

			Assert.That(num1 + num2 != 3f);
		}
	}
}
