@MusaLog
Feature: UsingCalculatorMusaLogarithmic
  In order to estimate reliability using Musa Logarithmic
  As a reliability analyst
  I want the calculator to compute current failure intensity and expected failures

  # Musa Logarithmic model (execution time x):
  #   lambda(x) = lambda0 / (1 + theta * lambda0 * x)
  #   mu(x)     = (1/theta) * ln(1 + theta * lambda0 * x)

  Scenario: Current failure intensity
    Given I have a calculator
    When I enter lambda0 0.8, theta 0.02, time 50 and press musa_log_lambda
    Then the reliability result should be 0.4444444444

  Scenario: Expected failures
    Given I have a calculator
    When I enter lambda0 0.8, theta 0.02, time 50 and press musa_log_mu
    Then the reliability result should be 29.3893332451

  Scenario Outline: Vary time values
    Given I have a calculator
    When I enter lambda0 0.5, theta 0.01, time <x> and press musa_log_mu
    Then the reliability result should be <mu>
    Examples:
      | x  | mu        |
      | 0  | 0         |
      | 20 | 9.531018  |
      | 50 | 22.3143551314|
