@QualityMetrics
Feature: UsingCalculatorQualityMetrics
  In order to report quality metrics
  As a quality engineer
  I want the calculator to compute defect density and next-release SSI

  Scenario: Defect density for a release
    Given I have a calculator
    When I enter 45 defects and 120 KSSI and press defect_density
    Then the metrics result should be 0.375

  Scenario Outline: Compute next-release SSI from previous release and changes
    Given I have a calculator
    When I enter previous SSI <prev>, added <added>, reused <reused>, modified <modified>, deleted <deleted> and press next_ssi
    Then the metrics result should be <ssi>
    Examples:
      | prev | added | reused | modified | deleted | ssi |
      | 1000 |  150  |  0     |   0      |   50    | 1100 |
      | 5000 |  0    |  200   |   80     |   30    | 5250 |
