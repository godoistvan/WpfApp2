using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    public class Tyuk : ObservableObject
    {
		private string name;
		private int eggcount;
		private bool isfed;

		public bool Isfed
		{
			get { return isfed; }
			set { isfed = value; }
		}

		public int Eggcount
		{
			get { return eggcount; }
			set { eggcount = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

	}
}
