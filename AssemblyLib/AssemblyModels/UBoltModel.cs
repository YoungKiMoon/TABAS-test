﻿using AssemblyLib.Utils;using System;using System.Collections.Generic;using System.Collections.ObjectModel;using System.Linq;using System.Text;using System.Threading.Tasks;namespace AssemblyLib.AssemblyModels{	public class UBoltModel : Notifier	{		public UBoltModel()		{					DN = "";			NPS = "";			SupportAngle = "";			D1D2 = "";			R = "";			P = "";			Q = "";			TypeAH = "";			TypeAE = "";			TypeBH = "";			TypeBE = "";			S = "";			D3 = "";		}				private string _DN;		public string DN			{				get { return _DN; }				set				{					_DN = value;					OnPropertyChanged(nameof(DN));				}			}				private string _NPS;		public string NPS			{				get { return _NPS; }				set				{					_NPS = value;					OnPropertyChanged(nameof(NPS));				}			}				private string _SupportAngle;		public string SupportAngle			{				get { return _SupportAngle; }				set				{					_SupportAngle = value;					OnPropertyChanged(nameof(SupportAngle));				}			}				private string _D1D2;		public string D1D2			{				get { return _D1D2; }				set				{					_D1D2 = value;					OnPropertyChanged(nameof(D1D2));				}			}				private string _R;		public string R			{				get { return _R; }				set				{					_R = value;					OnPropertyChanged(nameof(R));				}			}				private string _P;		public string P			{				get { return _P; }				set				{					_P = value;					OnPropertyChanged(nameof(P));				}			}				private string _Q;		public string Q			{				get { return _Q; }				set				{					_Q = value;					OnPropertyChanged(nameof(Q));				}			}				private string _TypeAH;		public string TypeAH			{				get { return _TypeAH; }				set				{					_TypeAH = value;					OnPropertyChanged(nameof(TypeAH));				}			}				private string _TypeAE;		public string TypeAE			{				get { return _TypeAE; }				set				{					_TypeAE = value;					OnPropertyChanged(nameof(TypeAE));				}			}				private string _TypeBH;		public string TypeBH			{				get { return _TypeBH; }				set				{					_TypeBH = value;					OnPropertyChanged(nameof(TypeBH));				}			}				private string _TypeBE;		public string TypeBE			{				get { return _TypeBE; }				set				{					_TypeBE = value;					OnPropertyChanged(nameof(TypeBE));				}			}				private string _S;		public string S			{				get { return _S; }				set				{					_S = value;					OnPropertyChanged(nameof(S));				}			}				private string _D3;		public string D3			{				get { return _D3; }				set				{					_D3 = value;					OnPropertyChanged(nameof(D3));				}			}			}}