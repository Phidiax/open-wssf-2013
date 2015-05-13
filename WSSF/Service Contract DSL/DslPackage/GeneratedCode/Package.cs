﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using VSShellInterop = global::Microsoft.VisualStudio.Shell.Interop;
using VSShell = global::Microsoft.VisualStudio.Shell;
using DslShell = global::Microsoft.VisualStudio.Modeling.Shell;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslModeling = global::Microsoft.VisualStudio.Modeling;
using System;
using System.Diagnostics;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;
	
namespace Microsoft.Practices.ServiceFactory.ServiceContracts
{
	/// <summary>
	/// This class implements the VS package that integrates this DSL into Visual Studio.
	/// </summary>
	[VSShell::DefaultRegistryRoot("Software\\Microsoft\\VisualStudio\\12.0")]
	[VSShell::PackageRegistration(RegisterUsing = VSShell::RegistrationMethod.Assembly, UseManagedResourcesOnly = true)]
	[VSShell::ProvideToolWindow(typeof(ServiceContractDslExplorerToolWindow), MultiInstances = false, Style = VSShell::VsDockStyle.Tabbed, Orientation = VSShell::ToolWindowOrientation.Right, Window = "{3AE79031-E1BC-11D0-8F78-00A0C9110057}")]
	[VSShell::ProvideToolWindowVisibility(typeof(ServiceContractDslExplorerToolWindow), Constants.ServiceContractDslEditorFactoryId)]
	[VSShell::ProvideStaticToolboxGroup("@Service Contract ToolsToolboxTab;Microsoft.Practices.ServiceFactory.ServiceContracts.Dsl.dll", "Microsoft.Practices.ServiceFactory.ServiceContracts.Service Contract ToolsToolboxTab")]
	[VSShell::ProvideStaticToolboxItem("Microsoft.Practices.ServiceFactory.ServiceContracts.Service Contract ToolsToolboxTab",
					"@ServiceToolboxItem;Microsoft.Practices.ServiceFactory.ServiceContracts.Dsl.dll", 
					"Microsoft.Practices.ServiceFactory.ServiceContracts.ServiceToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"Service", 
					"@ServiceToolboxBitmap;Microsoft.Practices.ServiceFactory.ServiceContracts.Dsl.dll", 
					0xff00ff,
					Index = 0)]
	[VSShell::ProvideStaticToolboxItem("Microsoft.Practices.ServiceFactory.ServiceContracts.Service Contract ToolsToolboxTab",
					"@ServiceContractToolboxItem;Microsoft.Practices.ServiceFactory.ServiceContracts.Dsl.dll", 
					"Microsoft.Practices.ServiceFactory.ServiceContracts.ServiceContractToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"ServiceContract", 
					"@ServiceContractToolboxBitmap;Microsoft.Practices.ServiceFactory.ServiceContracts.Dsl.dll", 
					0xff00ff,
					Index = 1)]
	[VSShell::ProvideStaticToolboxItem("Microsoft.Practices.ServiceFactory.ServiceContracts.Service Contract ToolsToolboxTab",
					"@OperationToolboxItem;Microsoft.Practices.ServiceFactory.ServiceContracts.Dsl.dll", 
					"Microsoft.Practices.ServiceFactory.ServiceContracts.OperationToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"Operation", 
					"@OperationToolboxBitmap;Microsoft.Practices.ServiceFactory.ServiceContracts.Dsl.dll", 
					0xff00ff,
					Index = 2)]
	[VSShell::ProvideStaticToolboxItem("Microsoft.Practices.ServiceFactory.ServiceContracts.Service Contract ToolsToolboxTab",
					"@MessageToolboxItem;Microsoft.Practices.ServiceFactory.ServiceContracts.Dsl.dll", 
					"Microsoft.Practices.ServiceFactory.ServiceContracts.MessageToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"Message", 
					"@MessageToolboxBitmap;Microsoft.Practices.ServiceFactory.ServiceContracts.Dsl.dll", 
					0xff00ff,
					Index = 3)]
	[VSShell::ProvideStaticToolboxItem("Microsoft.Practices.ServiceFactory.ServiceContracts.Service Contract ToolsToolboxTab",
					"@XsdMessageToolboxItem;Microsoft.Practices.ServiceFactory.ServiceContracts.Dsl.dll", 
					"Microsoft.Practices.ServiceFactory.ServiceContracts.XsdMessageToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"XsdMessage", 
					"@XsdMessageToolboxBitmap;Microsoft.Practices.ServiceFactory.ServiceContracts.Dsl.dll", 
					0xff00ff,
					Index = 4)]
	[VSShell::ProvideStaticToolboxItem("Microsoft.Practices.ServiceFactory.ServiceContracts.Service Contract ToolsToolboxTab",
					"@ConnectToolToolboxItem;Microsoft.Practices.ServiceFactory.ServiceContracts.Dsl.dll", 
					"Microsoft.Practices.ServiceFactory.ServiceContracts.ConnectToolToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"ConnectTool", 
					"@ConnectToolToolboxBitmap;Microsoft.Practices.ServiceFactory.ServiceContracts.Dsl.dll", 
					0xff00ff,
					Index = 5)]
	[VSShell::ProvideEditorFactory(typeof(ServiceContractDslEditorFactory), 103, TrustLevel = VSShellInterop::__VSEDITORTRUSTLEVEL.ETL_AlwaysTrusted)]
	[VSShell::ProvideEditorExtension(typeof(ServiceContractDslEditorFactory), "." + Constants.DesignerFileExtension, 50)]
	[VSShell::ProvideEditorLogicalView(typeof(ServiceContractDslEditorFactory), "{7651A702-06E5-11D1-8EBD-00A0C90F26EA}")] // Designer logical view GUID i.e. VSConstants.LOGVIEWID_Designer
	[DslShell::ProvideRelatedFile("." + Constants.DesignerFileExtension, Constants.DefaultDiagramExtension,
		ProjectSystem = DslShell::ProvideRelatedFileAttribute.CSharpProjectGuid,
		FileOptions = DslShell::RelatedFileType.FileName)]
	[DslShell::ProvideRelatedFile("." + Constants.DesignerFileExtension, Constants.DefaultDiagramExtension,
		ProjectSystem = DslShell::ProvideRelatedFileAttribute.VisualBasicProjectGuid,
		FileOptions = DslShell::RelatedFileType.FileName)]
	[DslShell::RegisterAsDslToolsEditor]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[DslShell::ProvideBindingPath]
	[DslShell::ProvideXmlEditorChooserBlockSxSWithXmlEditor(@"ServiceContractDsl", typeof(ServiceContractDslEditorFactory))]

	internal abstract partial class ServiceContractDslPackageBase : DslShell::ModelingPackage
	{
		protected global::Microsoft.Practices.ServiceFactory.ServiceContracts.ServiceContractDslToolboxHelper toolboxHelper;	
		
		/// <summary>
		/// Initialization method called by the package base class when this package is loaded.
		/// </summary>
		protected override void Initialize()
		{
			base.Initialize();

			// Register the editor factory used to create the DSL editor.
			this.RegisterEditorFactory(new ServiceContractDslEditorFactory(this));
			
			// Initialize the toolbox helper
			toolboxHelper = new global::Microsoft.Practices.ServiceFactory.ServiceContracts.ServiceContractDslToolboxHelper(this);

			// Create the command set that handles menu commands provided by this package.
			ServiceContractDslCommandSet commandSet = new ServiceContractDslCommandSet(this);
			commandSet.Initialize();
			
			// Create the command set that handles cut/copy/paste commands provided by this package.
			ServiceContractDslClipboardCommandSet clipboardCommandSet = new ServiceContractDslClipboardCommandSet(this);
			clipboardCommandSet.Initialize();
			
			// Register the model explorer tool window for this DSL.
			this.AddToolWindow(typeof(ServiceContractDslExplorerToolWindow));

			// Initialize Extension Registars
			// this is a partial method call
			this.InitializeExtensions();

			// Add dynamic toolbox items
			this.SetupDynamicToolbox();
		}

		/// <summary>
		/// Partial method to initialize ExtensionRegistrars (if any) in the DslPackage
		/// </summary>
		partial void InitializeExtensions();
		
		/// <summary>
		/// Returns any dynamic tool items for the designer
		/// </summary>
		/// <remarks>The default implementation is to return the list of items from the generated toolbox helper.</remarks>
		protected override global::System.Collections.Generic.IList<DslDesign::ModelingToolboxItem> CreateToolboxItems()
		{
			try
			{
				Debug.Assert(toolboxHelper != null, "Toolbox helper is not initialized");
				return toolboxHelper.CreateToolboxItems();
			}
			catch(global::System.Exception e)
			{
				global::System.Diagnostics.Debug.Fail("Exception thrown during toolbox item creation.  This may result in Package Load Failure:\r\n\r\n" + e);
				throw;
			}
		}
		
		
		/// <summary>
		/// Given a toolbox item "unique ID" and a data format identifier, returns the content of
		/// the data format. 
		/// </summary>
		/// <param name="itemId">The unique ToolboxItem to retrieve data for</param>
		/// <param name="format">The desired format of the resulting data</param>
		protected override object GetToolboxItemData(string itemId, DataFormats.Format format)
		{
			Debug.Assert(toolboxHelper != null, "Toolbox helper is not initialized");
		
			// Retrieve the specified ToolboxItem from the DSL
			return toolboxHelper.GetToolboxItemData(itemId, format);
		}
	}

}

//
// Package attributes which may need to change are placed on the partial class below, rather than in the main include file.
//
namespace Microsoft.Practices.ServiceFactory.ServiceContracts
{
	/// <summary>
	/// Double-derived class to allow easier code customization.
	/// </summary>
	[VSShell::ProvideMenuResource("1000.ctmenu", 18)]
	[VSShell::ProvideToolboxItems(1)]
	[global::Microsoft.VisualStudio.TextTemplating.VSHost.ProvideDirectiveProcessor(typeof(global::Microsoft.Practices.ServiceFactory.ServiceContracts.ServiceContractDslDirectiveProcessor), global::Microsoft.Practices.ServiceFactory.ServiceContracts.ServiceContractDslDirectiveProcessor.ServiceContractDslDirectiveProcessorName, "A directive processor that provides access to ServiceContractDsl files")]
	[global::System.Runtime.InteropServices.Guid(Constants.ServiceContractDslPackageId)]
	internal sealed partial class ServiceContractDslPackage : ServiceContractDslPackageBase
	{
	}
}