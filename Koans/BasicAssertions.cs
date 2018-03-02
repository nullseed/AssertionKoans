﻿using System;
using AssertionKoans.Engine;
using AssertionKoans.Engine.Extensions;
using FluentAssertions;

namespace AssertionKoans.Koans
{
    class BasicAssertions : Koan
    {
		//[Step(1)]
	    public void BasicAssertionUsingUnidaysShould()
	    {
			// observe failure message, nice and clear right?
		    "hello".ShouldEqual("helll");
	    }

	    //[Step(2)]
	    public void BasicAssertionUsingFluentAssertions()
	    {
			// how does the error message compare with the previous step?
		    "hello".Should().Be("helll");
	    }

	  //  [Step(3)]
	    public void TrueAssertionUsingUnidaysShould()
	    {
			// what is wrong with this failure message?
			(1 == 2).ShouldBeTrue();
	    }

	    //[Step(4)]
	    public void TrueAssertionUsingFluentAssertions()
	    {
			// what is better about this failure message?
		    (1 == 2).Should().BeTrue();
	    }

	    //[Step(5)]
	    public void NotNullAssertionUsingUnidaysShould()
	    {
		    string b = null;
			// does this say what is null in the error?
			b.ShouldNotBeNull();
	    }

	    //[Step(6)]
	    public void NotNullAssertionUsingFluentAssertions()
	    {
		    string b = null;

			// is this clearer
		    b.Should().NotBeNull();
	    }

	   // [Step(7)]
	    public void NullAssertionUsingUnidaysShould()
	    {
		    var b = "hello";
		    // this is not a terrible failure message
		    b.ShouldBeNull();
	    }

	    //[Step(8)]
	    public void NullAssertionUsingFluentAssertions()
	    {
		    var b = "hello";

		    // this gives the same info, but is a little bit more succinct
		    b.Should().BeNull();
	    }
	}
}
