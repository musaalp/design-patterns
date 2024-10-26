using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodDesignPattern
{
    public class TransferMoneyTask : Task
    {
        public TransferMoneyTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        protected override void DoExecute()
        {
            Console.WriteLine("Transfer Money");
        }
    }
}
