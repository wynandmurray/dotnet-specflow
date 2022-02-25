using Shouldly;
using specflow_demo.Models;
using Microsoft.AspNetCore.Mvc;
using specflow_demo.Controllers;

namespace specflowtests.StepDefinitions
{
    [Binding]
    public sealed class SpecflowControllerTestDefinitions
    {
        private IActionResult? _httpResult;
        private SpecflowController? _specflowController;

        /// <summary>
        /// Class constructor.
        /// </summary>
        public SpecflowControllerTestDefinitions()
        { }

        [Given(@"A specflow controller is created")]
        public void GivenASpecflowControllerIsCreated()
        {
            _specflowController = new SpecflowController();
        }


        [When(@"the GetPeople method is invoked")]
        public void WhenTheGetPeopleMethodIsInvoked()
        {
            if (_specflowController != null)
            {
                _httpResult = _specflowController.GetPeople();
            }
        }

        [Then(@"the following people are returned")]
        public void ThenTheFollowingPeopleAreReturned(Table table)
        {
            if (_httpResult is not OkObjectResult okResult) { return; }
            
            var people = okResult.Value as List<Person>;
            people.Should().NotBeNull();

            if (people == null) { return; }

            people.Count.ShouldBe(table.Rows.Count);

            foreach (var row in table.Rows)
            {
                people.ShouldContain(p =>
                                            p.PersonId == Convert.ToInt32(row["PersonId"]) &&
                                            p.FirstName == row["FirstName"] &&
                                            p.LastName == row["LastName"] &&
                                            p.EmailAddress == row["EmailAddress"]);
            }
        }
    }
}
