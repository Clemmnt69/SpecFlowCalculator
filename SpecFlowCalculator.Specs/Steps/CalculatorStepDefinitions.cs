using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private readonly Calculator _calculator = new Calculator();
        private int _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [Given("all numbers is (.*)")]
        public void GivenAllNumbers(string numbers)
        { 
            _calculator.ListNumber = numbers.Split(',').Select(Int32.Parse).ToList();
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When("the multiple numbers are added")]
        public void WhenTheMultiplesNumbersAreAdded()
        {
            _result = _calculator.AddMultipleNumbers();
        }

        [When("the two numbers are multiply")]
        public void WhenTheTwoNumbersAreMultiply()
        {
            _result = _calculator.Multiply();
        }

        [When("the multiple numbers are multiply")]
        public void WhenTheMultiplesNumbersAreMultiply()
        {
            _result = _calculator.MultiplyMultipleNumbers();
        }

        [When("the two numbers are divised")]
        public void WhenTheTwoNumbersAreDivised()
        {
            _result = _calculator.Divide();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }
    }
}
