using System;
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

        [When(@"I specify an (.*) Time")]
        public void WhenISpecifyAnEndTime(StartOrEnd startOrEnd)
        {
            switch (startOrEnd)
            {
                case StartOrEnd.Start:
                    _sicknessEpisodeEventCreationContext.SpecifyStartTime();
                    break;
                case StartOrEnd.End:
                    _sicknessEpisodeEventCreationContext.SpecifyEndTime();
                    break;
            }
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

        [Then(@"it should reflect my desired (.*) Time")]
        public void ThenItShouldReflectMyDesiredEndTime(StartOrEnd startOrEnd)
        {
            switch (startOrEnd)
            {
                case StartOrEnd.Start:
                    _sicknessEpisodeEventCreationContext.AssertCorrectStartDateTime();
                    break;
                case StartOrEnd.End:
                    _sicknessEpisodeEventCreationContext.AssertCorrectEndDateTime();
                    break;
            }
        }

    }

    public enum StartOrEnd
    {
        Start,
        End
    }
}
