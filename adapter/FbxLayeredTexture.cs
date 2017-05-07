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

public class FbxLayeredTexture : FbxTexture {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxLayeredTexture(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxLayeredTexture_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLayeredTexture obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static FbxClassId ClassId {
    set {
      fbx_wrapperPINVOKE.FbxLayeredTexture_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLayeredTexture_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(fbx_wrapperPINVOKE.FbxLayeredTexture_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxLayeredTexture Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLayeredTexture_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxLayeredTexture ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayeredTexture(cPtr, false);
    return ret;
  }

  public new static FbxLayeredTexture Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLayeredTexture_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxLayeredTexture ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayeredTexture(cPtr, false);
    return ret;
  }

  public bool eq(FbxLayeredTexture pOther) {
    bool ret = fbx_wrapperPINVOKE.FbxLayeredTexture_eq(swigCPtr, FbxLayeredTexture.getCPtr(pOther));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetTextureBlendMode(int pIndex, FbxLayeredTexture.EBlendMode pMode) {
    bool ret = fbx_wrapperPINVOKE.FbxLayeredTexture_SetTextureBlendMode(swigCPtr, pIndex, (int)pMode);
    return ret;
  }

  public bool GetTextureBlendMode(int pIndex, SWIGTYPE_p_FbxLayeredTexture__EBlendMode pMode) {
    bool ret = fbx_wrapperPINVOKE.FbxLayeredTexture_GetTextureBlendMode(swigCPtr, pIndex, SWIGTYPE_p_FbxLayeredTexture__EBlendMode.getCPtr(pMode));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetTextureAlpha(int pIndex, double pAlpha) {
    bool ret = fbx_wrapperPINVOKE.FbxLayeredTexture_SetTextureAlpha(swigCPtr, pIndex, pAlpha);
    return ret;
  }

  public bool GetTextureAlpha(int pIndex, SWIGTYPE_p_double pAlpha) {
    bool ret = fbx_wrapperPINVOKE.FbxLayeredTexture_GetTextureAlpha(swigCPtr, pIndex, SWIGTYPE_p_double.getCPtr(pAlpha));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override FbxObject Copy(FbxObject pObject) {
    FbxObject ret = new FbxObject(fbx_wrapperPINVOKE.FbxLayeredTexture_Copy(swigCPtr, FbxObject.getCPtr(pObject)), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum EBlendMode {
    eTranslucent,
    eAdditive,
    eModulate,
    eModulate2,
    eOver,
    eNormal,
    eDissolve,
    eDarken,
    eColorBurn,
    eLinearBurn,
    eDarkerColor,
    eLighten,
    eScreen,
    eColorDodge,
    eLinearDodge,
    eLighterColor,
    eSoftLight,
    eHardLight,
    eVividLight,
    eLinearLight,
    ePinLight,
    eHardMix,
    eDifference,
    eExclusion,
    eSubtract,
    eDivide,
    eHue,
    eSaturation,
    eColor,
    eLuminosity,
    eOverlay,
    eBlendModeCount
  }

}

}