﻿using AssemblyLib.Utils;using System;using System.Collections.Generic;using System.Collections.ObjectModel;using System.Linq;using System.Text;using System.Threading.Tasks;namespace AssemblyLib.AssemblyModels{	public class StructureCRTGirderInputModel : Notifier	{		public StructureCRTGirderInputModel()		{					No = "";			Radius = "";			Qty = "";			Size = "";		}				private string _No;		public string No			{				get { return _No; }				set				{					_No = value;					OnPropertyChanged(nameof(No));				}			}				private string _Radius;		public string Radius			{				get { return _Radius; }				set				{					_Radius = value;					OnPropertyChanged(nameof(Radius));				}			}				private string _Qty;		public string Qty			{				get { return _Qty; }				set				{					_Qty = value;					OnPropertyChanged(nameof(Qty));				}			}				private string _Size;		public string Size			{				get { return _Size; }				set				{					_Size = value;					OnPropertyChanged(nameof(Size));				}			}			}}