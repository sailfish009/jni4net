//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface Appendable {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(C)Ljava/lang/Appendable;")]
        global::java.lang.Appendable append(char par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/CharSequence;)Ljava/lang/Appendable;")]
        global::java.lang.Appendable append(global::java.lang.CharSequence par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;")]
        global::java.lang.Appendable append(global::java.lang.CharSequence par0, int par1, int par2);
    }
    #endregion
    
    #region Component Designer generated code 
    public unsafe partial class Appendable_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.@__Appendable.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.lang.Appendable))]
    internal sealed unsafe partial class @__Appendable : global::java.lang.Object, global::java.lang.Appendable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _append0;
        
        internal static global::net.sf.jni4net.jni.MethodId _append1;
        
        internal static global::net.sf.jni4net.jni.MethodId _append2;
        
        protected @__Appendable(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.@__Appendable.staticClass = staticClass;
            global::java.lang.@__Appendable._append0 = env.GetMethodID(global::java.lang.@__Appendable.staticClass, "append", "(C)Ljava/lang/Appendable;");
            global::java.lang.@__Appendable._append1 = env.GetMethodID(global::java.lang.@__Appendable.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
            global::java.lang.@__Appendable._append2 = env.GetMethodID(global::java.lang.@__Appendable.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
        }
        
        public global::java.lang.Appendable append(char par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Appendable>(env.CallObjectMethod(this, global::java.lang.@__Appendable._append0, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        public global::java.lang.Appendable append(global::java.lang.CharSequence par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Appendable>(env.CallObjectMethod(this, global::java.lang.@__Appendable._append1, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        public global::java.lang.Appendable append(global::java.lang.CharSequence par0, int par1, int par2) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Appendable>(env.CallObjectMethod(this, global::java.lang.@__Appendable._append2, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1), new global::net.sf.jni4net.jni.Value(par2)));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__Appendable);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "append", "append0", "(C)Ljava/lang/Appendable;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "append", "append1", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "append", "append2", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;"));
            return methods;
        }
        
        private static global::java.lang.Object.JavaPtr* append0(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj, char par0) {
            // (C)Ljava/lang/Appendable;
            // (C)Ljava/lang/Appendable;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::java.lang.Appendable real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.Appendable>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.append(par0));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* append1(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* par0) {
            // (Ljava/lang/CharSequence;)Ljava/lang/Appendable;
            // (Ljava/lang/CharSequence;)Ljava/lang/Appendable;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::java.lang.Appendable real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.Appendable>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.append(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.CharSequence>(__env, par0)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* append2(global::System.IntPtr @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* par0, int par1, int par2) {
            // (Ljava/lang/CharSequence;II)Ljava/lang/Appendable;
            // (Ljava/lang/CharSequence;II)Ljava/lang/Appendable;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::java.lang.Appendable real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.Appendable>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.append(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.CharSequence>(__env, par0), par1, par2));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.@__Appendable(env);
            }
        }
    }
    #endregion
}
