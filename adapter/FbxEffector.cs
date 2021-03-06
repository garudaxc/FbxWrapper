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

public class FbxEffector : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxEffector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxEffector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxEffector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxEffector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxEffector() : this(fbx_wrapperPINVOKE.new_FbxEffector(), true) {
  }

  public FbxEffector assign(FbxEffector pEffector) {
    FbxEffector ret = new FbxEffector(fbx_wrapperPINVOKE.FbxEffector_assign(swigCPtr, FbxEffector.getCPtr(pEffector)), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reset() {
    fbx_wrapperPINVOKE.FbxEffector_Reset(swigCPtr);
  }

  public FbxNode mNode {
    set {
      fbx_wrapperPINVOKE.FbxEffector_mNode_set(swigCPtr, FbxNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxEffector_mNode_get(swigCPtr);
      FbxNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNode(cPtr, false);
      return ret;
    } 
  }

  public bool mShow {
    set {
      fbx_wrapperPINVOKE.FbxEffector_mShow_set(swigCPtr, value);
    } 
    get {
      bool ret = fbx_wrapperPINVOKE.FbxEffector_mShow_get(swigCPtr);
      return ret;
    } 
  }

  public bool mTActive {
    set {
      fbx_wrapperPINVOKE.FbxEffector_mTActive_set(swigCPtr, value);
    } 
    get {
      bool ret = fbx_wrapperPINVOKE.FbxEffector_mTActive_get(swigCPtr);
      return ret;
    } 
  }

  public bool mRActive {
    set {
      fbx_wrapperPINVOKE.FbxEffector_mRActive_set(swigCPtr, value);
    } 
    get {
      bool ret = fbx_wrapperPINVOKE.FbxEffector_mRActive_get(swigCPtr);
      return ret;
    } 
  }

  public bool mCandidateTActive {
    set {
      fbx_wrapperPINVOKE.FbxEffector_mCandidateTActive_set(swigCPtr, value);
    } 
    get {
      bool ret = fbx_wrapperPINVOKE.FbxEffector_mCandidateTActive_get(swigCPtr);
      return ret;
    } 
  }

  public bool mCandidateRActive {
    set {
      fbx_wrapperPINVOKE.FbxEffector_mCandidateRActive_set(swigCPtr, value);
    } 
    get {
      bool ret = fbx_wrapperPINVOKE.FbxEffector_mCandidateRActive_get(swigCPtr);
      return ret;
    } 
  }

  public enum ESetId {
    eDefaultSet,
    eAux1Set,
    eAux2Set,
    eAux3Set,
    eAux4Set,
    eAux5Set,
    eAux6Set,
    eAux7Set,
    eAux8Set,
    eAux9Set,
    eAux10Set,
    eAux11Set,
    eAux12Set,
    eAux13Set,
    eAux14Set,
    eSetIdCount
  }

  public enum ENodeId {
    eHips,
    eLeftAnkle,
    eRightAnkle,
    eLeftWrist,
    eRightWrist,
    eLeftKnee,
    eRightKnee,
    eLeftElbow,
    eRightElbow,
    eChestOrigin,
    eChestEnd,
    eLeftFoot,
    eRightFoot,
    eLeftShoulder,
    eRightShoulder,
    eHead,
    eLeftHip,
    eRightHip,
    eLeftHand,
    eRightHand,
    eLeftHandThumb,
    eLeftHandIndex,
    eLeftHandMiddle,
    eLeftHandRing,
    eLeftHandPinky,
    eLeftHandExtraFinger,
    eRightHandThumb,
    eRightHandIndex,
    eRightHandMiddle,
    eRightHandRing,
    eRightHandPinky,
    eRightHandExtraFinger,
    eLeftFootThumb,
    eLeftFootIndex,
    eLeftFootMiddle,
    eLeftFootRing,
    eLeftFootPinky,
    eLeftFootExtraFinger,
    eRightFootThumb,
    eRightFootIndex,
    eRightFootMiddle,
    eRightFootRing,
    eRightFootPinky,
    eRightFootExtraFinger,
    eNodeIdCount,
    eNodeIdInvalid = -1
  }

}

}
