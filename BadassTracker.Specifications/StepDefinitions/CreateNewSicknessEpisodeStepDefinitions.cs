using BadassTracker.Specifications.Support;
using TechTalk.SpecFlow;

namespace BadassTracker.Specifications.StepDefinitions
{
    [Binding]
    public class CreateNewSicknessEpisodeStepDefinitions
    {
        private readonly SicknessEpisodeEventCreationContext _sicknessEpisodeEventCreationContext;

        public CreateNewSicknessEpisodeStepDefinitions()
        {
            _sicknessEpisodeEventCreationContext = new SicknessEpisodeEventCreationContext();
        }

        [Given(@"I am Creating a Sickness Episode Event")]
        public void GivenIAmCreatingASicknessEpisodeEvent()
        {
            _sicknessEpisodeEventCreationContext.StartCreation();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _sicknessEpisodeEventCreationContext.CreateEvent();
        }

        [Then(@"My Sickness Episode should be tracked")]
        public void ThenMySicknessEpisodeShouldBeTracked()
        {
            ScenarioContext.Current.Pending();
        }
    }
}