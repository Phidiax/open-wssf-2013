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
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Validation.Configuration;
using System.Collections.Specialized;

namespace Microsoft.Practices.ServiceFactory.Validation
{
    /// <summary/>
	public class NonEmptyStringValidator : StringLengthValidator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:NonEmptyStringValidator"/> class.
        /// </summary>
		public NonEmptyStringValidator()
			: base(1, int.MaxValue)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:NonEmptyStringValidator"/> class.
        /// </summary>
        /// <param name="errorMessage">Message posted to the validation context when
        /// validation rule fails.</param>
        public NonEmptyStringValidator(string errorMessage)
			: base(1, RangeBoundaryType.Inclusive, int.MaxValue, RangeBoundaryType.Inclusive, errorMessage)
        {
        }
    }
}
