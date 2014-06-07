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

        [When(@"I specify an End Time")]
        public void WhenISpecifyAnEndTime()
        {
            _sicknessEpisodeEventCreationContext.SpecifyEndTime();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _sicknessEpisodeEventCreationContext.CreateEvent();
        }

        [Then(@"My Sickness Episode should be tracked")]
        public void ThenMySicknessEpisodeShouldBeTracked()
        {
            _sicknessEpisodeEventCreationContext.AssertEventTracked();
        }

        [Then(@"it should reflect my desired End Time")]
        public void ThenItShouldReflectMyDesiredEndTime()
        {
            _sicknessEpisodeEventCreationContext.AssertCorrectEndDateTime();
        }

    }
}
