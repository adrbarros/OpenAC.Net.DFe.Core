// ***********************************************************************
// Assembly         : OpenAC.Net.DFe.Core
// Author           : RFTD
// Created          : 03-11-2018
//
// Last Modified By : RFTD
// Last Modified On : 03-11-2018
// ***********************************************************************
// <copyright file="DFeConfigBase.cs" company="OpenAC .Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2016 Grupo OpenAC.Net
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

using System;

namespace OpenAC.Net.DFe.Core.Common
{
    public abstract class DFeConfigBase<TGeralConfig, TWebserviceConfig, TCertificadosConfig, TArquivosConfig>
        where TGeralConfig : DFeGeralConfigBase
        where TWebserviceConfig : DFeWebserviceConfigBase
        where TCertificadosConfig : DFeCertificadosConfigBase
        where TArquivosConfig : DFeArquivosConfigBase
    {
        #region Properties
        
        /// <summary>
        /// Configurações principais do componente.
        /// </summary>
        public TGeralConfig Geral { get; protected set; }

        /// <summary>
        /// Configurações de webservices do componente.
        /// </summary>
        public TWebserviceConfig WebServices { get; protected set; }

        /// <summary>
        /// Configurações de certificado do componente.
        /// </summary>
        public TCertificadosConfig Certificados { get; protected set; }

        /// <summary>
        /// Configurações de arquivos do componente.
        /// </summary>
        public TArquivosConfig Arquivos { get; protected set; }

        #endregion Properties
    }
}