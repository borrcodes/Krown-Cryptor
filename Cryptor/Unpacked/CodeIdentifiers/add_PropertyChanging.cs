using System;
using System.Windows.Forms;

namespace CodeIdentifiers
{
	// Token: 0x02000010 RID: 16
	internal static class add_PropertyChanging
	{
		// Token: 0x0600008F RID: 143 RVA: 0x00006C64 File Offset: 0x00004E64
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new EndChildrenCallback());
		}
	}
}
