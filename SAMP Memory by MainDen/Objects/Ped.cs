using System;

namespace MainDen.SAMP.Memory.Objects
{
    public class Ped : Physical
    {
        public new enum Addresses
        {
            AnimationDynamicStatus = 0x15C,
            Sound = 0x294,
            AnimationStaticStatus = 0x46C,
            FirstAbilities = 0x470,
            SecondAbilities = 0x474,
            Animation = 0x47C,
            AnimationGroup = 0x4D4,
            CurrentWeapon = 0x4F4,
            CurrentWeaponFlash = 0x4F8,
            Glasses = 0x4FC,
            GlassesType = 0x500,
            FirstWeaponFlashTransparencyMultiplier = 0x504,
            SecondWeaponFlashTransparencyMultiplier = 0x508,
            WorldStatus = 0x530,
            MotionStaus = 0x534,
            Health = 0x540,
            HealthMax = 0x544,
            Armour = 0x548,
            AngleZ = 0x558,
            AimAngleZ = 0x55C,
            RotationSpeed = 0x560,
            CurrentVehicleCollision = 0x568,
            CerrentEntityCollision = 0x584,
            LastVehicleDriven = 0x58C,
            PedType = 0x598,
            Weapons = 0x5A0,
            TurretWeapon = 0x70C,
            CurrentWeaponIndex = 0x718,
            ShootingAccuracy = 0x71A,
            AimDynamic = 0x71C,
            ShootingSkill = 0x72C,
            FirstFightingStyle = 0x72D,
            SecondFightingStyle = 0x72E,
            AttachedFire = 0x730,
            WeaponId = 0x740,
            Money = 0x756,
            KilledByWeapon = 0x760,
            KilledByPed = 0x764,
            TurretObjectOffset = 0x76C,
            TurretAngleDeg = 0x778,
            TurretAngleRad = 0x77C,
            TuuretPositionView = 0x780,
            TurretBulletCount = 0x784,
            AimPed = 0x79C,
        }

        public Vector3 AnimationDynamicStatus
        {
            get => new Vector3 { ProcessHandle = ProcessHandle, BaseAddress = BaseAddress + (int)Addresses.AnimationDynamicStatus };
        }

        public SAMPObject Sound
        {
            get => new SAMPObject { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.Sound) };
            set => Memory.Write((int)Addresses.Sound, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }

        public UInt32 AnimationStaticStatus
        {
            get => Memory.ReadUInt32((int)Addresses.AnimationStaticStatus);
            set => Memory.Write((int)Addresses.AnimationStaticStatus, value);
        }

        public UInt32 FirstAbilities
        {
            get => Memory.ReadUInt32((int)Addresses.FirstAbilities);
            set => Memory.Write((int)Addresses.FirstAbilities, value);
        }

        public UInt32 SecondAbilities
        {
            get => Memory.ReadUInt32((int)Addresses.SecondAbilities);
            set => Memory.Write((int)Addresses.SecondAbilities, value);
        }

        public SAMPObject Animation
        {
            get => new SAMPObject { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.Animation) };
            set => Memory.Write((int)Addresses.Animation, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }

        public UInt32 AnimationGroup
        {
            get => Memory.ReadUInt32((int)Addresses.AnimationGroup);
            set => Memory.Write((int)Addresses.AnimationGroup, value);
        }

        public Weapon CurrentWeapon
        {
            get => new Weapon { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.CurrentWeapon) };
            set => Memory.Write((int)Addresses.CurrentWeapon, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }

        public SAMPObject CurrentWeaponFlash
        {
            get => new SAMPObject { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.CurrentWeaponFlash) };
            set => Memory.Write((int)Addresses.CurrentWeaponFlash, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }

        public SAMPObject Glasses
        {
            get => new SAMPObject { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.Glasses) };
            set => Memory.Write((int)Addresses.Glasses, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }

        public SAMPObject GlassesType
        {
            get => new SAMPObject { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.GlassesType) };
            set => Memory.Write((int)Addresses.GlassesType, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }

        public UInt16 FirstWeaponFlashTransparencyMultiplier
        {
            get => Memory.ReadUInt16((int)Addresses.FirstWeaponFlashTransparencyMultiplier);
            set => Memory.Write((int)Addresses.FirstWeaponFlashTransparencyMultiplier, value);
        }

        public UInt16 SecondWeaponFlashTransparencyMultiplier
        {
            get => Memory.ReadUInt16((int)Addresses.SecondWeaponFlashTransparencyMultiplier);
            set => Memory.Write((int)Addresses.SecondWeaponFlashTransparencyMultiplier, value);
        }

        public UInt32 WorldStatus
        {
            get => Memory.ReadUInt32((int)Addresses.WorldStatus);
            set => Memory.Write((int)Addresses.WorldStatus, value);
        }

        public UInt32 MotionStaus
        {
            get => Memory.ReadUInt32((int)Addresses.MotionStaus);
            set => Memory.Write((int)Addresses.MotionStaus, value);
        }

        public Single Health
        {
            get => Memory.ReadSingle((int)Addresses.Health);
            set => Memory.Write((int)Addresses.Health, value);
        }

        public Single HealthMax
        {
            get => Memory.ReadSingle((int)Addresses.HealthMax);
            set => Memory.Write((int)Addresses.HealthMax, value);
        }

        public Single Armour
        {
            get => Memory.ReadSingle((int)Addresses.Armour);
            set => Memory.Write((int)Addresses.Armour, value);
        }

        public Single AngleZ
        {
            get => Memory.ReadSingle((int)Addresses.AngleZ);
            set => Memory.Write((int)Addresses.AngleZ, value);
        }

        public Single AimAngleZ
        {
            get => Memory.ReadSingle((int)Addresses.AimAngleZ);
            set => Memory.Write((int)Addresses.AimAngleZ, value);
        }

        public Single RotationSpeed
        {
            get => Memory.ReadSingle((int)Addresses.RotationSpeed);
            set => Memory.Write((int)Addresses.RotationSpeed, value);
        }

        public Vehicle CurrentVehicleCollision
        {
            get => new Vehicle { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.CurrentVehicleCollision) };
            set => Memory.Write((int)Addresses.CurrentVehicleCollision, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }

        public Entity CerrentEntityCollision
        {
            get => new Entity { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.CerrentEntityCollision) };
            set => Memory.Write((int)Addresses.CerrentEntityCollision, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }

        public Vehicle LastVehicleDriven
        {
            get => new Vehicle { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.LastVehicleDriven) };
            set => Memory.Write((int)Addresses.LastVehicleDriven, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }

        public Byte PedType
        {
            get => Memory.ReadByte((int)Addresses.PedType);
            set => Memory.Write((int)Addresses.PedType, value);
        }

        public UInt32 TurretWeapon
        {
            get => Memory.ReadUInt32((int)Addresses.TurretWeapon);
            set => Memory.Write((int)Addresses.TurretWeapon, value);
        }

        public Byte CurrentWeaponIndex
        {
            get => Memory.ReadByte((int)Addresses.CurrentWeaponIndex);
            set => Memory.Write((int)Addresses.CurrentWeaponIndex, value);
        }

        public Byte ShootingAccuracy
        {
            get => Memory.ReadByte((int)Addresses.ShootingAccuracy);
            set => Memory.Write((int)Addresses.ShootingAccuracy, value);
        }

        public Dynamic AimDynamic
        {
            get => new Dynamic { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.AimDynamic) };
            set => Memory.Write((int)Addresses.AimDynamic, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }

        public Byte ShootingSkill
        {
            get => Memory.ReadByte((int)Addresses.ShootingSkill);
            set => Memory.Write((int)Addresses.ShootingSkill, value);
        }

        public Byte FirstFightingStyle
        {
            get => Memory.ReadByte((int)Addresses.FirstFightingStyle);
            set => Memory.Write((int)Addresses.FirstFightingStyle, value);
        }

        public Byte SecondFightingStyle
        {
            get => Memory.ReadByte((int)Addresses.SecondFightingStyle);
            set => Memory.Write((int)Addresses.SecondFightingStyle, value);
        }

        public SAMPObject AttachedFire
        {
            get => new SAMPObject { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.AttachedFire) };
            set => Memory.Write((int)Addresses.AttachedFire, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }

        public Byte WeaponId
        {
            get => Memory.ReadByte((int)Addresses.WeaponId);
            set => Memory.Write((int)Addresses.WeaponId, value);
        }

        public UInt16 Money
        {
            get => Memory.ReadUInt16((int)Addresses.Money);
            set => Memory.Write((int)Addresses.Money, value);
        }

        public Weapon KilledByWeapon
        {
            get => new Weapon { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.KilledByWeapon) };
            set => Memory.Write((int)Addresses.KilledByWeapon, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }

        public Ped KilledByPed
        {
            get => new Ped { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.KilledByPed) };
            set => Memory.Write((int)Addresses.KilledByPed, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }

        public Vector3 TurretObjectOffset
        {
            get => new Vector3 { ProcessHandle = ProcessHandle, BaseAddress = BaseAddress + (int)Addresses.TurretObjectOffset };
        }

        public UInt16 TurretAngleDeg
        {
            get => Memory.ReadUInt16((int)Addresses.TurretAngleDeg);
            set => Memory.Write((int)Addresses.TurretAngleDeg, value);
        }

        public Single TurretAngleRad
        {
            get => Memory.ReadSingle((int)Addresses.TurretAngleRad);
            set => Memory.Write((int)Addresses.TurretAngleRad, value);
        }

        public UInt32 TuuretPositionView
        {
            get => Memory.ReadUInt32((int)Addresses.TuuretPositionView);
            set => Memory.Write((int)Addresses.TuuretPositionView, value);
        }

        public UInt32 TurretBulletCount
        {
            get => Memory.ReadUInt32((int)Addresses.TurretBulletCount);
            set => Memory.Write((int)Addresses.TurretBulletCount, value);
        }

        public Ped AimPed
        {
            get => new Ped { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.AimPed) };
            set => Memory.Write((int)Addresses.AimPed, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }
    }
}
