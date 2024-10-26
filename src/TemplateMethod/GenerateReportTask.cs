using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodDesignPattern
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
