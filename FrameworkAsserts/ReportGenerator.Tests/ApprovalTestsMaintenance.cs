using ApprovalTests.Maintenance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ReportGenerator.Tests
{
	public class ApprovalTestsMaintenance
	{
		[Fact]
		public void Maintenance()
		{
			ApprovalMaintenance.VerifyNoAbandonedFiles();
		}
	}
}
