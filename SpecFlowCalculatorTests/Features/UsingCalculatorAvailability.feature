@Availability
Feature: UsingCalculatorAvailability
  In order to calculate MTBF and Availability
  As someone who struggles with math
  I want to be able to use my calculator to do this

  Scenario: Calculating MTBF
    Given I have a calculator
    When I have entered 100 and 10 into the calculator and press MTBF
    Then the availability result should be 110

  Scenario: Calculating Availability
    Given I have a calculator
    When I have entered 100 and 10 into the calculator and press Availability
    Then the availability result should be 0.9090909091

  Scenario Outline: Sanity check different repair times
    Given I have a calculator
    When I have entered <mttf> and <mttr> into the calculator and press Availability
    Then the availability result should be <avail>
    Examples:
      | mttf | mttr | avail       |
      | 50   | 0    | 1           |
      | 0    | 10   | 0           |
      | 90   | 10   | 0.9         |
