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

public class FbxTakeLayerInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxTakeLayerInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxTakeLayerInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxTakeLayerInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxTakeLayerInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxString mName {
    set {
      fbx_wrapperPINVOKE.FbxTakeLayerInfo_mName_set(swigCPtr, FbxString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxTakeLayerInfo_mName_get(swigCPtr);
      FbxString ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxString(cPtr, false);
      return ret;
    } 
  }

  public int mId {
    set {
      fbx_wrapperPINVOKE.FbxTakeLayerInfo_mId_set(swigCPtr, value);
    } 
    get {
      int ret = fbx_wrapperPINVOKE.FbxTakeLayerInfo_mId_get(swigCPtr);
      return ret;
    } 
  }

  public FbxTakeLayerInfo() : this(fbx_wrapperPINVOKE.new_FbxTakeLayerInfo(), true) {
  }

}

}
