using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegates
{
	public sealed class HpChangedEventArgs : EventArgs
	{
		public int hp;
		public HpChangedEventArgs(int hp) => this.hp = hp;
	}
}
