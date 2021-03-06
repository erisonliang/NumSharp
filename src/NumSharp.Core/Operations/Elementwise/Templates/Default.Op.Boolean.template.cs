﻿#if _REGEN_TEMPLATE
%arr = supported_dtypes
%template "../Equals/Default.Equals.#1.cs" for every ["Boolean"], ["bool"]
#endif

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using NumSharp.Backends.Unmanaged;
using NumSharp.Generic;
using NumSharp.Utilities;

namespace NumSharp.Backends
{
    public partial class DefaultEngine
    {
        [MethodImpl((MethodImplOptions)768)]
        [SuppressMessage("ReSharper", "JoinDeclarationAndInitializer")]
        [SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
        public unsafe NDArray<bool> Equals__1__(in NDArray lhs, in NDArray rhs)
        {
            //lhs is NDArray of __2__
            switch (rhs.GetTypeCode)
            {
#if _REGEN
                %op = "=="
                case NPTypeCode.Boolean:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>((*((__2__*)lhs.Address) %(op) (*((bool*)rhs.Address)))).MakeGeneric<bool>();;
                    
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (__2__*)lhs.Address;
                    var rhs_address = (bool*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
                    //iterate
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDCoordinatesIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetOffset(current)) = (*(lhs_address + BroadcastedLeftShape.GetOffset(current))) %(op) *(rhs_address + BroadcastedRightShape.GetOffset(current));
                    } while (incr.Next() != null);

                    return ret;
                }

	            %foreach except(supported_dtypes, "Boolean"), except(supported_dtypes_lowercase, "bool")%
                case NPTypeCode.#1:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>(((*((__2__*)lhs.Address) ? 1 : 0) #(op) *((#2*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (__2__*)lhs.Address;
                    var rhs_address = (#2*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDCoordinatesIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetOffset(current)) = ((*(lhs_address + BroadcastedLeftShape.GetOffset(current)) ? 1 : 0) #(op) *(rhs_address + BroadcastedRightShape.GetOffset(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                %
                default:
		            throw new NotSupportedException();
#else

                case NPTypeCode.Boolean:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>((*((__2__*)lhs.Address) == (*((bool*)rhs.Address)))).MakeGeneric<bool>();;
                    
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (__2__*)lhs.Address;
                    var rhs_address = (bool*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
                    //iterate
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDCoordinatesIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetOffset(current)) = (*(lhs_address + BroadcastedLeftShape.GetOffset(current))) == 0 != *(rhs_address + BroadcastedRightShape.GetOffset(current));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.Byte:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>(((*((__2__*)lhs.Address)  ? 1 : 0) == *((byte*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (__2__*)lhs.Address;
                    var rhs_address = (byte*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDCoordinatesIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetOffset(current)) = (*(lhs_address + BroadcastedLeftShape.GetOffset(current)) == (__2__) *(rhs_address + BroadcastedRightShape.GetOffset(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.Int16:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>(((*((__2__*)lhs.Address)  ? 1 : 0) == *((short*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (__2__*)lhs.Address;
                    var rhs_address = (short*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDCoordinatesIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetOffset(current)) = (*(lhs_address + BroadcastedLeftShape.GetOffset(current)) == (__2__) *(rhs_address + BroadcastedRightShape.GetOffset(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.UInt16:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>(((*((__2__*)lhs.Address)  ? 1 : 0) == *((ushort*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (__2__*)lhs.Address;
                    var rhs_address = (ushort*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDCoordinatesIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetOffset(current)) = (*(lhs_address + BroadcastedLeftShape.GetOffset(current)) == (__2__) *(rhs_address + BroadcastedRightShape.GetOffset(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.Int32:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>(((*((__2__*)lhs.Address)  ? 1 : 0) == *((int*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (__2__*)lhs.Address;
                    var rhs_address = (int*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDCoordinatesIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetOffset(current)) = (*(lhs_address + BroadcastedLeftShape.GetOffset(current)) == (__2__) *(rhs_address + BroadcastedRightShape.GetOffset(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.UInt32:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>(((*((__2__*)lhs.Address)  ? 1 : 0) == *((uint*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (__2__*)lhs.Address;
                    var rhs_address = (uint*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDCoordinatesIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetOffset(current)) = (*(lhs_address + BroadcastedLeftShape.GetOffset(current)) == (__2__) *(rhs_address + BroadcastedRightShape.GetOffset(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.Int64:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>(((*((__2__*)lhs.Address)  ? 1 : 0) == *((long*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (__2__*)lhs.Address;
                    var rhs_address = (long*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDCoordinatesIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetOffset(current)) = (*(lhs_address + BroadcastedLeftShape.GetOffset(current)) == (__2__) *(rhs_address + BroadcastedRightShape.GetOffset(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.UInt64:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>(((*((__2__*)lhs.Address)  ? 1 : 0) == *((ulong*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (__2__*)lhs.Address;
                    var rhs_address = (ulong*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDCoordinatesIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetOffset(current)) = (*(lhs_address + BroadcastedLeftShape.GetOffset(current)) == (__2__) *(rhs_address + BroadcastedRightShape.GetOffset(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.Char:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>(((*((__2__*)lhs.Address)  ? 1 : 0) == *((char*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (__2__*)lhs.Address;
                    var rhs_address = (char*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDCoordinatesIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetOffset(current)) = (*(lhs_address + BroadcastedLeftShape.GetOffset(current)) == (__2__) *(rhs_address + BroadcastedRightShape.GetOffset(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.Double:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>(((*((__2__*)lhs.Address)  ? 1 : 0) == *((double*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (__2__*)lhs.Address;
                    var rhs_address = (double*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDCoordinatesIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetOffset(current)) = (*(lhs_address + BroadcastedLeftShape.GetOffset(current)) == (__2__) *(rhs_address + BroadcastedRightShape.GetOffset(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.Single:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>(((*((__2__*)lhs.Address)  ? 1 : 0) == *((float*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (__2__*)lhs.Address;
                    var rhs_address = (float*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDCoordinatesIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetOffset(current)) = (*(lhs_address + BroadcastedLeftShape.GetOffset(current)) == (__2__) *(rhs_address + BroadcastedRightShape.GetOffset(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                case NPTypeCode.Decimal:
                {
                    //if return type is scalar
                    if (lhs.Shape.IsScalar && rhs.Shape.IsScalar)
                        return NDArray.Scalar<bool>(((*((__2__*)lhs.Address)  ? 1 : 0) == *((decimal*)rhs.Address))).MakeGeneric<bool>();
                    (Shape BroadcastedLeftShape, Shape BroadcastedRightShape) = DefaultEngine.Broadcast(lhs.Shape, rhs.Shape);
                    var lhs_address = (__2__*)lhs.Address;
                    var rhs_address = (decimal*)rhs.Address;
                    var ret = new NDArray<bool>(new Shape(BroadcastedLeftShape.dimensions), true);
                    Shape retShape = ret.Shape;
                    
		            var ret_address = (bool*)ret.Address;
                    var incr = new NDCoordinatesIncrementor(BroadcastedLeftShape.dimensions); //doesn't matter which side it is.
                    int[] current = incr.Index;
                    do
                    {
                        *(ret_address + retShape.GetOffset(current)) = (*(lhs_address + BroadcastedLeftShape.GetOffset(current)) == (__2__) *(rhs_address + BroadcastedRightShape.GetOffset(current)));
                    } while (incr.Next() != null);

                    return ret;
                }

                default:
		            throw new NotSupportedException();
#endif
            }
        }
    }
}
