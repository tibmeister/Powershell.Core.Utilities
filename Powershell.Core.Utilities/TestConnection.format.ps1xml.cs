using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;

namespace Powershell.Core.Utilities
{
    internal sealed class DotNetTypes_Format_Ps1Xml
    {
        internal static IEnumerable<ExtendedTypeDefinition> GetFormatData()
        {
            yield return new ExtendedTypeDefinition(
                            @"System.Management.ManagementObject#root\cimv2\Win32_PingStatus",
                            ViewsOf_System_Management_ManagementObject_root_cimv2_Win32_PingStatus());

            yield return new ExtendedTypeDefinition(
                "Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_PingStatus",
                ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_PingStatus());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_ManagementObject_root_cimv2_Win32_PingStatus()
        {
            yield return new FormatViewDefinition(@"System.Management.ManagementObject#root\cimv2\Win32_PingStatus",
                TableControl.Create()
                    .AddHeader(label: "Source", width: 13)
                    .AddHeader(label: "Destination", width: 15)
                    .AddHeader(label: "IPV4Address", width: 16)
                    .AddHeader(label: "IPV6Address", width: 40)
                    .AddHeader(label: "Bytes", width: 8)
                    .AddHeader(label: "Time(ms)", width: 9)
                    .StartRowDefinition()
                        .AddPropertyColumn("__Server")
                        .AddPropertyColumn("Address")
                        .AddPropertyColumn("IPV4Address")
                        .AddPropertyColumn("IPV6Address")
                        .AddPropertyColumn("BufferSize")
                        .AddPropertyColumn("ResponseTime")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_PingStatus()
        {
            yield return new FormatViewDefinition("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_PingStatus",
                TableControl.Create()
                    .AddHeader(label: "Source", width: 13)
                    .AddHeader(label: "Destination", width: 15)
                    .AddHeader(label: "IPV4Address", width: 16)
                    .AddHeader(label: "IPV6Address", width: 40)
                    .AddHeader(label: "Bytes", width: 8)
                    .AddHeader(label: "Time(ms)", width: 9)
                    .StartRowDefinition()
                         .AddScriptBlockColumn(@"
							$sourceName = $_.PSComputerName;
							if($sourceName -eq ""."")
							{$sourceName = $env:COMPUTERNAME;}
							return $sourceName;
						")
                        .AddPropertyColumn("Address")
                        .AddPropertyColumn("IPV4Address")
                        .AddPropertyColumn("IPV6Address")
                        .AddPropertyColumn("BufferSize")
                        .AddPropertyColumn("ResponseTime")
                    .EndRowDefinition()
                .EndTable());
        }
    }
}
