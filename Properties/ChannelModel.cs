﻿using AssemblyLib.Utils;using System;using System.Collections.Generic;using System.Collections.ObjectModel;using System.Linq;using System.Text;using System.Threading.Tasks;namespace AssemblyLib.AssemblyModels{	public class ChannelModel : Notifier	{		public ChannelModel()		{					SIZE = "";			A = "";			B = "";			t1 = "";			t2 = "";			R1 = "";			R2 = "";		}				private string _SIZE;		public string SIZE			{				get { return _SIZE; }				set				{					_SIZE = value;					OnPropertyChanged(nameof(SIZE));				}			}				private string _A;		public string A			{				get { return _A; }				set				{					_A = value;					OnPropertyChanged(nameof(A));				}			}				private string _B;		public string B			{				get { return _B; }				set				{					_B = value;					OnPropertyChanged(nameof(B));				}			}				private string _t1;		public string t1			{				get { return _t1; }				set				{					_t1 = value;					OnPropertyChanged(nameof(t1));				}			}				private string _t2;		public string t2			{				get { return _t2; }				set				{					_t2 = value;					OnPropertyChanged(nameof(t2));				}			}				private string _R1;		public string R1			{				get { return _R1; }				set				{					_R1 = value;					OnPropertyChanged(nameof(R1));				}			}				private string _R2;		public string R2			{				get { return _R2; }				set				{					_R2 = value;					OnPropertyChanged(nameof(R2));				}			}			}}