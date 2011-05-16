using System;
using System.Web.Mvc;
using DontMockMe.Web.Controllers;
using Xunit;

namespace DontMockMe.Tests.Web.Controllers
{
    public abstract class SpecFor<T> where T : class 
    {
        protected T subject;

        protected SpecFor()
        {
            Context();
            Because();
        }

        protected ~SpecFor()
        {
            CleanUp();
        }

        public abstract void Context();
        public abstract void Because();
        public virtual void CleanUp() { }
    }

    public abstract class with_a_fuzzie_bunny_controller : SpecFor<FuzzieBunniesController>
    {
        public override void Context()
        {
            subject = new FuzzieBunniesController();
        }
    }

    public class when_getting_a_list_of_fuzzie_bunnies : with_a_fuzzie_bunny_controller
    {
        private ActionResult result;

        public override void Because()
        {
            result = subject.Index();
        }

        [Fact]
        public void i_should_have_a_list_of_them_bunnies()
        {
            Assert.NotNull(result);
        }
    }
}