/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.35
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace be.belgium.eid {

using System;
using System.Runtime.InteropServices;

/// <summary>
/// Class for the id document on a EID Card.
/// You can get such an object from BEID_EIDCard::getID()	(or getDocument).
/// </summary>
public class BEID_EId : BEID_XMLDoc {
  private HandleRef swigCPtr;

  internal BEID_EId(IntPtr cPtr, bool cMemoryOwn) : base(beidlib_dotNetPINVOKE.BEID_EIdUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BEID_EId obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BEID_EId() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        beidlib_dotNetPINVOKE.delete_BEID_EId(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  /// <summary>Return Document Version field.</summary>
  public string getDocumentVersion()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getDocumentVersion(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Document Type field.</summary>
  public string getDocumentType()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getDocumentType(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Complete First Names.</summary>
  public string getFirstName()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getFirstName(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return First Name part 1 (2 first given name).</summary>
  public string getFirstName1()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getFirstName1(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return First Name part 2 (first letter of the 3rd given name).</summary>
  public string getFirstName2()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getFirstName2(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Surname field.</summary>
  public string getSurname()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getSurname(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Gender field.</summary>
  public string getGender()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getGender(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Date Of Birth field.</summary>
  public string getDateOfBirth()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getDateOfBirth(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Location Of Birth field.</summary>
  public string getLocationOfBirth()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getLocationOfBirth(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Nobility field.</summary>
  public string getNobility()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getNobility(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Nationality field.</summary>
  public string getNationality()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getNationality(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return National Number field.</summary>
  public string getNationalNumber()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getNationalNumber(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Duplicata field.</summary>
  public string getDuplicata()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getDuplicata(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Special Organization field.</summary>
  public string getSpecialOrganization()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getSpecialOrganization(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Member Of Family field.</summary>
  public string getMemberOfFamily()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getMemberOfFamily(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Logical Number field.</summary>
  public string getLogicalNumber()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getLogicalNumber(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Chip Number field.</summary>
  public string getChipNumber()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getChipNumber(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Validity Begin Date field.</summary>
  public string getValidityBeginDate()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getValidityBeginDate(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Validity End Date field.</summary>
  public string getValidityEndDate()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getValidityEndDate(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Issuing Municipality field.</summary>
  public string getIssuingMunicipality()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getIssuingMunicipality(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Address Version field.</summary>
  public string getAddressVersion()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getAddressVersion(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Street field.</summary>
  public string getStreet()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getStreet(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Zip Code field.</summary>
  public string getZipCode()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getZipCode(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Municipality field.</summary>
  public string getMunicipality()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getMunicipality(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Country field.</summary>
  public string getCountry()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getCountry(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  /// <summary>Return Special Status field.</summary>
  public string getSpecialStatus()
  {
    string ret = beidlib_dotNetPINVOKE.BEID_EId_getSpecialStatus(swigCPtr);
    if (beidlib_dotNetPINVOKE.SWIGPendingException.Pending) throw beidlib_dotNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
