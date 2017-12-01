using System;

namespace CodingTest
{
    public static class BackgroundCheckService
    {
        public static string RegisterApplicant(string firstName, string lastName, string dateOfBirth)
        {
            //Code to send application information to background check API.
            return Guid.NewGuid().ToString();
        }

        public static bool VerifyApplication(string ssn, string applicantId)
        {
            //Code to send the SSN and Applicant ID to background check API
            return ssn == "555-55-5555";
        }
    }
}
