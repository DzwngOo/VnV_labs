@Factorial
Feature: UsingCalculatorFactorial
  In order to compute factorials
  As a user who prefers examples
  I want my calculator to give correct factorial values

  Scenario: Factorial of a positive number
    Given I have a calculator
    When I have entered 5 into the calculator and press factorial
    Then the result should be 120

  Scenario: Zero factorial
    Given I have a calculator
    When I have entered 0 into the calculator and press factorial
    Then the result should be 1
