//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Reflection {
    
    
    #region Component Designer generated code 
    public unsafe partial class MethodBase_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.Reflection.@__MethodBase.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Reflection.MethodBase))]
    internal sealed unsafe partial class @__MethodBase : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__MethodBase(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.Reflection.@__MethodBase.staticClass = staticClass;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__MethodBase);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetMethodFromHandle", "GetMethodFromHandle0", "(Lsystem/ValueType;)Lsystem/reflection/MethodBase;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetMethodFromHandle", "GetMethodFromHandle1", "(Lsystem/ValueType;Lsystem/ValueType;)Lsystem/reflection/MethodBase;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetCurrentMethod", "GetCurrentMethod2", "()Lsystem/reflection/MethodBase;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetParameters", "GetParameters3", "()[Lsystem/reflection/ParameterInfo;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetMethodImplementationFlags", "GetMethodImplementationFlags4", "()Lsystem/Enum;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getMethodHandle", "MethodHandle5", "()Lsystem/ValueType;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getAttributes", "Attributes6", "()Lsystem/Enum;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Invoke", "Invoke7", "(Lsystem/Object;Lsystem/reflection/BindingFlags;Ljava/lang/Object;[Lsystem/Object" +
                        ";Lsystem/ICloneable;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getCallingConvention", "CallingConvention8", "()Lsystem/Enum;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetGenericArguments", "GetGenericArguments9", "()[Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isGenericMethodDefinition", "IsGenericMethodDefinition10", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getContainsGenericParameters", "ContainsGenericParameters11", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isGenericMethod", "IsGenericMethod12", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Invoke", "Invoke13", "(Lsystem/Object;[Lsystem/Object;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isPublic", "IsPublic14", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isPrivate", "IsPrivate15", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isFamily", "IsFamily16", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isAssembly", "IsAssembly17", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isFamilyAndAssembly", "IsFamilyAndAssembly18", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isFamilyOrAssembly", "IsFamilyOrAssembly19", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isStatic", "IsStatic20", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isFinal", "IsFinal21", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isVirtual", "IsVirtual22", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isHideBySig", "IsHideBySig23", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isAbstract", "IsAbstract24", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isSpecialName", "IsSpecialName25", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isConstructor", "IsConstructor26", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetMethodBody", "GetMethodBody27", "()Ljava/lang/Object;"));
            return methods;
        }
        
        private static global::java.lang.Object.JavaPtr* GetMethodFromHandle0(global::System.IntPtr @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* handle) {
            // (Lsystem/ValueType;)Lsystem/reflection/MethodBase;
            // (LSystem/RuntimeMethodHandle;)LSystem/Reflection/MethodBase;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, global::System.Reflection.MethodBase.GetMethodFromHandle(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.RuntimeMethodHandle>(__env, handle)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* GetMethodFromHandle1(global::System.IntPtr @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* handle, global::java.lang.Object.JavaPtr* declaringType) {
            // (Lsystem/ValueType;Lsystem/ValueType;)Lsystem/reflection/MethodBase;
            // (LSystem/RuntimeMethodHandle;LSystem/RuntimeTypeHandle;)LSystem/Reflection/MethodBase;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, global::System.Reflection.MethodBase.GetMethodFromHandle(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.RuntimeMethodHandle>(__env, handle), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.RuntimeTypeHandle>(__env, declaringType)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* GetCurrentMethod2(global::System.IntPtr @__envi, global::java.lang.Class.JavaPtr* @__clazz) {
            // ()Lsystem/reflection/MethodBase;
            // ()LSystem/Reflection/MethodBase;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, global::System.Reflection.MethodBase.GetCurrentMethod());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* GetParameters3(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()[Lsystem/reflection/ParameterInfo;
            // ()[LSystem/Reflection/ParameterInfo;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.GetParameters());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* GetMethodImplementationFlags4(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/Enum;
            // ()LSystem/Reflection/MethodImplAttributes;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.GetMethodImplementationFlags());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* MethodHandle5(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/ValueType;
            // ()LSystem/RuntimeMethodHandle;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.MethodHandle);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* Attributes6(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/Enum;
            // ()LSystem/Reflection/MethodAttributes;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.Attributes);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* Invoke7(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* obj, global::java.lang.Object.JavaPtr* invokeAttr, global::java.lang.Object.JavaPtr* binder, global::java.lang.Object.JavaPtr* parameters, global::java.lang.Object.JavaPtr* culture) {
            // (Lsystem/Object;Lsystem/reflection/BindingFlags;Ljava/lang/Object;[Lsystem/Object;Lsystem/ICloneable;)Lsystem/Object;
            // (LSystem/Object;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;[LSystem/Object;LSystem/Globalization/CultureInfo;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.Invoke(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Object>(__env, obj), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.BindingFlags>(__env, invokeAttr), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.Binder>(__env, binder), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Object[]>(__env, parameters), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Globalization.CultureInfo>(__env, culture)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* CallingConvention8(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/Enum;
            // ()LSystem/Reflection/CallingConventions;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.CallingConvention);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* GetGenericArguments9(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()[Lsystem/Type;
            // ()[LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.GetGenericArguments());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static bool IsGenericMethodDefinition10(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return real.IsGenericMethodDefinition;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool ContainsGenericParameters11(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return real.ContainsGenericParameters;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsGenericMethod12(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return real.IsGenericMethod;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static global::java.lang.Object.JavaPtr* Invoke13(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* obj, global::java.lang.Object.JavaPtr* parameters) {
            // (Lsystem/Object;[Lsystem/Object;)Lsystem/Object;
            // (LSystem/Object;[LSystem/Object;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.Invoke(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Object>(__env, obj), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Object[]>(__env, parameters)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static bool IsPublic14(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return real.IsPublic;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsPrivate15(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return real.IsPrivate;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsFamily16(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return real.IsFamily;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsAssembly17(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return real.IsAssembly;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsFamilyAndAssembly18(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return real.IsFamilyAndAssembly;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsFamilyOrAssembly19(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return real.IsFamilyOrAssembly;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsStatic20(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return real.IsStatic;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsFinal21(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return real.IsFinal;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsVirtual22(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return real.IsVirtual;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsHideBySig23(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return real.IsHideBySig;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsAbstract24(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return real.IsAbstract;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsSpecialName25(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return real.IsSpecialName;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsConstructor26(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return real.IsConstructor;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static global::java.lang.Object.JavaPtr* GetMethodBody27(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Ljava/lang/Object;
            // ()LSystem/Reflection/MethodBody;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.MethodBase real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodBase>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.GetMethodBody());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.Reflection.@__MethodBase(env);
            }
        }
    }
    #endregion
}
