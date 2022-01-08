using System;

namespace MainDen.SAMP.Memory.Objects
{
    public class Physical : Entity
    {
        public new enum Addresses
        {
            Immunities = 0x40,
            Velocity = 0x44,
            Spin = 0x50,
            Acceleration = 0x5C,
            Mass = 0x8C,
            InertialMass = 0x90,
            GripDivider = 0x94,
            GripMass = 0x98,
            Elasticity = 0x9C,
            Buoyancy = 0xA0,
            MassCenter = 0xA4,
            CollisionObjectCount = 0xB9,
            CollisionObjects = 0xBC,
            DamageAmount = 0xD8,
            DamageOwner = 0xDC,
            CollisionLocation = 0xE0,
            CollisionPosition = 0xEC,
            CollisionPart = 0xF8,
            AttachmentObject = 0xFC,
            AttachmentPosition = 0x100,
            AttachmentDirection = 0x10C,
            CollisionIgnorableObject = 0x128,
            CollisionObjectIllumination = 0x12C,
            ShadowData = 0x134,
        }
        
        public UInt32 Immunities
        {
            get => Memory.ReadUInt32((int)Addresses.Immunities);
            set => Memory.Write((int)Addresses.Immunities, value);
        }
        
        public Vector3 Velocity
        {
            get => new Vector3 { ProcessHandle = ProcessHandle, BaseAddress = BaseAddress + (int)Addresses.Velocity };
        }
        
        public Vector3 Spin
        {
            get => new Vector3 { ProcessHandle = ProcessHandle, BaseAddress = BaseAddress + (int)Addresses.Spin };
        }
        
        public Vector3 Acceleration
        {
            get => new Vector3 { ProcessHandle = ProcessHandle, BaseAddress = BaseAddress + (int)Addresses.Acceleration };
        }
        
        public Single Mass
        {
            get => Memory.ReadSingle((int)Addresses.Mass);
            set => Memory.Write((int)Addresses.Mass, value);
        }
        
        public Single InertialMass
        {
            get => Memory.ReadSingle((int)Addresses.InertialMass);
            set => Memory.Write((int)Addresses.InertialMass, value);
        }
        
        public Single GripDivider
        {
            get => Memory.ReadSingle((int)Addresses.GripDivider);
            set => Memory.Write((int)Addresses.GripDivider, value);
        }
        
        public Single GripMass
        {
            get => Memory.ReadSingle((int)Addresses.GripMass);
            set => Memory.Write((int)Addresses.GripMass, value);
        }
        
        public Single Elasticity
        {
            get => Memory.ReadSingle((int)Addresses.Elasticity);
            set => Memory.Write((int)Addresses.Elasticity, value);
        }
        
        public Single Buoyancy
        {
            get => Memory.ReadSingle((int)Addresses.Buoyancy);
            set => Memory.Write((int)Addresses.Buoyancy, value);
        }
        
        public Vector3 MassCenter
        {
            get => new Vector3 { ProcessHandle = ProcessHandle, BaseAddress = BaseAddress + (int)Addresses.MassCenter };
        }
        
        public UInt16 CollisionObjectCount
        {
            get => Memory.ReadUInt16((int)Addresses.CollisionObjectCount);
            set => Memory.Write((int)Addresses.CollisionObjectCount, value);
        }
        
        public SAMPCollection<Physical> CollisionObjects
        {
            get => new SAMPCollection<Physical> { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.CollisionObjects), Capacity = 6 };
}
        
        public Single DamageAmount
        {
            get => Memory.ReadSingle((int)Addresses.DamageAmount);
            set => Memory.Write((int)Addresses.DamageAmount, value);
        }
        
        public Physical DamageOwner
        {
            get => new Physical { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.DamageOwner) };
            set => Memory.Write((int)Addresses.DamageOwner, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }
        
        public Vector3 CollisionLocation
        {
            get => new Vector3 { ProcessHandle = ProcessHandle, BaseAddress = BaseAddress + (int)Addresses.CollisionLocation };
        }
        
        public Vector3 CollisionPosition
        {
            get => new Vector3 { ProcessHandle = ProcessHandle, BaseAddress = BaseAddress + (int)Addresses.CollisionPosition };
        }
        
        public UInt16 CollisionPart
        {
            get => Memory.ReadUInt16((int)Addresses.CollisionPart);
            set => Memory.Write((int)Addresses.CollisionPart, value);
        }
        
        public Physical AttachmentObject
        {
            get => new Physical { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.AttachmentObject) };
            set => Memory.Write((int)Addresses.AttachmentObject, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }
        
        public Vector3 AttachmentPosition
        {
            get => new Vector3 { ProcessHandle = ProcessHandle, BaseAddress = BaseAddress + (int)Addresses.AttachmentPosition };
        }
        
        public Vector3 AttachmentDirection
        {
            get => new Vector3 { ProcessHandle = ProcessHandle, BaseAddress = BaseAddress + (int)Addresses.AttachmentDirection };
        }
        
        public Physical CollisionIgnorableObject
        {
            get => new Physical { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.CollisionIgnorableObject) };
            set => Memory.Write((int)Addresses.CollisionIgnorableObject, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }
        
        public Single CollisionObjectIllumination
        {
            get => Memory.ReadSingle((int)Addresses.CollisionObjectIllumination);
            set => Memory.Write((int)Addresses.CollisionObjectIllumination, value);
        }
        
        public SAMPObject ShadowData
        {
            get => new SAMPObject { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.ShadowData) };
            set => Memory.Write((int)Addresses.ShadowData, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }
    }
}
