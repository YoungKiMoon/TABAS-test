﻿using AssemblyLib.Utils;using System;using System.Collections.Generic;using System.Collections.ObjectModel;using System.Linq;using System.Text;using System.Threading.Tasks;namespace AssemblyLib.AssemblyModels{	public class RoofCRTInputModel : Notifier	{		public RoofCRTInputModel()		{					TankId = "";			TankHeight = "";			InsulationRequired = "";			InsulationThickness = "";			InsulationDensity = "";			InsulationType = "";			RoofSlope = "";			PlateWidth = "";			PlateLength = "";			RoofPlateThickness = "";			RoofPlateArrangementType = "";			RoofPlateStartAngle = "";			RoofPlateWeldType = "";			RoofPlateWeldDirection = "";			RoofPlateWeldOvelap = "";			RoofPlateAluminum = "";			CompressionRingType = "";			CompressionRingTypeMaterial = "";			DeatilBAngleSize = "";			DeatilBRetainingPlate = "";			DetailDAngleSize = "";			DetailDRetainingPlate = "";			DetailEAngleSize = "";			CompressionRingMaterial = "";			CompressionRingPlateWidth = "";			CompressionRingPlateLength = "";			DetailIThickness = "";			DetailIWidth = "";			DetailIOutsideProjection = "";			DetailIOverlap = "";			DetailIRoofPlateLocation = "";			DetailKThickness = "";			DetailKWidth = "";			DetailKShellThickness = "";			DetailKShellWidth = "";			DetailKDistance = "";		}				private string _TankId;		public string TankId			{				get { return _TankId; }				set				{					_TankId = value;					OnPropertyChanged(nameof(TankId));				}			}				private string _TankHeight;		public string TankHeight			{				get { return _TankHeight; }				set				{					_TankHeight = value;					OnPropertyChanged(nameof(TankHeight));				}			}				private string _InsulationRequired;		public string InsulationRequired			{				get { return _InsulationRequired; }				set				{					_InsulationRequired = value;					OnPropertyChanged(nameof(InsulationRequired));				}			}				private string _InsulationThickness;		public string InsulationThickness			{				get { return _InsulationThickness; }				set				{					_InsulationThickness = value;					OnPropertyChanged(nameof(InsulationThickness));				}			}				private string _InsulationDensity;		public string InsulationDensity			{				get { return _InsulationDensity; }				set				{					_InsulationDensity = value;					OnPropertyChanged(nameof(InsulationDensity));				}			}				private string _InsulationType;		public string InsulationType			{				get { return _InsulationType; }				set				{					_InsulationType = value;					OnPropertyChanged(nameof(InsulationType));				}			}				private string _RoofSlope;		public string RoofSlope			{				get { return _RoofSlope; }				set				{					_RoofSlope = value;					OnPropertyChanged(nameof(RoofSlope));				}			}				private string _PlateWidth;		public string PlateWidth			{				get { return _PlateWidth; }				set				{					_PlateWidth = value;					OnPropertyChanged(nameof(PlateWidth));				}			}				private string _PlateLength;		public string PlateLength			{				get { return _PlateLength; }				set				{					_PlateLength = value;					OnPropertyChanged(nameof(PlateLength));				}			}				private string _RoofPlateThickness;		public string RoofPlateThickness			{				get { return _RoofPlateThickness; }				set				{					_RoofPlateThickness = value;					OnPropertyChanged(nameof(RoofPlateThickness));				}			}				private string _RoofPlateArrangementType;		public string RoofPlateArrangementType			{				get { return _RoofPlateArrangementType; }				set				{					_RoofPlateArrangementType = value;					OnPropertyChanged(nameof(RoofPlateArrangementType));				}			}				private string _RoofPlateStartAngle;		public string RoofPlateStartAngle			{				get { return _RoofPlateStartAngle; }				set				{					_RoofPlateStartAngle = value;					OnPropertyChanged(nameof(RoofPlateStartAngle));				}			}				private string _RoofPlateWeldType;		public string RoofPlateWeldType			{				get { return _RoofPlateWeldType; }				set				{					_RoofPlateWeldType = value;					OnPropertyChanged(nameof(RoofPlateWeldType));				}			}				private string _RoofPlateWeldDirection;		public string RoofPlateWeldDirection			{				get { return _RoofPlateWeldDirection; }				set				{					_RoofPlateWeldDirection = value;					OnPropertyChanged(nameof(RoofPlateWeldDirection));				}			}				private string _RoofPlateWeldOvelap;		public string RoofPlateWeldOvelap			{				get { return _RoofPlateWeldOvelap; }				set				{					_RoofPlateWeldOvelap = value;					OnPropertyChanged(nameof(RoofPlateWeldOvelap));				}			}				private string _RoofPlateAluminum;		public string RoofPlateAluminum			{				get { return _RoofPlateAluminum; }				set				{					_RoofPlateAluminum = value;					OnPropertyChanged(nameof(RoofPlateAluminum));				}			}				private string _CompressionRingType;		public string CompressionRingType			{				get { return _CompressionRingType; }				set				{					_CompressionRingType = value;					OnPropertyChanged(nameof(CompressionRingType));				}			}				private string _CompressionRingTypeMaterial;		public string CompressionRingTypeMaterial			{				get { return _CompressionRingTypeMaterial; }				set				{					_CompressionRingTypeMaterial = value;					OnPropertyChanged(nameof(CompressionRingTypeMaterial));				}			}				private string _DeatilBAngleSize;		public string DeatilBAngleSize			{				get { return _DeatilBAngleSize; }				set				{					_DeatilBAngleSize = value;					OnPropertyChanged(nameof(DeatilBAngleSize));				}			}				private string _DeatilBRetainingPlate;		public string DeatilBRetainingPlate			{				get { return _DeatilBRetainingPlate; }				set				{					_DeatilBRetainingPlate = value;					OnPropertyChanged(nameof(DeatilBRetainingPlate));				}			}				private string _DetailDAngleSize;		public string DetailDAngleSize			{				get { return _DetailDAngleSize; }				set				{					_DetailDAngleSize = value;					OnPropertyChanged(nameof(DetailDAngleSize));				}			}				private string _DetailDRetainingPlate;		public string DetailDRetainingPlate			{				get { return _DetailDRetainingPlate; }				set				{					_DetailDRetainingPlate = value;					OnPropertyChanged(nameof(DetailDRetainingPlate));				}			}				private string _DetailEAngleSize;		public string DetailEAngleSize			{				get { return _DetailEAngleSize; }				set				{					_DetailEAngleSize = value;					OnPropertyChanged(nameof(DetailEAngleSize));				}			}				private string _CompressionRingMaterial;		public string CompressionRingMaterial			{				get { return _CompressionRingMaterial; }				set				{					_CompressionRingMaterial = value;					OnPropertyChanged(nameof(CompressionRingMaterial));				}			}				private string _CompressionRingPlateWidth;		public string CompressionRingPlateWidth			{				get { return _CompressionRingPlateWidth; }				set				{					_CompressionRingPlateWidth = value;					OnPropertyChanged(nameof(CompressionRingPlateWidth));				}			}				private string _CompressionRingPlateLength;		public string CompressionRingPlateLength			{				get { return _CompressionRingPlateLength; }				set				{					_CompressionRingPlateLength = value;					OnPropertyChanged(nameof(CompressionRingPlateLength));				}			}				private string _DetailIThickness;		public string DetailIThickness			{				get { return _DetailIThickness; }				set				{					_DetailIThickness = value;					OnPropertyChanged(nameof(DetailIThickness));				}			}				private string _DetailIWidth;		public string DetailIWidth			{				get { return _DetailIWidth; }				set				{					_DetailIWidth = value;					OnPropertyChanged(nameof(DetailIWidth));				}			}				private string _DetailIOutsideProjection;		public string DetailIOutsideProjection			{				get { return _DetailIOutsideProjection; }				set				{					_DetailIOutsideProjection = value;					OnPropertyChanged(nameof(DetailIOutsideProjection));				}			}				private string _DetailIOverlap;		public string DetailIOverlap			{				get { return _DetailIOverlap; }				set				{					_DetailIOverlap = value;					OnPropertyChanged(nameof(DetailIOverlap));				}			}				private string _DetailIRoofPlateLocation;		public string DetailIRoofPlateLocation			{				get { return _DetailIRoofPlateLocation; }				set				{					_DetailIRoofPlateLocation = value;					OnPropertyChanged(nameof(DetailIRoofPlateLocation));				}			}				private string _DetailKThickness;		public string DetailKThickness			{				get { return _DetailKThickness; }				set				{					_DetailKThickness = value;					OnPropertyChanged(nameof(DetailKThickness));				}			}				private string _DetailKWidth;		public string DetailKWidth			{				get { return _DetailKWidth; }				set				{					_DetailKWidth = value;					OnPropertyChanged(nameof(DetailKWidth));				}			}				private string _DetailKShellThickness;		public string DetailKShellThickness			{				get { return _DetailKShellThickness; }				set				{					_DetailKShellThickness = value;					OnPropertyChanged(nameof(DetailKShellThickness));				}			}				private string _DetailKShellWidth;		public string DetailKShellWidth			{				get { return _DetailKShellWidth; }				set				{					_DetailKShellWidth = value;					OnPropertyChanged(nameof(DetailKShellWidth));				}			}				private string _DetailKDistance;		public string DetailKDistance			{				get { return _DetailKDistance; }				set				{					_DetailKDistance = value;					OnPropertyChanged(nameof(DetailKDistance));				}			}			}}