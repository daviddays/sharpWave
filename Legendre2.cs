///
/// SharpWave - A refactored port of JWave
/// https://github.com/graetz23/JWave
///
/// MIT License
///
/// Copyright (c) 2020 Christian (graetz23@gmail.com)
///
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
///
/// The above copyright notice and this permission notice shall be included in all
/// copies or substantial portions of the Software.
///
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
/// SOFTWARE.
///
using System;

namespace SharpWave
{

  ///<summary>
  /// Orthonormal Legendre wavelet transform of four coefficients based on the
  /// Legendre polynomial; normed, due to ||*||2 euclidean norm..
  ///</summary>
  ///<remarks>
  /// Christian (graetz23@gmail.com) 03.06.2010 21:19:04
  /// TODO NOT working for odd values; recheck coefficients ..
  ///</remarks>
  public class Legendre2 : Wavelet {

    ///<summary>
    /// Constructor calculating analytically the orthogonal Legendre wavelet of
    /// four coefficients, orthonormalizes them (normed, due to ||*||2
    /// euclidean norm), and builds the scaling coefficients, and the
    /// orthonormal bases afterwards; .
    ///</summary>
    ///<remarks>
    /// Christian (graetz23@gmail.com) 03.06.2010 21:19:04
    ///</remarks>
    public Legendre2( ) : base( "Legendre 2", 4, 2 ) {
      double sqrt02 = Math.Sqrt( 2.0 ); // 1.4142135623730951
      // these coefficients are already orthonormal
      _scalingDeCom[ 0 ] = ( -5.0 / 8.0 ) / sqrt02; // s0
      _scalingDeCom[ 1 ] = ( -3.0 / 8.0 ) / sqrt02; // s1
      _scalingDeCom[ 2 ] = ( -3.0 / 8.0 ) / sqrt02; // s2
      _scalingDeCom[ 3 ] = ( -5.0 / 8.0 ) / sqrt02; // s3
      _buildBaseSystem( ); // build all other from low pass decomposition
    } // Legendre2

  } // class

} // namespace