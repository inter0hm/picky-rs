// <auto-generated/> by Diplomat

#pragma warning disable 0105
using System;
using System.Runtime.InteropServices;

using Devolutions.Picky.Diplomat;
#pragma warning restore 0105

namespace Devolutions.Picky;

#nullable enable

public partial class Pkcs12MacAlgorithmHmac: IDisposable
{
    private unsafe Raw.Pkcs12MacAlgorithmHmac* _inner;

    /// <summary>
    /// Creates a managed <c>Pkcs12MacAlgorithmHmac</c> from a raw handle.
    /// </summary>
    /// <remarks>
    /// Safety: you should not build two managed objects using the same raw handle (may causes use-after-free and double-free).
    /// <br/>
    /// This constructor assumes the raw struct is allocated on Rust side.
    /// If implemented, the custom Drop implementation on Rust side WILL run on destruction.
    /// </remarks>
    public unsafe Pkcs12MacAlgorithmHmac(Raw.Pkcs12MacAlgorithmHmac* handle)
    {
        _inner = handle;
    }

    /// <returns>
    /// A <c>Pkcs12MacAlgorithmHmac</c> allocated on Rust side.
    /// </returns>
    public static Pkcs12MacAlgorithmHmac NewHmac(Pkcs12HashAlgorithm hashAlgorithm)
    {
        unsafe
        {
            Raw.Pkcs12HashAlgorithm hashAlgorithmRaw;
            hashAlgorithmRaw = (Raw.Pkcs12HashAlgorithm)hashAlgorithm;
            Raw.Pkcs12MacAlgorithmHmac* retVal = Raw.Pkcs12MacAlgorithmHmac.NewHmac(hashAlgorithmRaw);
            return new Pkcs12MacAlgorithmHmac(retVal);
        }
    }

    /// <returns>
    /// A <c>Pkcs12MacAlgorithmHmac</c> allocated on Rust side.
    /// </returns>
    public static Pkcs12MacAlgorithmHmac NewHmacWithIterations(Pkcs12HashAlgorithm hashAlgorithm, uint iterations)
    {
        unsafe
        {
            Raw.Pkcs12HashAlgorithm hashAlgorithmRaw;
            hashAlgorithmRaw = (Raw.Pkcs12HashAlgorithm)hashAlgorithm;
            Raw.Pkcs12MacAlgorithmHmac* retVal = Raw.Pkcs12MacAlgorithmHmac.NewHmacWithIterations(hashAlgorithmRaw, iterations);
            return new Pkcs12MacAlgorithmHmac(retVal);
        }
    }

    /// <returns>
    /// A <c>Pkcs12HashAlgorithm</c> allocated on C# side.
    /// </returns>
    public Pkcs12HashAlgorithm HashAlgorithm()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("Pkcs12MacAlgorithmHmac");
            }
            Raw.Pkcs12HashAlgorithm retVal = Raw.Pkcs12MacAlgorithmHmac.HashAlgorithm(_inner);
            return (Pkcs12HashAlgorithm)retVal;
        }
    }

    public uint? Iterations()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("Pkcs12MacAlgorithmHmac");
            }
            uint* retVal = Raw.Pkcs12MacAlgorithmHmac.Iterations(_inner);
            if (retVal == null)
            {
                return null;
            }
            return retVal;
        }
    }

    /// <summary>
    /// Returns the underlying raw handle.
    /// </summary>
    public unsafe Raw.Pkcs12MacAlgorithmHmac* AsFFI()
    {
        return _inner;
    }

    /// <summary>
    /// Destroys the underlying object immediately.
    /// </summary>
    public void Dispose()
    {
        unsafe
        {
            if (_inner == null)
            {
                return;
            }

            Raw.Pkcs12MacAlgorithmHmac.Destroy(_inner);
            _inner = null;

            GC.SuppressFinalize(this);
        }
    }

    ~Pkcs12MacAlgorithmHmac()
    {
        Dispose();
    }
}
