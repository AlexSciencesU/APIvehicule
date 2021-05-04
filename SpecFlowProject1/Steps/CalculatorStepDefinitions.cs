using FluentAssertions;
using SpecFlowProject1.Fake;
using TechTalk.SpecFlow;
using VehiculeAPI;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private string _username;
        private string _password;
        private Location _target;
        private string _lastErrorMessage;
        private FakeDataLayer _fakeDataLayer;

        private string _startDate;
        private string _endDate;
        private string _successMessage;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            this._fakeDataLayer = new FakeDataLayer();
            _target = new Location(this._fakeDataLayer);
        }




        #region Background

        [Given(@"following existing clients")]
        public void GivenFollowingExistingClients(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                this._fakeDataLayer.Clients.Add(new Client(row[0], row[1]));
            }
        }

        #endregion


        [Given(@"my username is ""(.*)""")]
        public void GivenMyUsernameIs(string username)
        {
            this._username = username;
        }

        [Given(@"my password is ""(.*)""")]
        public void GivenMyPasswordIs(string password)
        {
            this._password = password;
        }

        [When(@"I try to connect to my account")]
        public void WhenITryToConnectToMyAccount()
        {
            this._lastErrorMessage = this._target.ConnectUser(this._username, this._password);
        }

        [Then(@"the connection is accepted")]
        public void ThenTheConnectionIsAccepted()
        {
            this._target.UserConnected.Should().BeTrue();
        }


        [Then(@"the connection is refused")]
        public void ThenTheConnectionIsRefused()
        {
            this._target.UserConnected.Should().BeFalse();
        }

        [Then(@"the error message is ""(.*)""")]
        public void ThenTheErrorMessageIs(string errorMessage)
        {
            
            _lastErrorMessage.Should().Be(errorMessage);
        }


        [Then(@"the connection is established")]
        public void ThenTheConnectionIsEstablished()
        {
            this._target.UserConnected.Should().BeTrue();
        }


        [Given(@"Start date is ""(.*)""")]
        public void GivenStartDateIs(string startDate)
        {
            this._startDate = startDate;
        }

        [Given(@"End date is ""(.*)""")]
        public void GivenEndDateIs(string endDate)
        {
            this._endDate = endDate;
        }

        [When(@"I make a reservation")]
        public void WhenIMakeAReservation()
        {
            _successMessage = this._target.makeReservation(_startDate, _endDate);
        }

        [Then(@"the success message is ""(.*)""")]
        public void ThenTheSuccessMessageIs(string successMessage)
        {
            _successMessage.Should().Be(successMessage);
        }
    }
}
