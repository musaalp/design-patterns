using System;

namespace TemplateMethod
{
    public class GenerateReportTask : Task
    {
        public GenerateReportTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        protected override void DoExecute()
        {
            Console.WriteLine("Generate Report");
        }
    }
}
