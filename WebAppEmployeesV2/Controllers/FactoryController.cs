using System;
using WebAppEmployeesV2.Interfaces;

namespace WebAppEmployeesV2.Factory
{
    public class FactoryController
    {
        public FactoryController()
        {

        }

        public ICalculateSalary GetContractType(string contractType)
        {
            switch (contractType)
            {
                case "1":
                    {
                        return new SalaryHourlyController();
                    }
                case "2":
                    {
                        return new SalaryMonthlyController();
                    }

                default: throw new ArgumentNullException("contractType");
            }
        }
    }
}