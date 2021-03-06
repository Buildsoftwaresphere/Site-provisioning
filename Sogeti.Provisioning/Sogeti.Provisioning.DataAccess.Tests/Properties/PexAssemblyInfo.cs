using System.Runtime.CompilerServices;
using Microsoft.Pex.Framework.Suppression;
// <copyright file="PexAssemblyInfo.cs">Copyright ©  2015</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("Sogeti.Provisioning.DataAccess")]
[assembly: PexInstrumentAssembly("Sogeti.Provisioning.Domain")]
[assembly: PexInstrumentAssembly("System.Configuration")]
[assembly: PexInstrumentAssembly("System.Core")]
[assembly: PexInstrumentAssembly("Sogeti.Provisioning.DataAccess.Interface")]
[assembly: PexInstrumentAssembly("Microsoft.Azure.Documents.Client")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Sogeti.Provisioning.Domain")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Configuration")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Sogeti.Provisioning.DataAccess.Interface")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.Azure.Documents.Client")]
[assembly: PexSuppressUninstrumentedMethodFromType("System.CultureAwareComparer")]
[assembly: PexInstrumentType(typeof(AsyncVoidMethodBuilder))]

