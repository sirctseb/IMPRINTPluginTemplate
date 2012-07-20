using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MAAD.Plugins.ImprintPluginLoader;

[assembly: ImprintPluginAttribute()]

/** TODO
 * Change namespace to something meaningful
 * e.g. MyMathPlugin
 **/
namespace IMPRINTPluginTemplate
{
	/** TODO
	 * Change class name to something meaninfgul
	 * e.g. MyMathPluginProvider
	 **/
	public class IMPRINTPluginProvider : IExternalVariableProvider, IImprintPlugin
	{
		#region IExternalVariableProvider Implementation

		public string[] GetAssemblyReferences()
		{
			return new string[]
			{
				/** TODO
				 * Set to the Assembly name in the project properties
				 **/
				"IMPRINTPluginTemplate.dll",
				/** TODO
				 * Add assemblies from other projects that this project requires
				 */
				//"OtherProjectAssembly.dll"
			};
		}

		public IEnumerable<VariableName> GetExternalVariables()
		{
			return new VariableName[]
			{
				// The first parameter will be the name of the instance IMPRINT creates
				// i.e. ExternalVariables.IMPRINTPluginVariableName.MethodName();
				new VariableName("IMPRINTPluginVariableName", typeof(IMPRINTPluginDefinition)),
				/** TODO
				 * Add other classes you want to access from IMPRINT via ExternalVariables.VariableName
				 **/
				//new VariableName("OtherVariableName", typeof(OtherClass))
			};
		}

		public string[] GetNamespaceAliases()
		{
			// Supply namespaces here if you want to be able to access their types
			// without qualifying them in IMPRINT
			return new string[]
			{
				// Allows IMPRINTPluginDefinition def = new IMPRINTPluginDefinition();
				// instead of IMPRINTPluginTemplate.IMPRINTPluginDefinition def = new IMPRINTPluginTemplate.IMPRINTPluginDefinition();
				//"IMPRINTPluginTemplate"
			};
		}

		#endregion

		#region IImprintPlugin Implementation
		
		public string Author
		{
			/** TODO
			 * Change to your name
			 **/
			get { return "Your Name"; }
		}

		public DateTime Date
		{
			get { return DateTime.Today; }
		}

		public string Description
		{
			/** TODO
			 * Change to a meaningful description
			 **/
			get { return "Description of your plugin"; }
		}

		public string Name
		{
			/** TODO
			 * Change to a meaningful name
			 **/
			// This name appears under the Plugins entry in the tree menu
			get { return "IMPRINTPlugin"; }
		}

		#endregion
	}
}
