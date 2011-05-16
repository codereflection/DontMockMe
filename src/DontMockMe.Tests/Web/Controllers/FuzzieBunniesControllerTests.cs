using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DontMockMe.Core.Models;
using DontMockMe.Core.Repositories;
using DontMockMe.Tests.TestingConstructs;
using DontMockMe.Web.Controllers;
using Xunit;

namespace DontMockMe.Tests.Web.Controllers
{
    public abstract class with_a_fuzzie_bunny_controller : SpecFor<FuzzieBunniesController>
    {
        public override void Context()
        {
            subject = new FuzzieBunniesController();
        }
    }

    public class when_getting_a_list_of_fuzzie_bunnies : with_a_fuzzie_bunny_controller
    {
        ViewResult result;

        public override void Because()
        {
            result = subject.Index();
        }

        [Fact]
        public void i_should_have_a_list_of_them_bunnies()
        {
            Assert.NotEmpty(result.Model as IEnumerable<FuzzieBunny>);
        }
    }

    public class when_ensuring_the_controller_gets_the_purple_bunny : with_a_fuzzie_bunny_controller
    {
        IEnumerable<FuzzieBunny> result;

        public override void Context()
        {
            base.Context();

            FuzzieBunnies.GetAll = () => new[] { new FuzzieBunny { Color = "Purple", Name = "Fred" } };
        }
        
        public override void Because()
        {
            result = subject.Index().Model as IEnumerable<FuzzieBunny>;
        }

        [Fact]
        public void the_purple_bunnie_named_Fred_I_should_see()
        {
            Assert.Equal(1, result.Count(x => x.Name == "Fred" && x.Color == "Purple"));
        }
    }
}