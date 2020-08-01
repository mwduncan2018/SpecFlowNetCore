Feature: Ozone Smoke

  Scenario: Zabbix
    Given I start the Ozone application
    When I navigate to the Zabbix page
    Then verify navigation to the Zabbix page

  Scenario: MFLTS
    Given I start the Ozone application
    When I navigate to the MFLTS page
    Then verify navigation to the MFLTS page