// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package org.drools.agent;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class KnowledgeAgent_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return org.drools.agent.KnowledgeAgent_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        org.drools.agent.KnowledgeAgent_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __KnowledgeAgent extends system.Object implements org.drools.agent.KnowledgeAgent {
    
    protected __KnowledgeAgent(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String getName();
    
    @net.sf.jni4net.attributes.ClrMethod("()Lorg/drools/KnowledgeBase;")
    public native org.drools.KnowledgeBase getKnowledgeBase();
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/event/knowledgeagent/KnowledgeAgentEventListener;)V")
    public native void addEventListener(org.drools.event.knowledgeagent.KnowledgeAgentEventListener par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void dispose();
    
    @net.sf.jni4net.attributes.ClrMethod("()Lorg/drools/runtime/StatelessKnowledgeSession;")
    public native org.drools.runtime.StatelessKnowledgeSession newStatelessKnowledgeSession();
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/runtime/KnowledgeSessionConfiguration;)Lorg/drools/runtime/StatelessKnowledgeSession;")
    public native org.drools.runtime.StatelessKnowledgeSession newStatelessKnowledgeSession(org.drools.runtime.KnowledgeSessionConfiguration par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/SystemEventListener;)V")
    public native void setSystemEventListener(org.drools.SystemEventListener par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Z)V")
    public native void monitorResourceChangeEvents(boolean par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/ChangeSet;)V")
    public native void applyChangeSet(org.drools.ChangeSet par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/io/Resource;)V")
    public native void applyChangeSet(org.drools.io.Resource par0);
}
//</generated-proxy>