using TechTalk.SpecFlow;
using System;
using NUnit.Framework;

namespace SpecFlow1.steps
{
    [Binding]
    public class Example01Steps
    {
        [Given(@"I start the Ozone application")]
        public void I_start_the_Ozone_application()
        {
            Console.WriteLine("Executing... I start the Ozone application");
        }

        [When(@"I navigate to the Zabbix page")]
        public void I_navigate_to_the_Zabbix_page()
        {
            Console.WriteLine("Executing... I navigate to the Zabbix page");
        }

        [When(@"I navigate to the MFLTS page")]
        public void I_navigate_to_the_MFLTS_page()
        {
            Console.WriteLine("Executing... I navigate to the MFLTS page");
        }

        [Then(@"verify navigation to the Zabbix page")]
        public void verify_navigation_to_the_Zabbix_page()
        {
            Console.WriteLine("Executing... verify navigation to the Zabbix page");   
        }

        [Then(@"verify navigation to the MFLTS page")]
        public void verify_navigation_to_the_MFLTS_page()
        {
            Console.WriteLine("Executing... veirfy navigation to the MFLTS page");
        }
    }
}