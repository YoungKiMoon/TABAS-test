﻿using AssemblyLib.Utils;using System;using System.Collections.Generic;using System.Collections.ObjectModel;using System.Linq;using System.Text;using System.Threading.Tasks;namespace AssemblyLib.AssemblyModels{	public class NozzleRoofInputModel : Notifier	{		public NozzleRoofInputModel()		{					Position = "";			LR = "";			Mark = "";			Size = "";			SCH = "";			PipeMaterial = "";			Qty = "";			Flange = "";			Rating = "";			Type = "";			Facing = "";			FlangeMaterial = "";			R = "";			H = "";			Ort = "";			AttachedType = "";			OffsetToCL = "";			Description = "";			Remarks = "";			ASMESeries = "";			RePad = "";			RePadType = "";			InternalPipe = "";			InternalPipeBottomSupt = "";			PipeJoint = "";			Fitting = "";			OutletDirection = "";			DrainType = "";			Cover = "";			Manhole = "";			CleanOut = "";			ManholeSupt = "";			RiserPipe = "";			Mixer = "";			GaugeHatch = "";			InternalLadder = "";			GooseNeckBirdScreen = "";			FlameArrestor = "";			BreatherValve = "";			VacuumReliefValve = "";			EmergencyVent = "";			InternalPipeBended = "";			WaterSpray = "";			FoamConn = "";			AutoBleederVent = "";			RimVent = "";			RoofDrainSump = "";			NozzleOnPlateform = "";			HRSort = 0;		}				private string _Position;		public string Position			{				get { return _Position; }				set				{					_Position = value;					OnPropertyChanged(nameof(Position));				}			}				private string _LR;		public string LR			{				get { return _LR; }				set				{					_LR = value;					OnPropertyChanged(nameof(LR));				}			}				private string _Mark;		public string Mark			{				get { return _Mark; }				set				{					_Mark = value;					OnPropertyChanged(nameof(Mark));				}			}				private string _Size;		public string Size			{				get { return _Size; }				set				{					_Size = value;					OnPropertyChanged(nameof(Size));				}			}				private string _SCH;		public string SCH			{				get { return _SCH; }				set				{					_SCH = value;					OnPropertyChanged(nameof(SCH));				}			}				private string _PipeMaterial;		public string PipeMaterial			{				get { return _PipeMaterial; }				set				{					_PipeMaterial = value;					OnPropertyChanged(nameof(PipeMaterial));				}			}				private string _Qty;		public string Qty			{				get { return _Qty; }				set				{					_Qty = value;					OnPropertyChanged(nameof(Qty));				}			}				private string _Flange;		public string Flange			{				get { return _Flange; }				set				{					_Flange = value;					OnPropertyChanged(nameof(Flange));				}			}				private string _Rating;		public string Rating			{				get { return _Rating; }				set				{					_Rating = value;					OnPropertyChanged(nameof(Rating));				}			}				private string _Type;		public string Type			{				get { return _Type; }				set				{					_Type = value;					OnPropertyChanged(nameof(Type));				}			}				private string _Facing;		public string Facing			{				get { return _Facing; }				set				{					_Facing = value;					OnPropertyChanged(nameof(Facing));				}			}				private string _FlangeMaterial;		public string FlangeMaterial			{				get { return _FlangeMaterial; }				set				{					_FlangeMaterial = value;					OnPropertyChanged(nameof(FlangeMaterial));				}			}				private string _R;		public string R			{				get { return _R; }				set				{					_R = value;					OnPropertyChanged(nameof(R));				}			}				private string _H;		public string H			{				get { return _H; }				set				{					_H = value;					OnPropertyChanged(nameof(H));				}			}				private string _Ort;		public string Ort			{				get { return _Ort; }				set				{					_Ort = value;					OnPropertyChanged(nameof(Ort));				}			}				private string _AttachedType;		public string AttachedType			{				get { return _AttachedType; }				set				{					_AttachedType = value;					OnPropertyChanged(nameof(AttachedType));				}			}				private string _OffsetToCL;		public string OffsetToCL			{				get { return _OffsetToCL; }				set				{					_OffsetToCL = value;					OnPropertyChanged(nameof(OffsetToCL));				}			}				private string _Description;		public string Description			{				get { return _Description; }				set				{					_Description = value;					OnPropertyChanged(nameof(Description));				}			}				private string _Remarks;		public string Remarks			{				get { return _Remarks; }				set				{					_Remarks = value;					OnPropertyChanged(nameof(Remarks));				}			}				private string _ASMESeries;		public string ASMESeries			{				get { return _ASMESeries; }				set				{					_ASMESeries = value;					OnPropertyChanged(nameof(ASMESeries));				}			}				private string _RePad;		public string RePad			{				get { return _RePad; }				set				{					_RePad = value;					OnPropertyChanged(nameof(RePad));				}			}				private string _RePadType;		public string RePadType			{				get { return _RePadType; }				set				{					_RePadType = value;					OnPropertyChanged(nameof(RePadType));				}			}				private string _InternalPipe;		public string InternalPipe			{				get { return _InternalPipe; }				set				{					_InternalPipe = value;					OnPropertyChanged(nameof(InternalPipe));				}			}				private string _InternalPipeBottomSupt;		public string InternalPipeBottomSupt			{				get { return _InternalPipeBottomSupt; }				set				{					_InternalPipeBottomSupt = value;					OnPropertyChanged(nameof(InternalPipeBottomSupt));				}			}				private string _PipeJoint;		public string PipeJoint			{				get { return _PipeJoint; }				set				{					_PipeJoint = value;					OnPropertyChanged(nameof(PipeJoint));				}			}				private string _Fitting;		public string Fitting			{				get { return _Fitting; }				set				{					_Fitting = value;					OnPropertyChanged(nameof(Fitting));				}			}				private string _OutletDirection;		public string OutletDirection			{				get { return _OutletDirection; }				set				{					_OutletDirection = value;					OnPropertyChanged(nameof(OutletDirection));				}			}				private string _DrainType;		public string DrainType			{				get { return _DrainType; }				set				{					_DrainType = value;					OnPropertyChanged(nameof(DrainType));				}			}				private string _Cover;		public string Cover			{				get { return _Cover; }				set				{					_Cover = value;					OnPropertyChanged(nameof(Cover));				}			}				private string _Manhole;		public string Manhole			{				get { return _Manhole; }				set				{					_Manhole = value;					OnPropertyChanged(nameof(Manhole));				}			}				private string _CleanOut;		public string CleanOut			{				get { return _CleanOut; }				set				{					_CleanOut = value;					OnPropertyChanged(nameof(CleanOut));				}			}				private string _ManholeSupt;		public string ManholeSupt			{				get { return _ManholeSupt; }				set				{					_ManholeSupt = value;					OnPropertyChanged(nameof(ManholeSupt));				}			}				private string _RiserPipe;		public string RiserPipe			{				get { return _RiserPipe; }				set				{					_RiserPipe = value;					OnPropertyChanged(nameof(RiserPipe));				}			}				private string _Mixer;		public string Mixer			{				get { return _Mixer; }				set				{					_Mixer = value;					OnPropertyChanged(nameof(Mixer));				}			}				private string _GaugeHatch;		public string GaugeHatch			{				get { return _GaugeHatch; }				set				{					_GaugeHatch = value;					OnPropertyChanged(nameof(GaugeHatch));				}			}				private string _InternalLadder;		public string InternalLadder			{				get { return _InternalLadder; }				set				{					_InternalLadder = value;					OnPropertyChanged(nameof(InternalLadder));				}			}				private string _GooseNeckBirdScreen;		public string GooseNeckBirdScreen			{				get { return _GooseNeckBirdScreen; }				set				{					_GooseNeckBirdScreen = value;					OnPropertyChanged(nameof(GooseNeckBirdScreen));				}			}				private string _FlameArrestor;		public string FlameArrestor			{				get { return _FlameArrestor; }				set				{					_FlameArrestor = value;					OnPropertyChanged(nameof(FlameArrestor));				}			}				private string _BreatherValve;		public string BreatherValve			{				get { return _BreatherValve; }				set				{					_BreatherValve = value;					OnPropertyChanged(nameof(BreatherValve));				}			}				private string _VacuumReliefValve;		public string VacuumReliefValve			{				get { return _VacuumReliefValve; }				set				{					_VacuumReliefValve = value;					OnPropertyChanged(nameof(VacuumReliefValve));				}			}				private string _EmergencyVent;		public string EmergencyVent			{				get { return _EmergencyVent; }				set				{					_EmergencyVent = value;					OnPropertyChanged(nameof(EmergencyVent));				}			}				private string _InternalPipeBended;		public string InternalPipeBended			{				get { return _InternalPipeBended; }				set				{					_InternalPipeBended = value;					OnPropertyChanged(nameof(InternalPipeBended));				}			}				private string _WaterSpray;		public string WaterSpray			{				get { return _WaterSpray; }				set				{					_WaterSpray = value;					OnPropertyChanged(nameof(WaterSpray));				}			}				private string _FoamConn;		public string FoamConn			{				get { return _FoamConn; }				set				{					_FoamConn = value;					OnPropertyChanged(nameof(FoamConn));				}			}				private string _AutoBleederVent;		public string AutoBleederVent			{				get { return _AutoBleederVent; }				set				{					_AutoBleederVent = value;					OnPropertyChanged(nameof(AutoBleederVent));				}			}				private string _RimVent;		public string RimVent			{				get { return _RimVent; }				set				{					_RimVent = value;					OnPropertyChanged(nameof(RimVent));				}			}				private string _RoofDrainSump;		public string RoofDrainSump			{				get { return _RoofDrainSump; }				set				{					_RoofDrainSump = value;					OnPropertyChanged(nameof(RoofDrainSump));				}			}				private string _NozzleOnPlateform;		public string NozzleOnPlateform			{				get { return _NozzleOnPlateform; }				set				{					_NozzleOnPlateform = value;					OnPropertyChanged(nameof(NozzleOnPlateform));				}			}				private double _HRSort;		public double HRSort			{				get { return _HRSort; }				set				{					_HRSort = value;					OnPropertyChanged(nameof(HRSort));				}			}			}}