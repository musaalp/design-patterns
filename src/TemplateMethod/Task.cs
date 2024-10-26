using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodDesignPattern
{
    public abstract class Task
    {
        private readonly AuditTrail _auditTrail;

        protected Task(AuditTrail auditTrail)
        {
            _auditTrail = auditTrail;
        }

        public void Execute()
        {
            _auditTrail.Record();

            DoExecute();
        }

        //template method
        protected abstract void DoExecute();
    }
}
