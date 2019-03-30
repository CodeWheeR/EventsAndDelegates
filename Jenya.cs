using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegates
{
	public class Jenya
	{
		List<EventHandler<HpChangedEventArgs>> _hpChangedEvents = new List<EventHandler<HpChangedEventArgs>>();
		public event EventHandler<HpChangedEventArgs> HpChanged;
		int _hp;
		public int HP
		{
			get => _hp;
			set
			{
				_hp = value;
				OnHpChanged(this, new HpChangedEventArgs(value));
			}
		}

		~Jenya()
		{
			foreach (var i in _hpChangedEvents)
				HpChanged -= i;
		}
		
		public void OnHpChanged(object obj, HpChangedEventArgs e) 
			=> HpChanged?.Invoke(obj, e);

		public void HpChangedAddEvent(EventHandler<HpChangedEventArgs> action)
		{
			HpChanged += action;
			_hpChangedEvents.Add(action);
		}

		public void HpChangedRemoveEvent(EventHandler<HpChangedEventArgs> action)
		{
			HpChanged -= action;
			if (_hpChangedEvents.Contains(action))
				_hpChangedEvents.Remove(action);
		}

		public Jenya(int hp = 100)
		{
			_hp = hp;
		}
	}
}
