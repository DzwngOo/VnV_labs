@Musa
Feature: UsingCalculatorBasicReliability
  In order to calculate the Basic Musa model's failures/intensities
  As a Software Quality Metric enthusiast
  I want to use my calculator to do this

  Scenario: Current failure intensity (lambda at tau)
    Given I have a calculator
    When I have entered 100, 0.5 and 10 into the calculator and press musa_current_intensity
    Then the musa result should be 0.4756147123

  Scenario: Expected failures (mu at tau)
    Given I have a calculator
    When I have entered 100, 0.5 and 10 into the calculator and press musa_expected_failures
    Then the musa result should be 4.87705755

  Scenario Outline: Vary time
    Given I have a calculator
    When I have entered 100, 0.5 and <tau> into the calculator and press musa_expected_failures
    Then the musa result should be <mu>
    Examples:
      | tau | mu          |
      | 0   | 0           |
      | 5   | 2.4690087972    |
      | 20  | 9.516258    |
