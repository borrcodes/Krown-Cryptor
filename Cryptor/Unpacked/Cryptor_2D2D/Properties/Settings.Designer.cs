using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Cryptor_2D2D.Properties
{
	// Token: 0x02000011 RID: 17
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00006C88 File Offset: 0x00004E88
		public static Settings Default
		{
			get
			{
				return Settings.HostType;
			}
		}

		// Token: 0x0400008C RID: 140
		private static Settings HostType = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
