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

public class FbxCameraStereo : FbxCamera {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxCameraStereo(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxCameraStereo_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxCameraStereo obj) {
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
      fbx_wrapperPINVOKE.FbxCameraStereo_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCameraStereo_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(fbx_wrapperPINVOKE.FbxCameraStereo_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxCameraStereo Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCameraStereo_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxCameraStereo ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxCameraStereo(cPtr, false);
    return ret;
  }

  public new static FbxCameraStereo Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCameraStereo_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxCameraStereo ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxCameraStereo(cPtr, false);
    return ret;
  }

  public override FbxNodeAttribute.EType GetAttributeType() {
    FbxNodeAttribute.EType ret = (FbxNodeAttribute.EType)fbx_wrapperPINVOKE.FbxCameraStereo_GetAttributeType(swigCPtr);
    return ret;
  }

  public new void Reset() {
    fbx_wrapperPINVOKE.FbxCameraStereo_Reset(swigCPtr);
  }

  public FbxCamera GetLeftCamera() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCameraStereo_GetLeftCamera(swigCPtr);
    FbxCamera ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxCamera(cPtr, false);
    return ret;
  }

  public FbxCamera GetRightCamera() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCameraStereo_GetRightCamera(swigCPtr);
    FbxCamera ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxCamera(cPtr, false);
    return ret;
  }

  public bool SetLeftCamera(FbxCamera pCamera) {
    bool ret = fbx_wrapperPINVOKE.FbxCameraStereo_SetLeftCamera(swigCPtr, FbxCamera.getCPtr(pCamera));
    return ret;
  }

  public bool SetRightCamera(FbxCamera pCamera) {
    bool ret = fbx_wrapperPINVOKE.FbxCameraStereo_SetRightCamera(swigCPtr, FbxCamera.getCPtr(pCamera));
    return ret;
  }

  public FbxAMatrix GetLeftCameraLocalMatrix() {
    FbxAMatrix ret = new FbxAMatrix(fbx_wrapperPINVOKE.FbxCameraStereo_GetLeftCameraLocalMatrix(swigCPtr), true);
    return ret;
  }

  public FbxAMatrix GetLeftCameraGlobalMatrix() {
    FbxAMatrix ret = new FbxAMatrix(fbx_wrapperPINVOKE.FbxCameraStereo_GetLeftCameraGlobalMatrix(swigCPtr), true);
    return ret;
  }

  public FbxAMatrix GetRightCameraLocalMatrix() {
    FbxAMatrix ret = new FbxAMatrix(fbx_wrapperPINVOKE.FbxCameraStereo_GetRightCameraLocalMatrix(swigCPtr), true);
    return ret;
  }

  public FbxAMatrix GetRightCameraGlobalMatrix() {
    FbxAMatrix ret = new FbxAMatrix(fbx_wrapperPINVOKE.FbxCameraStereo_GetRightCameraGlobalMatrix(swigCPtr), true);
    return ret;
  }

  public double ReevaluateLeftCameraFilmOffsetX() {
    double ret = fbx_wrapperPINVOKE.FbxCameraStereo_ReevaluateLeftCameraFilmOffsetX(swigCPtr);
    return ret;
  }

  public double ReevaluateRightCameraFilmOffsetX() {
    double ret = fbx_wrapperPINVOKE.FbxCameraStereo_ReevaluateRightCameraFilmOffsetX(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxCameraStereo__EStereoType_t Stereo {
    set {
      fbx_wrapperPINVOKE.FbxCameraStereo_Stereo_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxCameraStereo__EStereoType_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCameraStereo_Stereo_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxCameraStereo__EStereoType_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxCameraStereo__EStereoType_t(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble InteraxialSeparation {
    set {
      fbx_wrapperPINVOKE.FbxCameraStereo_InteraxialSeparation_set(swigCPtr, FbxPropertyTDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCameraStereo_InteraxialSeparation_get(swigCPtr);
      FbxPropertyTDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble ZeroParallax {
    set {
      fbx_wrapperPINVOKE.FbxCameraStereo_ZeroParallax_set(swigCPtr, FbxPropertyTDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCameraStereo_ZeroParallax_get(swigCPtr);
      FbxPropertyTDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble ToeInAdjust {
    set {
      fbx_wrapperPINVOKE.FbxCameraStereo_ToeInAdjust_set(swigCPtr, FbxPropertyTDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCameraStereo_ToeInAdjust_get(swigCPtr);
      FbxPropertyTDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble FilmOffsetRightCam {
    set {
      fbx_wrapperPINVOKE.FbxCameraStereo_FilmOffsetRightCam_set(swigCPtr, FbxPropertyTDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCameraStereo_FilmOffsetRightCam_get(swigCPtr);
      FbxPropertyTDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble FilmOffsetLeftCam {
    set {
      fbx_wrapperPINVOKE.FbxCameraStereo_FilmOffsetLeftCam_set(swigCPtr, FbxPropertyTDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCameraStereo_FilmOffsetLeftCam_get(swigCPtr);
      FbxPropertyTDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTReference RightCamera {
    set {
      fbx_wrapperPINVOKE.FbxCameraStereo_RightCamera_set(swigCPtr, FbxPropertyTReference.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCameraStereo_RightCamera_get(swigCPtr);
      FbxPropertyTReference ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTReference(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTReference LeftCamera {
    set {
      fbx_wrapperPINVOKE.FbxCameraStereo_LeftCamera_set(swigCPtr, FbxPropertyTReference.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCameraStereo_LeftCamera_get(swigCPtr);
      FbxPropertyTReference ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTReference(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t PrecompFileName {
    set {
      fbx_wrapperPINVOKE.FbxCameraStereo_PrecompFileName_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCameraStereo_PrecompFileName_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t RelativePrecompFileName {
    set {
      fbx_wrapperPINVOKE.FbxCameraStereo_RelativePrecompFileName_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCameraStereo_RelativePrecompFileName_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public bool ConnectProperties() {
    bool ret = fbx_wrapperPINVOKE.FbxCameraStereo_ConnectProperties(swigCPtr);
    return ret;
  }

  public enum EStereoType {
    eNone,
    eConverged,
    eOffAxis,
    eParallel
  }

}

}