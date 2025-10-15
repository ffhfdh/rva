using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokvijum.rva
{
	public class Semafor
	{
		string rezultat;

		public Semafor()
        {
			this.rezultat = "0";
        }

		private List<IObserverDogadjaja> observers = new List<IObserverDogadjaja>();

		public void PromeniReultat(string rezultat)
		{
			this.rezultat = rezultat;
			NotifyObservers();
		}

		public void RegisterObserver(IObserverDogadjaja observer)
		{
			observers.Add(observer);
		}

		public void UnregisterObserver(IObserverDogadjaja observer)
		{
			observers.Remove(observer);
		}

		public void NotifyObservers()
		{
			foreach (IObserverDogadjaja observer in observers)
			{
				observer.Update(rezultat);
			}
		}
	}
}
