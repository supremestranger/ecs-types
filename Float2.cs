﻿// ----------------------------------------------------------------------------
// The MIT License
// Types for Entity Component System framework https://github.com/Leopotam/ecs
// Copyright (c) 2017-2018 Leopotam <leopotam@gmail.com>
// ----------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;

#if NET_4_6
using System.Runtime.CompilerServices;
#endif

namespace Leopotam.Ecs.Types {
    [Serializable]
    [StructLayout (LayoutKind.Sequential)]
    public struct Float2 {
        public float X;

        public float Y;

#if NET_4_6
        [MethodImpl (MethodImplOptions.AggressiveInlining)]
#endif
        public float SqrMagnitude () {
            return X * X + Y * Y;
        }

#if NET_4_6
        [MethodImpl (MethodImplOptions.AggressiveInlining)]
#endif
        public float Magnitude () {
            return (float) Math.Sqrt (X * X + Y * Y);
        }

#if NET_4_6
        [MethodImpl (MethodImplOptions.AggressiveInlining)]
#endif
        public void Normalize () {
            var invMagnitude = 1f / (float) Math.Sqrt (X * X + Y * Y);
            X *= invMagnitude;
            Y *= invMagnitude;
        }

#if NET_4_6
        [MethodImpl (MethodImplOptions.AggressiveInlining)]
#endif
        public void Neg () {
            X = -X;
            Y = -Y;
        }

#if NET_4_6
        [MethodImpl (MethodImplOptions.AggressiveInlining)]
#endif
        public void Add (ref Float2 rhs) {
            X += rhs.X;
            Y += rhs.Y;
        }

#if NET_4_6
        [MethodImpl (MethodImplOptions.AggressiveInlining)]
#endif
        public void Add (float addX, float addY) {
            X += addX;
            Y += addY;
        }

#if NET_4_6
        [MethodImpl (MethodImplOptions.AggressiveInlining)]
#endif
        public void Sub (ref Float2 rhs) {
            X -= rhs.X;
            Y -= rhs.Y;
        }

#if NET_4_6
        [MethodImpl (MethodImplOptions.AggressiveInlining)]
#endif
        public void Scale (float addX, float addY) {
            X *= addX;
            Y *= addY;
        }

#if NET_4_6
        [MethodImpl (MethodImplOptions.AggressiveInlining)]
#endif
        public static Float2 Add (ref Float2 lhs, ref Float2 rhs) {
            Float2 res;
            res.X = lhs.X + rhs.X;
            res.Y = lhs.Y + rhs.Y;
            return res;
        }

#if NET_4_6
        [MethodImpl (MethodImplOptions.AggressiveInlining)]
#endif
        public static void Add (ref Float2 lhs, float addX, float addY, float addZ) {
            Float2 res;
            res.X = lhs.X + addX;
            res.Y = lhs.Y + addY;
        }

#if NET_4_6
        [MethodImpl (MethodImplOptions.AggressiveInlining)]
#endif
        public static Float2 Sub (ref Float2 lhs, ref Float2 rhs) {
            Float2 res;
            res.X = lhs.X - rhs.X;
            res.Y = lhs.Y - rhs.Y;
            return res;
        }

#if NET_4_6
        [MethodImpl (MethodImplOptions.AggressiveInlining)]
#endif
        public static Float2 Scale (ref Float2 lhs, float scaleX, float scaleY, float scaleZ) {
            Float2 res;
            res.X = lhs.X * scaleX;
            res.Y = lhs.Y * scaleY;
            return res;
        }

#if NET_4_6
        [MethodImpl (MethodImplOptions.AggressiveInlining)]
#endif
        public static Float2 Normalize (ref Float2 rhs) {
            Float2 res;
            var invMagnitude = 1f / (float) Math.Sqrt (rhs.X * rhs.X + rhs.Y * rhs.Y);
            res.X = rhs.X * invMagnitude;
            res.Y = rhs.Y * invMagnitude;
            return res;
        }

#if NET_4_6
        [MethodImpl (MethodImplOptions.AggressiveInlining)]
#endif
        public static bool Equals (ref Float2 lhs, ref Float2 rhs) {
            return (lhs.X - rhs.X) * (lhs.X - rhs.X) + (lhs.Y - rhs.Y) * (lhs.Y - rhs.Y) < float.Epsilon * float.Epsilon;
        }
    }
}