﻿using AssemblyLib.Utils;using System;using System.Collections.Generic;using System.Collections.ObjectModel;using System.Linq;using System.Text;using System.Threading.Tasks;namespace AssemblyLib.AssemblyModels{	public class NDRTRafterJointClipModel : Notifier	{		public NDRTRafterJointClipModel()		{					Rafter = "";			A = "";			B = "";			C = "";			D = "";			E = "";			F = "";			G = "";			H = "";			I = "";			A1 = "";			B1 = "";		}				private string _Rafter;		public string Rafter			{				get { return _Rafter; }				set				{					_Rafter = value;					OnPropertyChanged(nameof(Rafter));				}			}				private string _A;		public string A			{				get { return _A; }				set				{					_A = value;					OnPropertyChanged(nameof(A));				}			}				private string _B;		public string B			{				get { return _B; }				set				{					_B = value;					OnPropertyChanged(nameof(B));				}			}				private string _C;		public string C			{				get { return _C; }				set				{					_C = value;					OnPropertyChanged(nameof(C));				}			}				private string _D;		public string D			{				get { return _D; }				set				{					_D = value;					OnPropertyChanged(nameof(D));				}			}				private string _E;		public string E			{				get { return _E; }				set				{					_E = value;					OnPropertyChanged(nameof(E));				}			}				private string _F;		public string F			{				get { return _F; }				set				{					_F = value;					OnPropertyChanged(nameof(F));				}			}				private string _G;		public string G			{				get { return _G; }				set				{					_G = value;					OnPropertyChanged(nameof(G));				}			}				private string _H;		public string H			{				get { return _H; }				set				{					_H = value;					OnPropertyChanged(nameof(H));				}			}				private string _I;		public string I			{				get { return _I; }				set				{					_I = value;					OnPropertyChanged(nameof(I));				}			}				private string _A1;		public string A1			{				get { return _A1; }				set				{					_A1 = value;					OnPropertyChanged(nameof(A1));				}			}				private string _B1;		public string B1			{				get { return _B1; }				set				{					_B1 = value;					OnPropertyChanged(nameof(B1));				}			}			}}