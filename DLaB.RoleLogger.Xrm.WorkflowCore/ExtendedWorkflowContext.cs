using System.Activities;
using Source.DLaB.Xrm.Workflow;

namespace DLaB.RoleLogger.Xrm.Workflow
{
    public class ExtendedWorkflowContext: DLaBExtendedWorkflowContext
    {
        public ExtendedWorkflowContext(CodeActivityContext executionContext, CodeActivity codeActivity) 
            : base(executionContext, codeActivity)
        {
        }
    }
}
