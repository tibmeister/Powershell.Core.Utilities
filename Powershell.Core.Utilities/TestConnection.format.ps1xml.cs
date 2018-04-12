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
                TableControl.Create(false,true,false)
                    .AddHeader(label: "Source", width: 13, alignment: Alignment.Undefined)
                    .AddHeader(label: "Destination", width: 15, alignment: Alignment.Undefined)
                    .AddHeader(label: "IPV4Address", width: 16, alignment: Alignment.Undefined)
                    .AddHeader(label: "IPV6Address", width: 40, alignment: Alignment.Undefined)
                    .AddHeader(label: "Bytes", width: 8, alignment: Alignment.Undefined)
                    .AddHeader(label: "Time(ms)", width: 9, alignment: Alignment.Undefined)
                    .StartRowDefinition(false,null,null)
                        .AddPropertyColumn("__Server",Alignment.Undefined,null)
                        .AddPropertyColumn("Address", Alignment.Undefined, null)
                        .AddPropertyColumn("IPV4Address", Alignment.Undefined, null)
                        .AddPropertyColumn("IPV6Address", Alignment.Undefined, null)
                        .AddPropertyColumn("BufferSize", Alignment.Undefined, null)
                        .AddPropertyColumn("ResponseTime", Alignment.Undefined, null)
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_PingStatus()
        {
            yield return new FormatViewDefinition("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_PingStatus",
                TableControl.Create(false,true,false)
                    .AddHeader(label: "Source", width: 13, alignment: Alignment.Undefined)
                    .AddHeader(label: "Destination", width: 15, alignment: Alignment.Undefined)
                    .AddHeader(label: "IPV4Address", width: 16, alignment: Alignment.Undefined)
                    .AddHeader(label: "IPV6Address", width: 40, alignment: Alignment.Undefined)
                    .AddHeader(label: "Bytes", width: 8, alignment: Alignment.Undefined)
                    .AddHeader(label: "Time(ms)", width: 9, alignment: Alignment.Undefined)
                    .StartRowDefinition(false,null,null)
                         .AddScriptBlockColumn(@"
							$sourceName = $_.PSComputerName;
							if($sourceName -eq ""."")
							{$sourceName = $env:COMPUTERNAME;}
							return $sourceName;
						", Alignment.Undefined, null)
                        .AddPropertyColumn("Address", Alignment.Undefined, null)
                        .AddPropertyColumn("IPV4Address", Alignment.Undefined, null)
                        .AddPropertyColumn("IPV6Address", Alignment.Undefined, null)
                        .AddPropertyColumn("BufferSize", Alignment.Undefined, null)
                        .AddPropertyColumn("ResponseTime", Alignment.Undefined, null)
                    .EndRowDefinition()
                .EndTable());
        }
    }
}
