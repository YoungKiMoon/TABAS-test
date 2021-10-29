﻿using AssemblyLib.Utils;using System;using System.Collections.Generic;using System.Collections.ObjectModel;using System.Linq;using System.Text;using System.Threading.Tasks;namespace AssemblyLib.AssemblyModels{	public class StructureCRTInputModel : Notifier	{		public StructureCRTInputModel()		{					TankID = "";			TankHeight = "";			RoofSlope = "";			SupportingType = "";			RafterMaterial = "";			RafterType = "";			RafterWeldToRoof = "";			RafterWeldAngle = "";			GirderMaterial = "";			GirderType = "";			ColumnShape = "";			ColumnNo = "";		}				private string _TankID;		public string TankID			{				get { return _TankID; }				set				{					_TankID = value;					OnPropertyChanged(nameof(TankID));				}			}				private string _TankHeight;		public string TankHeight			{				get { return _TankHeight; }				set				{					_TankHeight = value;					OnPropertyChanged(nameof(TankHeight));				}			}				private string _RoofSlope;		public string RoofSlope			{				get { return _RoofSlope; }				set				{					_RoofSlope = value;					OnPropertyChanged(nameof(RoofSlope));				}			}				private string _SupportingType;		public string SupportingType			{				get { return _SupportingType; }				set				{					_SupportingType = value;					OnPropertyChanged(nameof(SupportingType));				}			}				private string _RafterMaterial;		public string RafterMaterial			{				get { return _RafterMaterial; }				set				{					_RafterMaterial = value;					OnPropertyChanged(nameof(RafterMaterial));				}			}				private string _RafterType;		public string RafterType			{				get { return _RafterType; }				set				{					_RafterType = value;					OnPropertyChanged(nameof(RafterType));				}			}				private string _RafterWeldToRoof;		public string RafterWeldToRoof			{				get { return _RafterWeldToRoof; }				set				{					_RafterWeldToRoof = value;					OnPropertyChanged(nameof(RafterWeldToRoof));				}			}				private string _RafterWeldAngle;		public string RafterWeldAngle			{				get { return _RafterWeldAngle; }				set				{					_RafterWeldAngle = value;					OnPropertyChanged(nameof(RafterWeldAngle));				}			}				private string _GirderMaterial;		public string GirderMaterial			{				get { return _GirderMaterial; }				set				{					_GirderMaterial = value;					OnPropertyChanged(nameof(GirderMaterial));				}			}				private string _GirderType;		public string GirderType			{				get { return _GirderType; }				set				{					_GirderType = value;					OnPropertyChanged(nameof(GirderType));				}			}				private string _ColumnShape;		public string ColumnShape			{				get { return _ColumnShape; }				set				{					_ColumnShape = value;					OnPropertyChanged(nameof(ColumnShape));				}			}				private string _ColumnNo;		public string ColumnNo			{				get { return _ColumnNo; }				set				{					_ColumnNo = value;					OnPropertyChanged(nameof(ColumnNo));				}			}			}}