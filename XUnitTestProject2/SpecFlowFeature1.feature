Feature: SpecFlowFeature1
    In order to avoid silly mistakes
    As a math idiot
    I want to be told the sinus/cosinus/tanges of numbers

@mytag
Scenario: Sinus of a number
    Given the first number is 3.1415
    When the sinus is calculated
    Then the result should be 0


Scenario: Kosinus of a number
    Given the first number is 3.1415
    When the cosinus is calculated
    Then the result should be -1


Scenario: Tangens of a number
    Given the first number is 3.1415
    When the tangens is calculated
    Then the result should be 0
    |