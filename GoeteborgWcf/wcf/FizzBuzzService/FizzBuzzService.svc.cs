using System;
using System.Collections.Generic;
using DomainServices;
using DomainServices.enums;
using DomainServices.Services;
using FizzBuzzService.DataContracts;

namespace FizzBuzzService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class FizzBuzzService : IFizzBuzzService
    {
        private readonly ILogService logService;

        public FizzBuzzService()
        {
            this.logService = new Log4NetService();
        }

        public IEnumerable<string> GetCalculate(int endNumber)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);

            var results = new List<string>();
            for (var item = randomNumber; item <= endNumber; item++)
            {
                var result = string.Empty;

                if (item % 3 == 0)
                {
                    result = "Fizz";
                }

                if (item % 5 == 0)
                {
                    result = result + "Buzz";
                }

                if (result.Length == 0)
                {
                    result = item.ToString();
                }

                results.Add(result);
            }

            this.logService.WriteLog(EnumLogLevel.Information, "Informacion");

            return results;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                //LOG
                this.logService.WriteLog(EnumLogLevel.Information, "");

                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
