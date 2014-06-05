using TechTalk.SpecFlow;

namespace BadassTracker.Specifications.StepDefinitions
{
    [Binding]
    public class CreateNewSicknessEpisodeStepDefinitions
    {
        [Given(@"I am Creating a Sickness Episode Event")]
        public void GivenIAmCreatingASicknessEpisodeEvent()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"My Sickness Episode should be tracked")]
        public void ThenMySicknessEpisodeShouldBeTracked()
        {
            ScenarioContext.Current.Pending();
        }
    }
}