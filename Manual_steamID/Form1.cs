using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using SpooferHDDID;

namespace Manual_steamID
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			this.InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);

        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }


        private void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				Process[] processesByName = Process.GetProcessesByName("hl");
				if (processesByName.Length != 0)
				{
					IntPtr[] array = new IntPtr[1024];
					IntPtr lphModule = GCHandle.Alloc(array, GCHandleType.Pinned).AddrOfPinnedObject();
					uint cb = (uint)(Marshal.SizeOf(typeof(IntPtr)) * array.Length);
					uint num = 0u;
					if (processesByName[0].ProcessName == "hl" && API.EnumProcessModules(processesByName[0].Handle, lphModule, cb, out num) == 1)
					{
						if (pId == -1)
						{
							object obj = lockObject;
							lock (obj)
							{
								pId = processesByName[0].Id;
								baseAdres = processesByName[0].MainModule.BaseAddress;
							}
						}
						label3.Text = "Runned";
                        label3.ForeColor = Color.Green;


                    }
                }
				else
				{
					pId = -1;
					baseAdres = IntPtr.Zero;
					label3.Text = "Wait";
                    label3.ForeColor = Color.Red;


                }
                Process[] processesByName2 = Process.GetProcessesByName("Injected");
				if (processesByName2.Length != 0)
				{
					IntPtr[] array2 = new IntPtr[1024];
					IntPtr lphModule2 = GCHandle.Alloc(array2, GCHandleType.Pinned).AddrOfPinnedObject();
					uint cb2 = (uint)(Marshal.SizeOf(typeof(IntPtr)) * array2.Length);
					uint num2 = 0u;
					if (processesByName2[0].ProcessName == "Injected" && API.EnumProcessModules(processesByName2[0].Handle, lphModule2, cb2, out num2) == 1)
					{
                        label4.Text = "Runned";
                        label4.ForeColor = Color.Green;


                    }
                }
				else
				{
					label4.Text = "Wait";
                    label4.ForeColor = Color.Red;

                }
                if (label3.Text == "Runned" && label4.Text == "Runned")
				{
                    button1.Enabled = true;
					ok = true;
				}
				else if (ok)
				{
					button1.Enabled = false;
					ok = false;
					if (m != null)
					{
						m.Dispose();
						m = null;
					}
				}
			}
			catch (Exception)
			{
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ManualSetID();
		}

		private void ManualSetID()
		{
			m = new MemoryOperation(pId);
			string text = textBox2.Text;
			try
			{
				if (m != null)
				{
					int value = (int)baseAdres + 26949482;
					byte[] bytes = Encoding.ASCII.GetBytes(text);
					m.WriteProcessMemory((IntPtr)value, bytes);
				}
			}
			catch (Exception ex)
			{
				Exception ex3;

				Invoke(new Action(delegate()
				{
					MessageBox.Show(this, ex.Message + "\r\n" + ex.StackTrace, "ERROR");
				}));
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (ignore_events)
			{
				return;
			}
			ignore_events = true;
			TextBox textBox = sender as TextBox;
			long value = 0L;
			try
			{
				string name = textBox.Name;
				if (!(name == "textBox1"))
				{
					if (!(name == "textBox2"))
					{
						throw new Exception();
					}
					value = Convert.ToInt64(textBox.Text, 16);
				}
				else
				{
					value = long.Parse(textBox.Text);
				}
			}
			catch (Exception)
			{
			}
			if (textBox.Name != "txtDecimal")
			{
				textBox1.Text = value.ToString();
			}
			if (textBox.Name != "txtHexadecimal")
			{
				textBox2.Text = Convert.ToString(value, 16);
			}
			ignore_events = false;
		}

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void Mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private int pId = -1;

		public static IntPtr baseAdres;

		private object lockObject = new object();

		private bool ok;

		private MemoryOperation m;

		private bool ignore_events;

       
    }

}
