using System;
using System.Collections.Generic;
using System.Text;
using Exercicio3.Entities;

namespace Exercicio3.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;
        public ContractService(IOnlinePaymentService onlinepaymentservice)
        {
            _onlinePaymentService = onlinepaymentservice;
        }
        public void ProcessConstract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for(int i=1; i<=months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updateQuota + _onlinePaymentService.PaymentFee(updateQuota);
                contract.AddInstallment(new Installment(date, fullQuota));

            }
        }
    }
}
