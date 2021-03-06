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

public class FbxPropertyTBool : FbxProperty {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxPropertyTBool(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxPropertyTBool_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxPropertyTBool obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxPropertyTBool() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxPropertyTBool(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FbxProperty StaticInit(FbxObject pObject, string pName, bool pValue, bool pForceSet, FbxPropertyFlags.EFlags pFlags) {
    FbxProperty ret = new FbxProperty(fbx_wrapperPINVOKE.FbxPropertyTBool_StaticInit__SWIG_0(swigCPtr, FbxObject.getCPtr(pObject), pName, pValue, pForceSet, (int)pFlags), false);
    return ret;
  }

  public FbxProperty StaticInit(FbxObject pObject, string pName, bool pValue, bool pForceSet) {
    FbxProperty ret = new FbxProperty(fbx_wrapperPINVOKE.FbxPropertyTBool_StaticInit__SWIG_1(swigCPtr, FbxObject.getCPtr(pObject), pName, pValue, pForceSet), false);
    return ret;
  }

  public FbxProperty StaticInit(FbxObject pObject, string pName, FbxDataType pDataType, bool pValue, bool pForceSet, FbxPropertyFlags.EFlags pFlags) {
    FbxProperty ret = new FbxProperty(fbx_wrapperPINVOKE.FbxPropertyTBool_StaticInit__SWIG_2(swigCPtr, FbxObject.getCPtr(pObject), pName, FbxDataType.getCPtr(pDataType), pValue, pForceSet, (int)pFlags), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty StaticInit(FbxObject pObject, string pName, FbxDataType pDataType, bool pValue, bool pForceSet) {
    FbxProperty ret = new FbxProperty(fbx_wrapperPINVOKE.FbxPropertyTBool_StaticInit__SWIG_3(swigCPtr, FbxObject.getCPtr(pObject), pName, FbxDataType.getCPtr(pDataType), pValue, pForceSet), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty StaticInit(FbxProperty pCompound, string pName, FbxDataType pDataType, bool pValue, bool pForceSet, FbxPropertyFlags.EFlags pFlags) {
    FbxProperty ret = new FbxProperty(fbx_wrapperPINVOKE.FbxPropertyTBool_StaticInit__SWIG_4(swigCPtr, FbxProperty.getCPtr(pCompound), pName, FbxDataType.getCPtr(pDataType), pValue, pForceSet, (int)pFlags), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty StaticInit(FbxProperty pCompound, string pName, FbxDataType pDataType, bool pValue, bool pForceSet) {
    FbxProperty ret = new FbxProperty(fbx_wrapperPINVOKE.FbxPropertyTBool_StaticInit__SWIG_5(swigCPtr, FbxProperty.getCPtr(pCompound), pName, FbxDataType.getCPtr(pDataType), pValue, pForceSet), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty StaticInit(FbxProperty pCompound, string pName, FbxDataType pDataType, bool pValue) {
    FbxProperty ret = new FbxProperty(fbx_wrapperPINVOKE.FbxPropertyTBool_StaticInit__SWIG_6(swigCPtr, FbxProperty.getCPtr(pCompound), pName, FbxDataType.getCPtr(pDataType), pValue), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxPropertyTBool Set(bool pValue) {
    FbxPropertyTBool ret = new FbxPropertyTBool(fbx_wrapperPINVOKE.FbxPropertyTBool_Set(swigCPtr, pValue), false);
    return ret;
  }

  public bool Get() {
    bool ret = fbx_wrapperPINVOKE.FbxPropertyTBool_Get(swigCPtr);
    return ret;
  }

  public FbxPropertyTBool assign(bool pValue) {
    FbxPropertyTBool ret = new FbxPropertyTBool(fbx_wrapperPINVOKE.FbxPropertyTBool_assign(swigCPtr, pValue), false);
    return ret;
  }

  public bool EvaluateValue(FbxTime pTime, bool pForceEval) {
    bool ret = fbx_wrapperPINVOKE.FbxPropertyTBool_EvaluateValue__SWIG_0(swigCPtr, FbxTime.getCPtr(pTime), pForceEval);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool EvaluateValue(FbxTime pTime) {
    bool ret = fbx_wrapperPINVOKE.FbxPropertyTBool_EvaluateValue__SWIG_1(swigCPtr, FbxTime.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool EvaluateValue() {
    bool ret = fbx_wrapperPINVOKE.FbxPropertyTBool_EvaluateValue__SWIG_2(swigCPtr);
    return ret;
  }

  public FbxPropertyTBool() : this(fbx_wrapperPINVOKE.new_FbxPropertyTBool__SWIG_0(), true) {
  }

  public FbxPropertyTBool(FbxProperty pProperty) : this(fbx_wrapperPINVOKE.new_FbxPropertyTBool__SWIG_1(FbxProperty.getCPtr(pProperty)), true) {
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
