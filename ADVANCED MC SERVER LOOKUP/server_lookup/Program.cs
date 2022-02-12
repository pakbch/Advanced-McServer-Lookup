using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Colorful;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;

namespace server_lookup
{
	// Token: 0x02000002 RID: 2
	internal class Program
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		private static void Main(string[] args)
		{
			for (;;)
			{
				Console.Clear();
				Console.Title = "Advanced Minecraft server lookup v2 by MegaPower";
				WebClient webClient = new WebClient();
				Console.Write("Tool created by MegaPower ", Color.LightPink);
				Console.WriteLine("(cracked.to/MegaPower)", Color.Aqua);
				Console.WriteLine(" ");
				Console.Write("Please type the server ip: ", Color.Gray);
				string text = Console.ReadLine();
				if (text == "")
				{
					Console.WriteLine("Please type the ip!");
					Task.Delay(500).Wait();
					Console.Write(" ");
					Console.Write("\nPress 'Enter' to restart", Color.LightBlue);
					while (Console.ReadKey().Key != ConsoleKey.Enter)
					{
					}
				}
				else
				{
					Console.WriteLine(" ");
					object arg = JsonConvert.DeserializeObject<object>(webClient.DownloadString("https://api.mcsrvstat.us/2/" + text));
					if (Program.<>o__0.<>p__2 == null)
					{
						Program.<>o__0.<>p__2 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> target = Program.<>o__0.<>p__2.Target;
					CallSite <>p__ = Program.<>o__0.<>p__2;
					if (Program.<>o__0.<>p__1 == null)
					{
						Program.<>o__0.<>p__1 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Program), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, bool, object> target2 = Program.<>o__0.<>p__1.Target;
					CallSite <>p__2 = Program.<>o__0.<>p__1;
					if (Program.<>o__0.<>p__0 == null)
					{
						Program.<>o__0.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "online", typeof(Program), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					if (target(<>p__, target2(<>p__2, Program.<>o__0.<>p__0.Target(Program.<>o__0.<>p__0, arg), false)))
					{
						Console.WriteLine(" ");
						Console.WriteLine("Server is offline/Invalid IP", Color.Red);
						Task.Delay(500).Wait();
						Console.Write(" ");
						Console.Write("\nPress 'Enter' to restart", Color.LightBlue);
						while (Console.ReadKey().Key != ConsoleKey.Enter)
						{
						}
					}
					else
					{
						if (Program.<>o__0.<>p__6 == null)
						{
							Program.<>o__0.<>p__6 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Program)));
						}
						Func<CallSite, object, string> target3 = Program.<>o__0.<>p__6.Target;
						CallSite <>p__3 = Program.<>o__0.<>p__6;
						if (Program.<>o__0.<>p__5 == null)
						{
							Program.<>o__0.<>p__5 = CallSite<Func<CallSite, WebClient, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "DownloadString", null, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, WebClient, object, object> target4 = Program.<>o__0.<>p__5.Target;
						CallSite <>p__4 = Program.<>o__0.<>p__5;
						WebClient arg2 = webClient;
						if (Program.<>o__0.<>p__4 == null)
						{
							Program.<>o__0.<>p__4 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, string, object, object> target5 = Program.<>o__0.<>p__4.Target;
						CallSite <>p__5 = Program.<>o__0.<>p__4;
						string arg3 = "http://extreme-ip-lookup.com/json/";
						if (Program.<>o__0.<>p__3 == null)
						{
							Program.<>o__0.<>p__3 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "ip", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						object arg4 = JsonConvert.DeserializeObject<object>(target3(<>p__3, target4(<>p__4, arg2, target5(<>p__5, arg3, Program.<>o__0.<>p__3.Target(Program.<>o__0.<>p__3, arg)))));
						Console.Write("+ ", Color.Aqua);
						Console.Write("IP: ", Color.SkyBlue);
						if (Program.<>o__0.<>p__8 == null)
						{
							Program.<>o__0.<>p__8 = CallSite<Action<CallSite, Type, object, Color>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "WriteLine", null, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						Action<CallSite, Type, object, Color> target6 = Program.<>o__0.<>p__8.Target;
						CallSite <>p__6 = Program.<>o__0.<>p__8;
						Type typeFromHandle = typeof(Console);
						if (Program.<>o__0.<>p__7 == null)
						{
							Program.<>o__0.<>p__7 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "ip", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						target6(<>p__6, typeFromHandle, Program.<>o__0.<>p__7.Target(Program.<>o__0.<>p__7, arg), Color.LightGray);
						Console.Write("+ ", Color.Aqua);
						Console.Write("PORT: ", Color.SkyBlue);
						if (Program.<>o__0.<>p__10 == null)
						{
							Program.<>o__0.<>p__10 = CallSite<Action<CallSite, Type, object, Color>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "WriteLine", null, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						Action<CallSite, Type, object, Color> target7 = Program.<>o__0.<>p__10.Target;
						CallSite <>p__7 = Program.<>o__0.<>p__10;
						Type typeFromHandle2 = typeof(Console);
						if (Program.<>o__0.<>p__9 == null)
						{
							Program.<>o__0.<>p__9 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "port", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						target7(<>p__7, typeFromHandle2, Program.<>o__0.<>p__9.Target(Program.<>o__0.<>p__9, arg), Color.LightGray);
						Console.WriteLine(" ");
						Console.Write("+ ", Color.Aqua);
						Console.Write("ISP: ", Color.DarkOrange);
						if (Program.<>o__0.<>p__12 == null)
						{
							Program.<>o__0.<>p__12 = CallSite<Action<CallSite, Type, object, Color>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "WriteLine", null, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						Action<CallSite, Type, object, Color> target8 = Program.<>o__0.<>p__12.Target;
						CallSite <>p__8 = Program.<>o__0.<>p__12;
						Type typeFromHandle3 = typeof(Console);
						if (Program.<>o__0.<>p__11 == null)
						{
							Program.<>o__0.<>p__11 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "isp", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						target8(<>p__8, typeFromHandle3, Program.<>o__0.<>p__11.Target(Program.<>o__0.<>p__11, arg4), Color.LightGray);
						Console.WriteLine(" ");
						Console.Write("+ ", Color.Aqua);
						Console.Write("Country: ", Color.Yellow);
						if (Program.<>o__0.<>p__14 == null)
						{
							Program.<>o__0.<>p__14 = CallSite<Action<CallSite, Type, object, Color>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "WriteLine", null, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						Action<CallSite, Type, object, Color> target9 = Program.<>o__0.<>p__14.Target;
						CallSite <>p__9 = Program.<>o__0.<>p__14;
						Type typeFromHandle4 = typeof(Console);
						if (Program.<>o__0.<>p__13 == null)
						{
							Program.<>o__0.<>p__13 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "country", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						target9(<>p__9, typeFromHandle4, Program.<>o__0.<>p__13.Target(Program.<>o__0.<>p__13, arg4), Color.LightCyan);
						Console.WriteLine(" ");
						Console.Write("+ ", Color.Aqua);
						Console.Write("Region: ", Color.OrangeRed);
						if (Program.<>o__0.<>p__16 == null)
						{
							Program.<>o__0.<>p__16 = CallSite<Action<CallSite, Type, object, Color>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "WriteLine", null, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						Action<CallSite, Type, object, Color> target10 = Program.<>o__0.<>p__16.Target;
						CallSite <>p__10 = Program.<>o__0.<>p__16;
						Type typeFromHandle5 = typeof(Console);
						if (Program.<>o__0.<>p__15 == null)
						{
							Program.<>o__0.<>p__15 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "region", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						target10(<>p__10, typeFromHandle5, Program.<>o__0.<>p__15.Target(Program.<>o__0.<>p__15, arg4), Color.LightCyan);
						Console.WriteLine(" ");
						Console.WriteLine(" ");
						Console.Write("+ ", Color.Aqua);
						Console.Write("players: ", Color.Aqua);
						if (Program.<>o__0.<>p__19 == null)
						{
							Program.<>o__0.<>p__19 = CallSite<Action<CallSite, Type, object, Color>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Write", null, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						Action<CallSite, Type, object, Color> target11 = Program.<>o__0.<>p__19.Target;
						CallSite <>p__11 = Program.<>o__0.<>p__19;
						Type typeFromHandle6 = typeof(Console);
						if (Program.<>o__0.<>p__18 == null)
						{
							Program.<>o__0.<>p__18 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "online", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object> target12 = Program.<>o__0.<>p__18.Target;
						CallSite <>p__12 = Program.<>o__0.<>p__18;
						if (Program.<>o__0.<>p__17 == null)
						{
							Program.<>o__0.<>p__17 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "players", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						target11(<>p__11, typeFromHandle6, target12(<>p__12, Program.<>o__0.<>p__17.Target(Program.<>o__0.<>p__17, arg)), Color.Gray);
						if (Program.<>o__0.<>p__23 == null)
						{
							Program.<>o__0.<>p__23 = CallSite<Action<CallSite, Type, object, Color>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "WriteLine", null, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						Action<CallSite, Type, object, Color> target13 = Program.<>o__0.<>p__23.Target;
						CallSite <>p__13 = Program.<>o__0.<>p__23;
						Type typeFromHandle7 = typeof(Console);
						if (Program.<>o__0.<>p__22 == null)
						{
							Program.<>o__0.<>p__22 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, string, object, object> target14 = Program.<>o__0.<>p__22.Target;
						CallSite <>p__14 = Program.<>o__0.<>p__22;
						string arg5 = "/";
						if (Program.<>o__0.<>p__21 == null)
						{
							Program.<>o__0.<>p__21 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "max", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object> target15 = Program.<>o__0.<>p__21.Target;
						CallSite <>p__15 = Program.<>o__0.<>p__21;
						if (Program.<>o__0.<>p__20 == null)
						{
							Program.<>o__0.<>p__20 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "players", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						target13(<>p__13, typeFromHandle7, target14(<>p__14, arg5, target15(<>p__15, Program.<>o__0.<>p__20.Target(Program.<>o__0.<>p__20, arg))), Color.LightCoral);
						Console.WriteLine(" ");
						if (Program.<>o__0.<>p__27 == null)
						{
							Program.<>o__0.<>p__27 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, bool> target16 = Program.<>o__0.<>p__27.Target;
						CallSite <>p__16 = Program.<>o__0.<>p__27;
						if (Program.<>o__0.<>p__26 == null)
						{
							Program.<>o__0.<>p__26 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, object, object> target17 = Program.<>o__0.<>p__26.Target;
						CallSite <>p__17 = Program.<>o__0.<>p__26;
						if (Program.<>o__0.<>p__25 == null)
						{
							Program.<>o__0.<>p__25 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "list", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object> target18 = Program.<>o__0.<>p__25.Target;
						CallSite <>p__18 = Program.<>o__0.<>p__25;
						if (Program.<>o__0.<>p__24 == null)
						{
							Program.<>o__0.<>p__24 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "players", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						if (!target16(<>p__16, target17(<>p__17, target18(<>p__18, Program.<>o__0.<>p__24.Target(Program.<>o__0.<>p__24, arg)), null)))
						{
							Console.Write("+ ", Color.Aqua);
							if (Program.<>o__0.<>p__31 == null)
							{
								Program.<>o__0.<>p__31 = CallSite<Action<CallSite, Type, object, Color>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "WriteLine", null, typeof(Program), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
								}));
							}
							Action<CallSite, Type, object, Color> target19 = Program.<>o__0.<>p__31.Target;
							CallSite <>p__19 = Program.<>o__0.<>p__31;
							Type typeFromHandle8 = typeof(Console);
							if (Program.<>o__0.<>p__30 == null)
							{
								Program.<>o__0.<>p__30 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Program), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, string, object, object> target20 = Program.<>o__0.<>p__30.Target;
							CallSite <>p__20 = Program.<>o__0.<>p__30;
							string arg6 = "player list: ";
							if (Program.<>o__0.<>p__29 == null)
							{
								Program.<>o__0.<>p__29 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "list", typeof(Program), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, object> target21 = Program.<>o__0.<>p__29.Target;
							CallSite <>p__21 = Program.<>o__0.<>p__29;
							if (Program.<>o__0.<>p__28 == null)
							{
								Program.<>o__0.<>p__28 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "players", typeof(Program), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							target19(<>p__19, typeFromHandle8, target20(<>p__20, arg6, target21(<>p__21, Program.<>o__0.<>p__28.Target(Program.<>o__0.<>p__28, arg))), Color.Aqua);
						}
						Console.Write("+ ", Color.Aqua);
						Console.Write("version: ", Color.Yellow);
						if (Program.<>o__0.<>p__33 == null)
						{
							Program.<>o__0.<>p__33 = CallSite<Action<CallSite, Type, object, Color>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "WriteLine", null, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						Action<CallSite, Type, object, Color> target22 = Program.<>o__0.<>p__33.Target;
						CallSite <>p__22 = Program.<>o__0.<>p__33;
						Type typeFromHandle9 = typeof(Console);
						if (Program.<>o__0.<>p__32 == null)
						{
							Program.<>o__0.<>p__32 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "version", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						target22(<>p__22, typeFromHandle9, Program.<>o__0.<>p__32.Target(Program.<>o__0.<>p__32, arg), Color.LightGray);
						Console.Write("+ ", Color.Aqua);
						Console.Write("protocol version: ", Color.Yellow);
						if (Program.<>o__0.<>p__35 == null)
						{
							Program.<>o__0.<>p__35 = CallSite<Action<CallSite, Type, object, Color>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "WriteLine", null, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						Action<CallSite, Type, object, Color> target23 = Program.<>o__0.<>p__35.Target;
						CallSite <>p__23 = Program.<>o__0.<>p__35;
						Type typeFromHandle10 = typeof(Console);
						if (Program.<>o__0.<>p__34 == null)
						{
							Program.<>o__0.<>p__34 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "protocol", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						target23(<>p__23, typeFromHandle10, Program.<>o__0.<>p__34.Target(Program.<>o__0.<>p__34, arg), Color.LightGray);
						Console.WriteLine(" ");
						if (Program.<>o__0.<>p__38 == null)
						{
							Program.<>o__0.<>p__38 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, bool> target24 = Program.<>o__0.<>p__38.Target;
						CallSite <>p__24 = Program.<>o__0.<>p__38;
						if (Program.<>o__0.<>p__37 == null)
						{
							Program.<>o__0.<>p__37 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, object, object> target25 = Program.<>o__0.<>p__37.Target;
						CallSite <>p__25 = Program.<>o__0.<>p__37;
						if (Program.<>o__0.<>p__36 == null)
						{
							Program.<>o__0.<>p__36 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "software", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						if (!target24(<>p__24, target25(<>p__25, Program.<>o__0.<>p__36.Target(Program.<>o__0.<>p__36, arg), null)))
						{
							Console.Write("+ ", Color.Aqua);
							if (Program.<>o__0.<>p__41 == null)
							{
								Program.<>o__0.<>p__41 = CallSite<Action<CallSite, Type, object, Color>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "WriteLine", null, typeof(Program), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
								}));
							}
							Action<CallSite, Type, object, Color> target26 = Program.<>o__0.<>p__41.Target;
							CallSite <>p__26 = Program.<>o__0.<>p__41;
							Type typeFromHandle11 = typeof(Console);
							if (Program.<>o__0.<>p__40 == null)
							{
								Program.<>o__0.<>p__40 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Program), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, string, object, object> target27 = Program.<>o__0.<>p__40.Target;
							CallSite <>p__27 = Program.<>o__0.<>p__40;
							string arg7 = "software: ";
							if (Program.<>o__0.<>p__39 == null)
							{
								Program.<>o__0.<>p__39 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "software", typeof(Program), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							target26(<>p__26, typeFromHandle11, target27(<>p__27, arg7, Program.<>o__0.<>p__39.Target(Program.<>o__0.<>p__39, arg)), Color.Gray);
						}
						Console.WriteLine(" ");
						Console.Write("+ ", Color.Aqua);
						if (Program.<>o__0.<>p__45 == null)
						{
							Program.<>o__0.<>p__45 = CallSite<Action<CallSite, Type, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "WriteLine", null, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Action<CallSite, Type, object> target28 = Program.<>o__0.<>p__45.Target;
						CallSite <>p__28 = Program.<>o__0.<>p__45;
						Type typeFromHandle12 = typeof(Console);
						if (Program.<>o__0.<>p__44 == null)
						{
							Program.<>o__0.<>p__44 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, string, object, object> target29 = Program.<>o__0.<>p__44.Target;
						CallSite <>p__29 = Program.<>o__0.<>p__44;
						string arg8 = "query: ";
						if (Program.<>o__0.<>p__43 == null)
						{
							Program.<>o__0.<>p__43 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "query", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object> target30 = Program.<>o__0.<>p__43.Target;
						CallSite <>p__30 = Program.<>o__0.<>p__43;
						if (Program.<>o__0.<>p__42 == null)
						{
							Program.<>o__0.<>p__42 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "debug", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						target28(<>p__28, typeFromHandle12, target29(<>p__29, arg8, target30(<>p__30, Program.<>o__0.<>p__42.Target(Program.<>o__0.<>p__42, arg))));
						Console.WriteLine(" ");
						Console.Write("+ ", Color.Aqua);
						Console.WriteLine("motd: ", Color.LightCyan);
						if (Program.<>o__0.<>p__48 == null)
						{
							Program.<>o__0.<>p__48 = CallSite<Action<CallSite, Type, object, Color>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "WriteLine", null, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						Action<CallSite, Type, object, Color> target31 = Program.<>o__0.<>p__48.Target;
						CallSite <>p__31 = Program.<>o__0.<>p__48;
						Type typeFromHandle13 = typeof(Console);
						if (Program.<>o__0.<>p__47 == null)
						{
							Program.<>o__0.<>p__47 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "clean", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object> target32 = Program.<>o__0.<>p__47.Target;
						CallSite <>p__32 = Program.<>o__0.<>p__47;
						if (Program.<>o__0.<>p__46 == null)
						{
							Program.<>o__0.<>p__46 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "motd", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						target31(<>p__31, typeFromHandle13, target32(<>p__32, Program.<>o__0.<>p__46.Target(Program.<>o__0.<>p__46, arg)), Color.Aqua);
						Console.WriteLine(" ");
						if (Program.<>o__0.<>p__51 == null)
						{
							Program.<>o__0.<>p__51 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, bool> target33 = Program.<>o__0.<>p__51.Target;
						CallSite <>p__33 = Program.<>o__0.<>p__51;
						if (Program.<>o__0.<>p__50 == null)
						{
							Program.<>o__0.<>p__50 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, object, object> target34 = Program.<>o__0.<>p__50.Target;
						CallSite <>p__34 = Program.<>o__0.<>p__50;
						if (Program.<>o__0.<>p__49 == null)
						{
							Program.<>o__0.<>p__49 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "plugins", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						if (!target33(<>p__33, target34(<>p__34, Program.<>o__0.<>p__49.Target(Program.<>o__0.<>p__49, arg), null)))
						{
							Console.Write("+ ", Color.Aqua);
							if (Program.<>o__0.<>p__55 == null)
							{
								Program.<>o__0.<>p__55 = CallSite<Action<CallSite, Type, object, Color>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "WriteLine", null, typeof(Program), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
								}));
							}
							Action<CallSite, Type, object, Color> target35 = Program.<>o__0.<>p__55.Target;
							CallSite <>p__35 = Program.<>o__0.<>p__55;
							Type typeFromHandle14 = typeof(Console);
							if (Program.<>o__0.<>p__54 == null)
							{
								Program.<>o__0.<>p__54 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Program), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, string, object, object> target36 = Program.<>o__0.<>p__54.Target;
							CallSite <>p__36 = Program.<>o__0.<>p__54;
							string arg9 = "Detected Plugins list: ";
							if (Program.<>o__0.<>p__53 == null)
							{
								Program.<>o__0.<>p__53 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "raw", typeof(Program), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, object> target37 = Program.<>o__0.<>p__53.Target;
							CallSite <>p__37 = Program.<>o__0.<>p__53;
							if (Program.<>o__0.<>p__52 == null)
							{
								Program.<>o__0.<>p__52 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "plugins", typeof(Program), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							target35(<>p__35, typeFromHandle14, target36(<>p__36, arg9, target37(<>p__37, Program.<>o__0.<>p__52.Target(Program.<>o__0.<>p__52, arg))), Color.Aqua);
						}
						if (Program.<>o__0.<>p__58 == null)
						{
							Program.<>o__0.<>p__58 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, bool> target38 = Program.<>o__0.<>p__58.Target;
						CallSite <>p__38 = Program.<>o__0.<>p__58;
						if (Program.<>o__0.<>p__57 == null)
						{
							Program.<>o__0.<>p__57 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, object, object> target39 = Program.<>o__0.<>p__57.Target;
						CallSite <>p__39 = Program.<>o__0.<>p__57;
						if (Program.<>o__0.<>p__56 == null)
						{
							Program.<>o__0.<>p__56 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "mods", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						if (!target38(<>p__38, target39(<>p__39, Program.<>o__0.<>p__56.Target(Program.<>o__0.<>p__56, arg), null)))
						{
							Console.Write("+ ", Color.Aqua);
							if (Program.<>o__0.<>p__62 == null)
							{
								Program.<>o__0.<>p__62 = CallSite<Action<CallSite, Type, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "WriteLine", null, typeof(Program), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Action<CallSite, Type, object> target40 = Program.<>o__0.<>p__62.Target;
							CallSite <>p__40 = Program.<>o__0.<>p__62;
							Type typeFromHandle15 = typeof(Console);
							if (Program.<>o__0.<>p__61 == null)
							{
								Program.<>o__0.<>p__61 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Program), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, string, object, object> target41 = Program.<>o__0.<>p__61.Target;
							CallSite <>p__41 = Program.<>o__0.<>p__61;
							string arg10 = "mods: ";
							if (Program.<>o__0.<>p__60 == null)
							{
								Program.<>o__0.<>p__60 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "raw", typeof(Program), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, object> target42 = Program.<>o__0.<>p__60.Target;
							CallSite <>p__42 = Program.<>o__0.<>p__60;
							if (Program.<>o__0.<>p__59 == null)
							{
								Program.<>o__0.<>p__59 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "mods", typeof(Program), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							target40(<>p__40, typeFromHandle15, target41(<>p__41, arg10, target42(<>p__42, Program.<>o__0.<>p__59.Target(Program.<>o__0.<>p__59, arg))));
						}
						if (Program.<>o__0.<>p__65 == null)
						{
							Program.<>o__0.<>p__65 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, bool> target43 = Program.<>o__0.<>p__65.Target;
						CallSite <>p__43 = Program.<>o__0.<>p__65;
						if (Program.<>o__0.<>p__64 == null)
						{
							Program.<>o__0.<>p__64 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, object, object> target44 = Program.<>o__0.<>p__64.Target;
						CallSite <>p__44 = Program.<>o__0.<>p__64;
						if (Program.<>o__0.<>p__63 == null)
						{
							Program.<>o__0.<>p__63 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "info", typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						if (!target43(<>p__43, target44(<>p__44, Program.<>o__0.<>p__63.Target(Program.<>o__0.<>p__63, arg), null)))
						{
							Console.Write("+ ", Color.Aqua);
							if (Program.<>o__0.<>p__69 == null)
							{
								Program.<>o__0.<>p__69 = CallSite<Action<CallSite, Type, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "WriteLine", null, typeof(Program), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Action<CallSite, Type, object> target45 = Program.<>o__0.<>p__69.Target;
							CallSite <>p__45 = Program.<>o__0.<>p__69;
							Type typeFromHandle16 = typeof(Console);
							if (Program.<>o__0.<>p__68 == null)
							{
								Program.<>o__0.<>p__68 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Program), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, string, object, object> target46 = Program.<>o__0.<>p__68.Target;
							CallSite <>p__46 = Program.<>o__0.<>p__68;
							string arg11 = "info: ";
							if (Program.<>o__0.<>p__67 == null)
							{
								Program.<>o__0.<>p__67 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "clean", typeof(Program), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, object> target47 = Program.<>o__0.<>p__67.Target;
							CallSite <>p__47 = Program.<>o__0.<>p__67;
							if (Program.<>o__0.<>p__66 == null)
							{
								Program.<>o__0.<>p__66 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "info", typeof(Program), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							target45(<>p__45, typeFromHandle16, target46(<>p__46, arg11, target47(<>p__47, Program.<>o__0.<>p__66.Target(Program.<>o__0.<>p__66, arg))));
						}
						Task.Delay(1200).Wait();
						Console.Write(" ");
						Console.Write("\nPress 'Enter' to restart", Color.LightBlue);
						while (Console.ReadKey().Key != ConsoleKey.Enter)
						{
						}
					}
				}
			}
		}
	}
}
