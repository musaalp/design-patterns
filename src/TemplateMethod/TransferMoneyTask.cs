using System;

namespace TemplateMethod
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
