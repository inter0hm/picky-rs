// <auto-generated/> by Diplomat

#pragma warning disable 0105
using System;
using System.Runtime.InteropServices;

using Devolutions.Picky.Diplomat;
#pragma warning restore 0105

namespace Devolutions.Picky.Raw;

#nullable enable

[StructLayout(LayoutKind.Sequential)]
public partial struct Pkcs12MacAlgorithmHmac
{
#if __IOS__
    private const string NativeLib = "libDevolutionsPicky.framework/libDevolutionsPicky";
#else
    private const string NativeLib = "DevolutionsPicky";
#endif

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pkcs12MacAlgorithmHmac_new_hmac", ExactSpelling = true)]
    public static unsafe extern Pkcs12MacAlgorithmHmac* NewHmac(Pkcs12HashAlgorithm hashAlgorithm);

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pkcs12MacAlgorithmHmac_new_hmac_with_iterations", ExactSpelling = true)]
    public static unsafe extern Pkcs12MacAlgorithmHmac* NewHmacWithIterations(Pkcs12HashAlgorithm hashAlgorithm, uint iterations);

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pkcs12MacAlgorithmHmac_hash_algorithm", ExactSpelling = true)]
    public static unsafe extern Pkcs12HashAlgorithm HashAlgorithm(Pkcs12MacAlgorithmHmac* self);

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pkcs12MacAlgorithmHmac_iterations", ExactSpelling = true)]
    public static unsafe extern uint* Iterations(Pkcs12MacAlgorithmHmac* self);

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pkcs12MacAlgorithmHmac_destroy", ExactSpelling = true)]
    public static unsafe extern void Destroy(Pkcs12MacAlgorithmHmac* self);
}
