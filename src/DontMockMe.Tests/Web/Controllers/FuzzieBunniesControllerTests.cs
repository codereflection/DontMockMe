using System;
using System.Web.Mvc;
using DontMockMe.Web.Controllers;
using Xunit;

namespace DontMockMe.Tests.Web.Controllers
{
    public abstract class SpecFor<T> where T : class 
    {
        protected SpecFor()
        {
            Context();
            Because();
        }

        public abstract void Context();
        public abstract void Because();

    }

    public abstract class with_a_fuzzie_bunny_controller : SpecFor<FuzzieBunniesController>
    {
        protected FuzzieBunniesController controller;

        public override void Context()
        {
            controller = new FuzzieBunniesController();
        }
    }

    public class when_getting_a_list_of_fuzzie_bunnies : with_a_fuzzie_bunny_controller
    {
        private ActionResult result;

        public override void Because()
        {
            result = controller.Index();
        }

        [Fact]
        public void i_should_have_a_list_of_them_bunnies()
        {
            Assert.NotNull(result);
        }
    }
}