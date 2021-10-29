﻿using AssemblyLib.Utils;using System;using System.Collections.Generic;using System.Collections.ObjectModel;using System.Linq;using System.Text;using System.Threading.Tasks;namespace AssemblyLib.AssemblyModels{	public class RoofManholeModel : Notifier	{		public RoofManholeModel()		{					NPS = "";			D1 = "";			BCD = "";			D2 = "";			L = "";			RoofToManhole = "";			TopToManhole = "";			ManholeThickness = "";		}				private string _NPS;		public string NPS			{				get { return _NPS; }				set				{					_NPS = value;					OnPropertyChanged(nameof(NPS));				}			}				private string _D1;		public string D1			{				get { return _D1; }				set				{					_D1 = value;					OnPropertyChanged(nameof(D1));				}			}				private string _BCD;		public string BCD			{				get { return _BCD; }				set				{					_BCD = value;					OnPropertyChanged(nameof(BCD));				}			}				private string _D2;		public string D2			{				get { return _D2; }				set				{					_D2 = value;					OnPropertyChanged(nameof(D2));				}			}				private string _L;		public string L			{				get { return _L; }				set				{					_L = value;					OnPropertyChanged(nameof(L));				}			}				private string _RoofToManhole;		public string RoofToManhole			{				get { return _RoofToManhole; }				set				{					_RoofToManhole = value;					OnPropertyChanged(nameof(RoofToManhole));				}			}				private string _TopToManhole;		public string TopToManhole			{				get { return _TopToManhole; }				set				{					_TopToManhole = value;					OnPropertyChanged(nameof(TopToManhole));				}			}				private string _ManholeThickness;		public string ManholeThickness			{				get { return _ManholeThickness; }				set				{					_ManholeThickness = value;					OnPropertyChanged(nameof(ManholeThickness));				}			}			}}