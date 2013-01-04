using FubuMVC.Core.Registration.Nodes;
using FubuMVC.Validation.UI;

namespace FubuMVC.Validation
{
    public class AjaxValidationNode : Wrapper, ValidationNode
    {
        public AjaxValidationNode(ActionCall call)
            : base(typeof(AjaxValidationBehavior<>).MakeGenericType(call.InputType()))
        {
        	Strategies = RenderingStrategyRegistry.Default();
        }

    	public ValidationMode Mode
    	{
			get { return ValidationMode.Ajax; }
    	}

		public RenderingStrategyRegistry Strategies { get; private set; }
    }
}