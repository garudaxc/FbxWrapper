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

public class FbxTrimNurbsSurface : FbxGeometry {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxTrimNurbsSurface(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxTrimNurbsSurface_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxTrimNurbsSurface obj) {
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
      fbx_wrapperPINVOKE.FbxTrimNurbsSurface_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxTrimNurbsSurface_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(fbx_wrapperPINVOKE.FbxTrimNurbsSurface_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxTrimNurbsSurface Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxTrimNurbsSurface_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxTrimNurbsSurface ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxTrimNurbsSurface(cPtr, false);
    return ret;
  }

  public new static FbxTrimNurbsSurface Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxTrimNurbsSurface_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxTrimNurbsSurface ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxTrimNurbsSurface(cPtr, false);
    return ret;
  }

  public override FbxNodeAttribute.EType GetAttributeType() {
    FbxNodeAttribute.EType ret = (FbxNodeAttribute.EType)fbx_wrapperPINVOKE.FbxTrimNurbsSurface_GetAttributeType(swigCPtr);
    return ret;
  }

  public int GetTrimRegionCount() {
    int ret = fbx_wrapperPINVOKE.FbxTrimNurbsSurface_GetTrimRegionCount(swigCPtr);
    return ret;
  }

  public void BeginTrimRegion() {
    fbx_wrapperPINVOKE.FbxTrimNurbsSurface_BeginTrimRegion(swigCPtr);
  }

  public void EndTrimRegion() {
    fbx_wrapperPINVOKE.FbxTrimNurbsSurface_EndTrimRegion(swigCPtr);
  }

  public bool AddBoundary(FbxBoundary pBoundary) {
    bool ret = fbx_wrapperPINVOKE.FbxTrimNurbsSurface_AddBoundary(swigCPtr, FbxBoundary.getCPtr(pBoundary));
    return ret;
  }

  public FbxBoundary GetBoundary(int pIndex, int pRegionIndex) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxTrimNurbsSurface_GetBoundary__SWIG_0(swigCPtr, pIndex, pRegionIndex);
    FbxBoundary ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxBoundary(cPtr, false);
    return ret;
  }

  public FbxBoundary GetBoundary(int pIndex) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxTrimNurbsSurface_GetBoundary__SWIG_1(swigCPtr, pIndex);
    FbxBoundary ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxBoundary(cPtr, false);
    return ret;
  }

  public int GetBoundaryCount(int pRegionIndex) {
    int ret = fbx_wrapperPINVOKE.FbxTrimNurbsSurface_GetBoundaryCount__SWIG_0(swigCPtr, pRegionIndex);
    return ret;
  }

  public int GetBoundaryCount() {
    int ret = fbx_wrapperPINVOKE.FbxTrimNurbsSurface_GetBoundaryCount__SWIG_1(swigCPtr);
    return ret;
  }

  public void SetNurbsSurface(FbxNurbsSurface pNurbs) {
    fbx_wrapperPINVOKE.FbxTrimNurbsSurface_SetNurbsSurface(swigCPtr, FbxNurbsSurface.getCPtr(pNurbs));
  }

  public FbxNurbsSurface GetNurbsSurface() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxTrimNurbsSurface_GetNurbsSurface__SWIG_0(swigCPtr);
    FbxNurbsSurface ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNurbsSurface(cPtr, false);
    return ret;
  }

  public void SetFlipNormals(bool pFlip) {
    fbx_wrapperPINVOKE.FbxTrimNurbsSurface_SetFlipNormals(swigCPtr, pFlip);
  }

  public bool GetFlipNormals() {
    bool ret = fbx_wrapperPINVOKE.FbxTrimNurbsSurface_GetFlipNormals(swigCPtr);
    return ret;
  }

  public override int GetControlPointsCount() {
    int ret = fbx_wrapperPINVOKE.FbxTrimNurbsSurface_GetControlPointsCount(swigCPtr);
    return ret;
  }

  public override void SetControlPointAt(FbxVector4 pCtrlPoint, FbxVector4 pNormal, int pIndex, bool pI2DSearch) {
    fbx_wrapperPINVOKE.FbxTrimNurbsSurface_SetControlPointAt__SWIG_0(swigCPtr, FbxVector4.getCPtr(pCtrlPoint), FbxVector4.getCPtr(pNormal), pIndex, pI2DSearch);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SetControlPointAt(FbxVector4 pCtrlPoint, FbxVector4 pNormal, int pIndex) {
    fbx_wrapperPINVOKE.FbxTrimNurbsSurface_SetControlPointAt__SWIG_1(swigCPtr, FbxVector4.getCPtr(pCtrlPoint), FbxVector4.getCPtr(pNormal), pIndex);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SetControlPointAt(FbxVector4 pCtrlPoint, int pIndex) {
    fbx_wrapperPINVOKE.FbxTrimNurbsSurface_SetControlPointAt__SWIG_2(swigCPtr, FbxVector4.getCPtr(pCtrlPoint), pIndex);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public override FbxVector4 GetControlPoints(FbxStatus pStatus) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxTrimNurbsSurface_GetControlPoints__SWIG_0(swigCPtr, FbxStatus.getCPtr(pStatus));
    FbxVector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxVector4(cPtr, false);
    return ret;
  }

  public override FbxVector4 GetControlPoints() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxTrimNurbsSurface_GetControlPoints__SWIG_1(swigCPtr);
    FbxVector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxVector4(cPtr, false);
    return ret;
  }

  public override FbxObject Copy(FbxObject pObject) {
    FbxObject ret = new FbxObject(fbx_wrapperPINVOKE.FbxTrimNurbsSurface_Copy(swigCPtr, FbxObject.getCPtr(pObject)), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsValid(bool mustClosed) {
    bool ret = fbx_wrapperPINVOKE.FbxTrimNurbsSurface_IsValid__SWIG_0(swigCPtr, mustClosed);
    return ret;
  }

  public bool IsValid() {
    bool ret = fbx_wrapperPINVOKE.FbxTrimNurbsSurface_IsValid__SWIG_1(swigCPtr);
    return ret;
  }

  public void ClearBoundaries() {
    fbx_wrapperPINVOKE.FbxTrimNurbsSurface_ClearBoundaries(swigCPtr);
  }

  public void CopyBoundaries(FbxTrimNurbsSurface pOther) {
    fbx_wrapperPINVOKE.FbxTrimNurbsSurface_CopyBoundaries(swigCPtr, FbxTrimNurbsSurface.getCPtr(pOther));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsValid(int pRegion, bool mustClosed) {
    bool ret = fbx_wrapperPINVOKE.FbxTrimNurbsSurface_IsValid__SWIG_2(swigCPtr, pRegion, mustClosed);
    return ret;
  }

  public bool IsValid(int pRegion) {
    bool ret = fbx_wrapperPINVOKE.FbxTrimNurbsSurface_IsValid__SWIG_3(swigCPtr, pRegion);
    return ret;
  }

  public void RebuildRegions() {
    fbx_wrapperPINVOKE.FbxTrimNurbsSurface_RebuildRegions(swigCPtr);
  }

}

}