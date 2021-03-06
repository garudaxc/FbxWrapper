//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Fbx {

public class FbxConnectionPointFilter : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxConnectionPointFilter(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxConnectionPointFilter obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxConnectionPointFilter() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxConnectionPointFilter(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual FbxConnectionPointFilter Ref() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxConnectionPointFilter_Ref(swigCPtr);
    FbxConnectionPointFilter ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxConnectionPointFilter(cPtr, false);
    return ret;
  }

  public virtual void Unref() {
    fbx_wrapperPINVOKE.FbxConnectionPointFilter_Unref(swigCPtr);
  }

  public virtual int GetUniqueId() {
    int ret = fbx_wrapperPINVOKE.FbxConnectionPointFilter_GetUniqueId(swigCPtr);
    return ret;
  }

  public virtual bool IsValid(FbxConnectionPoint pConnect) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPointFilter_IsValid(swigCPtr, FbxConnectionPoint.getCPtr(pConnect));
    return ret;
  }

  public virtual bool IsValidConnection(FbxConnectionPoint pConnect, FbxConnection.EType pType) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPointFilter_IsValidConnection(swigCPtr, FbxConnectionPoint.getCPtr(pConnect), (int)pType);
    return ret;
  }

  public virtual bool IsEqual(FbxConnectionPointFilter pConnectFilter) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPointFilter_IsEqual(swigCPtr, FbxConnectionPointFilter.getCPtr(pConnectFilter));
    return ret;
  }

  public FbxConnectionPointFilter() : this(fbx_wrapperPINVOKE.new_FbxConnectionPointFilter(), true) {
  }

}

}
