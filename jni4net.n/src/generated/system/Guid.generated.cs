//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System {
    
    
    #region Component Designer generated code 
    public unsafe partial class Guid_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.@__Guid.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Guid))]
    internal sealed unsafe partial class @__Guid : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__Guid(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.@__Guid.staticClass = staticClass;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__Guid);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToString", "ToString0", "(Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "CompareTo", "CompareTo1", "(Lsystem/Object;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToByteArray", "ToByteArray2", "()[B"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Equals", "Equals3", "(Lsystem/Guid;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "CompareTo", "CompareTo4", "(Lsystem/Guid;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "NewGuid", "NewGuid5", "()Lsystem/Guid;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToString", "ToString6", "(Ljava/lang/String;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorGuid0", "__ctorGuid0", "(Lnet/sf/jni4net/inj/IClrProxy;[B)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorGuid1", "__ctorGuid1", "(Lnet/sf/jni4net/inj/IClrProxy;ISSBBBBBBBB)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorGuid2", "__ctorGuid2", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorGuid3", "__ctorGuid3", "(Lnet/sf/jni4net/inj/IClrProxy;ISS[B)V"));
            return methods;
        }
        
        private static global::java.lang.Object.JavaPtr* ToString0(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* format, global::java.lang.Object.JavaPtr* formatProvider) {
            // (Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String;
            // (LSystem/String;LSystem/IFormatProvider;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Guid real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Guid>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.ConvertString(@__env, ((global::System.IFormattable)(real)).ToString(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, format), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, formatProvider)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static int CompareTo1(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* obj) {
            // (Lsystem/Object;)I
            // (LSystem/Object;)I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Guid real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Guid>(__env, @__obj);
            return ((global::System.IComparable)(real)).CompareTo(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Object>(__env, obj));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static global::java.lang.Object.JavaPtr* ToByteArray2(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()[B
            // ()[B
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Guid real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Guid>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.ToByteArray());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static bool Equals3(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* g) {
            // (Lsystem/Guid;)Z
            // (LSystem/Guid;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Guid real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Guid>(__env, @__obj);
            return real.Equals(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Guid>(__env, g));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static int CompareTo4(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* value) {
            // (Lsystem/Guid;)I
            // (LSystem/Guid;)I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Guid real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Guid>(__env, @__obj);
            return real.CompareTo(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Guid>(__env, value));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static global::java.lang.Object.JavaPtr* NewGuid5(global::System.IntPtr @__envi, global::java.lang.Class.JavaPtr* @__clazz) {
            // ()Lsystem/Guid;
            // ()LSystem/Guid;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, global::System.Guid.NewGuid());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* ToString6(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* format) {
            // (Ljava/lang/String;)Ljava/lang/String;
            // (LSystem/String;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Guid real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Guid>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.ConvertString(@__env, real.ToString(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, format)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static void @__ctorGuid0(global::System.IntPtr @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* b) {
            // ([B)V
            // ([B)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Guid real = new global::System.Guid(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Byte[]>(__env, b));
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorGuid1(global::System.IntPtr @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* @__obj, uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) {
            // (ISSBBBBBBBB)V
            // (LSystem/UInt32;LSystem/UInt16;LSystem/UInt16;BBBBBBBB)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Guid real = new global::System.Guid(a, b, c, d, e, f, g, h, i, j, k);
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorGuid2(global::System.IntPtr @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* g) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Guid real = new global::System.Guid(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, g));
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorGuid3(global::System.IntPtr @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* @__obj, int a, short b, short c, global::java.lang.Object.JavaPtr* d) {
            // (ISS[B)V
            // (ISS[B)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Guid real = new global::System.Guid(a, b, c, global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Byte[]>(__env, d));
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.@__Guid(env);
            }
        }
    }
    #endregion
}
