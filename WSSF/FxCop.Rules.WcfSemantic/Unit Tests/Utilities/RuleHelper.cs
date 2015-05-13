//===============================================================================
// Microsoft patterns & practices
// Web Service Software Factory 2010
//===============================================================================
// Copyright (c) Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//===============================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.FxCop.Sdk;
using System.Reflection;

namespace Microsoft.Practices.FxCop.Rules.WcfSemantic.Tests.Utilities
{
	public static class RuleHelper
	{
		public static TypeNode GetTypeNodeFromType(Type type)
		{
			return AssemblyNode.GetModule(type.Assembly.Location).GetType(
				Identifier.For(type.Namespace), Identifier.For(type.Name));
		}

		public static Member GetMemberForOperation(TypeNode typeNode, string operationName)
		{
			return typeNode.GetMembersNamed(Identifier.For(operationName))[0];
		}
	}
}
