using System.Web.Mvc;
using DontMockMe.Web.Controllers;
using Xunit;

namespace DontMockMe.Tests.Web.Controllers
{
    public abstract class with_a_fuzzie_bunny_controller
    {
        protected FuzzieBunniesController controller;

        protected with_a_fuzzie_bunny_controller()
        {
            controller = new FuzzieBunniesController();

            BecauseOf();
        }

        public abstract void BecauseOf();
    }

    public class when_getting_a_list_of_fuzzie_bunnies : with_a_fuzzie_bunny_controller
    {
        private ActionResult result;

        public override void BecauseOf()
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