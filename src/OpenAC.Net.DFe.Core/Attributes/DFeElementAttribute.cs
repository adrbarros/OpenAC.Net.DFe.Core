// ***********************************************************************
// Assembly         : OpenAC.Net.DFe.Core
// Author           : RFTD
// Created          : 03-27-2016
//
// Last Modified By : RFTD
// Last Modified On : 10-15-2016
// ***********************************************************************
// <copyright file="DFeElementAttribute.cs" company="OpenAC .Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2014-2022 Grupo OpenAC.Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using OpenAC.Net.DFe.Core.Serializer;
using System;

namespace OpenAC.Net.DFe.Core.Attributes
{
    /// <summary>
    /// Classe DFeElementAttribute.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    /// <seealso cref="DFeBaseAttribute" />
    [AttributeUsage(AttributeTargets.Property)]
    public class DFeElementAttribute : DFeBaseAttribute
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DFeElementAttribute" /> class.
        /// </summary>
        public DFeElementAttribute()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DFeElementAttribute" /> class.
        /// </summary>
        /// <param name="tag">The Name.</param>
        public DFeElementAttribute(string tag)
        {
            Name = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DFeElementAttribute" /> class.
        /// </summary>
        /// <param name="tipo">The tipo.</param>
        /// <param name="name">The name.</param>
        public DFeElementAttribute(TipoCampo tipo, string name)
        {
            Tipo = tipo;
            Name = name;
        }

        #endregion Constructors

        #region Properties

        public bool UseCData { get; set; }

        #endregion Properties
    }
}